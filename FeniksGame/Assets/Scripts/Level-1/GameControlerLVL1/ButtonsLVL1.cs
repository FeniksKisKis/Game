using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsLVL1 : MonoBehaviour
{
    private GameObject player;

    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void Aftors()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
}
