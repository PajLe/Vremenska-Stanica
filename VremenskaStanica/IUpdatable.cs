﻿using ParametarskiStandardi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VremenskaStanica
{
    public interface IUpdatable
    {
        void Update(Dictionary<IVremenskiParametar, double> vrednostiVremenskihParametara, DateTime vremeSlanja);
    }
}
