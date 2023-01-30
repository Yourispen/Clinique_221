using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Views
{
    public interface IConsultationView
    {
        string TxtRecherchePatient { get; set; }
        DateTime DtpDate { get; set; }
        DataGridView DtgvListe { get;}
        //Event
        event EventHandler eventRecherchePatient;
        event EventHandler eventAnnuler;
        event EventHandler eventAjouter;
        event EventHandler eventDetails;
        event EventHandler eventSelectionLigneDtgv;
        event EventHandler eventfiltrerParDate;

        void Show();

        //Methodes
        void setBindingSource(BindingSource consultationList);
    }
}
