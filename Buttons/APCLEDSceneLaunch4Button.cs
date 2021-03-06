using Midi;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Scene Launch 4
    /// </summary>
    [Serializable]
    public class APCLEDSceneLaunch4Button : APCLEDSceneLaunchButton
    {
        public APCLEDSceneLaunch4Button() : 
            base(sceneLaunchNumber: 4,
                noteNumber: Pitch.CSharp7)
        {

        }
    }
}
