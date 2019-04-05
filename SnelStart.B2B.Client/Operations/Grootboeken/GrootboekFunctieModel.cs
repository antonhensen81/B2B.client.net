namespace SnelStart.B2B.Client.Operations
{
    /// <summary>
    /// Een enumeratie van grootboekfuncties.
    /// </summary>
    public enum GrootboekFunctieModel
    {
        /// <summary>
        /// Diversen.
        /// </summary>
        Diversen = 0,
        /// <summary>
        /// Dagboek Kas.
        /// </summary>
        DagboekKas = 1,
        /// <summary>
        /// Dagboek Bank.
        /// </summary>
        DagboekBank = 2,
        /// <summary>
        /// Dagboek Giro.
        /// </summary>
        DagboekGiro = 3,
        /// <summary>
        /// Dagboek Verkoop.
        /// </summary>
        DagboekVerkoop = 4,
        /// <summary>
        /// Dagboek Inkoop.
        /// </summary>
        DagboekInkoop = 5,
        /// <summary>
        /// Dagboek Memoriaal.
        /// </summary>
        DagboekMemoriaal = 7,
        /// <summary>
        /// Dagboek Balans.
        /// </summary>
        DagboekBalans = 8,
        /// <summary>
        /// Verkopen/omzet onbelast (rubriek 1e).
        /// </summary>
        VerkopenOmzetOnbelastVerlegd = 10,
        /// <summary>
        /// Verkopen/omzet laag (exclusief btw; rubriek 1b).
        /// </summary>
        VerkopenOmzetLaag = 11,
        /// <summary>
        /// Verkopen/omzet hoog (exclusief btw; rubriek 1a).
        /// </summary>
        VerkopenOmzetHoog = 12,
        /// <summary>
        /// Verkopen/omzet overig (exclusief btw; rubriek 1c).
        /// </summary>
        VerkopenOmzetOverig = 13,
        /// <summary>
        /// Verkopen/omzet vrij.
        /// </summary>
        VerkopenBtwVrij = 15,
        /// <summary>
        /// Btw af te dragen laag (verkopen).
        /// </summary>
        BtwAfteDragenLaag = 21,
        /// <summary>
        /// Btw af te dragen hoog (verkopen).
        /// </summary>
        BtwAfTeDragenHoog = 22,
        /// <summary>
        /// Btw af te dragen overig (verkopen).
        /// </summary>
        BtwAfTeDragenOverig = 23,
        /// <summary>
        /// Btw af te dragen verlegd (verkopen).
        /// </summary>
        BtwAfTeDragenVerlegdVerkopen = 24,
        /// <summary>
        /// Btw te vorderen verlegd (verkopen).
        /// </summary>
        BtwTeVorderenVerlegd = 25,
        /// <summary>
        /// Btw af te dragen globalisatie laag.
        /// </summary>
        BtwAfteDragenLaagGlobalisatie = 26,
        /// <summary>
        /// Btw af te dragen globalisatie hoog.
        /// </summary>
        BtwAfTeDragenHoogGlobalisatie = 27,
        /// <summary>
        /// Btw af te dragen globalisatie overig.
        /// </summary>
        BtwAfTeDragenOverigGlobalisatie = 28,
        /// <summary>
        /// Inkopen/kosten alle btw tarieven (rubriek 5b).
        /// </summary>
        InkopenKostenAlleBtwTarieven = 30,
        /// <summary>
        /// Inkopen/kosten laag (exclusief btw; rubriek 5b).
        /// </summary>
        InkopenKostenLaag = 31,
        /// <summary>
        /// Inkopen/kosten hoog (exclusief btw; rubriek 5b).
        /// </summary>
        InkopenKostenHoog = 32,
        /// <summary>
        /// Inkopen/kosten overig (exclusief btw; rubriek 5b).
        /// </summary>
        InkopenKostenOverig = 33,
        /// <summary>
        /// Vraagposten inkopen (exclusief btw; rubriek 5b).
        /// </summary>
        InkopenVraagPosten = 34,
        /// <summary>
        /// Btw te vorderen laag (inkopen).
        /// </summary>
        BtwTeVorderenLaag = 41,
        /// <summary>
        /// Btw te vorderen hoog (inkopen).
        /// </summary>
        BtwTeVorderenHoog = 42,
        /// <summary>
        /// Btw te vorderen overig (inkopen).
        /// </summary>
        BtwTeVorderenOverig = 43,
        /// <summary>
        /// Btw af te dragen verlegd (inkopen).
        /// </summary>
        BtwAfTeDragenVerlegdInkopen = 44,
        /// <summary>
        /// Btw te vorderen verlegd (inkopen).
        /// </summary>
        BtwTeVorderenVerlegdInkopen = 45,
        /// <summary>
        /// Inkopen import binnen EU laag (rubriek 4b).
        /// </summary>
        InkopenImportBinnenEUlaag = 61,
        /// <summary>
        /// Inkopen import binnen EU hoog (rubriek 4b).
        /// </summary>
        InkopenImportBinnenEUhoog = 62,
        /// <summary>
        /// Inkopen import binnen EU overig (rubriek 4b).
        /// </summary>
        InkopenImportBinnenEUoverig = 63,
        /// <summary>
        /// Inkopen import buiten EU laag (rubriek 4a).
        /// </summary>
        InkopenImportBuitenEUlaag = 71,
        /// <summary>
        /// Inkopen import buiten EU hoog (rubriek 4a).
        /// </summary>
        InkopenImportBuitenEUhoog = 72,
        /// <summary>
        /// Inkopen import buiten EU overig (rubriek 4a).
        /// </summary>
        InkopenImportBuitenEUoverig = 73,
        /// <summary>
        /// Verkopen export binnen EU (rubriek 3b).
        /// </summary>
        VerkopenExportBinnenEU = 80,
        /// <summary>
        /// Verkopen export buiten EU (rubriek 3a).
        /// </summary>
        VerkopenExportBuitenEU = 81,
        /// <summary>
        /// Oninbare vorderingen.
        /// </summary>
        OninbareVorderingen = 82,
        /// <summary>
        /// Herrekening/correcties.
        /// </summary>
        HerrekeningCorrecties = 83,
        /// <summary>
        /// Installatie/televerkoop binnen EU.
        /// </summary>
        InstallatieTeleverkoopBinnenEUgeen = 84,
        /// <summary>
        /// BPM verkoop.
        /// </summary>
        BpmVerkopen = 85,
        /// <summary>
        /// BPM inkoop.
        /// </summary>
        BpmInkopen = 86,
        /// <summary>
        /// BPM voorraad.
        /// </summary>
        BpmVoorraad = 87,
        /// <summary>
        /// Dienstverlening binnen EU (rubriek 3b).
        /// </summary>
        DienstverleningBinnenEU = 88,
        /// <summary>
        /// Verkoop globalisatie laag (rubriek 1b).
        /// </summary>
        VerkoopGlobalisatieLaag = 91,
        /// <summary>
        /// Verkoop globalisatie hoog (rubriek 1a).
        /// </summary>
        VerkoopGlobalisatieHoog = 92,
        /// <summary>
        /// Verkoop globalisatie overig (rubriek 1c).
        /// </summary>
        VerkoopGlobalisatieOverig = 93,
        /// <summary>
        /// Inkoop globalisatie laag (rubriek 1b).
        /// </summary>
        InkoopGlobalisatieLaag = 94,
        /// <summary>
        /// Inkoop globalisatie hoog (rubriek 1a).
        /// </summary>
        InkoopGlobalisatieHoog = 95,
        /// <summary>
        /// Inkoop globalisatie overig (rubriek 1c).
        /// </summary>
        InkoopGlobalisatieOverig = 96,
        /// <summary>
        /// Btw globalisatie.
        /// </summary>
        BtwGlobalisatie = 97,
        /// <summary>
        /// Kredietbeperking (verkopen).
        /// </summary>
        KredietbeperkingVerkopen = 100,
        /// <summary>
        /// Kredietbeperking (inkopen).
        /// </summary>
        KredietbeperkingInkopen = 101,
        /// <summary>
        /// Betalingskorting.
        /// </summary>
        Betalingskorting = 102,
        /// <summary>
        /// Tussenrekening betalingen.
        /// </summary>
        TussenrekeningBetalingen = 110,
        /// <summary>
        /// Onbekende betalingen.
        /// </summary>
        OnbekendeBetalingen = 111,
        /// <summary>
        /// Kruisposten.
        /// </summary>
        Kruisposten = 112,
        /// <summary>
        /// Betaalwijze (contant).
        /// </summary>
        ContanteBetaling = 120,
        /// <summary>
        /// Betaalwijze (elektronisch).
        /// </summary>
        ElectronischeBetaling = 121,
        /// <summary>
        /// Winstboeking.
        /// </summary>
        Winstboeking = 130
    }
}
