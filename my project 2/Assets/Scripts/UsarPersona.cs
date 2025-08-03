
using UnityEngine;
using System;
using System.Collections.Generic;
using PackagePersona;

public class usaPersona : MonoBehaviour
{

    List<Estudiante> listaE = new List<Estudiante>();
    // Start is called before the first frame update
    public void Start()
    {
        Estudiante e1 = new Estudiante("2025", "ing multimedia", "sofia aguiar", "sofia@uao", "cra45");
        listaE.Add(e1);
        Estudiante e2 = new Estudiante("234", "ing datos", "aleja", "aleja@uao", "cra5");
        listaE.Add(e2);


        for (int i=0; i<listaE.Count; i++)
        {
            Debug.Log(listaE[i].NameP + "" + listaE[i].Carrera);
        }
    }

    // Update is called once per frame
    public void Update()
    {

    }
}

