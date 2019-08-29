using BlazorState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Features.Counter
{
    public partial class CounterState : State<CounterState>
    {
        public int CurrentCount { get; set; }

        protected override void Initialize()
        {
            CurrentCount = 0;
        }
    }
}
