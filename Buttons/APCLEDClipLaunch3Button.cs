using Midi;
using System;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Clip launch 3 button for each track
    /// </summary>
    [Serializable]
    public class APCLEDClipLaunch3Button : APCLEDClipLaunchButton
    {
        public APCLEDClipLaunch3Button(int trackNumber) : 
            base(trackNumber: trackNumber, clipLaunchNumber: 3, Pitch.G3)
        {

        }
    }
}
