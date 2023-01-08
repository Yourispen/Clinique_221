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

namespace Clinique_221.Views
{
    public partial class RdvForm : Form,IRdvView
    {
        public RdvForm()
        {
            InitializeComponent();
            activeEvent();
        }
        void activeEvent()
        {
            //Mappe ecouteur et objet
            btnAjouterRdv.Click += delegate { eventAjouterRdv.Invoke(this, EventArgs.Empty); };
            btnRecherche.Click += delegate { eventRecherchePatient.Invoke(this, EventArgs.Empty); };
            btnAnnulerRdv.Click += delegate { eventAnnulerRdv.Invoke(this, EventArgs.Empty); };
            btnValiderRdv.Click += delegate { eventValiderRdv.Invoke(this, EventArgs.Empty); };
            txtRecherchePatient.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Enter)
                {
                    eventRecherchePatient.Invoke(this, EventArgs.Empty);
                }
            };
            dtgvListeRdv.SelectionChanged += delegate { eventSelectionLigneDtgv.Invoke(this, EventArgs.Empty); };

        }

        //les champs
        public string TxtRecherchePatient 
        { 
            get => txtRecherchePatient.Text.Trim(); 
            set => txtRecherchePatient.Text=value; 
        }

        public event EventHandler eventRecherchePatient;
        public event EventHandler eventAjouterPatient;
        public event EventHandler eventAjouterRdv;
        public event EventHandler eventAnnulerRdv;
        public event EventHandler eventValiderRdv;
        public event EventHandler eventSelectionLigneDtgv;

        public void setRdvBindingSource(BindingSource rdvList)
        {
            /*dtgvListeRdv.Rows.Clear();
            foreach(var obj in rdvList)
            {
                Rdv rdv = obj as Rdv;
                dtgvListeRdv.Rows.Add(new object[] {
                    rdv.DateRdv,
                    rdv.Patient,
                    rdv.TypeRdv,
                    rdv.Medecin,
                    rdv.EtatRdv,
                    "Annuler",
                    "Valider"
                }) ;
                dtgvListeRdv.Rows[]
            }*/
            dtgvListeRdv.DataSource = rdvList;
        }

        private void RdvForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
