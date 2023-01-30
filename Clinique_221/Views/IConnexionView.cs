using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique_221.Views
{
    public interface IConnexionView
    {
        string TxtLogin { get; set; }
        string TxtPassword { get; set; }
        bool Success { get; set; }

        void Hide();
        void Show();

        event EventHandler eventConnexion;
        event EventHandler eventAnnuler;

    }
}
