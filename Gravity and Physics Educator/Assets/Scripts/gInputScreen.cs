using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gInputScreen : MonoBehaviour
{
    public GameObject ball;
    TheBall ballScript;
    private float upperBounds = 5000f;
    private float lowerBounds = 0f;
    private TMP_InputField inputField;
    private float g = 0f;
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

    public void setG(float ga)
    {
        g = ga;
    }

    public void onEndEdit()
    {
        float tempG = float.Parse(inputField.text); //always a decimal, okay to use
        if (tempG > upperBounds)
        {
            inputField.text = upperBounds.ToString();
            tempG = upperBounds;
        }
        else if (tempG < lowerBounds)
        {
            inputField.text = lowerBounds.ToString();
            tempG = lowerBounds;
        }
        g = tempG;
        ballScript.updateGravityForce(g);
    }

    public void onDeselect()
    {
        float tempG = float.Parse(inputField.text); //always a decimal, okay to use
        if (tempG > upperBounds)
        {
            inputField.text = upperBounds.ToString();
            tempG = upperBounds;
        }
        else if (tempG < lowerBounds)
        {
            inputField.text = lowerBounds.ToString();
            tempG = lowerBounds;
        }
        g = tempG;
        ballScript.updateGravityForce(g);
    }
}
