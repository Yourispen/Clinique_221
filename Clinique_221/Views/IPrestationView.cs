using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Views
{
    public interface IPrestationView
    {
        string TxtRecherchePatient { get; set; }
        DateTime DtpDate { get; set; }
        DataGridView DtgvListe { get; }
        //Event
        event EventHandler eventRecherchePatient;
        event EventHandler eventAjouter;
        event EventHandler eventAnnuler;
        event EventHandler eventDetails;
        event EventHandler eventSelectionLigneDtgv;
        event EventHandler eventfiltrerParDate;
        //Methodes
        void Show();
        void setBindingSource(BindingSource consultationtionList);
    }
}
