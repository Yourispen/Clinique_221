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

namespace Clinique_221.Presenter
{
    public class ConsultationPresenter:IConsultationPresenter
    {
        ConsultationDto consultationSelect;
        //Dependance et couplage faible
        private IConsultationView view;
        private IServiceClinique serviceClinique;
        private IHomeView homeView;

        Medecin medecinTest;

        //Injection de dependance et inversion de controle
        public ConsultationPresenter(IConsultationView view, IServiceClinique serviceClinique,IHomeView homeView)
        {
            this.homeView = homeView;
            this.view = view;
            this.serviceClinique = serviceClinique;

            medecinTest = serviceClinique.rechercherMedecin(homeView.UserConnect.Id);

            this.initialise();
            this.callBackEvent();

            this.view.Show();
        }
        //BindingSource
        BindingSource bindingListe = new BindingSource();

        //Liste
        IEnumerable<ConsultationDto> liste = new List<ConsultationDto>();

        public void initialise()
        {
            liste = toListeDto( Fabrique.getService().listerConsultation(view.DtpDate,medecinTest.Id));
            this.bindingListe.DataSource = liste;
            this.view.setBindingSource(bindingListe);
        }

        //definir les fonctions de rappel(callback)
        public void callBackEvent()
        {
            view.eventRecherchePatient += rechercherPatientHandle;
            view.eventAnnuler += annulerHandle;
            view.eventDetails += detailsHandle;
            view.eventfiltrerParDate += filtrerParDateHandle;
            view.eventSelectionLigneDtgv += selectionLigneHandle;
            view.eventAjouter += ajouterHandle;
        }

        private void selectionLigneHandle(object sender, EventArgs e)
        {
           
        }

        private void filtrerParDateHandle(object sender, EventArgs e)
        {
            liste = toListeDto( Fabrique.getService().listerConsultation(view.DtpDate,medecinTest.Id));
            bindingListe.DataSource = liste;
        }

        private void annulerHandle(object sender, EventArgs e)
        {
            ConsultationDto consultationDto = bindingListe.Current as ConsultationDto;
            if (consultationDto != null)
            {
                Consultation consultation = serviceClinique.rechercherConsultation(consultationDto.Id);
                consultation.EtatConsultation = Etat.Annule;
                consultation = serviceClinique.ajouterConsultation(consultation);
            }
        }

        private void rechercherPatientHandle(object sender, EventArgs e)
        {
            bindingListe.Clear();
            if (!string.IsNullOrWhiteSpace(view.TxtRecherchePatient))
            {
                liste =toListeDto( Fabrique.getService().listerConsultation(view.DtpDate,view.TxtRecherchePatient,medecinTest.Id));
            }
            else
            {
                liste = toListeDto(Fabrique.getService().listerConsultation());
            }
            bindingListe.DataSource = liste;

        }

        private void ajouterHandle(object sender, EventArgs e)
        {
            IAjoutConsultationView ajoutConsultationView = new AjoutConsultationForm();
            new AjoutConsultationPresenter(ajoutConsultationView, Fabrique.getService(), homeView, new Consultation());
        }
        private void detailsHandle(object sender, EventArgs e)
        {
            if (bindingListe.Current != null)
            {
                Consultation consultation = serviceClinique.rechercherConsultation((bindingListe.Current as ConsultationDto).Id);
                IAjoutConsultationView ajoutConsultationView = new AjoutConsultationForm();
                new AjoutConsultationPresenter(ajoutConsultationView, Fabrique.getService(), homeView, consultation);
            }
        }

        private List<ConsultationDto> toListeDto(IEnumerable<Consultation> consultations)
        {
            List<ConsultationDto> list = new List<ConsultationDto>();
            foreach (var consultation in consultations)
            {
                ConsultationDto consultationDto = new ConsultationDto();
                consultationDto.toDto(consultation);
                list.Add(consultationDto);
            }
            Console.WriteLine(list.Count);
            return list;
        }
    }
}
