using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{

    public float globalTimer = 10;

    public float waterTimer = 10;
    public float foodTimer = 30;
    public float lightTimer = 20;

    public Text globalTimeTextBox;

    public Text waterTextBox;
    public Text foodTextBox;
    public Text lightTextBox;

    public CharacterController player;


    // Start is called before the first frame update
    void Start()
    {
        globalTimeTextBox.text = globalTimer.ToString();

        waterTextBox.text = "Water: " + waterTimer.ToString();
        foodTextBox.text = "Food: " + foodTimer.ToString();
        lightTextBox.text = "Light: " + lightTimer.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        globalTimer -= Time.deltaTime;
        globalTimeTextBox.text = Mathf.Round(globalTimer).ToString();

        waterTimer -= Time.deltaTime;
        waterTextBox.text = "Water: " + Mathf.Round(waterTimer).ToString();

        foodTimer -= Time.deltaTime;
        foodTextBox.text = "Food: " +  Mathf.Round(foodTimer).ToString();

        lightTimer -= Time.deltaTime;
        lightTextBox.text = "Light: " + Mathf.Round(lightTimer).ToString();


    }

}
