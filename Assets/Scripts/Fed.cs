using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fed : MonoBehaviour
{

    public GameManager plant;
    public CountDown clock;


    private void OnTriggerEnter(Collider other)
    {
        if (!plant.isFed)
        {
            plant.isFed = true;
            clock.foodTimer = 20f;
        }

    }
}
