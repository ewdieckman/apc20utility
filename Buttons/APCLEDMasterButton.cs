using Midi;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MIDI_SysEx.Buttons
{
    /// <summary>
    /// Master button
    /// </summary>
    [Serializable]
    public class APCLEDMasterButton : APCLEDButton
    {
        public APCLEDMasterButton() : 
            base(name: $"Master", 
                channel: Channel.Channel1,
                noteNumber: Pitch.GSharp5, 
                options: new List<IAPCLEDButtonOption>() {
                    new APCLEDButtonOption(Color.Green, false, 1),
                  })
        {

        }
    }
}
