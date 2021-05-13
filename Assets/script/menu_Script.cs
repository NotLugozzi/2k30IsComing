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
    public void settings()
    {
       AsyncOperation settings = SceneManager.LoadSceneAsync(2);
    }
    public void AndTitle()
    {
        AsyncOperation TitoliDiCoda = SceneManager.LoadSceneAsync(4);
    }
    public void menu()
    {
        AsyncOperation TitoliDiCoda = SceneManager.LoadSceneAsync(0);
    }
}