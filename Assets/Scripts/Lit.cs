using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lit : MonoBehaviour
{

    public GameManager plant;
    public CountDown clock;


    private void OnTriggerEnter(Collider other)
    {
        if (!plant.isLit)
        {
            plant.isLit = true;
            clock.lightTimer = 30f;
        }

    }
}