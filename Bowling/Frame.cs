using System;
namespace Bowling
{
    public class Frame
    {
        public int FrameId { get; set; }
        public int Pins1 { get; set; }
        public int Pins2 { get; set; }
        public bool Spare { get; set; }
        public bool Strike { get; set; }

    }
}