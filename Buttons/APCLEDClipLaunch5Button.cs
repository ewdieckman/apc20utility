using Midi;
using System;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Clip launch 5 button for each track
    /// </summary>
    [Serializable]
    public class APCLEDClipLaunch5Button : APCLEDClipLaunchButton
    {
        public APCLEDClipLaunch5Button(int trackNumber) : 
            base(trackNumber: trackNumber, clipLaunchNumber: 5, Pitch.A3)
        {

        }
    }
}
