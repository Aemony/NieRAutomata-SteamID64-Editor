using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/* 
 * 56 bytes = SystemData.dat
 * 1 128 bytes = GameData.dat
 * > 1 128 bytes = SlotData.dat
 * 
 */

namespace NieR_Automata_Editor
{
    public partial class Form1 : Form
    {
        private string filePath = null;
        private int fileOffset = 0;
        private byte[] byteSteamID64 = new byte[8];
        private UInt32 steamID3 = 0;
        private UInt64 steamID64 = 0;
        private string lastStatus = "Open a file to begin...";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            ReadSteamID();
        }

        private void ReadSteamID()
        {
            Console.WriteLine("========= ReadSteamID =========");

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\My Games\\NieR_Automata";
            dlg.Filter = "Data files (*.dat)|*.dat";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                filePath = dlg.FileName;

                if (filePath.Contains("SlotData"))
                {
                    // SlotData files stores the SteamID64 in offset 04-11, GameData and SystemData files stores the SteamID64 in offset 00-07
                    fileOffset = 4;
                }
                else
                {
                    fileOffset = 0;
                }
                
                try {
                    using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        stream.Position = fileOffset;
                        stream.Read(byteSteamID64, 0, 8);
                    }

                    Console.WriteLine("Read: " + BitConverter.ToString(byteSteamID64));

                    // Convert to proper IDs.
                    // SteamID64 is stored as Little-Endian in the files, but as Intel is little-endian as well no reversal is needed
                    steamID3 = BitConverter.ToUInt32(byteSteamID64, 0);
                    textBoxSteamID3.Text = steamID3.ToString();
                    Console.WriteLine("SteamID3: " + steamID3.ToString());

                    steamID64 = BitConverter.ToUInt64(byteSteamID64, 0);
                    textBoxSteamID64.Text = steamID64.ToString();
                    Console.WriteLine("SteamID64: " + steamID64.ToString());

                    // Misc
                    textBoxWorkingFile.Text = filePath;
                    textBoxWorkingFile.SelectionStart = textBoxWorkingFile.TextLength;
                    toolStripStatusLabel1.Text = "Read from file: " + BitConverter.ToString(byteSteamID64);
                    lastStatus = toolStripStatusLabel1.Text;

                    // Check if a new ID is already written, and if so, enable the button
                    if (String.IsNullOrWhiteSpace(textBoxSteamID64_New.Text) == false && String.IsNullOrWhiteSpace(filePath) == false && textBoxSteamID64_New.Text != steamID64.ToString())
                    {
                        buttonSteamIDUpdate.Enabled = true;
                    }
                    else
                    {
                        buttonSteamIDUpdate.Enabled = false;
                    }
                } catch (Exception ex)
                {
                    throw ex;
                }
            }

            Console.WriteLine("========= END ReadSteamID =========");
        }

        private void WriteSteamID()
        {
            Console.WriteLine("========= WriteSteamID =========");

            steamID64 = Convert.ToUInt64(textBoxSteamID64_New.Text);
            byteSteamID64 = BitConverter.GetBytes(steamID64);
            steamID3 = BitConverter.ToUInt32(byteSteamID64, 0); // Relies on byteSteamID64 having been updated. 

            Console.WriteLine("New bytes: " + BitConverter.ToString(byteSteamID64));
            Console.WriteLine("New SteamID3: " + steamID3.ToString());
            Console.WriteLine("New SteamID64: " + steamID64.ToString());
            
            // SteamID64 is stored as Little-Endian in the files, but as Intel is little-endian as well no reversal is needed

            try
            {
                // Create a backup first
                File.Copy(filePath, filePath + DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss.bak"));

                // Now overwrite the data
                using (Stream stream = File.Open(filePath, FileMode.Open, FileAccess.Write))
                {
                    stream.Position = fileOffset;
                    stream.Write(byteSteamID64, 0, 8);
                }

                textBoxSteamID3.Text = steamID3.ToString();
                textBoxSteamID64.Text = steamID64.ToString();
                toolStripStatusLabel1.Text = "Wrote to file: " + BitConverter.ToString(byteSteamID64);
                lastStatus = toolStripStatusLabel1.Text;
                buttonSteamIDUpdate.Enabled = false;

            } catch (Exception ex)
            {
                throw ex;
            }
            Console.WriteLine("========= END WriteSteamID =========");
        }

        private void linkLabelSteamID64_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void buttonSteamIDUpdate_Click(object sender, EventArgs e)
        {
            WriteSteamID();
        }

        private void textBoxSteamID64_New_TextChanged(object sender, EventArgs e)
        {
            textBoxSteamID64_New.Text = Regex.Replace(textBoxSteamID64_New.Text, @"[^\d]", "");

            UInt64 tmp;
            if (UInt64.TryParse(textBoxSteamID64_New.Text, out tmp) == true)
            {
                toolStripStatusLabel1.Text = lastStatus;

                if (textBoxSteamID64_New.Text.Length > 0)
                {
                    // Create the new Steam Community link
                    linkLabelSteamID64_New.Links.Clear();
                    LinkLabel.Link linkSteamCommunityProfile_New = new LinkLabel.Link();
                    linkSteamCommunityProfile_New.LinkData = "http://steamcommunity.com/profiles/" + textBoxSteamID64_New.Text;
                    linkLabelSteamID64_New.Links.Add(linkSteamCommunityProfile_New);
                    linkLabelSteamID64_New.Enabled = true;
                }
                else
                {
                    linkLabelSteamID64_New.Links.Clear();
                    linkLabelSteamID64_New.Enabled = false;
                }

                // Check if a current file is loaded
                if (String.IsNullOrWhiteSpace(textBoxSteamID64_New.Text) == false && String.IsNullOrWhiteSpace(filePath) == false && textBoxSteamID64_New.Text != steamID64.ToString())
                {
                    buttonSteamIDUpdate.Enabled = true;
                }
                else
                {
                    buttonSteamIDUpdate.Enabled = false;
                }
            } else {
                toolStripStatusLabel1.Text = "Could not convert SteamID64 to UInt64. Incorrect SteamID64?";
                buttonSteamIDUpdate.Enabled = false;
                linkLabelSteamID64_New.Enabled = false;

            }
        }

        private void linkLabelSteamID64_MouseEnter(object sender, EventArgs e)
        {
            lastStatus = toolStripStatusLabel1.Text;
            toolStripStatusLabel1.Text = linkLabelSteamID64.Links[0].LinkData as string;
        }

        private void linkLabelSteamID64_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = lastStatus;
        }

        private void linkLabelSteamID64_New_MouseEnter(object sender, EventArgs e)
        {
            lastStatus = toolStripStatusLabel1.Text;
            toolStripStatusLabel1.Text = linkLabelSteamID64_New.Links[0].LinkData as string;
        }

        private void linkLabelSteamID64_New_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = lastStatus;
        }

        private void linkLabelSteamID64_New_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void textBoxSteamID64_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSteamID64.Text.Length > 0)
            {
                // Create the Steam Community link
                linkLabelSteamID64.Links.Clear();
                LinkLabel.Link linkSteamCommunityProfile = new LinkLabel.Link();
                linkSteamCommunityProfile.LinkData = "http://steamcommunity.com/profiles/" + steamID64.ToString();
                linkLabelSteamID64.Links.Add(linkSteamCommunityProfile);
                linkLabelSteamID64.Enabled = true;
            }
            else
            {
                linkLabelSteamID64_New.Links.Clear();
                linkLabelSteamID64_New.Enabled = false;
            }
        }
    }
}
