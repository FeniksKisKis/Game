using UnityEngine.UI;
using UnityEngine;

public class DemonLVL4 : EnemyLVL4
{
    [SerializeField] private float speed;
    [SerializeField] private float areaMove;
    [SerializeField] private float areaAttack;
    [SerializeField] private float timerAttack;
    [SerializeField] private GameObject GameWine;
    [SerializeField] private GameObject HPCanvas;
    [SerializeField] private int HP;
    [SerializeField] private int damage;

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
        if (timeAttack > timerAttack)
        {
            if (Vector3.Distance(transform.position, player.transform.position) < areaAttack)
            {
                player.GetComponent<PlayerControllerLVL4>().ChangeHealth(-damage);
                timeAttack = 0;
            }
        }
    }
    protected override void HPEnemy()
    {
        if (HP == 0)
        {
            Cursor.lockState = CursorLockMode.None;
            GameWine.SetActive(true);
            HPCanvas.SetActive(false);
            Destroy(gameObject);
        }
        if (HP < 0)
        {
            Cursor.lockState = CursorLockMode.None;
            GameWine.SetActive(true);
            HPCanvas.SetActive(false);
            Destroy(gameObject);
        }
    }
}
