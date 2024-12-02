using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MassInputScr : MonoBehaviour
{
    public GameObject ball;
    TheBall ballScript;
    private float upperBounds = 2000f;
    private float lowerBounds = 0f;
    private TMP_InputField inputField;
    private float mass = 0f;
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
        float tempMass = float.Parse(inputField.text); //always a decimal, okay to use
        if (tempMass > upperBounds)
        {
            inputField.text = upperBounds.ToString();
            tempMass = upperBounds;
        }
        else if (tempMass < lowerBounds)
        {
            inputField.text = lowerBounds.ToString();
            tempMass = lowerBounds;
        }
        mass = tempMass;
        ballScript.updateMass(mass);
    }

    public void onDeselect()
    {
        float tempMass = float.Parse(inputField.text); //always a decimal, okay to use
        if (tempMass > upperBounds)
        {
            inputField.text = upperBounds.ToString();
            tempMass = upperBounds;
        }
        else if (tempMass < lowerBounds)
        {
            inputField.text = lowerBounds.ToString();
            tempMass = lowerBounds;
        }
        mass = tempMass;
        ballScript.updateMass(mass);
    }

    public void setBounds(float uB, float lB)
    {
        upperBounds = uB;
        lowerBounds = lB;
    }
}
