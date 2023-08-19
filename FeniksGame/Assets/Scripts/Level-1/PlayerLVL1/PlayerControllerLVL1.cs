using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControllerLVL1 : MonoBehaviour
{
    //Canvas
    [SerializeField] private GameObject narration;
    //HP BAR
    [SerializeField] private GameObject HP200;
    [SerializeField] private GameObject HP175;
    [SerializeField] private GameObject HP150;
    [SerializeField] private GameObject HP125;
    [SerializeField] private GameObject HP100;
    [SerializeField] private GameObject HP75;
    [SerializeField] private GameObject HP50;
    [SerializeField] private GameObject HP25;
    [SerializeField] private int HP;
    [SerializeField] private Text HPText;
    private HPBar hpbar = HPBar.HP200;

    enum HPBar
    {
        HP200,
        HP175,
        HP150,
        HP125,
        HP100,
        HP75,
        HP50,
        HP25
    }
    void Start()
    {
        ChangeHealth(200);
    }
    public void ChangeHealth(int value)
    {
        HP += value;
        HPText.text = HP.ToString();
    }
    private void HPBARText()
    {
        HPText.text = HP.ToString();
    }
    private void Update()
    {
        ExaminationHPBar();
        GetInput();
        HPBARText();
    }
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.B))
        {
            narration.SetActive(!narration.activeInHierarchy);
            if (narration.activeInHierarchy)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
    void ExaminationHPBar()
    {
        if (HP > 175)
        {
            if (HP < 201)
            {
                hpbar = HPBar.HP200;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP > 150)
        {
            if (HP < 175)
            {
                hpbar = HPBar.HP175;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP > 125)
        {
            if (HP < 150)
            {
                hpbar = HPBar.HP150;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP > 100)
        {
            if (HP < 126)
            {
                hpbar = HPBar.HP125;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP > 75)
        {
            if (HP < 101)
            {
                hpbar = HPBar.HP100;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP > 50)
        {
            if (HP < 76)
            {
                hpbar = HPBar.HP75;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP > 25)
        {
            if (HP < 51) 
            {
                hpbar = HPBar.HP50;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP > 0)
        {
            if (HP < 26)
            {
                hpbar = HPBar.HP25;
                ChooseHPBar(hpbar);
            }
        }
    }
    private void ChooseHPBar(HPBar hpbar)
    {
        switch (hpbar)
        {
            case HPBar.HP200:
                HP200.SetActive(true);
                HP175.SetActive(false);
                HP150.SetActive(false);
                HP125.SetActive(false);
                HP100.SetActive(false);
                HP75.SetActive(false);
                HP50.SetActive(false);
                HP25.SetActive(false);
                break;
            case HPBar.HP175:
                HP200.SetActive(false);
                HP175.SetActive(true);
                HP150.SetActive(false);
                HP125.SetActive(false);
                HP100.SetActive(false);
                HP75.SetActive(false);
                HP50.SetActive(false);
                HP25.SetActive(false);
                break;
            case HPBar.HP150:
                HP200.SetActive(false);
                HP175.SetActive(false);
                HP150.SetActive(true);
                HP125.SetActive(false);
                HP100.SetActive(false);
                HP75.SetActive(false);
                HP50.SetActive(false);
                HP25.SetActive(false);
                break;
            case HPBar.HP125:
                HP200.SetActive(false);
                HP175.SetActive(false);
                HP150.SetActive(false);
                HP125.SetActive(true);
                HP100.SetActive(false);
                HP75.SetActive(false);
                HP50.SetActive(false);
                HP25.SetActive(false);
                break;
            case HPBar.HP100:
                HP200.SetActive(false);
                HP175.SetActive(false);
                HP150.SetActive(false);
                HP125.SetActive(false);
                HP100.SetActive(true);
                HP75.SetActive(false);
                HP50.SetActive(false);
                HP25.SetActive(false);
                break;
            case HPBar.HP75:
                HP200.SetActive(false);
                HP175.SetActive(false);
                HP150.SetActive(false);
                HP125.SetActive(false);
                HP100.SetActive(false);
                HP75.SetActive(true);
                HP50.SetActive(false);
                HP25.SetActive(false);
                break;
            case HPBar.HP50:
                HP200.SetActive(false);
                HP175.SetActive(false);
                HP150.SetActive(false);
                HP125.SetActive(false);
                HP100.SetActive(false);
                HP75.SetActive(false);
                HP50.SetActive(true);
                HP25.SetActive(false);
                break;
            case HPBar.HP25:
                HP200.SetActive(false);
                HP175.SetActive(false);
                HP150.SetActive(false);
                HP125.SetActive(false);
                HP100.SetActive(false);
                HP75.SetActive(false);
                HP50.SetActive(false);
                HP25.SetActive(true);
                break;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Teleport1"))
        {
            SceneManager.LoadScene(3);
        }
    }
}