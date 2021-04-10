using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_Script : MonoBehaviour
{
    public void play()
    {
        AsyncOperation operazione = SceneManager.LoadSceneAsync(1);
    }
    public void quit()
    {
        Application.Quit();
    }
}