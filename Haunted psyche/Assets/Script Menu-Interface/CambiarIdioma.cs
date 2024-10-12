using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IdiomaManager : MonoBehaviour
{
    public TMP_Text textoIdioma; // Texto que muestra el idioma actual
    public Button botonCambio; // Botón para cambiar el idioma
    public RectTransform botonTransform; // Transform del botón para manipular su posición

    private bool esEspanol = true; // Variable para controlar el idioma actual

    void Start()
    {
        // Inicializa el texto con el idioma actual
        ActualizarTextoIdioma();
        // Asigna la función al evento de clic del botón
        botonCambio.onClick.AddListener(CambiarIdioma);
    }

    void CambiarIdioma()
    {
        // Alterna entre español e inglés
        esEspanol = !esEspanol;

        // Actualiza el texto del idioma
        ActualizarTextoIdioma();

        // Cambia la posición y rota el botón
        if (esEspanol)
        {
            // Regresa a español
            botonTransform.localPosition = new Vector3(-195, 35, 0); // Ajusta la posición como desees
            botonTransform.localRotation = Quaternion.Euler(0, 0, 0); // Rotación original
        }
        else
        {
            // Cambia a inglés
            botonTransform.localPosition = new Vector3(-615, 35, 0); // Ajusta la posición como desees
            botonTransform.localRotation = Quaternion.Euler(0, 0, 180); // Rota 90 grados
        }
    }

    void ActualizarTextoIdioma()
    {
        // Actualiza el texto según el idioma
        if (esEspanol)
        {
            textoIdioma.text = "Español";
        }
        else
        {
            textoIdioma.text = "English";
        }
    }
}