using Midi;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Scene Launch 5
    /// </summary>
    public class APCLEDSceneLaunch5Button : APCLEDSceneLaunchButton
    {
        public APCLEDSceneLaunch5Button() : 
            base(sceneLaunchNumber: 5,
                noteNumber: Pitch.D7)
        {

        }
    }
}
