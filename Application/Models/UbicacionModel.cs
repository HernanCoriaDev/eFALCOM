﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UbicacionModel
    {
        public int UbicacionId { get; set; }
        public string Nombre { get; set; }
        public string CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
    }


}
