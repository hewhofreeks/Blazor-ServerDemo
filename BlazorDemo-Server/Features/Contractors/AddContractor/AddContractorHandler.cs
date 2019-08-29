using BlazorDemo_Server.Data;
using BlazorDemo_Server.Features.Contractors.AddContractor;
using BlazorState;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Features.Contractors
{
    public partial class ContractorsState
    {
        public class AddContractorHandler : RequestHandler<AddContractorAction, ContractorsState>
        {
            private readonly HttpClient _client;

            public AddContractorHandler(IStore aStore, HttpClient client) : base(aStore)
            {
                _client = client;
            }

            public override async Task<ContractorsState> Handle(AddContractorAction aRequest, CancellationToken aCancellationToken)
            {
                var contractor = new Contractor { Name = aRequest.ContractorName };
                var json = JsonConvert.SerializeObject(contractor);

                var response = await _client.PostAsync("api/Contractor/Add", new StringContent(json, Encoding.UTF8, "application/json"));
                var contractorResponse = JsonConvert.DeserializeObject<Contractor>(await response.Content.ReadAsStringAsync());

                var state = this.Store.GetState<ContractorsState>();
                state.ContractorList.Add(contractorResponse);

                return state;
            }
        }
    }
}
