﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlumnos
{
    class Alumno
    {
        public string nombre;
        public string apellidos;
        public DateTime fechaNacimiento;
        public string grupo;


        public Alumno(string pNombre, string pApellidos, DateTime pFechaNacimiento, string pGrupo)
        {
            nombre = pNombre;
            apellidos = pApellidos;
            fechaNacimiento = pFechaNacimiento;
            grupo = pGrupo;

        }
    }
}
