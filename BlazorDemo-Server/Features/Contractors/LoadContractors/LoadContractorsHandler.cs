using BlazorDemo_Server.Data;
using BlazorDemo_Server.Features.Contractors.LoadContractors;
using BlazorState;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Features.Contractors
{
    public partial class ContractorsState
    {
        public class LoadContractorsHandler : RequestHandler<LoadContractorsAction, ContractorsState>
        {
            private readonly HttpClient _httpClient;

            public LoadContractorsHandler(IStore aStore, HttpClient client) : base(aStore)
            {
                _httpClient = client;
            }


            public override async Task<ContractorsState> Handle(LoadContractorsAction aRequest, CancellationToken aCancellationToken)
            {
                var state = this.Store.GetState<ContractorsState>();

                var response = await _httpClient.GetAsync("api/Contractor/Get");
                var json = await response.Content.ReadAsStringAsync();
                var contractors = JsonConvert.DeserializeObject<List<Contractor>>(json);

                state.ContractorList = contractors;
                state.IsLoading = false;

                Console.WriteLine(JsonConvert.SerializeObject(state));

                return state;
            }
        }
    }
    
}
