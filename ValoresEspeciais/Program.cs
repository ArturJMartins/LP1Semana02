using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            short aMax = short.MaxValue;
            short aMin = short.MinValue;
            int bMax = int.MaxValue;
            int bMin = int.MinValue;
            long cMax = long.MaxValue;
            long cMin = long.MinValue;
            ushort dMax = ushort.MaxValue;
            ushort dMin = ushort.MinValue;
            uint eMax = uint.MaxValue;
            uint eMin = uint.MinValue;
            ulong fMax = ulong.MaxValue;
            ulong fMin = ulong.MinValue;

            double gMax = double.MaxValue;
            double gMin = double.MinValue;
            float hMax = float.MaxValue;
            float hMin = float.MinValue;
            decimal iMax = decimal.MaxValue;
            decimal iMin = decimal.MinValue;

            float xF = float.PositiveInfinity;
            float yF = float.NegativeInfinity;
            float zF = float.NaN;

            double xD = double.PositiveInfinity;
            double yD = double.NegativeInfinity;
            double zD = double.NaN;



            Console.WriteLine($"Valor máximo de short {aMax} / mínimo {aMin}");
            Console.WriteLine($"Valor máximo de int {bMax} / mínimo {bMin}");
            Console.WriteLine($"Valor máximo de long {cMax} / mínimo {cMin}");
            Console.WriteLine($"Valor máximo de ushort {dMax} / mínimo {dMin}");
            Console.WriteLine($"Valor máximo de uint {eMax} / mínimo {eMin}");
            Console.WriteLine($"Valor máximo de ulong {fMax} / mínimo {fMin}");
            Console.WriteLine($"Valor máximo de double {gMax} / mínimo {gMin}");
            Console.WriteLine($"Valor máximo de float {hMax} / mínimo {hMin}");
            Console.WriteLine($"Valor máximo de decimal {iMax} /" +
            $" mínimo {iMin}");

            Console.WriteLine($"Valor especial float +∞ {xF}");
            Console.WriteLine($"Valor especial float −∞ {yF}");
            Console.WriteLine($"Valor especial float NaN {zF}");
            Console.WriteLine($"Valor especial double +∞ {xD}");
            Console.WriteLine($"Valor especial double −∞ {yD}");
            Console.WriteLine($"Valor especial double NaN {zD}");

            Console.WriteLine("Overflow em uint é: " + $"{(uint) (eMax + 1)}");

            Console.WriteLine("Overflow int em float: "
             + $"{(float) (bMax + 1)}");
            Console.WriteLine("Overflow long em float: " 
            + $"{(float) (cMax + 1)}");
        }
    }
}
