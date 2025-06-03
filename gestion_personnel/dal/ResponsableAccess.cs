using gestion_personnel.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace gestion_personnel.dal
{
    internal class ResponsableAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ResponsableAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Controle si le responsable a le droit de se connecter (login, pwd et profil "responsable")
        /// </summary>
        /// <param name="responsable"></param>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "SELECT * FROM responsable WHERE login = @login AND pwd = SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@login", responsable.login },
                    { "@pwd", responsable.pwd },
                };
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.ControleAuthentification catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }

        /// <summary>
        /// Récupère et retourne les peersonnels
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetLesPersonnels()
        {
            List<Personnel> lesPersonnels = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "SELECT p.idpersonnel as Identifiant, p.nom as Nom, p.prenom as Prénom, p.tel as Téléphone, p.mail as Mail, s.idservice as IdService, s.nom AS nomservice ";
                req += "FROM personnel p JOIN service s ON p.idservice = s.idservice ";
                req += "ORDER BY p.nom, p.prenom ";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("ResponsableAccess.GetLesPersonnels nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[5], (string)record[6]);
                            Log.Debug("ResponsableAccess.GetLesPersonnels Personnel : id={0} nom={1} prenom={2} tel={3} mail={4} idService={5} nomService={6}", record[0], record[1], record[2], record[3], record[4], record[5], record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2],
                                (string)record[3], (string)record[4], service);
                            lesPersonnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.GetLesPersonnels catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesPersonnels;
        }

        /// <summary>
        /// Récupère et retourne les absences
        /// </summary>
        /// <param name="idPersonnel">objet personnel à supprimer</param>
        /// <returns>liste des développeurs</returns>
        public List<Absence> GetAbsencesPourPersonnel(int idPersonnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "SELECT a.idpersonnel AS Identifiant, p.nom AS Nom, p.prenom AS Prenom, " +
                             "a.datedebut AS `Date début`, a.datefin AS `Date fin`, " +
                             "m.idmotif AS `Id Motif`, m.libelle AS Raison " +
                             "FROM absence a " +
                             "JOIN motif m ON a.idmotif = m.idmotif " +
                             "JOIN personnel p ON a.idpersonnel = p.idpersonnel " +
                             "WHERE a.idpersonnel = @id " +
                             "ORDER BY GREATEST(a.datedebut, a.datefin) DESC";

                try
                {
                    Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", idPersonnel }
            };

                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[5], (string)record[6]);
                            Absence absence = new Absence(
                                (int)record[0],
                                (DateTime)record[3],
                                (DateTime)record[4],
                                motif
                            );
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.GetAbsencesPourPersonnel erreur req={0} message={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }

            return lesAbsences;
        }


        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from personnel where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    {"@idpersonnel", personnel.idpersonnel }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.DelPersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
                req += "values (@nom, @prenom, @tel, @mail, @idService);";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@nom", personnel.nom },
                    { "@prenom", personnel.prenom },
                    { "@tel", personnel.tel },
                    { "@mail", personnel.mail },
                    { "@idservice", personnel.service.idservice }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.AddPersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice=@idservice where idpersonnel = @idpersonnel;";

                Dictionary<string, object> parameters = new Dictionary<string, object> {
                    { "@idpersonnel", personnel.idpersonnel },
                    { "@nom", personnel.nom },
                    { "@prenom", personnel.prenom },
                    { "@tel", personnel.tel },
                    { "@mail", personnel.mail },
                    { "@idservice", personnel.service.idservice }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.UpdatePersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = @"
                DELETE FROM absence
                WHERE idpersonnel = @idpersonnel
                AND datedebut = @datedebut
                AND datefin = @datefin
                AND idmotif = @idmotif
                ";
                Dictionary<string, object> parameters = new Dictionary<string, object> {
                {"@idpersonnel", absence.idpersonnel },
                {"@datedebut", absence.datedebut },
                {"@datefin", absence.datefin },
                {"@idmotif", absence.motif.idmotif }
                };
                
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.DelAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";

                Dictionary<string, object> parameters = new Dictionary<string, object> {
                { "@idpersonnel", absence.idpersonnel },
                { "@datedebut", absence.datedebut }, 
                { "@datefin", absence.datefin },     
                { "@idmotif", absence.motif.idmotif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                    Log.Debug("ResponsableAccess.AddAbsence - Absence ajoutée avec succès pour personnel {0}", absence.idpersonnel);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.AddAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }


        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        /// <param name="oldDateDebut"></param>
        /// <param name="oldDateFin"></param>/param>
        /// <param name="oldIdMotif"></param>
        public void UpdateAbsence(Absence absence, DateTime oldDateDebut, DateTime oldDateFin, int oldIdMotif)
        {
            if (access.Manager != null)
            {
                string req = @"
                UPDATE absence
                SET datedebut = @newDateDebut, datefin = @newDateFin, idmotif = @newIdMotif
                WHERE idpersonnel = @idpersonnel
                 AND datedebut = @oldDateDebut
                AND datefin = @oldDateFin
                AND idmotif = @oldIdMotif;
                ";

                Dictionary<string, object> parameters = new Dictionary<string, object> {
                { "@idpersonnel", absence.idpersonnel },
                { "@newDateDebut", absence.datedebut },
                { "@newDateFin", absence.datefin },
                { "@newIdMotif", absence.motif.idmotif },
                { "@oldDateDebut", oldDateDebut },
                { "@oldDateFin", oldDateFin },
                { "@oldIdMotif", oldIdMotif }
                };

                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                    Log.Debug("ResponsableAccess.UpdateAbsence - Mise à jour effectuée");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("ResponsableAccess.UpdateAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
