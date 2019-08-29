using BlazorDemo_Server.Features.Counter.IncrementCount;
using BlazorState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Features.Counter
{
    public partial class CounterState
    {
        public class IncrementCountHandler : RequestHandler<IncrementCountAction, CounterState>
        {
            public IncrementCountHandler(IStore aStore) : base(aStore)
            {
            }

            public override Task<CounterState> Handle(IncrementCountAction aRequest, CancellationToken aCancellationToken)
            {
                var state = this.Store.GetState<CounterState>();

                state.CurrentCount++;
                
                return Task.FromResult(state);
            }
        }
    }
    
}
