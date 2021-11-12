using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watered : MonoBehaviour
{

    public GameManager plant;


    private void OnTriggerEnter(Collider other)
    {
        plant.isWatered = true;
        
    }
}
