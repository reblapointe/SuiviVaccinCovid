﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SuiviVaccinCovidCodeFirst.Modeles
{
    public class Vaccin : Immunisation
    {
        public TypeVaccin Type { get; set; }

        public override string ToString()
        {
            return $" Vaccin #{ImmunisationID} ({Type?.Nom}), adiminstré le {Date} à {NAMPatient}";
        }

    }
}
