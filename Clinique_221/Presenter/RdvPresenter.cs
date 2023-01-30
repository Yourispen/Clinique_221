using Clinique_221.Core;
using Clinique_221.Models;
using Clinique_221.Models.Dto;
using Clinique_221.Services;
using Clinique_221.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Clinique_221.Presenter
{
    public class RdvPresenter:IRdvPresenter
    {
        RdvDto rdvSelect;
        //Dependance et couplage faible
        private IRdvView rdvView;
        private IServiceClinique serviceClinique;
        IHomeView homeView;

        //Injection de dependance et inversion de controle
        public RdvPresenter(IRdvView rdvView, IServiceClinique serviceClinique,IHomeView homeView)
        {
            this.homeView = homeView;
            this.rdvView = rdvView;
            this.serviceClinique = serviceClinique;
            if (homeView.UserConnect.Role != Role.Secretaire)
            {
                rdvView.BtnAjouterRdv.Visible = false;
            }
            this.initialise();
            this.callBackEvent();
            this.rdvView.Show();
        }
        //BindingSource
        BindingSource bindingRdvListe = new BindingSource();

        //Liste
        IEnumerable<RdvDto> rdvListe = new List<RdvDto>();

        public void initialise()
        {
            
            if (homeView.UserConnect.Role == Role.Secretaire)
            {
                rdvListe = toListeRdvDto(Fabrique.getService().listerRdv(DateTime.Now));
                bindingRdvListe.DataSource = rdvListe;
                rdvView.setRdvBindingSource(bindingRdvListe);
            }
            else if (homeView.UserConnect.Role == Role.Medecin)
            {
                rdvListe = toListeRdvDto(Fabrique.getService().listerRdvParMedecin(homeView.UserConnect.Id,DateTime.Now));
                bindingRdvListe.DataSource = rdvListe;
                rdvView.setRdvBindingSource(bindingRdvListe);
            }
            else if (homeView.UserConnect.Role == Role.Rp)
            {
                rdvListe = toListeRdvDto(Fabrique.getService().listerRdvParRp(homeView.UserConnect.Id, DateTime.Now));
                bindingRdvListe.DataSource = rdvListe;
                rdvView.setRdvBindingSource(bindingRdvListe);
            }
        }

        //definir les fonctions de rappel(callback)
        public void callBackEvent()
        {
            rdvView.eventAjouterRdv += ajouterRdvHandle;
            rdvView.eventRecherchePatient += rechercherPatientHandle;
            rdvView.eventAnnulerRdv += annulerRdvHandle;
            rdvView.eventValiderRdv += validerRdvHandle;
            rdvView.eventSelectionLigneDtgv += selectionRdvHandle;
            rdvView.eventfiltrerParDate += filtrerRdvParDateHandle;
        }

        private void selectionRdvHandle(object sender, EventArgs e)
        {
            rdvSelect=bindingRdvListe.Current as RdvDto;
            if (rdvSelect != null)
            {
                if (rdvSelect.EtatRdv == Etat.Valide || rdvSelect.EtatRdv == Etat.Annule)
                {
                    rdvView.BtnAnnulerRdv.Visible = false;
                    rdvView.BtnValiderRdv.Visible = false;
                }
                else
                {
                    rdvView.BtnAnnulerRdv.Visible = true;
                    rdvView.BtnValiderRdv.Visible = true;
                }
            }
        }
        private void filtrerRdvParDateHandle(object sender, EventArgs e)
        {
            //rdvListe=toListeRdvDto(Fabrique.getService().listerRdv(rdvView.DtpDateRdv));
            bindingRdvListe.Clear();
            if (homeView.UserConnect.Role == Role.Secretaire)
            {
                rdvListe = toListeRdvDto(Fabrique.getService().listerRdv(rdvView.DtpDateRdv));
            }
            else if (homeView.UserConnect.Role == Role.Medecin)
            {
                rdvListe = toListeRdvDto(Fabrique.getService().listerRdvParMedecin(homeView.UserConnect.Id, rdvView.DtpDateRdv));
            }
            else if (homeView.UserConnect.Role == Role.Rp)
            {
                rdvListe = toListeRdvDto(Fabrique.getService().listerRdvParRp(homeView.UserConnect.Id, rdvView.DtpDateRdv));
            }
            bindingRdvListe.DataSource = rdvListe;
        }

        private void validerRdvHandle(object sender, EventArgs e)
        {
            if(bindingRdvListe.Current != null)
            {
                Rdv rdv = serviceClinique.rechercherRdv((bindingRdvListe.Current as RdvDto).Id);
                rdv.EtatRdv = Etat.Valide;
                serviceClinique.ajouterRdv(rdv);
                MessageBox.Show("Rendez-vous validé.");
            }
        }

        private void annulerRdvHandle(object sender, EventArgs e)
        {
            RdvDto rdvDto = bindingRdvListe.Current as RdvDto;
            if(rdvDto != null)
            {
                Rdv rdv = serviceClinique.rechercherRdv(rdvDto.Id);
                rdv.EtatRdv = Etat.Annule;
                rdv = serviceClinique.ajouterRdv(rdv);
                MessageBox.Show("Rendez-vous annulé.");
            }
        }

        private void rechercherPatientHandle(object sender, EventArgs e)
        {
            bindingRdvListe.Clear();
            if (!string.IsNullOrWhiteSpace(rdvView.TxtRecherchePatient))
            {
                rdvListe=toListeRdvDto(Fabrique.getService().listerRdvParPatient(rdvView.TxtRecherchePatient));            
            }
            else
            {
                rdvListe=toListeRdvDto(Fabrique.getService().listerRdv());
            }
            bindingRdvListe.DataSource = rdvListe;

        }

        private void ajouterRdvHandle(object sender, EventArgs e)
        {
            IAjoutRdvView ajoutRdvView = new AjoutRdvForm();
            new AjoutRdvPresenter(ajoutRdvView, Fabrique.getService());
        }

        private List<RdvDto> toListeRdvDto(IEnumerable<Rdv> rdvs)
        {
            List<RdvDto> list = new List<RdvDto>();
            foreach (var rdv in rdvs)
            {
                RdvDto rdvDto = new RdvDto();
                rdvDto.toRdvDto(rdv);
                list.Add(rdvDto);
            }
            Console.WriteLine(list.Count);
            return list;
        }
    }
}
