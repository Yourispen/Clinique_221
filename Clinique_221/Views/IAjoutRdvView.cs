using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Views
{
    public interface IAjoutRdvView
    {
        GroupBox GboxPatient { get;}
        CheckBox ChboxNouveauPatient { get;}
        CheckBox ChboxAncienPatient { get; }
        Panel PnlRechercherPatient { get;}
        string TxtCode { get; set; }
        Panel PnlAjoutPatient { get;}
        string TxtNomComplet { get; set; }
        CheckBox ChboxMasculin { get;}
        CheckBox ChboxFeminin { get;}
        DateTime DtpDateNaissance { get; set; }
        CheckedListBox ChlboxListeDesAntecedentsMedicaux { get; }
        GroupBox GboxRdv { get;}
        Panel PnlAjoutRdv { get;}
        CheckBox ChboxConsultation { get;}
        CheckBox ChboxPrestation { get;}
        Label LblListePrestation { get;}
        CheckedListBox ChlboxListeDesPrestations { get; }
        Label LblMedecin { get; }
        ComboBox CboxListeDesMedecin { get; }
        DateTime DtpDateRdv { get; set; }
        Button BtnAjouterDemandeRdv { get; set; }
        ComboBox CboxHeure { get; }

        event EventHandler eventAjouterDemandeRdv;
        event EventHandler eventAnnulerDemandeRdv;
        event EventHandler eventRecherchePatientParCode;
        event EventHandler eventNouveauPatient;
        event EventHandler eventAncienPatient;
        event EventHandler eventChoixSexeFemininPatient;
        event EventHandler eventChoixSexeMasculinPatient;
        event EventHandler eventChoixTypeConsultation;
        event EventHandler eventChoixTypePrestation;
        event EventHandler eventChoixDateRdv;
        event EventHandler eventChoixHeureRdv;

        void Show();

        void setListeTypePrestationsBindingSource(BindingSource prestationList);
        void setListeAntecedentMedicalBindingSource(BindingSource antecedentMedicalList);
        void setListeDesMedecinBindingSource(BindingSource typePrestationList);
        void setListeHorairesBindingSource(BindingSource horaireList);

    }
}
