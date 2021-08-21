using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using CModelos;
using CNegocio;

namespace WSTestThalesYonyV.Controllers
{
    [RoutePrefix("Api/Employ")]
    public class EmployController : ApiController
    {
        INEmploy nEmploy = new NEmploy();

        [HttpGet]
        [Route("LstEmploy")]
        public List<EmployModel> ListEmploy()
        {
            return nEmploy.ListEmploy();
        }

        [HttpPost]
        [Route("EmployById")]
        public EmployModel EmployById([FromUri] int Id)
        {
            return nEmploy.EmployById(Id);
        }
    }
}