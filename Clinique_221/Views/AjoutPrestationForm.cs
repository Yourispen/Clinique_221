using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Views
{
    public partial class AjoutPrestationForm : Form,IAjoutPrestationView
    {
        public string TxtCode { get => txtCode.Text.Trim(); set => txtCode.Text = value; }
        public string TxtNomComplet { get => txtNomComplet.Text.Trim(); set => txtNomComplet.Text = value; }
        public CheckBox ChboxMasculin { get => chboxMasculin; }
        public CheckBox ChboxFeminin { get => chboxFeminin; }
        public DateTime DtpDateNaissance { get => dtpDateNaissance.Value; set => dtpDateNaissance.Value = value; }
        public GroupBox GboxPatient { get => gboxPatient; }
        public Panel PnlAjoutPatient { get => pnlAjoutPatient; }
        public CheckedListBox ChlboxListeDesAntecedentsMedicaux => chlboxAntecedentMedical;
        public CheckedListBox ChlboxListeDesPrestations => chlboxListeDesPrestations;

        public Button BtnAjouter { get => btnAjouter; set => throw new NotImplementedException(); }


        public Panel PnlRechercherPatient => pnlRechercherPatient;

        public GroupBox GboxPrestation => gboxPrestation;

        public Button BtnAnnuler { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public AjoutPrestationForm()
        {
            InitializeComponent();
            activeEvent();
        }

        public event EventHandler eventAjouter;
        public event EventHandler eventRecherchePatientParCode;
        public event EventHandler eventAnnuler;

        void activeEvent()
        {
            btnRecherchePatient.Click += delegate { eventRecherchePatientParCode.Invoke(this, EventArgs.Empty); };
            btnAjouter.Click += delegate { eventAjouter.Invoke(this, EventArgs.Empty); };
            btnAnnuler.Click += delegate { eventAnnuler.Invoke(this, EventArgs.Empty); };
        }


        public void setListeTypePrestationsBindingSource(BindingSource prestationList)
        {
            chlboxListeDesPrestations.DataSource = prestationList;
        }
        public void setListeAntecedentMedicalBindingSource(BindingSource antecedentMedicalList)
        {
            chlboxAntecedentMedical.DataSource = antecedentMedicalList;
        }
        private void AjoutPrestationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
