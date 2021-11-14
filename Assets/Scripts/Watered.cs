using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watered : MonoBehaviour
{

    public GameManager plant;
    public CountDown clock;


    private void OnTriggerEnter(Collider other)
    {
        if (!plant.isWatered)
        {
            plant.isWatered = true;
            clock.waterTimer = 10f;
        }
        
    }
}
