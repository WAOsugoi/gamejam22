using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AscendOrDescend : MonoBehaviour
{
    public GameObject hellState;
    public GameObject heavenState;

    bool isHeaven = true;
    public bool startAnim = false;

    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(startAnim)
        {
            if (isHeaven)
            {
                heavenState.SetActive(true);
                transform.position += new Vector3(0f, 10 * Time.deltaTime, 0f);
            }
            else
            {
                hellState.SetActive(true);
                transform.position -= new Vector3(0f, 10 * Time.deltaTime, 0f);
            }
            timer += Time.deltaTime;
            if(timer >= 2)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void PlayAnimation(bool _isHeaven)
    {
        startAnim = true;
        isHeaven = _isHeaven;
        
    }
}
