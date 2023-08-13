using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Copy : MonoBehaviour
{

    [SerializeField] private Text healthText1;
    [SerializeField] private Text healthText2;
    [SerializeField] private Text healthText3;
    [SerializeField] private Text healthText4;
    [SerializeField] private Text healthText5;

    void Update()
    {
        healthText2.text = healthText1.text;
        healthText3.text = healthText1.text;
        healthText4.text = healthText1.text;
        healthText5.text = healthText1.text;
    }
}
