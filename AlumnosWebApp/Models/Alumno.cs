﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlumnosWebApp.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string FotoURL { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}