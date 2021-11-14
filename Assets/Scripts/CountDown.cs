using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{

    public float waterTimer = 15;
    public float foodTimer = 45;
    public float lightTimer = 30;
    
    public Text waterTextBox;
    public Text foodTextBox;
    public Text lightTextBox;

    public CharacterController player;


    // Start is called before the first frame update
    void Start()
    {
        waterTextBox.text = "Water: " + waterTimer.ToString();
        foodTextBox.text = "Food: " + foodTimer.ToString();
        lightTextBox.text = "Light: " + lightTimer.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        waterTimer -= Time.deltaTime;
        waterTextBox.text = "Water: " + Mathf.Round(waterTimer).ToString();

        foodTimer -= Time.deltaTime;
        foodTextBox.text = "Food: " +  Mathf.Round(foodTimer).ToString();

        lightTimer -= Time.deltaTime;
        lightTextBox.text = "Light: " + Mathf.Round(lightTimer).ToString();


    }

}
