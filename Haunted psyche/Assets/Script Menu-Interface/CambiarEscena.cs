using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    // Llamamos a esta funci�n para cambiar de escena
    public void CambiarEscenas(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}