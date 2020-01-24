using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Midi;

namespace MIDI_SysEx
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// APC Information taken from https://forums.pangolin.com/threads/apc20-initialization-script.1827/
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            OutputDevice midiOutput;

            lbDevices.Items.Clear();

            foreach(OutputDevice device in OutputDevice.InstalledDevices)
            {
                lbDevices.Items.Add(device);
                if (device.Name == "Akai APC20")
                {
                    lbDevices.SelectedIndex = lbDevices.Items.Count - 1;
                }
            }


        }

        private void lbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnGeneric_Click(object sender, EventArgs e)
        {
            SendMode(new byte[] { 0xF0, 0x47, 0x7F, 0x7B, 0x60, 0x00, 0x04, 0x40, 0x08, 0x02, 0x01, 0xF7 });
            // --------------------------------------------------------------^  0x40 for Generic mode
        }

        private void btnAbleton_Click(object sender, EventArgs e)
        {
            SendMode(new byte[] { 0xF0, 0x47, 0x7F, 0x7B, 0x60, 0x00, 0x04, 0x41, 0x08, 0x02, 0x01, 0xF7 });
            // ----------------------------------------------------------------^  0x41 for Ableton Live Mode
        }

        private void btnAltAbleton_Click(object sender, EventArgs e)
        {
            SendMode(new byte[] { 0xF0, 0x47, 0x7F, 0x7B, 0x60, 0x00, 0x04, 0x41, 0x08, 0x02, 0x01, 0xF7 });
            // -----------------------------------------------------------------^  0x42 for Alternate Ableton Live Mode
        }

        private void SendMode(byte[] modeSysEx)
        {
            OutputDevice selectedDevice = (OutputDevice)lbDevices.SelectedItem;

            try
            {
                selectedDevice.Open();

                try
                {
                    selectedDevice.SendSysEx(modeSysEx);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while sending the SysEx message to " + selectedDevice.Name + ".", "Error");
                }
                finally
                {
                    selectedDevice.Close();
                }
            }
            catch
            {
                MessageBox.Show("An error occurred while attempting to open " + selectedDevice.Name + ".  Be sure another application isn't currently accessing it.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
