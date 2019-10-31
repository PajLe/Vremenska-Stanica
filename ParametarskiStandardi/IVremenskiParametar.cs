using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametarskiStandardi
{
    public interface IVremenskiParametar
    {
        String Ime { get; }
        double MinStandard { get; }
        double MaxStandard { get; }
        bool postaviStandard(double min, double max);
        bool imaDefinisanStandard();
    }
}
