using System.Collections.Generic;
using System.IO;
using UnityEngine;
using PackagePersona;
using Puntos;


public class Utilidades
{
    public class EstudianteListWrapper
    {
        public List<Estudiante> listaE;
    }

 public class puntos2d
    {
        public List<Puntos> list;
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

   public static void SaveDataPuntos(List<Punto2D> puntos)
    {
  
        ListaPuntos lista = new ListaPuntos(puntos);

        string json = JsonUtility.ToJson(lista, true);

        string ruta = Path.Combine(Application.persistentDataPath, "coordenadas.json");

     
        File.WriteAllText(ruta, json);

        Debug.Log("Archivo JSON guardado en: " + ruta);
        Debug.Log("Contenido:\n" + json);
    }
}