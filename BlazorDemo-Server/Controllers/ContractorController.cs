using BlazorDemo_Server.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Controllers
{
    public class ContractorController : Controller
    {
        private readonly CraftJackContext _context;

        public ContractorController(CraftJackContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("api/Contractor/Get")]
        public IEnumerable<Contractor> Get()
        {
            return _context.Contractors.ToList();
        }

        [HttpPost]
        [Route("api/Contractor/Add")]
        public Contractor Add([FromBody]Contractor contractor)
        {
            _context.Contractors.Add(contractor);
            _context.SaveChanges();

            return contractor;
        }
    }
}
