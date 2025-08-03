using System.Collections.Generic;
using System.IO;
using UnityEngine;
using PackagePersona;
using Puntos;
using System;

public class Utilidades
{
    [Serializable]
    private class ContenedorEstudiantes
    {
        public List<Estudiante> estudiantes;
    }

    [Serializable]
    private class ContenedorPuntos
    {
        public List<Punto2D> puntos;
    }

    public static void GuardarListaEstudiantes(List<Estudiante> lista, string nombreArchivo = "estudiantes.json")
    {
        ContenedorEstudiantes contenedor = new ContenedorEstudiantes { estudiantes = lista };
        string json = JsonUtility.ToJson(contenedor, true);
        string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
        File.WriteAllText(ruta, json);
        Debug.Log("Estudiantes guardados en: " + ruta);
    }

    public static void GuardarListaPuntos(List<Punto2D> lista, string nombreArchivo = "puntos2D.json")
    {
        ContenedorPuntos contenedor = new ContenedorPuntos { puntos = lista };
        string json = JsonUtility.ToJson(contenedor, true);
        string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
        File.WriteAllText(ruta, json);
        Debug.Log("Puntos 2D guardados en: " + ruta);
    }
}
