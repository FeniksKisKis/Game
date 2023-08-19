using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTeleport : MonoBehaviour
{

    [SerializeField] private Transform Player;
    [SerializeField] private Transform Teleport1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Teleport1")
        {
            Player.position = Teleport1.position;
        }
    }
}
