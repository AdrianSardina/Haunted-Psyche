using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PantallaDeCarga : MonoBehaviour
{
    public Slider barraProgreso;        // Asigna el Slider de progreso desde el Inspector
    public TMP_Text textoCargando;      // Asigna el texto que dice "Cargando..."
    public TMP_Text textoConsejos;      // Asigna el texto donde mostrar�s consejos

    private string escenaDestino;

    // Lista de consejos
    private string[] consejos = new string[]
    {
        "Consejo: Recuerda explorar cada rinc�n, pueden haber objetos escondidos",
        "Consejo: Usa tu linterna sabiamente",
        "Consejo: Mant�n la calma, algunas situaciones son dif�ciles de manejar",
        "Consejo: No olvides revisar tu cordura",
        "Consejo: La paciencia es clave para resolver acertijos"
    };

    void Start()
    {
        // Obtenemos el nombre de la escena que queremos cargar desde PlayerPrefs
        escenaDestino = PlayerPrefs.GetString("EscenaDestino", "MainMenu");

        // Muestra un consejo aleatorio
        MostrarConsejoAleatorio();

        // Iniciamos la corutina para cambiar consejos
        StartCoroutine(CambiarConsejoCada5Segundos());

        // Iniciamos la corutina para cargar la escena as�ncronamente
        StartCoroutine(CargarEscenaAsync());
    }

    void MostrarConsejoAleatorio()
    {
        // Selecciona un �ndice aleatorio de la lista de consejos
        int indiceAleatorio = Random.Range(0, consejos.Length);
        textoConsejos.text = consejos[indiceAleatorio];
    }

    IEnumerator CambiarConsejoCada5Segundos()
    {
        while (true) // Ciclo infinito para cambiar el consejo cada 5 segundos
        {
            yield return new WaitForSeconds(10f); // Esperar 5 segundos
            MostrarConsejoAleatorio(); // Mostrar un nuevo consejo
        }
    }

    IEnumerator CargarEscenaAsync()
    {
        // Empieza a cargar la escena de manera as�ncrona
        AsyncOperation operacion = SceneManager.LoadSceneAsync(escenaDestino);

        // Evitamos que la escena se active autom�ticamente hasta que est� completamente cargada
        operacion.allowSceneActivation = false;

        // Variables de progreso
        float progresoVisual = 0f; // Progreso visual en porcentaje

        // Actualizamos la barra de progreso y el texto mientras se carga la escena
        while (!operacion.isDone)
        {
            // Incrementar el progreso visual de forma fluida
            if (progresoVisual < 1f) // Asegurarse de que no exceda el 100%
            {
                progresoVisual += Time.deltaTime / 20f; // Ajusta la velocidad de incremento aqu�
            }

            // Actualizar la barra de progreso
            barraProgreso.value = progresoVisual;

            // Actualizar el texto de carga con el porcentaje
            textoCargando.text = "Cargando " + (int)(progresoVisual * 100) + "%";

            // Cuando el progreso visual es 100%, activamos la nueva escena
            if (progresoVisual >= 1f)
            {
                // Esperamos un breve periodo antes de activar la escena (opcional)
                yield return new WaitForSeconds(0.5f);
                operacion.allowSceneActivation = true;
            }

            yield return null; // Espera hasta el siguiente frame
        }
    }
}