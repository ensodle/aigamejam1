using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu: MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void HikayeButton()
    {
        SceneManager.LoadScene(2);
    }
    public void QuitButton()
    {
        SceneManager.LoadScene(0);
    }
}
