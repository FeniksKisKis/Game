using UnityEngine;
using UnityEngine.UI;

public class BulletLVL3 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int Damage;
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
        if (other.CompareTag("KingDemon"))
        {
            other.GetComponent<DemonLVL4>().HPDemon(-Damage);
        }
        Destroy(gameObject);
    }
}