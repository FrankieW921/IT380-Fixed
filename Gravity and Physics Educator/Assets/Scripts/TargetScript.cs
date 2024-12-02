using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private Vector3 pos1 = new Vector3(-5f, .75f, 0f);
    private Vector3 pos2 = new Vector3(5f, .75f, 0f);
    private float lerpTime = 0f;
    private int travelDirection = 0; //0 is moving to the right of the frame, 1 is moving to the left of the frame
    // Start is called before the first frame update
    private float travelSpeed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(travelDirection == 0){
            transform.position = Vector3.Lerp(pos1, pos2, lerpTime);
            lerpTime += Time.deltaTime * travelSpeed;
        }
        else if(travelDirection == 1){
            transform.position = Vector3.Lerp(pos1, pos2, lerpTime);
            lerpTime -= Time.deltaTime * travelSpeed;
        }

        if(lerpTime <= 0f){
            travelDirection = 0;
        }
        else if(lerpTime >=1f){
            travelDirection = 1;
        }
    }

    public void setTravelSpeed(float speed){
        travelSpeed = speed;
    }
}
