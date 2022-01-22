using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CatCounter : MonoBehaviour
{
    public TextMeshProUGUI catsLeftText;
    public TextMeshProUGUI chancesLeftText;
    public GameObject pointerImage;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    RectTransform ImageRectTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        catsLeftText.text = "";
        chancesLeftText.text = "";
        ImageRectTransform = pointerImage.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateTotalCatsLeftCount(int currCount, int totalCount)
    {
        catsLeftText.text = currCount.ToString() + " / " + totalCount.ToString();
        float targetAngle = Mathf.Clamp(((float)currCount / (float)totalCount) * 360f, 0f, 360f);
        float angle = Mathf.SmoothDampAngle(ImageRectTransform.eulerAngles.z, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        ImageRectTransform.rotation = (Quaternion.Euler(0, 0, angle));
        Debug.Log(angle);
    }

    public void UpdateChancesLeftCount(int currChanceLeft, int totalChanceLeft)
    {
        chancesLeftText.text = currChanceLeft.ToString() + " / " + totalChanceLeft.ToString();
    }
}
