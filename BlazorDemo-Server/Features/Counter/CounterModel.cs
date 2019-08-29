using BlazorDemo_Server.Features.Counter.IncrementCount;
using BlazorState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Features.Counter
{
    public class CounterModel : BlazorStateComponent
    {
        public CounterState State => this.Store.GetState<CounterState>();

        public void IncrementCount() => this.Mediator.Send(new IncrementCountAction());
    }
}
