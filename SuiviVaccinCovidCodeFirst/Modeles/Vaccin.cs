﻿using System;
using System.Collections.Generic;

namespace SuiviVaccinCovidCodeFirst.Modeles
{
    public partial class Vaccin
    {
        public Vaccin()
        {
            Immunisations = new HashSet<Immunisation>();
        }

        public int VaccinId { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Immunisation> Immunisations { get; set; }
    }
}
