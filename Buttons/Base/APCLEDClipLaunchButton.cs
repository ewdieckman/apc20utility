using Midi;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// base class for all track clip launch buttons
    /// </summary>
    [Serializable]
    public abstract class APCLEDClipLaunchButton : APCLEDTrackButton
    {
        public APCLEDClipLaunchButton(int trackNumber, int clipLaunchNumber, Pitch noteNumber)
            : base(name: $"Clip Launch {clipLaunchNumber}", 
                  noteNumber: noteNumber, 
                  trackNumber: trackNumber,
                  options: new List<IAPCLEDButtonOption>() {
                    new APCLEDButtonOption(Color.Green, false, 1),
                    new APCLEDButtonOption(Color.Green, true, 2),
                    new APCLEDButtonOption(Color.Red, false, 3),
                    new APCLEDButtonOption(Color.Red, true, 4),
                    new APCLEDButtonOption(Color.Yellow, false, 5),
                    new APCLEDButtonOption(Color.Yellow, true, 6)
                  })
        {

        }
    }
}
