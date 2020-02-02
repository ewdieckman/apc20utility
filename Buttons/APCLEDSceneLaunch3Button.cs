using Midi;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Scene Launch 3
    /// </summary>
    public class APCLEDSceneLaunch3Button : APCLEDSceneLaunchButton
    {
        public APCLEDSceneLaunch3Button() : 
            base(sceneLaunchNumber: 3,
                noteNumber: Pitch.C6)
        {

        }
    }
}
