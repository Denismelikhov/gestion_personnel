using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_personnel.model
{
    /// <summary>
    /// Classe métier représentant les services du personnel.
    /// </summary>
    public class Service
    {
        public int idservice { get; }
        public string nom { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        /// <summary>
        /// Redéfinit ToString() pour afficher le nom du service
        /// </summary>
        /// <returns>Nom du service</returns>
        public override string ToString()
        {
            return nom;
        }
    }
}