using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoBrillo : MonoBehaviour
{
    public Slider slider; // Slider para ajustar el brillo
    public Image imagenBrillo; // Imagen sobre la que se aplicará el brillo

    void Start()
    {
        // Establecer el valor inicial del slider
        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f);
        CambiarBrillo(); // Aplica el brillo inicial
    }

    void Update()
    {
        // Actualiza el brillo cada frame según el valor del slider
        CambiarBrillo();
    }

    public void ChangeSlider()
    {
        PlayerPrefs.SetFloat("brillo", slider.value);
        // No es necesario llamar a CambiarBrillo() aquí, ya que se hace en Update()
    }

    public void CambiarBrillo()
    {
        // Ajustar el brillo de la imagen
        float brillo = slider.value; // Valor del slider (0 a 1)

        // Cambia el color de la imagen. Usa el color blanco multiplicado por el brillo
        imagenBrillo.color = new Color(brillo, brillo, brillo, 1f); // R, G, B, A
    }
}