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
    public partial class PrestationForm : Form,IPrestationView
    {
        public PrestationForm()
        {
            InitializeComponent();
            activeEvent();
        }
        void activeEvent()
        {
            //Mappe ecouteur et objet
            btnAjouter.Click += delegate { eventAjouter.Invoke(this, EventArgs.Empty); };
            btnRecherche.Click += delegate { eventRecherchePatient.Invoke(this, EventArgs.Empty); };
            btnDetails.Click += delegate { eventDetails.Invoke(this, EventArgs.Empty); };
            btnFiltreParDate.Click += delegate { eventfiltrerParDate.Invoke(this, EventArgs.Empty); };
            txtRecherchePatient.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    eventRecherchePatient.Invoke(this, EventArgs.Empty);
                }
            };

        }

        public string TxtRecherchePatient
        {
            get => txtRecherchePatient.Text.Trim();
            set => txtRecherchePatient.Text = value;
        }
        public DateTime DtpDate { get => dtpDate.Value; set => dtpDate.Value = value; }

        public DataGridView DtgvListe => dtgvListe;

        public event EventHandler eventRecherchePatient;
        public event EventHandler eventAjouter;
        public event EventHandler eventAnnuler;
        public event EventHandler eventValider;
        public event EventHandler eventSelectionLigneDtgv;
        public event EventHandler eventfiltrerParDate;
        public event EventHandler eventRecherche;
        public event EventHandler eventDetails;

        private static PrestationForm instance = null;

        public static PrestationForm getInstance(Form parentForm)
        {
            if (parentForm.ActiveMdiChild != null)
            {
                parentForm.ActiveMdiChild.Close();
            }
            if (instance == null || instance.IsDisposed)
            {
                instance = new PrestationForm();
                instance.TopLevel = false;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                instance.MdiParent = parentForm;

            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
        private void PrestationForm_Load(object sender, EventArgs e)
        {

        }

        public void setBindingSource(BindingSource prestationtionList)
        {
            dtgvListe.DataSource = prestationtionList;
        }
    }
}
