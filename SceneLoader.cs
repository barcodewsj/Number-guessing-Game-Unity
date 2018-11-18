using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This script should almost be universal, right?

public class SceneLoader : MonoBehaviour {

    public void LoadNextScene()
    {
        // Declared and defined an index for the current scene.

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScrene()
    {
        SceneManager.LoadScene(0);  
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
