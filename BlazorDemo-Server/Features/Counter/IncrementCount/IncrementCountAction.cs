using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Features.Counter.IncrementCount
{
    public class IncrementCountAction : IRequest<CounterState>
    {
    }
}
