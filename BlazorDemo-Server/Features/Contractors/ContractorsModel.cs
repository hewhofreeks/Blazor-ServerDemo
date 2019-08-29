using BlazorDemo_Server.Features.Contractors.AddContractor;
using BlazorDemo_Server.Features.Contractors.LoadContractors;
using BlazorState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Features.Contractors
{
    public class ContractorsModel: BlazorStateComponent
    {
        public ContractorsState State => this.Store.GetState<ContractorsState>();

        public string NewContractorName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await this.Mediator.Send(new LoadContractorsAction());
        }

        public async Task AddContractor()
        {
            await Mediator.Send(new AddContractorAction { ContractorName = NewContractorName });

            NewContractorName = string.Empty;
        }
    }
}
