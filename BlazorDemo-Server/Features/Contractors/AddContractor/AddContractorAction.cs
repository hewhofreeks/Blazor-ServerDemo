using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Features.Contractors.AddContractor
{
    public class AddContractorAction : IRequest<ContractorsState>
    {
        public string ContractorName { get; set; }
    }
}
