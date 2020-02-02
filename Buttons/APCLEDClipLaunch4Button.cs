using Midi;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Clip launch 4 button for each track
    /// </summary>
    public class APCLEDClipLaunch4Button : APCLEDClipLaunchButton
    {
        public APCLEDClipLaunch4Button(int trackNumber) : 
            base(trackNumber: trackNumber, clipLaunchNumber: 4, Pitch.GSharp3)
        {

        }
    }
}
