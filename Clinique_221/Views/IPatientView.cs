using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Views
{
    public interface IPatientView
    {
        string TxtRecherchePatient { get; set; }
        //Event
        event EventHandler eventRecherchePatient;
        event EventHandler eventVoirDossier;
        event EventHandler eventArchiverPatient;
        event EventHandler eventSelectionLigneDtgv;
        //Methodes
        void Show();
        void setRdvBindingSource(BindingSource patientListe);
    }
}
