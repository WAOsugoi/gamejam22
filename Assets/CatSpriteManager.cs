using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpriteManager : MonoBehaviour
{
    public Sprite[] Latte = new Sprite[5];
    public Sprite[] Vanila = new Sprite[5];
    public Sprite[] Matcha = new Sprite[5];

    Cat_Behaviour cat;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
