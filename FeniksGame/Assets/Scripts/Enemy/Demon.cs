using UnityEngine.UI;
using UnityEngine;

public class Demon : Enemy
{
    [SerializeField] private float speed;
    [SerializeField] private float areaMove;
    [SerializeField] private float areaAttack;
    [SerializeField] private float timerAttack;
    [SerializeField] protected int HP;

    public void HPDemon(int value)
    {
        HP += value;
    }
    protected override void Move()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < areaMove)
        {
            transform.LookAt(player.transform);
            GetComponent<CharacterController>().Move(transform.forward * Time.deltaTime * speed);
        }
    }
    protected override void Attack()
    {
        if (timeAttack == timerAttack)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < areaAttack)
            {
                player.GetComponent<PlayerController>().ChangeHealth(-10);
                timeAttack = 0;
            }
        }
        if (timeAttack > timerAttack)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < areaAttack)
            {
                player.GetComponent<PlayerController>().ChangeHealth(-10);
                timeAttack = 0;
            }
        }
    }
    protected override void HPEnemy()
    {
        if (HP == 0)
        {
            Destroy(gameObject);
        }
        if (HP < 0)
        {
            Destroy(gameObject);
        }
    }
}
