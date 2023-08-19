using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelateObjectLVL1 : MonoBehaviour
{
    [SerializeField] private float TimeLife;

    void Start()
    {
        Destroy(gameObject, TimeLife);
    }
}
