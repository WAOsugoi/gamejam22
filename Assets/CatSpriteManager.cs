using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpriteManager : MonoBehaviour
{
    
    public Sprite[] Latte = new Sprite[5];
    public Sprite[] Vanila = new Sprite[5];
    public Sprite[] Matcha = new Sprite[5];

    Cat_Behaviour cat;
    SpriteRenderer catSprite;
    Sprite[] selectedSprite;
    enum CAT_TYPE
    {
        LATTE,
        VANILLA,
        MATCHA
    };

    CAT_TYPE currCatType;

    // Start is called before the first frame update
    void Start()
    {
        currCatType = (CAT_TYPE)Random.Range(0, 3);
        cat = gameObject.GetComponentInParent<Cat_Behaviour>();
        catSprite = gameObject.GetComponentInParent<SpriteRenderer>();
        switch(currCatType)
        {
            case CAT_TYPE.LATTE:
                selectedSprite = Latte;
                break;
            case CAT_TYPE.VANILLA:
                selectedSprite = Vanila;
                break;
            case CAT_TYPE.MATCHA:
                selectedSprite = Matcha;
                break;
        }
        catSprite.sprite = selectedSprite[2];
    }

    // Update is called once per frame
    void Update()
    {
        catSprite.sprite = selectedSprite[(int)cat.temperature_state_flag];
    }
}
