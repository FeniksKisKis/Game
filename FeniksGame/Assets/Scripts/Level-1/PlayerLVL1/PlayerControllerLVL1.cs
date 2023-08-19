using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControllerLVL1 : MonoBehaviour
{
    //Canvas
    [SerializeField] private GameObject narration;

    private void Update()
    {
        GetInput();
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teleport1"))
        {
            SceneManager.LoadScene(3);
        }
    }
}