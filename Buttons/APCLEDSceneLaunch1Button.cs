using Midi;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Scene Launch 1
    /// </summary>
    [Serializable]
    public class APCLEDSceneLaunch1Button : APCLEDSceneLaunchButton
    {
        public APCLEDSceneLaunch1Button() : 
            base(sceneLaunchNumber: 1,
                noteNumber: Pitch.ASharp5)
        {

        }
    }
}
