using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Funci�n para cerrar el juego
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego..."); // Mensaje para confirmar en la consola
        Application.Quit(); // Cierra la aplicaci�n
    }
}
