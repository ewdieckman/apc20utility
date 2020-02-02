using Midi;
using System;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Clip launch 1 button for each track
    /// </summary>
    [Serializable]
    public class APCLEDClipLaunch1Button : APCLEDClipLaunchButton
    {
        public APCLEDClipLaunch1Button(int trackNumber) : 
            base(trackNumber: trackNumber, clipLaunchNumber: 1, Pitch.F3)
        {

        }
    }
}
