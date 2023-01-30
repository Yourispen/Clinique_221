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
    public partial class PatientForm : Form,IPatientView
    {
        public PatientForm()
        {
            InitializeComponent();
            activeEvent();
        }


        void activeEvent()
        {
            //Mappe ecouteur et objet
            //btnDossierMedicalPatient.Click += delegate { eventVoirDossier.Invoke(this, EventArgs.Empty); };
            btnRecherche.Click += delegate { eventRecherchePatient.Invoke(this, EventArgs.Empty); };
            //btnArchiverRdv.Click += delegate { eventArchiverPatient.Invoke(this, EventArgs.Empty); };
            txtRecherchePatient.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    eventRecherchePatient.Invoke(this, EventArgs.Empty);
                }
            };
            //dtgvListeRdv.SelectionChanged += delegate { eventSelectionLigneDtgv.Invoke(this, EventArgs.Empty); };

        }
        public string TxtRecherchePatient
        {
            get => txtRecherchePatient.Text.Trim();
            set => txtRecherchePatient.Text = value;
        }

        public event EventHandler eventRecherchePatient;
        public event EventHandler eventVoirDossier;
        public event EventHandler eventArchiverPatient;
        public event EventHandler eventSelectionLigneDtgv;

        public void setRdvBindingSource(BindingSource patientList)
        {
            dtgvListePatient.DataSource = patientList;
        }

        private static PatientForm instance = null;

        public static PatientForm getInstance(Form parentForm)
        {
            if(parentForm.ActiveMdiChild != null)
            {
                parentForm.ActiveMdiChild.Close();
            }
            if(instance == null || instance.IsDisposed)
            {
                instance = new PatientForm();
                instance.FormBorderStyle= FormBorderStyle.None;
                instance.MdiParent = parentForm;

            }
            else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
