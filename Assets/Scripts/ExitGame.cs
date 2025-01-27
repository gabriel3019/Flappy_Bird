using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Función para cerrar el juego
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego..."); // Mensaje para confirmar en la consola
        Application.Quit(); // Cierra la aplicación
    }
}
