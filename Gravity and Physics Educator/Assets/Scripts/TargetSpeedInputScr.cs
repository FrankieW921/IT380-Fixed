using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TargetSpeedInputScr : MonoBehaviour
{
    public GameObject target;
    TargetScript targetScript;
    private float upperBounds = 10f;
    private float lowerBounds = 0f;
    private TMP_InputField inputField;
    private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GetComponent<TMP_InputField>();
        targetScript = target.GetComponent<TargetScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onEndEdit(){
        float tempSpeed = float.Parse(inputField.text);
        if(tempSpeed > upperBounds){
            inputField.text = upperBounds.ToString();
            tempSpeed = upperBounds;
        }
        else if(tempSpeed < lowerBounds){
            inputField.text = lowerBounds.ToString();
            tempSpeed = lowerBounds;
        }
        speed = tempSpeed;
        targetScript.setTravelSpeed(speed);
    }
    public void onDeselect(){
        float tempSpeed = float.Parse(inputField.text);
        if(tempSpeed > upperBounds){
            inputField.text = upperBounds.ToString();
            tempSpeed = upperBounds;
        }
        else if(tempSpeed < lowerBounds){
            inputField.text = lowerBounds.ToString();
            tempSpeed = lowerBounds;
        }
        speed = tempSpeed;
        targetScript.setTravelSpeed(speed);
    }
    
}
