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
    public class PatientPresenter : IPatientPresenter
    {
        private IPatientView patientView;
        private IServiceClinique serviceClinique;
        private Patient patientSelect;

        public PatientPresenter(IPatientView patientView, IServiceClinique serviceClinique)
        {
            this.patientView = patientView;
            this.serviceClinique = serviceClinique;

            this.initialise();
            this.callBackEvent();

            this.patientView.Show();
        }

        //BindingSource
        BindingSource bindingPatientListe = new BindingSource();

        //Liste
        //IEnumerable<Patient> patientListe = new List<Patient>();
        List<PatientDto> patientDtoListe = new List<PatientDto>();

        public void initialise()
        {
            toListePatientDto(Fabrique.getService().listerPatient());
            bindingPatientListe.DataSource = patientDtoListe;

            this.patientView.setRdvBindingSource(bindingPatientListe);
        }

        public void callBackEvent()
        {
            //patientView.eventVoirDossier += voirDossierRdvHandle;
            //patientView.eventArchiverPatient += archiverPatientHandle;
            patientView.eventRecherchePatient += rechercherRdvHandle;
            patientView.eventSelectionLigneDtgv += selectionRdvHandle;
        }

        private void voirDossierRdvHandle(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void archiverPatientHandle(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void rechercherRdvHandle(object sender, EventArgs e)
        {
            bindingPatientListe.Clear();
            PatientDto patientDto = new PatientDto();
            if (!string.IsNullOrWhiteSpace(patientView.TxtRecherchePatient))
            {
                patientDto.toPatientDto(Fabrique.getService().rechercherPatient(patientView.TxtRecherchePatient));
                patientDtoListe = new List<PatientDto>()
                {
                    patientDto
                };
            }
            else
            {
                toListePatientDto(Fabrique.getService().listerPatient());
            }
            if (patientDtoListe != null)
                bindingPatientListe.DataSource = patientDtoListe;
        }
        private void selectionRdvHandle(object sender, EventArgs e)
        {
            patientSelect= bindingPatientListe.Current as Patient;
        }
        private void toListePatientDto(IEnumerable<Patient> patients)
        {
            foreach (var pat in patients)
            {
                PatientDto patientDto= new PatientDto();
                patientDto.toPatientDto(pat);
                patientDtoListe.Add(patientDto);
            }

        }
    }
}
