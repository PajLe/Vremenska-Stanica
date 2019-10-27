using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametarskiStandardi
{
    public class Vlaznost : IVremenskiParametar
    {
        private static Vlaznost instanca;
        private string ime = "vlaznost";
        private double minStandard;
        private double maxStandard;

        private Vlaznost()
        {
        }

        public static Vlaznost instance()
        {
            if (instanca == null)
                instanca = new Vlaznost();
            return instanca;
        }

        public string Ime { get { return ime; } }

        public bool postaviStandard(double min, double max)
        {
            if (min > max)
                return false;
            minStandard = min;
            maxStandard = max;
            return true;
        }

        public double MinStandard { get { return minStandard; } }
        public double MaxStandard { get { return maxStandard; } }
    }
}
