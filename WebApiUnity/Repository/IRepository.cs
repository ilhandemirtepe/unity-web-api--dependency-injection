﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiUnity.Repository
{
    public interface IRepository
    {
        IEnumerable<string> MyValues { get; set; }
    }
}
