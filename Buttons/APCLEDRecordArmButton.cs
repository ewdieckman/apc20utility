using Midi;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Record/Arm button
    /// </summary>
    public class APCLEDRecordArmButton : APCLEDTrackButton
    {
        public APCLEDRecordArmButton(int trackNumber) : 
            base(name: $"Record/Arm", 
                noteNumber: Pitch.C3, 
                trackNumber: trackNumber,
                options: new List<IAPCLEDButtonOption>() {
                    new APCLEDButtonOption(Color.Red, false, 1),
                  })
        {

        }
    }
}
