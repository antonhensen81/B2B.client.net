﻿using System;
using System.Threading.Tasks;
using SnelStart.B2B.Client.Operations;

namespace SnelStart.B2B.Client
{
    public class B2BClient : IB2BClient
    {
        private readonly ClientState _clientState;

        public string AccessToken => _clientState.AccessToken;

        public IKostenplaatsenOperations Kostenplaatsen { get; }
        public IGrootboekenOperations Grootboeken { get; }
        public ILandenOperations Landen { get; }
        public IMemoriaalboekingenOperations Memoriaalboekingen { get; }
        public IDagboekenOperations Dagboeken { get; }
        public IRelatiesOperations Relaties { get; }
        public IVerkoopboekingenOperations Verkoopboekingen { get; }
        public IVerkoopfacturenOperations Verkoopfacturen { get; }

        public B2BClient(Config config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            _clientState = new ClientState(config);

            Kostenplaatsen = new KostenplaatsenOperations(_clientState);
            Grootboeken = new GrootboekenOperations(_clientState);
            Landen = new LandenOperations(_clientState);
            Memoriaalboekingen = new MemoriaalboekingenOperations(_clientState);
            Dagboeken = new DagboekenOperations(_clientState);
            Relaties = new RelatiesOperations(_clientState);
            Verkoopboekingen = new VerkoopboekingenOperations(_clientState);
            Verkoopfacturen = new VerkoopfacturenOperations(_clientState);
        }

        public void Dispose()
        {
            _clientState.Dispose();
        }

        public async Task AuthorizeAsync()
        {
            await _clientState.AuthorizeAsync().ConfigureAwait(false);
        }
    }
}