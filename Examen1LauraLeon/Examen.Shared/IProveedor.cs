﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Shared
{
    public interface IProveedor
    {
        public string Nombre { get; set; }

        public string Direccion { get; set; }
    }
}
