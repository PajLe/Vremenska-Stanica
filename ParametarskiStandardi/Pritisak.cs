using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametarskiStandardi
{
    public class Pritisak : IVremenskiParametar
    {
        private static Pritisak instanca;
        private string ime = "pritisak";
        private double minStandard;
        private double maxStandard;

        private Pritisak()
        {
        }

        public static Pritisak instance()
        {
            if (instanca == null)
                instanca = new Pritisak();
            return instanca;
        }

        public string Ime { get { return ime; } }

        public bool postaviStandard(double min, double max)
        {
            if (min >= max)
                return false;
            minStandard = min;
            maxStandard = max;
            return true;
        }

        public bool imaDefinisanStandard()
        {
            return !(minStandard == 0 && maxStandard == 0);
        }

        public double MinStandard { get { return minStandard; } }
        public double MaxStandard { get { return maxStandard; } }
    }
}
