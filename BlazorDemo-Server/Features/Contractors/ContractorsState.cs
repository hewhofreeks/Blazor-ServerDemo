using BlazorDemo_Server.Data;
using BlazorState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Features.Contractors
{
    public partial class ContractorsState : State<ContractorsState>
    {
        public List<Contractor> ContractorList { get; set; }
        public bool IsLoading { get; set; }
        protected override void Initialize()
        {
            IsLoading = true;
            ContractorList = new List<Contractor>();
        }
    }
}
