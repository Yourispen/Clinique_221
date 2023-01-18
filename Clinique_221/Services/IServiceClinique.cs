using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Services
{
    public interface IServiceClinique
    {
        List<Rdv> listerRdv();
        Rdv ajouterRdv(Rdv rdv);
        List<Rdv> listerRdvParPatient(int idPatient);
        List<Rdv> listerRdvParPatient(string codePatient);
        List<TypePrestation> listerTypePrestation();
        List<TypePrestation> listerTypePrestation(string codePatient);
        List<Medecin> listerMedecin();
        List<Medecin> listerMedecin(DateTime date);
        Patient rechercherPatient(string code);
        Patient ajouterPatient(Patient patient);
        List<AntecedentMedical> listerAntecedentMedical();
        List<AntecedentMedical> listerAntecedentMedical(int idPatient);
        AntecedentMedical ajouterAntecedentMedical(AntecedentMedical antecedentMedical);
        void ajouterAntecedentMedicalUnPatient(Patient patient,List<AntecedentMedical> antecedentMedicaux);
        Consultation ajouterConsultation(Consultation consultation);
        Prestation ajouterPrestation(Prestation prestation);
        void ajouterPrestationTypePrestation(Prestation prestation);
    }
}
