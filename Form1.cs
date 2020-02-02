using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Midi;
using MIDI_SysEx.Buttons;

namespace MIDI_SysEx
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Button> allButtons;
        private Dictionary<string, Button> usedButtons;

        /// <summary>
        /// APC Information taken from https://forums.pangolin.com/threads/apc20-initialization-script.1827/
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            allButtons = new Dictionary<string, Button>();
            usedButtons = new Dictionary<string, Button>();

        }

        private EventHandler ButtonClickEventHandler { get; set; }
        private MouseEventHandler ButtonMouseDownEventHandler { get; set; }
        private EventHandler SelectedOptionChangedEventHandler { get; set; }

        private void LoadLEDButtons()
        {
            PopulateButtonDictionary();


            // all per-track buttons
            for(var track=1; track<9; track++)
            {
                // clip launch buttons
                SetupButton($"btn_cl_{track}_1", new APCLEDClipLaunch1Button(track));

                SetupButton($"btn_cl_{track}_2", new APCLEDClipLaunch2Button(track));

                SetupButton($"btn_cl_{track}_3", new APCLEDClipLaunch3Button(track));

                SetupButton($"btn_cl_{track}_4", new APCLEDClipLaunch4Button(track));

                SetupButton($"btn_cl_{track}_5", new APCLEDClipLaunch5Button(track));

                //clip stop
                SetupButton($"btn_cs_{track}", new APCLEDClipStopButton(track));

                // track selection
                SetupButton($"btn_ts_{track}", new APCLEDTrackSelectionButton(track));

                // activator
                SetupButton($"btn_act_{track}", new APCLEDActivatorButton(track));

                // solo/cue
                SetupButton($"btn_sc_{track}", new APCLEDSoloButton(track));

                // record/arm
                SetupButton($"btn_ra_{track}", new APCLEDRecordArmButton(track));
            }

            // master/Note Mode
            SetupButton($"btn_master", new APCLEDMasterButton());

            // Scene Launch 1
            SetupButton($"btn_sl_1", new APCLEDSceneLaunch1Button());

            // Scene Launch 2
            SetupButton($"btn_sl_2", new APCLEDSceneLaunch2Button());

            // Scene Launch 3
            SetupButton($"btn_sl_3", new APCLEDSceneLaunch3Button());

            // Scene Launch 4
            SetupButton($"btn_sl_4", new APCLEDSceneLaunch4Button());

            // Scene Launch 5
            SetupButton($"btn_sl_5", new APCLEDSceneLaunch5Button());
        }

        /// <summary>
        /// Sets up the button on the form with the necessary parameters
        /// </summary>
        /// <param name="name">id/name of the button to find</param>
        /// <param name="led">led to attach to the button</param>
        public void SetupButton(string name, IAPCLEDButton led)
        {
            Button btn = GetButton(name);
            btn.Tag = led;
            btn.Click += ButtonClickEventHandler;
            btn.MouseDown += ButtonMouseDownEventHandler;
            led.SelectedOptionChanged += SelectedOptionChangedEventHandler;
            led.SetParentButton(btn);

            usedButtons.Add(btn.Name, btn);
        }

        public void PopulateButtonDictionary()
        {
            var buttons = GetAll(this, typeof(Button)).ToList();
            allButtons = buttons.ToDictionary(x => x.Name, x => (Button)x);
        }

        public IEnumerable<System.Windows.Forms.Control> GetAll(System.Windows.Forms.Control control, Type type)
        {
            var controls = control.Controls.Cast<System.Windows.Forms.Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                        .Concat(controls)
                                        .Where(c => c.GetType() == type);
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
            SendMode(new byte[] { 0xF0, 0x47, 0x7F, 0x7B, 0x60, 0x00, 0x04, 0x42, 0x08, 0x02, 0x01, 0xF7 });
            // -----------------------------------------------------------------^  0x42 for Alternate Ableton Live Mode
        }

        /// <summary>
        /// common right-click event for all APC buttons
        /// </summary>
        private void APCButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btn = (Button)sender;
                APCLEDButton led = (APCLEDButton)btn.Tag;

                btn.BackColor = SystemColors.Control;
                btn.Text = "";
                led.SetSelectedOption(-1);
                TurnOffLED(led.Channel, led.NoteNumber);
            }
            
        }

        /// <summary>
        /// common click event for all APC buttons
        /// </summary>
        private void APCButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            APCLEDButton led = (APCLEDButton)btn.Tag;

            int index;
            
            if (((MouseEventArgs)e).Button == MouseButtons.Right || led.SelectedOptionIndex == (led.AvailableOptions.Count - 1))
            {
                index = -1;
                //btn.BackColor = SystemColors.Control;
                //btn.Text = "";
                //led.SetSelectedOption(index);
                //TurnOffLED(led.Channel, led.NoteNumber);
            }
            else
            { 
                if (led.SelectedOptionIndex == -1)
                    index = 0;
                else 
                    index = led.SelectedOptionIndex + 1;

                
                //var option = led.SelectedOption;
                //btn.BackColor = option.Color;
                //btn.Text = option.IsBlinking ? "(B)" : "";
                //TurnOnLED(led, option);
            }

            led.SetSelectedOption(index);
        }

        /// <summary>
        /// Sends a note on to the selected device
        /// </summary>
        private void TurnOnLED(IAPCLEDButton button, IAPCLEDButtonOption option)
        {
            OutputDevice selectedDevice = (OutputDevice)lbDevices.SelectedItem;

            selectedDevice.Open();

            try
            {

                selectedDevice.SendNoteOn(button.Channel, button.NoteNumber, option.Velocity);

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

        /// <summary>
        /// Sends a note off to the selected device
        /// </summary>
        private void TurnOffLED(Channel channel, Pitch noteNumber)
        {
            OutputDevice selectedDevice = (OutputDevice)lbDevices.SelectedItem;

            selectedDevice.Open();

            try
            {

                selectedDevice.SendNoteOff(channel, noteNumber,0);

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

        /// <summary>
        /// Retrieves the button on the form
        /// </summary>
        private Button GetButton(string key)
        {
            //return (Button)Controls.Find(key, true).First();
            if (allButtons.TryGetValue(key, out Button value))
                return value;
            else
                throw new ArgumentOutOfRangeException(nameof(key));

        }

        /// <summary>
        /// Sends the mode to the APC20
        /// </summary>
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

        /// <summary>
        /// Load event handler for the form
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            lbDevices.Items.Clear();

            foreach (OutputDevice device in OutputDevice.InstalledDevices)
            {
                lbDevices.Items.Add(device);
                if (device.Name == "Akai APC20")
                {
                    lbDevices.SelectedIndex = lbDevices.Items.Count - 1;
                }
            }


            ButtonClickEventHandler = new EventHandler(APCButton_Click);
            ButtonMouseDownEventHandler = new MouseEventHandler(APCButton_MouseDown);
            SelectedOptionChangedEventHandler = new EventHandler(LEDButtonSelectedOptionChanged);

            LoadLEDButtons();
        }

        /// <summary>
        /// Click event handler for the Exit button
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnClearAll_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear all of the APC20 buttons?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                ClearAllButtons();


        }

        /// <summary>
        /// event handler for when a selected option changed for <see cref="IAPCLEDButton"/>
        /// </summary>
        private void LEDButtonSelectedOptionChanged(object sender, EventArgs e)
        {
            var led = (IAPCLEDButton)sender;
            var btn = led.Parent;

            if (led.SelectedOption == APCLEDButtonOption.OFF)
            {
                btn.BackColor = SystemColors.Control;
                btn.Text = "";
                TurnOffLED(led.Channel, led.NoteNumber);
            }
            else
            {
                var option = led.SelectedOption;
                btn.BackColor = option.Color;
                btn.Text = option.IsBlinking ? "(B)" : "";
                TurnOnLED(led, option);
            }
                
        }

        /// <summary>
        /// Sets all buttons back to default color
        /// </summary>
        private void ClearAllButtons()
        {
            APCLEDButton led;
            foreach(string key in usedButtons.Keys)
            {
                usedButtons.TryGetValue(key, out Button button);
                led = (APCLEDButton)button.Tag;
                led.TurnOffButton();
            }
                
        }
    }
}
