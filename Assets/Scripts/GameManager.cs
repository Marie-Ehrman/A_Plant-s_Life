﻿using System.Collections;
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



    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSprite();
        RemoveLife();

        if (clock.waterTimer <= 0f) {
            isWatered = false;
        }

        if (clock.foodTimer <= 0f)
        {
            isFed = false;
        }

        if (clock.lightTimer <= 0f)
        {
            isLit = false;
        }

    }

    void ChangeSprite()
    {

        //ALL GOOD
        if (isWatered && isLit) {
            spriteRenderer.sprite = spriteArray[0];
        }

        if (isWatered && isLit && lives == 2)
        {
            spriteRenderer.sprite = spriteArray[1];
        }

        if (isWatered && isLit && lives == 1)
        {
            spriteRenderer.sprite = spriteArray[2];
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

    void RemoveLife() {
        Debug.Log("Global Clock: " + clock.globalTimer);

        if (Mathf.Round(clock.globalTimer) < 0)
        {
            Debug.Log("Timer at ZERO");
            clock.globalTimer = 10;
            lives--;
        }
        else {
            Debug.Log("NOT removing life");
        }
    }

}
