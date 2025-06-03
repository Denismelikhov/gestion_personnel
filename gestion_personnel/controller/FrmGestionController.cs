using gestion_personnel.dal;
using gestion_personnel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace gestion_personnel.controller
{
    /// <summary>
    /// Contrôleur de FrmHabilitations
    /// </summary>
    public class FrmGestionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur le personnel
        /// </summary>
        private readonly ResponsableAccess personnelAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur les absences
        /// </summary>
        private readonly ResponsableAccess absenceAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur les services
        /// </summary>
        private readonly ServiceAccess serviceAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur les motifs
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmGestionController()
        {
            personnelAccess = new ResponsableAccess();
            absenceAccess = new ResponsableAccess();
            serviceAccess = new ServiceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAccess.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les absences d'un personnel
        /// </summary>
        /// <param name="idPersonnel">int idPersonnel</param>
        /// <returns>absences du personnel</returns>
        public List<Absence> GetAbsencesPourPersonnel(int idPersonnel)
        {
            return absenceAccess.GetAbsencesPourPersonnel(idPersonnel);
        }

        /// <summary>
        /// Récupère et retourne les services du personnel
        /// </summary>
        /// <returns>liste de services</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Récupère et retourne les motifs d'absence
        /// </summary>
        /// <returns>liste de motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            Console.WriteLine($"Controller.AddAbsence - Personnel: {absence.idpersonnel}, Début: {absence.datedebut:yyyy-MM-dd}, Fin: {absence.datefin:yyyy-MM-dd}, Motif: {absence.motif.idmotif}");
            try
            {
                absenceAccess.AddAbsence(absence);
                Console.WriteLine("Controller.AddAbsence - Appel ResponsableAccess terminé");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Controller.AddAbsence - Exception: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence</param>
        /// <param name="oldDateDebut"></param>
        /// <param name="oldDateFin"></param>
        /// <param name="oldidmotif"></param>
        public void UpdateAbsence(Absence absence, DateTime oldDateDebut, DateTime oldDateFin, int oldidmotif)
        {
            absenceAccess.UpdateAbsence(absence, oldDateDebut, oldDateFin, oldidmotif);
        }

        /// <summary>
        /// Test pour savoir si un créneau existe déja.
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="absenceExclue">objet absenceExclue</param>
        public bool ExisteAbsenceCreneau(int idPersonnel, DateTime dateDebut, DateTime dateFin, Absence absenceExclue = null)
        {
            var absences = GetAbsencesPourPersonnel(idPersonnel);

            foreach (var abs in absences)
            {
                if (absenceExclue != null && abs.Equals(absenceExclue))
                    continue;

                if (dateDebut <= abs.datefin && dateFin >= abs.datedebut)
                    return true;
            }
            return false;
        }
    }
}
