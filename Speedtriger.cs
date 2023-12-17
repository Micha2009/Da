using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedtriger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        //Увеличить скорость бега игрока
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        //Понизить скорость бега игрока
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}
