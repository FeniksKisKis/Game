using UnityEngine;
using UnityEngine.UI;

public class NarrationShere : MonoBehaviour
{
    [SerializeField] private GameObject narration;  
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Narration")
        {
            narration.SetActive(!narration.activeInHierarchy);
            if (narration.activeInHierarchy)
            {
                Time.timeScale = 0;
                GetComponent<PlayerLook>().enabled = false;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Time.timeScale = 1;
                GetComponent<PlayerLook>().enabled = true;
            }
        }
        //Destroy(gameObject);
    }
}
