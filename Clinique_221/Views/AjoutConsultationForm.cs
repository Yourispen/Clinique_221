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
    public partial class AjoutConsultationForm : Form,IAjoutConsultationView
    {
        public string TxtCode { get => txtCode.Text.Trim(); set => txtCode.Text = value; }
        public string TxtNomComplet { get => txtNomComplet.Text.Trim(); set => txtNomComplet.Text = value; }
        public CheckBox ChboxMasculin { get => chboxMasculin; }
        public CheckBox ChboxFeminin { get => chboxFeminin; }
        public DateTime DtpDateNaissance { get => dtpDateNaissance.Value; set => dtpDateNaissance.Value = value; }
        public GroupBox GboxPatient { get => gboxPatient; }
        public Panel PnlAjoutPatient { get => pnlAjoutPatient; }
        public CheckedListBox ChlboxListeDesAntecedentsMedicaux => chlboxAntecedentMedical;
        public CheckBox ChboxSans { get => chboxSans; }
        public CheckBox ChboxAvec { get => chboxAvec; }

        public Button BtnAjouter { get => btnAjouter; set => throw new NotImplementedException(); }


        public Panel PnlRechercherPatient => pnlRechercherPatient;

        public GroupBox GboxConsultation => gboxConsultation;

        public Button BtnAnnuler { get => btnAnnuler; set => throw new NotImplementedException(); }
        public Button BtnSupprimerMedicament { get => btnSupprimerMedicament; set => throw new NotImplementedException(); }
        public Button BtnAjouterMedicament { get => btnAjouterMedicament; set => throw new NotImplementedException(); }

        public DataGridView DtgvListeMedicament => dtgvListeMedicament;

        public Panel PnlMedicament => pnlMedicament;

        public string TxtCodeMedicament { get => txtCodeMedicament.Text.Trim(); set => txtCodeMedicament.Text = value; }

        public AjoutConsultationForm()
        {
            InitializeComponent();
            activeEvent();
        }

        public event EventHandler eventAjouter;
        public event EventHandler eventRecherchePatientParCode;
        public event EventHandler eventAnnuler;
        public event EventHandler eventAjouterMedicament;
        public event EventHandler eventSupprimerMedicament;
        public event EventHandler eventAvecOrdonnance;
        public event EventHandler eventSansOrdonnance;

        void activeEvent()
        {
            btnRecherchePatient.Click += delegate { eventRecherchePatientParCode.Invoke(this, EventArgs.Empty); };
            btnAjouter.Click += delegate { eventAjouter.Invoke(this, EventArgs.Empty); };
            btnAnnuler.Click += delegate { eventAnnuler.Invoke(this, EventArgs.Empty); };
            btnAjouterMedicament.Click += delegate { eventAjouterMedicament.Invoke(this, EventArgs.Empty); };
            btnSupprimerMedicament.Click += delegate { eventSupprimerMedicament.Invoke(this, EventArgs.Empty); };
            chboxAvec.CheckedChanged += delegate { eventAvecOrdonnance.Invoke(this, EventArgs.Empty); };
            chboxSans.CheckedChanged += delegate { eventSansOrdonnance.Invoke(this, EventArgs.Empty); };
        }
        public void setListeAntecedentMedicalBindingSource(BindingSource antecedentMedicalList)
        {
            chlboxAntecedentMedical.DataSource = antecedentMedicalList;
        }
        private void AjoutConsultationForm_Load(object sender, EventArgs e)
        {

        }

        public void setListeMedicamentBindingSource(BindingSource medicamentList)
        {
            dtgvListeMedicament.DataSource = medicamentList;
        }
    }
}
