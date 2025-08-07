using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MousePositionUI : MonoBehaviour
{
    public RectTransform panelRectTransform; // Asigna el panel en el inspector
    public Canvas canvas;                    // Asigna el Canvas si no es Overlay

    void Update()
    {
        Vector2 localMousePosition;

        // Convierte la posici�n del mouse de pantalla a posici�n local dentro del panel
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
                panelRectTransform,
                Input.mousePosition,
                canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : canvas.worldCamera,
                out localMousePosition))
        {
            Debug.Log("Mouse en el panel (local): " + localMousePosition);
        }
    }
}
