using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void NewGame()
    {
        //SceneManager.LoadScene(1);
        Debug.Log("Рано тебе еще сюда");
    }

    public void SelectLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(3);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
