using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;
using Puntos;

public class MouseTrackerUI : MonoBehaviour
{
    public RectTransform panelRojo; // Asigna el panel desde el Inspector
List<Punto2D> puntos = new List<Punto2D>();
    void Update()
    {
       
        vector2 localMousePos;
        if(RectTransformUtility.RectangleContainsScreenPoint(panelRojo, Input.mousePosition))
        {
RectTransformUtility.ScreenPointToLocalPointInRectangle(panelRojo,Input.mousePosition,null,out localMousePos);
Punto2D punto2D = new Punto2D(localMousePos.x,localMousePos.y);
puntos.Add(punto2D);
        }
    }

    
    public void SaveDataPuntos()
    {
        Utilidades.SaveDataPuntos(puntos);
    }
}
