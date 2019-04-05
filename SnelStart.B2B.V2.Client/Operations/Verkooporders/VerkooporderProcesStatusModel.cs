using System;
using System.Collections.Generic;
using System.Text;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een enumeratie van Proces-statussen voor verkooporders.
    /// </summary>
    public enum ProcesStatusModel
    {
        /// <summary>
        /// Order
        /// </summary>
        Order,
        /// <summary>
        /// Offerte
        /// </summary>
        Offerte,
        /// <summary>
        /// Bevestiging
        /// </summary>
        Bevestiging,
        /// <summary>
        /// Werkbon
        /// </summary>
        Werkbon,
        /// <summary>
        /// Pakbon
        /// </summary>
        Pakbon,
        /// <summary>
        /// Afhaalbon
        /// </summary>
        Afhaalbon,
        /// <summary>
        /// Contantbon
        /// </summary>
        Contantbon,
        /// <summary>
        /// Factuur
        /// </summary>
        Factuur
    }
}
