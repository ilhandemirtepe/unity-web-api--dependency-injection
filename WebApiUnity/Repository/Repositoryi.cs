using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebApiUnity.Repository
{
    public class Repositoryi : IRepository
    {
        public IEnumerable<string> MyValues { get; set; }

        public Repositoryi()
        {
            MyValues = new List<string> { "Value1", "Value2", "Value3", "Value4" };
        }
    }
}