using UnityEngine;
using UnityEngine.UI;

public class EnemyLVL4 : MonoBehaviour
{
    protected GameObject player;
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
