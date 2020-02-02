using Midi;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Clip launch 2 button for each track
    /// </summary>
    public class APCLEDClipLaunch2Button : APCLEDClipLaunchButton
    {
        public APCLEDClipLaunch2Button(int trackNumber) : 
            base(trackNumber: trackNumber, clipLaunchNumber: 2, Pitch.FSharp3)
        {

        }
    }
}
