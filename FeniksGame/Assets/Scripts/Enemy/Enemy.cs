using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    protected GameObject player;
    protected int damage;


    private void Start()
    {
        player = FindObjectOfType<PlayerMove>().gameObject;
    }

    private void Update()
    {
        
        Move();
        Attack();
        
    }

    protected virtual void Move()
    {

    }

    protected virtual void Attack()
    {

    }
}
