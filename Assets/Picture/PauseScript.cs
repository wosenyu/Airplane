using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject pauseScript;

    public void Pause()
    {
        pauseScript.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseScript.SetActive(false);
        Time.timeScale=1f;
    }
    public void Home(int sceneID){
        Time.timeScale=1f;
        SceneManager.LoadScene(sceneID);
    }
}
