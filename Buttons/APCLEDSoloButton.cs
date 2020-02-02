using Midi;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Solo/Cue button per track
    /// </summary>
    public class APCLEDSoloButton : APCLEDTrackButton
    {
        public APCLEDSoloButton(int trackNumber) :
            base(name: $"Solo/Cue",
                noteNumber: Pitch.CSharp3,
                trackNumber: trackNumber,
                options: new List<IAPCLEDButtonOption>() {
                            new APCLEDButtonOption(Color.Blue, false, 1),
                  })
        {

        }
    }
}
