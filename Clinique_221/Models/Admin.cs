﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Models
{
    public class Admin : Utilisateur
    {
        public Admin()
        {
            Role = Role.Admin;
        }
    }
}
