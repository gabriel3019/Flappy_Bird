using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadGameScene()
    {
        // Aseg�rate de que "GameScene" sea el nombre de tu escena de juego
        SceneManager.LoadScene("Game");
    }

    public void LoadCreditsScene()
    {
        // Aseg�rate de que "GameScene" sea el nombre de tu escena de juego
        SceneManager.LoadScene("Creditos");
    }

    public void LoadMenuScene()
    {
        // Aseg�rate de que "GameScene" sea el nombre de tu escena de juego
        SceneManager.LoadScene("Menu");
    }
}
