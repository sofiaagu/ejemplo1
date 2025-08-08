using UnityEngine;
using System;
using System.Collections.Generic;
using Puntos;

public class usaPunto2D : MonoBehaviour
{
    List<Punto2D> listaP = new List<Punto2D>();

    public void Start()
    {
        Punto2D p1 = new Punto2D(10.5, 20.3);
        listaP.Add(p1);
        Punto2D p2 = new Punto2D(15.7, -8.2);
        listaP.Add(p2);
        Punto2D p3 = new Punto2D(0.0, 0.0);
        listaP.Add(p3);
        Punto2D p4 = new Punto2D(-12.4, 25.8);
        listaP.Add(p4);

        for (int i = 0; i < listaP.Count; i++)
        {
            Debug.Log("X: " + listaP[i].X + " Y: " + listaP[i].Y);
        }

        
    }

    public void Update()
    {
    }
}