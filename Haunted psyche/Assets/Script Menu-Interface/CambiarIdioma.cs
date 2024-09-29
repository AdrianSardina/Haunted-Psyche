using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IdiomaManager : MonoBehaviour
{
    public TMP_Text textoIdioma; // Texto que muestra el idioma actual
    public Button botonCambio; // Bot�n para cambiar el idioma
    public RectTransform botonTransform; // Transform del bot�n para manipular su posici�n

    private bool esEspanol = true; // Variable para controlar el idioma actual

    void Start()
    {
        // Inicializa el texto con el idioma actual
        ActualizarTextoIdioma();
        // Asigna la funci�n al evento de clic del bot�n
        botonCambio.onClick.AddListener(CambiarIdioma);
    }

    void CambiarIdioma()
    {
        // Alterna entre espa�ol e ingl�s
        esEspanol = !esEspanol;

        // Actualiza el texto del idioma
        ActualizarTextoIdioma();

        // Cambia la posici�n y rota el bot�n
        if (esEspanol)
        {
            // Regresa a espa�ol
            botonTransform.localPosition = new Vector3(-195, 35, 0); // Ajusta la posici�n como desees
            botonTransform.localRotation = Quaternion.Euler(0, 0, 0); // Rotaci�n original
        }
        else
        {
            // Cambia a ingl�s
            botonTransform.localPosition = new Vector3(-615, 35, 0); // Ajusta la posici�n como desees
            botonTransform.localRotation = Quaternion.Euler(0, 0, 180); // Rota 90 grados
        }
    }

    void ActualizarTextoIdioma()
    {
        // Actualiza el texto seg�n el idioma
        if (esEspanol)
        {
            textoIdioma.text = "Espa�ol";
        }
        else
        {
            textoIdioma.text = "English";
        }
    }
}