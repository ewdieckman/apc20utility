using Midi;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// LED Button used per-track
    /// </summary>
    public class APCLEDTrackButton : APCLEDButton, IAPCLEDButton
    {
        
        public APCLEDTrackButton(string name, Pitch noteNumber, int trackNumber, IEnumerable<IAPCLEDButtonOption> options) : 
            base (name: $"Track {trackNumber} {name}", channel:(Channel)(trackNumber-1), noteNumber:noteNumber, options: options)
        {

        }

    }
}
