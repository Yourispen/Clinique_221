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
    public partial class HomeForm : Form, IHomeView
    {
        public Utilisateur UserConnect { get; set; }
        public string LblTitrePage { get => lblTitrePage.Text; set => lblTitrePage.Text=value; }
        public Button BtnRdv { get => btnRdv; set => throw new NotImplementedException(); }
        public Button BtnPatient { get => btnPatient; set => throw new NotImplementedException(); }
        public Button BtnConsultation { get => btnConsultation; set => throw new NotImplementedException(); }
        public Button BtnPrestation { get => btnPrestation; set => throw new NotImplementedException(); }
        public string LblCompte { get => lblCompte.Text; set => lblCompte.Text = value; }

        public HomeForm()
        {
            InitializeComponent();
            activeEvent();
        }

        public event EventHandler eventShowRdv;
        public event EventHandler eventShowPatient;
        public event EventHandler eventShowPrestation;
        public event EventHandler eventShowConsultation;
        public event EventHandler eventShowView;
        public event EventHandler eventDeconnexionView;

        void activeEvent()
        {
            //Mappe ecouteur et objet
            btnRdv.Click += delegate { eventShowRdv.Invoke(this, EventArgs.Empty); };
            btnConsultation.Click += delegate { eventShowConsultation.Invoke(this, EventArgs.Empty); };
            btnPatient.Click += delegate { eventShowPatient.Invoke(this, EventArgs.Empty); };
            btnPrestation.Click += delegate { eventShowPrestation.Invoke(this, EventArgs.Empty); };
            btnDeconnexion.Click += delegate { eventDeconnexionView.Invoke(this, EventArgs.Empty); };
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

    }
}
