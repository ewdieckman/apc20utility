using Midi;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    public class APCLEDTrackSelectionButton : APCLEDTrackButton
    {
        public APCLEDTrackSelectionButton(int trackNumber) :
            base(name: $"Track Selection",
                noteNumber: Pitch.DSharp3,
                trackNumber: trackNumber,
                options: new List<IAPCLEDButtonOption>() {
                            new APCLEDButtonOption(Color.Green, false, 1),
                  })
        {

        }
    }
}
