using UnityEngine;
using UnityEngine.UI;

public class EnemyLVL2 : MonoBehaviour
{
    protected GameObject player;
    protected int damage;
    protected float timeAttack;

    private void Start()
    {
        player = FindObjectOfType<PlayerMoveLVL1>().gameObject;
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
