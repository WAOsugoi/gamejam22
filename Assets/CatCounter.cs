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
    public GameObject scaleTop;
    public GameObject[] failedOrders;
    public bool enableTextDebug;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    float moveSmoothVelocity;
    RectTransform ImageRectTransform;
    RectTransform scaleTopImageRectTransform;

    // Start is called before the first frame update
    void Start()
    {
        catsLeftText.text = "";
        chancesLeftText.text = "";
        ImageRectTransform = pointerImage.GetComponent<RectTransform>();
        scaleTopImageRectTransform = scaleTop.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateTotalCatsLeftCount(int currCount, int totalCount)
    {
        if(enableTextDebug)
            catsLeftText.text = currCount.ToString() + " / " + totalCount.ToString();
        float targetAngle = Mathf.Clamp(((float)currCount / (float)totalCount) * 360f, 0f, 360f);
        float angle = Mathf.SmoothDampAngle(ImageRectTransform.eulerAngles.z, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        ImageRectTransform.rotation = (Quaternion.Euler(0, 0, angle));
        UpdateScaleTop(currCount, totalCount);
        //Debug.Log(angle);
    }

    public void UpdateChancesLeftCount(int currChanceLeft, int totalChanceLeft)
    {
        if (enableTextDebug)
            chancesLeftText.text = currChanceLeft.ToString() + " / " + totalChanceLeft.ToString();
        for(int iter = 0; iter < totalChanceLeft; ++iter)
        {
            if(iter < totalChanceLeft - currChanceLeft)
                failedOrders[iter].SetActive(true);
            else
                failedOrders[iter].SetActive(false);
        }
    }

    public void UpdateScaleTop(int currCount, int totalCount)
    {
        float targetHeight = Mathf.Clamp(((float)currCount / (float)totalCount) * 32, 0, 32) - 32;
        float height = Mathf.SmoothDamp(scaleTopImageRectTransform.localPosition.y, targetHeight, ref moveSmoothVelocity, turnSmoothTime);
        //Debug.Log(targetHeight);
        //Debug.Log(height);
        scaleTopImageRectTransform.localPosition = new Vector3(0, height, 0);
    }
}
