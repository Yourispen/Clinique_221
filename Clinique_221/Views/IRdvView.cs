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
        //Event
        event EventHandler eventRecherchePatient;
        event EventHandler eventAjouterPatient;
        event EventHandler eventAjouterRdv;
        event EventHandler eventAnnulerRdv;
        event EventHandler eventValiderRdv;
        //Methodes
        void setRdvBindingSource(BindingSource RdvList);
    }
}
