using System;

namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een container voor bedrijfsinformatie.
    /// </summary>
    public class CompanyInfoModel
    {
        public const string ResourceName = "companyInfo";

        public Guid AdministratieIdentifier { get; set; }
        public string AdministratieNaam { get; set; }
        public string Bedrijfsnaam { get; set; }
        public string Contactpersoon { get; set; }
        public string Adres { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }
        public string Telefoon { get; set; }
        public string MobieleTelefoon { get; set; }
        public string Fax { get; set; }
        public string Bankrekeningnummer { get; set; }
        public string Iban { get; set; }
        public string Bic { get; set; }
        public string BtwNummer { get; set; }
        public string KvKNummer { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string VrijeTekst1 { get; set; }
        public string VrijeTekst2 { get; set; }
        public string VrijeTekst3 { get; set; }
        public string VrijeTekst4 { get; set; }
        public int HuidigBoekjaar { get; set; }
        public int BeginmaandFiscaleBoekjaar { get; set; }
        public AangiftePeriodeTypeModel? BtwAangiftePeriodeSoort { get; set; }
        public AangiftePeriodeTypeModel? IcpAangiftePeriodeSoort { get; set; }
        public string BtwNummerFiscaleEenheid { get; set; }
        public bool TussentijdseSuppletiesBerekenen { get; set; }
        public string MapUBLBestanden { get; set; }
        public decimal BtwPercentageAangifteKredietbeperking { get; set; }
        public MarkeergedragInlezenBankafschriftenModel MarkeergedragInlezenBankafschriften { get; set; }
        public bool VoorkeurenTijdensBoeken { get; set; }
        public int? AantalVoorloopnullenGrootboekrekeningen { get; set; }
        public KleineOndernemersRegelingModel KleineOndernemersregeling { get; set; }
        public int? VolgendFactuurnummer { get; set; }
        public int? VolgendVerkoopordernummer { get; set; }
        public int? VolgendContantbonnummer { get; set; }
        public int? VolgendInkoopordernummer { get; set; }
        public bool VoorraadcontroleOrderinvoer { get; set; }
        public bool AbonnementOvernemen { get; set; }
        public bool? KolomGeleverdAutomatischVullen { get; set; }
        public bool? VoorraadkolommenTonenInInkoop { get; set; }
        public bool BackorderGebruiken { get; set; }
        public bool DeelleveringOrdersDefaultAan { get; set; }
        public bool FactuurAlsBijlageVerkoopboeking { get; set; }
        public TekstregelsNaarBackorderModel? TekstregelsOvernemenNaarBackorder { get; set; }
        public RegelkortingRekenmethodeModel RegelkortingVerkooporder { get; set; }
        public decimal DrempelbedragVerkooporderbeheer { get; set; }
        public int DrempelbedragVerkooporderbeheerMaxDagenUitstel { get; set; }
        public bool VerkoopprijsArtikelbestandExclusiefBtw { get; set; }
        public bool InkoopprijsArtikelbestandExclusiefBtw { get; set; }
        public ArtikelCodeSoortModel ArtikelcodeSoort { get; set; }
        public int ArtikelcodeMaxLengte { get; set; }
        public DateTime BegindatumVoorraadtelling { get; set; }
        public bool VoorraadTonenInZoekvenster { get; set; }
        public int AantalDecimalenArtikelprijzen { get; set; }
        public int AantalDecimalenArtikelaantallen { get; set; }
        public VerkoopOrderVoorraadNiveauModel VerkooporderVoorraadVanafNiveau { get; set; }
        public VoorraadSysteemModel? VoorraadSysteem { get; set; }
        public VoorraadBijwerkmomentModel? MomentVoorraadBijwerken { get; set; }
        public GrootboekIdentifierModel RekeningTeOntvangenInkoopfacturen { get; set; }
        public GrootboekIdentifierModel DagboekVoorraadverschillen { get; set; }
    }
}
