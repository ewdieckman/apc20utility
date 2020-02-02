using Midi;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Scene Launch 2
    /// </summary>
    [Serializable]
    public class APCLEDSceneLaunch2Button : APCLEDSceneLaunchButton
    {
        public APCLEDSceneLaunch2Button() : 
            base(sceneLaunchNumber: 2,
                noteNumber: Pitch.B5)
        {

        }
    }
}
