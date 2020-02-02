using System.Drawing;

namespace MIDI_SysEx
{
    /// <summary>
    /// concrete class of options for an APC LED Button
    /// </summary>
    public class APCLEDButtonOption : IAPCLEDButtonOption
    {
        public static APCLEDButtonOption OFF = new APCLEDButtonOption(Color.White, false, 0);

        public APCLEDButtonOption(Color color, bool isBlinking, int velocity)
        {
            Color = color;
            IsBlinking = isBlinking;
            Velocity = velocity;
        }

        public Color Color { get; }
        public bool IsBlinking { get; }
        public int Velocity { get; }
    }
}
