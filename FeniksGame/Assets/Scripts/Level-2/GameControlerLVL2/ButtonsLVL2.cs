using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsLVL2 : MonoBehaviour
{
    private GameObject player;

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(1);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
}
