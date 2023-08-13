using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    private int health;
    [SerializeField] private Text healthText;
    [SerializeField] private GameObject narration;

    void Start()
    {
        ChangeHealth(200);
    }
    public void ChangeHealth(int value)
    {
        health += value;
        healthText.text = "Health: " + health.ToString();
    }
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.B))
        {
            narration.SetActive(!narration.activeInHierarchy);
            if (narration.activeInHierarchy)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
}