using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuCheckBox.Transitions;

namespace Clinique_221.Views
{
    public partial class AjoutRdvForm : Form,IAjoutRdvView
    {
        public string TxtCode { get => txtCode.Text.Trim(); set => txtCode.Text = value; }
        public string TxtNomComplet { get => txtNomComplet.Text.Trim(); set => txtNomComplet.Text = value; }
        public CheckBox ChboxMasculin { get => chboxMasculin; }
        public CheckBox ChboxFeminin { get => chboxFeminin;}
        public DateTime DtpDateNaissance { get => dtpDateNaissance.Value; set => dtpDateNaissance.Value = value; }
        public string TxtNomParent { get => txtNomComplet.Text.Trim(); set => txtNomComplet.Text = value; }
        public CheckBox ChboxConsultation { get => chboxConsultation;}
        public CheckBox ChboxPrestation { get => chboxPrestation;}
        public DateTime DtpDateRdv { get => dtpDateRdv.Value; set => dtpDateRdv.Value = value; }
        public GroupBox GboxPatient { get => gboxPatient;}
        public Panel PnlAjoutPatient { get => pnlAjoutPatient;}
        public GroupBox GboxRdv { get => gboxRdv;}
        public Panel PnlAjoutRdv { get => pnlAjoutRdv;}

        public Label LblListePrestation => lblListePrestation;

        public Label LblMedecin => lblMedecin;

        public CheckedListBox ChlboxListeDesPrestations => chlboxListeDesPrestations;

        public ComboBox CboxListeDesMedecin => cboxListeDesMedecin;

        public Panel PnlRechercherPatient => pnlRechercherPatient;

        public CheckBox ChboxNouveauPatient => chboxNouveauPatient;

        public CheckBox ChboxAncienPatient => chboxAncienPatient;

        public AjoutRdvForm()
        {
            InitializeComponent();
            activeEvent();
        }


        public event EventHandler eventAjouterDemandeRdv;
        public event EventHandler eventAnnulerDemandeRdv;
        public event EventHandler eventRecherchePatientParCode;
        public event EventHandler eventNouveauPatient;
        public event EventHandler eventAncienPatient;
        public event EventHandler eventChoixSexeFemininPatient;
        public event EventHandler eventChoixSexeMasculinPatient;
        public event EventHandler eventChoixTypeConsultation;
        public event EventHandler eventChoixTypePrestation;

        void activeEvent()
        {
            chboxNouveauPatient.CheckedChanged+= delegate { eventNouveauPatient.Invoke(this, EventArgs.Empty); };
            chboxAncienPatient.CheckedChanged += delegate { eventAncienPatient.Invoke(this, EventArgs.Empty); };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AjoutRdvForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void setListeTypePrestationsBindingSource(BindingSource prestationList)
        {
            chlboxListeDesPrestations.DataSource = prestationList;
        }

        public void setAntecedentMedicalBindingSource(BindingSource antecedentMedicalList)
        {
            throw new NotImplementedException();
        }

        public void setListeDesMedecinBindingSource(BindingSource typePrestationList)
        {
            cboxListeDesMedecin.DataSource = typePrestationList;
        }
    }
}
