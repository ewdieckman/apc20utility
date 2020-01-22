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
            }


        }

        private void lbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGeneric_Click(object sender, EventArgs e)
        {
            SendMode(new byte[] { 0xF0, 0x47, 0x7F, 0x7B, 0x60, 0x00, 0x40, 0x41, 0x08, 0x02, 0x01, 0xF7 });
            // -------------------------------------------------------^  0x40 for Generic mode
        }

        private void btnAbleton_Click(object sender, EventArgs e)
        {
            SendMode(new byte[] { 0xF0, 0x47, 0x7F, 0x7B, 0x60, 0x00, 0x41, 0x41, 0x08, 0x02, 0x01, 0xF7 });
            // -------------------------------------------------------^  0x41 for Ableton Live Mode
        }

        private void btnAltAbleton_Click(object sender, EventArgs e)
        {
            SendMode(new byte[] { 0xF0, 0x47, 0x7F, 0x7B, 0x60, 0x00, 0x42, 0x41, 0x08, 0x02, 0x01, 0xF7 });
            // -------------------------------------------------------^  0x42 for Alternate Ableton Live Mode
        }

        private void SendMode(byte[] modeSysEx)
        {
            OutputDevice selectedDevice = (OutputDevice)lbDevices.SelectedItem;

            try
            {
                selectedDevice.Open();

                selectedDevice.SendSysEx(new byte[] { 0xF0, 0x47, 0x7F, 0x7B, 0x60, 0x00, 0x41, 0x41, 0x08, 0x02, 0x01, 0xF7 });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


    }
}
