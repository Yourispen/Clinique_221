﻿using Clinique_221.Models;
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
        public event EventHandler eventSelectionLigneDtgv;
        public event EventHandler eventRecherchePatient;
        public event EventHandler eventAjouterPatient;
        public event EventHandler eventAjouterRdv;
        public event EventHandler eventAnnulerRdv;
        public event EventHandler eventValiderRdv;
        public event EventHandler eventfiltrerParDate;
        void activeEvent()
        {
            //Mappe ecouteur et objet
            dtgvListeRdv.SelectionChanged += delegate { eventSelectionLigneDtgv.Invoke(this, EventArgs.Empty); };

            btnAjouterRdv.Click += delegate { eventAjouterRdv.Invoke(this, EventArgs.Empty); };
            btnRecherche.Click += delegate { eventRecherchePatient.Invoke(this, EventArgs.Empty); };
            btnAnnulerRdv.Click += delegate { eventAnnulerRdv.Invoke(this, EventArgs.Empty); };
            btnValiderRdv.Click += delegate { eventValiderRdv.Invoke(this, EventArgs.Empty); };
            btnFiltreParDate.Click += delegate { eventfiltrerParDate.Invoke(this, EventArgs.Empty); };
            txtRecherchePatient.KeyDown += (s, e) =>
            {
                if(e.KeyCode == Keys.Enter)
                {
                    eventRecherchePatient.Invoke(this, EventArgs.Empty);
                }
            };
        }

        //les champs
        public string TxtRecherchePatient 
        { 
            get => txtRecherchePatient.Text.Trim(); 
            set => txtRecherchePatient.Text=value; 
        }
        public DateTime DtpDateRdv { get => dtpDateRdv.Value; set => dtpDateRdv.Value = value; }
        public DataGridView DtgvListeRdv { get => dtgvListeRdv;}

        public Button BtnAjouterRdv => btnAjouterRdv;

        public Button BtnAnnulerRdv => btnAnnulerRdv;

        public Button BtnValiderRdv => btnValiderRdv;

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

        private static RdvForm instance = null;

        public static RdvForm getInstance(Form parentForm)
        {
            if (parentForm.ActiveMdiChild != null)
            {
                parentForm.ActiveMdiChild.Close();
            }
            if (instance == null || instance.IsDisposed)
            {
                instance = new RdvForm();
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

        private void RdvForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
