using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametarskiStandardi
{
    public class Temperatura : IVremenskiParametar
    {
        private static Temperatura instanca;
        private string ime = "temperatura";
        private double minStandard;
        private double maxStandard;

        private Temperatura ()
        {
        }

        public static Temperatura instance()
        {
            if (instanca == null)
                instanca = new Temperatura();
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
