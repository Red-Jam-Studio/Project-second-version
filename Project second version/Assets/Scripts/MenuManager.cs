using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void SelectLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void Level1()
    {
        SceneManager.LoadScene(3);
    }

    public void Level2()
    {
        SceneManager.LoadScene(4);
    }

    public void Level3()
    {
        SceneManager.LoadScene(5);
    }

    public void Level4()
    {
        SceneManager.LoadScene(6);
    }

    public void Level5()
    {
        SceneManager.LoadScene(7);
    }

    public void Level6()
    {
        SceneManager.LoadScene(8);
    }

    public void Level7()
    {
        SceneManager.LoadScene(9);
    }

    public void Level8()
    {
        SceneManager.LoadScene(10);
    }

    public void Level9()
    {
        SceneManager.LoadScene(11);
    }

    public void Level10()
    {
        SceneManager.LoadScene(12);
    }

    public void Test()
    {
        SceneManager.LoadScene(13);
    }
}
