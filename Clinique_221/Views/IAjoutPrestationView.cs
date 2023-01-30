using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Views
{
    public interface IAjoutPrestationView
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
        CheckedListBox ChlboxListeDesPrestations { get; }
        GroupBox GboxPrestation { get; }

        event EventHandler eventAjouter;
        event EventHandler eventAnnuler;
        event EventHandler eventRecherchePatientParCode;

        void Show();

        void setListeTypePrestationsBindingSource(BindingSource prestationList);
        void setListeAntecedentMedicalBindingSource(BindingSource antecedentMedicalList);

    }
}
