using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{

    public void PindahKeGameplay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void PindahKeMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
