using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public CharacterController player;
    public CountDown clock;

    public SpriteRenderer spriteRenderer;
    public SpriteUpdate sprite;
    public Sprite[] spriteArray;

    public bool isWatered = true;
    public bool isFed = true;
    public bool isLit = true;

    public float lives = 3;

    float randomTime;


    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
        RandomTime();


        Debug.Log(Mathf.Round(clock.waterTimer));
        if (clock.waterTimer <= 0f) {
            

            isWatered = false;
        }

        if (clock.foodTimer <= 0f)
        {
            Debug.Log("not fed");

            isFed = false;
        }

        if (clock.lightTimer <= 0f)
        {
            Debug.Log("not lit");

            isLit = false;
        }


    }

    void ChangeSprite()
    {

        //ALL GOOD
        if (isWatered && isLit) {
            spriteRenderer.sprite = spriteArray[0];
        }

        //NEEDS WATER
        if (!isWatered)
        {
            spriteRenderer.sprite = spriteArray[3];
        }

        if (!isWatered && lives == 2)
        {
            spriteRenderer.sprite = spriteArray[4];
        }

        if (!isWatered && lives == 1)
        {
            spriteRenderer.sprite = spriteArray[5];
        }



        //NEEDS LIGHT
        if (!isLit)
        {
            spriteRenderer.sprite = spriteArray[6];
        }

        if (!isLit && lives == 2)
        {
            spriteRenderer.sprite = spriteArray[7];
        }

        if (!isLit && lives == 1)
        {
            spriteRenderer.sprite = spriteArray[8];
        }


        //NEEDS LIGHT AND WATER
        if (!isWatered && !isLit)
        {
            spriteRenderer.sprite = spriteArray[9];
        }

        if (!isWatered && !isLit && lives == 2)
        {
            spriteRenderer.sprite = spriteArray[10];
        }

        if (!isWatered && !isLit && lives == 1)
        {
            spriteRenderer.sprite = spriteArray[11];
        }

    }

    void RandomTime() {
        randomTime = Mathf.Round(Random.Range(1, 29) * 10.0f) * 0.1f;
    }

}
