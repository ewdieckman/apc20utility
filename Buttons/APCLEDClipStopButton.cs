using Midi;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Clip launch 5 button for each track
    /// </summary>
    [Serializable]
    public class APCLEDClipStopButton : APCLEDTrackButton
    {
        public APCLEDClipStopButton(int trackNumber) : 
            base(trackNumber: trackNumber, 
                noteNumber:Pitch.E3, 
                name:"Clip Stop",
                options: new List<IAPCLEDButtonOption>() {
                            new APCLEDButtonOption(Color.Green, false, 1),
                            new APCLEDButtonOption(Color.Green, true, 2),
                  })
        {

        }
    }
}
