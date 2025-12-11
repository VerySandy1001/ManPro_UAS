using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public string MainMenu, GameOver,MainGameplay;

    public void PindahKeGameplay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
