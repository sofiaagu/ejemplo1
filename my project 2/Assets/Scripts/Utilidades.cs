using System.Collections.Generic;
using System.IO;
using UnityEngine;
using PackagePersona;
//using Puntos;
//using System;

//public class Utilidades
//{
//    [Serializable]
//    private class ContenedorEstudiantes
//    {
//        public List<Estudiante> estudiantes;
//    }

//    [Serializable]
//    private class ContenedorPuntos
//    {
//        public List<Punto2D> puntos;
//    }

//    public static void GuardarListaEstudiantes(List<Estudiante> lista, string nombreArchivo = "estudiantes.json")
//    {
//        ContenedorEstudiantes contenedor = new ContenedorEstudiantes { estudiantes = lista };
//        string json = JsonUtility.ToJson(contenedor, true);
//        string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
//        File.WriteAllText(ruta, json);
//        Debug.Log("Estudiantes guardados en: " + ruta);
//    }

//    public static void GuardarListaPuntos(List<Punto2D> lista, string nombreArchivo = "puntos2D.json")
//    {
//        ContenedorPuntos contenedor = new ContenedorPuntos { puntos = lista };
//        string json = JsonUtility.ToJson(contenedor, true);
//        string ruta = Path.Combine(Application.persistentDataPath, nombreArchivo);
//        File.WriteAllText(ruta, json);
//        Debug.Log("Puntos 2D guardados en: " + ruta);
//    }
//}

public class Utilidades
{
    public class EstudianteListWrapper
    {
        public List<Estudiante> listaE;
    }


    public static bool SaveDataStudent(List<Estudiante> listaE)
    {
        EstudianteListWrapper wrapper = new EstudianteListWrapper();
        wrapper.listaE = listaE;
        bool resultado = false;
        string jsonString = JsonUtility.ToJson(wrapper, true);
        Debug.Log("lista" + jsonString);
        
        string path = Path.Combine(Application.streamingAssetsPath, "estudiantes.json");
         File.WriteAllText(path, jsonString);
        return resultado;
    }

[System.Serializable]
    public class Punto2D
    {
        public float x;
        public float y;

        public Punto2D(Vector2 pos)
        {
            x = pos.x;
            y = pos.y;
        }
    }

    [System.Serializable]
    private class ListaPuntos
    {
        public List<Punto2D> puntos = new List<Punto2D>();
    }

    private static ListaPuntos listaCoordenadas = new ListaPuntos();

    public static void AgregarCoordenada(Vector2 coordenada)
    {
        listaCoordenadas.puntos.Add(new Punto2D(coordenada));
    }

    public static void GuardarCoordenadasEnJson()
    {
        string json = JsonUtility.ToJson(listaCoordenadas, true);
        string ruta = Path.Combine(Application.streamingAssetsPath, "coordenadas.json");
        File.WriteAllText(ruta, json);

        Debug.Log("Coordenadas guardadas en: " + json);
    }
}