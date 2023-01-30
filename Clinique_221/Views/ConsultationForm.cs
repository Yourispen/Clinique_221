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
    public partial class ConsultationForm : Form,IConsultationView
    {
        public ConsultationForm()
        {
            InitializeComponent();
            activeEvent();
        }
        void activeEvent()
        {
            //Mappe ecouteur et objet
            btnRecherche.Click += delegate { eventRecherchePatient.Invoke(this, EventArgs.Empty); };
            btnAjouter.Click += delegate { eventAjouter.Invoke(this, EventArgs.Empty); };
            btnDetails.Click += delegate { eventDetails.Invoke(this, EventArgs.Empty); };
            btnFiltreParDate.Click += delegate { eventfiltrerParDate.Invoke(this, EventArgs.Empty); };
            txtRecherchePatient.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    eventRecherchePatient.Invoke(this, EventArgs.Empty);
                }
            };
            //dtgvListe.SelectionChanged += delegate { eventSelectionLigneDtgv.Invoke(this, EventArgs.Empty); };

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
        public event EventHandler eventfiltrerParDate;
        public event EventHandler eventRecherche;
        public event EventHandler eventSelectionLigneDtgv;
        public event EventHandler eventDetails;

        public void setBindingSource(BindingSource consultationtionList)
        {
            dtgvListe.DataSource = consultationtionList;
        }

        private static ConsultationForm instance = null;

        public static ConsultationForm getInstance(Form parentForm)
        {
            if (parentForm.ActiveMdiChild != null)
            {
                parentForm.ActiveMdiChild.Close();
            }
            if (instance == null || instance.IsDisposed)
            {
                instance = new ConsultationForm();
                instance.FormBorderStyle = FormBorderStyle.None;
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
        private void ConsultationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
