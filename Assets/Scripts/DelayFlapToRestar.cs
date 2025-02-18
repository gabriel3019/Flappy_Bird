using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayFlapToRestar : MonoBehaviour
{

    public GameObject flapToRestart;
    public int delay = 1;

    private void OnEnable()
    {
        Invoke("EnableFlapToRestart", delay);
    }

    void EnableFlapToRestart()
    {
        flapToRestart.SetActive(true);
    }
}
