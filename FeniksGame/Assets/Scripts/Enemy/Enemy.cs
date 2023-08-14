using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    protected GameObject player;
    protected int damage;
    protected float timeAttack;
    protected int HP;

    private void Start()
    {
        player = FindObjectOfType<PlayerMove>().gameObject;
    }

    private void Update()
    {
        timeAttack += Time.deltaTime;
        Move();
        Attack();
        HPEnemy();
    }

    protected virtual void Move()
    {

    }

    protected virtual void Attack()
    {

    }

    protected virtual void HPEnemy()
    {

    }
}
