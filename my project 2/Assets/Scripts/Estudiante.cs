
using UnityEngine;
using System;
using System.Xml.Linq;

namespace PackagePersona
{
    [Serializable]
    public class Estudiante : Persona
    {
        [SerializeField] private string codeE;
        [SerializeField] private string carrera;

        public Estudiante()
        {
        }

        public Estudiante(string codigo, string carrera, string nameP, string mailP, string dirP) :
        base(nameP, mailP, dirP)
        {

            this.codeE = codigo;
            this.carrera = carrera;
        }

        public string CodeE { get => codeE; set => codeE = value; }
        public string Carrera { get => carrera; set => carrera = value; }
    }
}