using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Views
{
    public interface IAjoutConsultationView
    {
        GroupBox GboxPatient { get; }
        Panel PnlRechercherPatient { get; }
        string TxtCode { get; set; }
        Panel PnlAjoutPatient { get; }
        string TxtNomComplet { get; set; }
        CheckBox ChboxMasculin { get; }
        CheckBox ChboxFeminin { get; }
        DateTime DtpDateNaissance { get; set; }
        CheckedListBox ChlboxListeDesAntecedentsMedicaux { get; }
        Button BtnAjouter { get; set; }
        Button BtnAnnuler { get; set; }
        Button BtnSupprimerMedicament { get; set; }
        Button BtnAjouterMedicament { get; set; }
        CheckBox ChboxAvec { get; }
        CheckBox ChboxSans { get; }
        GroupBox GboxConsultation { get; }
        DataGridView DtgvListeMedicament { get; }
        Panel PnlMedicament { get; }
        string TxtCodeMedicament { get; set;}

        event EventHandler eventAjouter;
        event EventHandler eventAnnuler;
        event EventHandler eventRecherchePatientParCode;
        event EventHandler eventAjouterMedicament;
        event EventHandler eventSupprimerMedicament;
        event EventHandler eventAvecOrdonnance;
        event EventHandler eventSansOrdonnance;

        void Show();

        void setListeAntecedentMedicalBindingSource(BindingSource antecedentMedicalList);
        void setListeMedicamentBindingSource(BindingSource medicamentList);
    }
}
