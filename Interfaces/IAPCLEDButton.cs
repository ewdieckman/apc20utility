using Midi;
using System;
using System.Collections.ObjectModel;

namespace MIDI_SysEx
{
    /// <summary>
    /// Interface for each LED button
    /// </summary>
    public interface IAPCLEDButton
    {
        string Name { get; }
        Channel Channel { get; }
        Pitch NoteNumber { get; }
        ReadOnlyCollection<IAPCLEDButtonOption> AvailableOptions { get; }
        int SelectedOptionIndex { get; }
        IAPCLEDButtonOption SelectedOption { get; }
        void SetSelectedOption(int index);
        event EventHandler SelectedOptionChanged;
        System.Windows.Forms.Button Parent { get; }
        void SetParentButton(System.Windows.Forms.Button button);

    }
}
