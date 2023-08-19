using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControllerLVL3 : MonoBehaviour
{
    //Object
    [SerializeField] private GameObject MagicWand1;
    [SerializeField] private GameObject MagicWand2;
    [SerializeField] private GameObject Teleport;
    //Canvas
    [SerializeField] private GameObject narration;

    void Start()
    {
        Time.timeScale = 0;
    }
    private void Update()
    {
        GetInput();
    }
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.B))
        {
            Destroy(narration.gameObject);
            Time.timeScale = 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teleport2"))
        {
            SceneManager.LoadScene(4);
        }
        if (other.CompareTag("Standforamagicwand"))
        {
            Destroy(other.gameObject);
            MagicWand1.SetActive(false);
            MagicWand2.SetActive(true);
            Teleport.SetActive(true);
        }
    }
}