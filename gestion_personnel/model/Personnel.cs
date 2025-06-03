using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_personnel.model
{
    /// <summary>
    /// Classe métier représentant le personnel.
    /// </summary>
    public class Personnel
    {
        public int idpersonnel { get; }
        public string nom { get; set;  }
        public string prenom { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public Service service { get; set; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.service = service;
        }

        public Personnel(string nom, string prenom, string tel, string mail, Service service)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.service = service;
        }
    }
}
