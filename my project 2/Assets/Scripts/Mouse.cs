using UnityEngine;
using UnityEngine.UI;

public class MouseTrackerUI : MonoBehaviour
{
    public RectTransform panelRectTransform; // Asigna el panel desde el Inspector
    private Vector2 ultimaCoordenada;

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
                ultimaCoordenada = localMousePosition;
                Debug.Log("Mouse sobre panel: " + ultimaCoordenada);
            }
        }
    }

    // Método que se llama desde el botón
    public void GuardarCoordenada()
    {
        Utilidades.GuardarCoordenadaEnJson(ultimaCoordenada);
    }
}
