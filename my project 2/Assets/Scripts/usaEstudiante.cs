using UnityEngine;
using System.Collections.Generic;
using PackagePersona;
using TMPro;

public class usaEstudiante : MonoBehaviour
{
    List<Estudiante> listaE = new List<Estudiante>();
    public TMP_InputField nameStudent;
    public TMP_InputField mailStudent;
    public TMP_InputField dirStudent;
    public TMP_InputField codeStudent;
    public TMP_InputField carreraStudent;
     public void Start()
    {
    //      Estudiante e1 = new Estudiante("2025", "ing multimedia", "sofia aguiar", "sofia@uao", "cra45");
    //        Estudiante e2 = new Estudiante("234", "ing datos", "aleja", "aleja@uao", "cra5");
    //        listaE.Add(e1);
    //        listaE.Add(e2);

    //      for (int i = 0; i < listaE.Count; i++)
    //{
    //    Estudiante e = listaE[i];
    //    Debug.Log(e.NameP + " " + e.Carrera);
    //}


    //        Utilidades.GuardarListaEstudiantes(listaE);
     }


    public void addStudentList()
    {
        string nameStudent1 = nameStudent.text;
        string mailStudent1 = mailStudent.text;
        string dirStudent1 = dirStudent.text;
        string codeStudent1 = codeStudent.text;
        string carreraStudent1 = carreraStudent.text;

        Estudiante e1 = new Estudiante(nameStudent1, mailStudent1, dirStudent1, codeStudent1, carreraStudent1);
        listaE.Add(e1);
    }

    public void ShowStudentList()
    {
        for (int i = 0; i < listaE.Count; i++)
    {
        Estudiante e = listaE[i];
        Debug.Log(e.NameP + " " + e.Carrera);
    }

        Utilidades.SaveDataEstudent(listaE);
    }
}


