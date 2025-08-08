using UnityEngine;

public class MouseTrackerUI : MonoBehaviour
{
    public RectTransform panelRectTransform; 

    void Update()
    {
        Vector2 localMousePosition;
        if (panelRectTransform != null &&
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                panelRectTransform,
                Input.mousePosition,
                null,
                out localMousePosition))
        {
            if (panelRectTransform.rect.Contains(localMousePosition))
            {
              
                Debug.Log("Mouse sobre panel: " + localMousePosition);

               
                Utilidades.AgregarCoordenada(localMousePosition);
            }
        }
    }

    public void GuardarCoordenadas()
    {
        Utilidades.GuardarCoordenadasEnJson();
    }
}
