﻿using SnelStart.B2B.Client.Operations;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.Client
{
    public class B2BClient : IB2BClient
    {
        private readonly ClientState _clientState;

        public string AccessToken => _clientState.AccessToken;

        public IKostenplaatsenOperations Kostenplaatsen { get; }
        public IGrootboekenOperations Grootboeken { get; }
        public IGrootboekMutatiesOperations GrootboekMutaties { get; }
        public ILandenOperations Landen { get; }
        public ICompanyInformationOperations CompanyInformation { get; }
        public IMemoriaalboekingenOperations Memoriaalboekingen { get; }
        public IDagboekenOperations Dagboeken { get; }
        public IRelatiesOperations Relaties { get; }
        public IVerkoopboekingenOperations Verkoopboekingen { get; }
        public IVerkoopboekingBijlagesOperations VerkoopboekingBijlages { get; }
        public IVerkoopfacturenOperations Verkoopfacturen { get; }
        public IInkoopfacturenOperations Inkoopfacturen { get; }
        public IBankboekingenOperations Bankboekingen { get; }
        public IBankafschriftBestandenOperations BankafschriftBestanden { get; }
        public IInkoopboekingenOperations Inkoopboekingen { get; }
        public IRelatieInkoopboekingenOperations RelatieInkoopboekingen { get; }
        public IInkoopBoekingBijlagesOperations InkoopboekingBijlages { get; }
        public IRelatieBijlagesOperations RelatieBijlages { get; }
        public IArtikelomzetgroepenOperations Artikelomzetgroepen { get; }
        public IArtikelenOperations Artikelen { get; }
        public IVerkoopordersOperations Verkooporders { get; }

        public B2BClient(Config config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            _clientState = new ClientState(config);

            ConfigureServicePointManager(config);

            Kostenplaatsen = new KostenplaatsenOperations(_clientState);
            Grootboeken = new GrootboekenOperations(_clientState);
            GrootboekMutaties = new GrootboekMutatiesOperations(_clientState);
            Landen = new LandenOperations(_clientState);
            Memoriaalboekingen = new MemoriaalboekingenOperations(_clientState);
            CompanyInformation = new CompanyInfoOperations(_clientState);
            Dagboeken = new DagboekenOperations(_clientState);
            Relaties = new RelatiesOperations(_clientState);
            Verkoopboekingen = new VerkoopboekingenOperations(_clientState);
            VerkoopboekingBijlages = new VerkoopboekingBijlagesOperations(_clientState);
            Verkoopfacturen = new VerkoopfacturenOperations(_clientState);
            Inkoopfacturen = new InkoopfacturenOperations(_clientState);
            Bankboekingen = new BankboekingenOperations(_clientState);
            BankafschriftBestanden = new BankafschriftBestandenOperations(_clientState);
            Inkoopboekingen = new InkoopboekingenOperations(_clientState);
            RelatieInkoopboekingen = new RelatieInkoopboekingenOperations(_clientState);
            InkoopboekingBijlages = new InkoopBoekingBijlagesOperations(_clientState);
            RelatieBijlages = new RelatieBijlagesOperations(_clientState);
            Artikelomzetgroepen = new ArtikelomzetgroepenOperations(_clientState);
            Artikelen = new ArtikelenOperations(_clientState);
            Verkooporders = new VerkoopordersOperations(_clientState);
        }

        private static void ConfigureServicePointManager(Config config)
        {
            ServicePointManager.FindServicePoint(config.AuthUri).ConnectionLeaseTimeout = config.ConnectionLeaseTimeoutInMilliseconds;
            ServicePointManager.FindServicePoint(config.ApiBaseUriVersioned).ConnectionLeaseTimeout = config.ConnectionLeaseTimeoutInMilliseconds;

            if (config.ConfigureDnsRefreshTimeoutEnabled)
            {
                ServicePointManager.DnsRefreshTimeout = config.DnsRefreshTimeoutInMilliseconds;
            }
        }

        public void Dispose()
        {

        }

        public async Task AuthorizeAsync()
        {
            await _clientState.AuthorizeAsync(CancellationToken.None).ConfigureAwait(false);
        }

        public async Task AuthorizeAsync(CancellationToken cancellationToken)
        {
            await _clientState.AuthorizeAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}