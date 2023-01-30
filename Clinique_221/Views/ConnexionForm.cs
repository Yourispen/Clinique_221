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
    public partial class ConnexionForm : Form,IConnexionView
    {
        public ConnexionForm()
        {
            InitializeComponent();
            activeEvent();
        }
        void activeEvent()
        {
            //Mappe ecouteur et objet
            //btnAnnuler.Click += delegate { eventAnnuler.Invoke(this, EventArgs.Empty); };
            btnConnexion.Click += delegate { eventConnexion.Invoke(this, EventArgs.Empty); };

        }

        public string TxtLogin
        {
            get => txtLogin.Text.Trim();
            set => txtLogin.Text = value;
        }
        public string TxtPassword
        {
            get => txtPassword.Text.Trim();
            set => txtPassword.Text = value;
        }
        public bool Success { get; set; }

        public event EventHandler eventAnnuler;
        public event EventHandler eventConnexion;


        private static ConnexionForm instance = null;

        public static ConnexionForm getInstance()
        {
            
            if (instance == null || instance.IsDisposed)
            {
                instance = new ConnexionForm();

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
        private void ConnexionForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
