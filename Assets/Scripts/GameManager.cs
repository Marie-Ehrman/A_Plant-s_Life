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

        //spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
       // clock = GetComponent<CountDown>();
        player = GetComponent<CharacterController>();
        //sprite = GetComponent<SpriteUpdate>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
        RandomTime();


        Debug.Log(randomTime);
        if (Mathf.Round(clock.timer) == 25) {
            
            isWatered = false;

        }


    }

    void ChangeSprite()
    {
        if (isWatered) {
            spriteRenderer.sprite = spriteArray[0];
        }
        if (!isWatered)
        {
            spriteRenderer.sprite = spriteArray[3];
        }
        
    }

    void RandomTime() {
        randomTime = Mathf.Round(Random.Range(1, 29));
    }

}
