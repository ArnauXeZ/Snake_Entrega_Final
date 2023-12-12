using UnityEngine;
using UnityEngine.UI;

public class MapSizeController : MonoBehaviour
{
    public Slider mapSizeSlider;

    private GameManager gameManager;

    private void Start()
    {

        mapSizeSlider.onValueChanged.AddListener(UpdateMapAndBackgroundSize);
    }

    private void UpdateMapAndBackgroundSize(float newSize)
    {
        // Llamamos al método en el GameManager para cambiar el tamaño del mapa
        GameManager.Instance.ChangeMapSize((int)newSize, (int)newSize);

        // Llamamos al método en el GameManager para cambiar el tamaño del fondo
        GameManager.Instance.ChangeBackgroundSize(newSize);
    }
}




