using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{

    public float timer = 30f;
    public Text textBox;
    public CharacterController player;


    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timer.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        textBox.text = Mathf.Round(timer).ToString();

    }


}
