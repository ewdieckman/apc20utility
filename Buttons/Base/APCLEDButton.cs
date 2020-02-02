using Midi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MIDI_SysEx
{
    /// <summary>
    /// concrete class representing an LED button
    /// </summary>
    public abstract class APCLEDButton : IAPCLEDButton
    {
        public APCLEDButton(string name, Channel channel, Pitch noteNumber, IEnumerable<IAPCLEDButtonOption> options)
        {
            Name = name;
            Channel = channel;
            NoteNumber = noteNumber;
            AvailableOptions = options.ToList().AsReadOnly();
            SelectedOptionIndex = -1;
        }

        public string Name { get; }

        public Channel Channel { get; }

        public Pitch NoteNumber { get; }

        public ReadOnlyCollection<IAPCLEDButtonOption> AvailableOptions { get; }

        public int SelectedOptionIndex { get; private set; }

        public System.Windows.Forms.Button Parent { get; private set; }

        public void SetSelectedOption(int index)
        {

            if (index != -1 && AvailableOptions.ElementAt(index) == null)
                throw new ArgumentOutOfRangeException(nameof(index));

            SelectedOptionIndex = index;
            OnSelectedOptionChanged();
        }

        public IAPCLEDButtonOption SelectedOption
        {
            get
            {

                if (SelectedOptionIndex == -1)
                    return APCLEDButtonOption.OFF;

                if (AvailableOptions.ElementAt(SelectedOptionIndex) == null)
                    throw new ArgumentOutOfRangeException(nameof(SelectedOptionIndex));

                return AvailableOptions[SelectedOptionIndex];
            }
        }

        public void SetParentButton(System.Windows.Forms.Button button)
        {
            Parent = button;
        }
        
        //declare event
        public event EventHandler SelectedOptionChanged;

        protected virtual void OnSelectedOptionChanged()
        {
            SelectedOptionChanged?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Turns off/clears the button
        /// </summary>
        public void TurnOffButton()
        {
            SetSelectedOption(-1);
        }
    }
}
