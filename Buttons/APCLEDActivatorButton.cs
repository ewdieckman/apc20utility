using Midi;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    [Serializable]
    public class APCLEDActivatorButton: APCLEDTrackButton
    {
        public APCLEDActivatorButton(int trackNumber) :
            base(name: $"Track Slection",
                noteNumber: Pitch.D3,
                trackNumber: trackNumber,
                options: new List<IAPCLEDButtonOption>() {
                            new APCLEDButtonOption(Color.Green, false, 1),
                  })
        {

        }
    }
}
