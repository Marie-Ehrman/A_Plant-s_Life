using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Warning : MonoBehaviour
{

    public GameManager plant;
    public CountDown clock;

    public Text warning;


    // Start is called before the first frame update
    void Start()
    {

        warning.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (!plant.isWatered && !plant.isLit) {
            warning.enabled = true;
            warning.text = "Warning, find water or light in: " + Mathf.Round(clock.globalTimer).ToString() + " seconds";
        } else {
            clock.globalTimer = 10;
            warning.enabled = false;
        }

    }
}
