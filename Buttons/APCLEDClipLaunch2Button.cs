using Midi;
using System;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Clip launch 2 button for each track
    /// </summary>
    [Serializable]
    public class APCLEDClipLaunch2Button : APCLEDClipLaunchButton
    {
        public APCLEDClipLaunch2Button(int trackNumber) : 
            base(trackNumber: trackNumber, clipLaunchNumber: 2, Pitch.FSharp3)
        {

        }
    }
}
