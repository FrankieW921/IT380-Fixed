using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RadiusInputScr : MonoBehaviour
{
    public GameObject ball;
    TheBall ballScript;
    private float upperBounds = 10000000f;
    private float lowerBounds = 1000000f;
    private TMP_InputField inputField;
    private float radius = 0f;
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
        float tempRad = float.Parse(inputField.text); //always a decimal, okay to use
        if (tempRad > upperBounds)
        {
            inputField.text = upperBounds.ToString();
            tempRad = upperBounds;
        }
        else if (tempRad < lowerBounds)
        {
            inputField.text = lowerBounds.ToString();
            tempRad = lowerBounds;
        }
        radius = tempRad;
        ballScript.updateRadius(radius);
    }

    public void onDeselect()
    {
        float tempRad = float.Parse(inputField.text); //always a decimal, okay to use
        if (tempRad > upperBounds)
        {
            inputField.text = upperBounds.ToString();
            tempRad = upperBounds;
        }
        else if (tempRad < lowerBounds)
        {
            inputField.text = lowerBounds.ToString();
            tempRad = lowerBounds;
        }
        radius = tempRad;
        ballScript.updateRadius(radius);
    }

    public void setBounds(float uB, float lB)
    {
        upperBounds = uB;
        lowerBounds = lB;
    }
}
