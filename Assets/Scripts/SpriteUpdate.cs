using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteUpdate : MonoBehaviour
{

    
    public SpriteRenderer spriteRenderer;


    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    void ChangeSprite(Sprite newSprite) {


        spriteRenderer.sprite = newSprite;
    }
}
