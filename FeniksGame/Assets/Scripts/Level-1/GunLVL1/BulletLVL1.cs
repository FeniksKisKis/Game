using UnityEngine;
using UnityEngine.UI;

public class BulletLVL1 : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 direction;

    public void SetDirection(Vector3 value)
    {
        direction = value;
    }

    void Start()
    {
        Destroy(gameObject, 30);
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BloodDemon"))
        {
            other.GetComponent<DemonLVL2>().HPDemon(-50);
        }
        Destroy(gameObject);
    }
}