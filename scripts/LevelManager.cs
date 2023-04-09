using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public bool pause;
    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    private void Start()
    {
        pause = false;
    }
    public void OnPause()
    {
        pause = !pause;
        if(!pause)
        {
            Time.timeScale = 1;
        }
        else if(pause)
        {
            Time.timeScale = 0;
        }
    }
}
