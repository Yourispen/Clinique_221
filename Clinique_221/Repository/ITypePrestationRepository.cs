﻿using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Repository
{
    public interface ITypePrestationRepository : IRepository<TypePrestation>
    {
        List<TypePrestation> findAllByPrestation(Prestation prestation);
        List<TypePrestation> findAllByConsultation(Consultation consultation);
    }
}
