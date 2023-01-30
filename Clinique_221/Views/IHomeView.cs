using Clinique_221.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Views
{
    public interface IHomeView
    {
        event EventHandler eventShowRdv;
        event EventHandler eventShowPatient;
        event EventHandler eventShowPrestation;
        event EventHandler eventShowConsultation;
        event EventHandler eventShowView;
        event EventHandler eventDeconnexionView;

        Utilisateur UserConnect { get; set; }
        string LblTitrePage { get; set; }
        string LblCompte { get; set; }
        Button BtnRdv { get; set; }
        Button BtnPatient { get; set; }
        Button BtnConsultation { get; set; }
        Button BtnPrestation { get; set; }

        void Show();
    }
}
