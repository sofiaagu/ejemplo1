using UnityEngine;
using System;
using System.Collections.Generic;
using PackagePersona;
using System.IO;

public class Utilidades 
{
    public static bool SaveDataStudent(List<Estudiante> listaE)
    {
        try
        {
            string jsonString = JsonUtility.ToJson(new EstudianteListWrapper { estudiantes = listaE }, true);
            string folderPath = Application.streamingAssetsPath;

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "datosEstudiante.json");
            File.WriteAllText(filePath, jsonString);

            Debug.Log(" Archivo JSON guardado correctamente en: " + filePath);
            return true;
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Error al guardar archivo JSON: " + ex.Message);
            return false;
        }
    }

    public static bool SaveDataPuntos(List<Punto2D> listaP)
    {
        try
        {
            string jsonString = JsonUtility.ToJson(new PuntosListWrapper { puntos = listaP }, true);
            string folderPath = Application.streamingAssetsPath;

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine(folderPath, "datosPuntos.json");
            File.WriteAllText(filePath, jsonString);

            Debug.Log(" Archivo JSON guardado correctamente en: " + filePath);
            return true;
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Error al guardar archivo JSON: " + ex.Message);
            return false;
        }
    }

    public static bool SaveIngenieria(List<Estudiante> listaE)
{
    try
    {
        List<Estudiante> sublista = listaE.FindAll(
            e => !string.IsNullOrEmpty(e.NameCarrera) && 
                 e.NameCarrera.ToLower().Contains("ingenieria")
        );

        string jsonString = JsonUtility.ToJson(new EstudianteListWrapper { estudiantes = sublista }, true);
        string folderPath = Application.streamingAssetsPath;

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        string filePath = Path.Combine(folderPath, "Estudiantes_Ingenieria.json");
        File.WriteAllText(filePath, jsonString);

        Debug.Log(" Sublista de Ingeniería guardada correctamente en: " + filePath +
                  " con " + sublista.Count + " estudiantes.");
        return true;
    }
    catch (System.Exception ex)
    {
        Debug.LogError("Error al guardar sublista de Ingeniería: " + ex.Message);
        return false;
    }
}
public static bool SaveCarreras(List<Estudiante> listaE)
{
    try
    {
      
        List<Estudiante> otros = listaE.FindAll( e => !string.IsNullOrEmpty(e.NameCarrera) && 
         !e.NameCarrera.ToLower().Contains("ingenieria"));

        string jsonString = JsonUtility.ToJson(new EstudianteListWrapper { estudiantes = otros }, true);
        string folderPath = Application.streamingAssetsPath;

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }

        string filePath = Path.Combine(folderPath, "OtrasCarreras.json");
        File.WriteAllText(filePath, jsonString);

        Debug.Log(" Sublista de otras carreras guardada correctamente en: " + filePath );
        return true;
    }
    catch (System.Exception ex)
    {
        Debug.LogError("Error al guardar sublista de Ingeniería: " + ex.Message);
        return false;
    }
}
}

[Serializable]
public class EstudianteListWrapper
{
    public List<Estudiante> estudiantes;
}

[Serializable]
public class PuntosListWrapper
{
    public List<Punto2D> puntos;
}
