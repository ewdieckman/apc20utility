using Midi;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    public class APCLEDSceneLaunchButton : APCLEDButton
    {
        public APCLEDSceneLaunchButton(int sceneLaunchNumber, Pitch noteNumber)
            : base(name: $"Scene Launch {sceneLaunchNumber}",
                  channel: Channel.Channel1,
                  noteNumber: noteNumber,
                  options: new List<IAPCLEDButtonOption>() {
                            new APCLEDButtonOption(Color.Green, false, 1),
                            new APCLEDButtonOption(Color.Green, true, 2),
                  })
                {

        }
    }
}
