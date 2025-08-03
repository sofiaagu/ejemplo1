
using UnityEngine;
using System;
using System.Xml.Linq;

namespace PackagePersona
{
    public class Estudiante : Persona
    {
        private string codeE;
        private string carrera;

        public Estudiante()
        {
        }

        public Estudiante(string codigo, string carrera, string nameP, string mailP, string dirP) :
        base(nameP, mailP, dirP)
        {

            this.codeE = codeE;
            this.carrera = carrera;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string Carrera { get => carrera; set => carrera = value; }
    }
}