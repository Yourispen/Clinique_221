using Clinique_221.Core;
using Clinique_221.Models.Dto;
using Clinique_221.Models;
using Clinique_221.Services;
using Clinique_221.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinique_221.Presenter
{
    public class PrestationPresenter:IPrestationPresenter
    {
        Prestation prestationSelect;
        //Dependance et couplage faible
        private IPrestationView view;
        private IServiceClinique serviceClinique;
        private IHomeView homeView;

        //Injection de dependance et inversion de controle
        public PrestationPresenter(IPrestationView view, IServiceClinique serviceClinique,IHomeView homeView)
        {
            this.homeView = homeView;
            this.view = view;
            this.serviceClinique = serviceClinique;

            this.initialise();
            this.callBackEvent();
            this.view.Show();
        }
        //BindingSource
        BindingSource bindingListe = new BindingSource();

        //Liste
        IEnumerable<PrestationDto> liste = new List<PrestationDto>();

        public void initialise()
        {
            liste = toListeDto(Fabrique.getService().listerPrestation(view.DtpDate));
            this.bindingListe.DataSource = liste;
            this.view.setBindingSource(bindingListe);
        }

        //definir les fonctions de rappel(callback)
        public void callBackEvent()
        {
            view.eventAjouter += ajouterHandle;
            view.eventRecherchePatient += rechercherPatientHandle;
            view.eventDetails += detailsHandle;
            view.eventfiltrerParDate += filtrerParDateHandle;
        }

        private void filtrerParDateHandle(object sender, EventArgs e)
        {
            liste = toListeDto(Fabrique.getService().listerPrestation(view.DtpDate));
            bindingListe.DataSource = liste;
        }

        private void rechercherPatientHandle(object sender, EventArgs e)
        {
            bindingListe.Clear();
            if (!string.IsNullOrWhiteSpace(view.TxtRecherchePatient))
            {
                liste = toListeDto(Fabrique.getService().listerPrestation(view.DtpDate,view.TxtRecherchePatient));
            }
            else
            {
                liste = toListeDto(Fabrique.getService().listerPrestation(view.DtpDate));
            }
            bindingListe.DataSource = liste;

        }

        private void ajouterHandle(object sender, EventArgs e)
        {
            IAjoutPrestationView ajoutPrestationView = new AjoutPrestationForm();
            new AjoutPrestationPresenter(ajoutPrestationView, Fabrique.getService(),homeView,new Prestation());
        }
        private void detailsHandle(object sender, EventArgs e)
        {
            if (bindingListe.Current != null)
            {
                Prestation prestation = serviceClinique.rechercherPrestation((bindingListe.Current as PrestationDto).Id);
                IAjoutPrestationView ajoutPrestationView = new AjoutPrestationForm();
                new AjoutPrestationPresenter(ajoutPrestationView, Fabrique.getService(), homeView, prestation);
            }
        }

        private List<PrestationDto> toListeDto(IEnumerable<Prestation> prestations)
        {
            List<PrestationDto> list = new List<PrestationDto>();
            foreach (var prestation in prestations)
            {
                PrestationDto prestationDto = new PrestationDto();
                prestationDto.toDto(prestation);
                list.Add(prestationDto);
            }
            Console.WriteLine(list.Count);
            return list;
        }
    }
}
