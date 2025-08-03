using UnityEngine;
using System.Collections.Generic;
using PackagePersona;

public class usaEstudiante : MonoBehaviour
{
    List<Estudiante> listaE = new List<Estudiante>();

    public void Start()
    {
        Estudiante e1 = new Estudiante("2025", "ing multimedia", "sofia aguiar", "sofia@uao", "cra45");
        Estudiante e2 = new Estudiante("234", "ing datos", "aleja", "aleja@uao", "cra5");
        listaE.Add(e1);
        listaE.Add(e2);

        foreach (Estudiante e in listaE)
        {
            Debug.Log(e.NameP + " " + e.Carrera);
        }

        Utilidades.GuardarListaEstudiantes(listaE);
    }
}


