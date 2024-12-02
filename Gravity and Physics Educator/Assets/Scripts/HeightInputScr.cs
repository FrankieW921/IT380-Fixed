using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HeightInputScr : MonoBehaviour
{
    public GameObject ball;
    TheBall ballScript;
    private float upperBounds = 500f;
    private float lowerBounds = 2.5f;
    private TMP_InputField inputField;
    private float height = 0f;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        ballScript = ball.GetComponent<TheBall>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onEndEdit()
    {
        float tempHeight = float.Parse(inputField.text); //always a decimal, okay to use
        if (tempHeight > upperBounds)
        {
            inputField.text = upperBounds.ToString();
            tempHeight = upperBounds;
        }
        else if (tempHeight < lowerBounds)
        {
            inputField.text = lowerBounds.ToString();
            tempHeight = lowerBounds;
        }
        height = tempHeight;
        ballScript.updateResetHeight(height);
        ballScript.updateHeight();
    }

    public void onDeselect()
    {
        float tempHeight = float.Parse(inputField.text); //always a decimal, okay to use
        if (tempHeight > upperBounds)
        {
            inputField.text = upperBounds.ToString();
            tempHeight = upperBounds;
        }
        else if (tempHeight < lowerBounds)
        {
            inputField.text = lowerBounds.ToString();
            tempHeight = lowerBounds;
        }
        height = tempHeight;
        ballScript.updateResetHeight(height);
        ballScript.updateHeight();
    }

    public void setBounds(float uB, float lB)
    {
        upperBounds = uB;
        lowerBounds = lB;
    }
}
