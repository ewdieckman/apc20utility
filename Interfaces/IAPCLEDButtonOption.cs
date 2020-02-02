using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MIDI_SysEx
{
    public interface IAPCLEDButtonOption
    {
        Color Color { get; }
        bool IsBlinking { get; }
        int Velocity { get; }
    }
}
