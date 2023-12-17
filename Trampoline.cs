using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{

    public float jumpFactor= 2.5f;

    void OnTriggerEnter(Collider other)
    {
        //Увеличить игрока
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;
    }

    void OnTriggerExit(Collider other)

    {
        //Увеличить игрока
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;
    } 
}
