namespace GameColor.Core.Models
{
    public class BitwiseRgb
    {
        public bool R { get; private set; }
        public bool G { get; private set; }
        public bool B { get; private set; }

        public BitwiseRgb(bool r, bool g, bool b)
        {
            R = r;
            G = g;
            B = b;
        }

        public int GetBitwiseSummary()
        {
            var sum = 0;
            if (R) sum += 2;
            if (G) sum += 3;
            if (B) sum += 6;

            return sum;
        }
    }
}
