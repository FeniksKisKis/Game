using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    private float mouseX;
    private float mouseY;

    [Header("Чуствительность мыши")]
    private float sensitivityMouse = 200f;

    [SerializeField] private Transform Player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * sensitivityMouse * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sensitivityMouse * Time.deltaTime;

        Player.Rotate(mouseX * new Vector3(0, 1, 0));

        transform.Rotate(-mouseY * new Vector3(1, 0, 0));
    }
}