using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    public GameObject Win;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Time.timeScale = 0;
            Win.SetActive(true);
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene(13);
        Win.SetActive(false);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Win.SetActive(false);
        Time.timeScale = 1;
    }
}
