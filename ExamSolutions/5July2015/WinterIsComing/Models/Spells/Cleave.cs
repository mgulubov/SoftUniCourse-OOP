﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterIsComing.Models.Spells
{
    public class Cleave : AbstractSpell
    {
        public Cleave(int damage, int energyCost)
            : base(damage, energyCost)
        {

        }
    }
}
