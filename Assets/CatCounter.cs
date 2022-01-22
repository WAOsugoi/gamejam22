using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CatCounter : MonoBehaviour
{
    public TextMeshProUGUI catsLeftText;
    public TextMeshProUGUI chancesLeftText;
    
    // Start is called before the first frame update
    void Start()
    {
        catsLeftText.text = "";
        chancesLeftText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTotalCatsLeftCount(int currCount, int totalCount)
    {
        catsLeftText.text = currCount.ToString() + " / " + totalCount.ToString();
    }

    public void UpdateChancesLeftCount(int currChanceLeft, int totalChanceLeft)
    {
        chancesLeftText.text = currChanceLeft.ToString() + " / " + totalChanceLeft.ToString();
    }
}
