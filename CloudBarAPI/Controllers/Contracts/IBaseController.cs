using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudBar.Controllers.Contracts
{
    public interface IBaseController<Dto>
    {
        public IActionResult Get(string sortExpre);
        public IActionResult Get(int id);
        public IActionResult Post(Dto entity);
        public IActionResult Put(Dto entity);
    }
}
