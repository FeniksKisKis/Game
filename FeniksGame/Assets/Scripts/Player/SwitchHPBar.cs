using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchHPBar : MonoBehaviour
{
    [SerializeField] private GameObject HP200;
    [SerializeField] private GameObject HP175;
    [SerializeField] private GameObject HP150;
    [SerializeField] private GameObject HP125;
    [SerializeField] private GameObject HP100;
    [SerializeField] private GameObject HP75;
    [SerializeField] private GameObject HP50;
    [SerializeField] private GameObject HP25;
    [SerializeField] private Text HPText;
    [SerializeField] private float HP;

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
    void Update()
    {
        //HP = HPText.text;
        ExaminationHPBar();
    }
    void ExaminationHPBar()
    {
        if (HP < 200)
        {
            if (HP > 175)
            {
                hpbar = HPBar.HP200;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP < 175)
        {
            if (HP > 150)
            {
                hpbar = HPBar.HP175;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP < 150)
        {
            if (HP > 125)
            {
                hpbar = HPBar.HP150;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP < 125)
        {
            if (HP > 100)
            {
                hpbar = HPBar.HP125;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP < 100)
        {
            if (HP > 75)
            {
                hpbar = HPBar.HP100;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP < 75)
        {
            if (HP > 50)
            {
                hpbar = HPBar.HP75;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP < 50)
        {
            if (HP > 25)
            {
                hpbar = HPBar.HP50;
                ChooseHPBar(hpbar);
            }
        }
        else if (HP < 25)
        {
            if (HP > 0)
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
                break;
            //case HPBar.HP200:
                //HP200.SetActive(false);
                //HP175.SetActive(true);
                //HP150.SetActive(false);
                //HP125.SetActive(false);
                //break;
        }
    }
}
