using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Views
{
    public interface IRdvView
    {
        //Propriété
        string TxtRecherchePatient { get; set; }
        DateTime DtpDateRdv { get; set; }
        Button BtnAnnulerRdv { get;}
        Button BtnValiderRdv { get; }
        Button BtnAjouterRdv { get; }
        DataGridView DtgvListeRdv { get;}
        //Event
        event EventHandler eventRecherchePatient;
        event EventHandler eventAjouterPatient;
        event EventHandler eventAjouterRdv;
        event EventHandler eventAnnulerRdv;
        event EventHandler eventValiderRdv;
        event EventHandler eventSelectionLigneDtgv;
        event EventHandler eventfiltrerParDate;
        //Methodes
        void Show();
        void setRdvBindingSource(BindingSource RdvList);
    }
}
