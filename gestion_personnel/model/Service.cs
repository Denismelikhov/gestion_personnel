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
        public Service(int idmotif, string libelle)
        {
            this.idservice = idservice;
            this.nom = nom;
        }
    }
}