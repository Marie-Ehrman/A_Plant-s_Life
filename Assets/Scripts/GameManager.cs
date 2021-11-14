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
        if (isWatered && isFed && isLit) {
            spriteRenderer.sprite = spriteArray[0];
        }


        if (!isWatered)
        {
            spriteRenderer.sprite = spriteArray[3];
        }


        if (!isFed)
        {
            spriteRenderer.sprite = spriteArray[4];
        }


        if (!isLit)
        {
            spriteRenderer.sprite = spriteArray[5];
        }

    }

    void RandomTime() {
        randomTime = Mathf.Round(Random.Range(1, 29) * 10.0f) * 0.1f;
    }

}
