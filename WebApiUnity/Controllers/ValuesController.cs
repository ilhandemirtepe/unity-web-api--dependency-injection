using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiUnity.Repository;

namespace WebApiUnity.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IRepository _repo;

        public ValuesController(IRepository repo)
        {
            _repo = repo;
        }

        // GET api/values     
        public IEnumerable<string> Get()
        {
            return _repo.MyValues;
        }

        // GET api/values/5     
        public string Get(int id)
        {
            var list = _repo.MyValues.ToList();

            if (id >= 0 && id < list.Count)
            {
                return list[id];
            }

            return "unknown";
        }
    }
}
