namespace SnelStart.B2B.Client.Operations
{
    public enum PrijsBepalingSoortModel
    {
        NormaleVerkoopprijs = 0,

        /// <summary>
        /// Actieprijzen per artikel
        /// </summary>
        ActieprijzenPerArtikel = 1,

        /// <summary>
        /// Actieprijzen per artikelkortingsgroep
        /// </summary>
        ActieprijzenPerArtikelkortingsgroep = 2,

        /// <summary>
        /// Prijsafspraak per artikel per klant
        /// </summary>
        AfspraakPerArtikelklant = 3,

        /// <summary>
        /// Prijsafspraak per artikel per klantkortingsgroep
        /// </summary>
        AfspraakPerArtikelPerKlantkortingsgroep = 4,

        /// <summary>
        /// Prijsafspraak per klant per artikelkortingsgroep
        /// </summary>
        AfspraakPerKlantPerArtikelkortingsgroep = 5,

        /// <summary>
        /// /// Prijsafspraak per artikelkortingsgroep per klantkortingsgroep
        /// </summary>
        AfspraakPerArtikelkortingsgroepPerKlantkortingsgroep = 6
    }
}
