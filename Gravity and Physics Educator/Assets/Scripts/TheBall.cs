using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TheBall : MonoBehaviour
{
    private Rigidbody rb;
    private float resetHeight;
    private bool groundTouched = false;
    private float Mass = 0f;
    private float Radius = 0f;
    private float GravitationalConstant = 6.6743f * Mathf.Pow(10, -11);
    //0.000000000066743f; //ten 0s before the 6

    public TMP_Text currentGtext;
    public TMP_Text targetHitText;
    public Button lessonNextButton;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        resetHeight = gameObject.transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        if (rb.transform.position.y < .385f && !groundTouched)
        {
            groundTouched = true;
            targetHitText.text = "Ground touched";
            targetHitText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            targetHitText.text = "Target Hit!";
            targetHitText.gameObject.SetActive(true);
            Time.timeScale = 0;
            lessonNextButton.gameObject.SetActive(true);
        }
        /*else if (other.gameObject.CompareTag("Ground"))
        {
            targetHitText.text = "Ground touched";
            targetHitText.gameObject.SetActive(true);
            Time.timeScale = 0;
        } */
    }

    //enable and disable the ball's gravity
    public void enableGravity()
    {
        rb.useGravity = true;
    }
    public void disableGravity()
    {
        rb.useGravity = false;
    }

    //update the ball's height that it will reset to
    public void updateResetHeight(float height)
    {
        resetHeight = height;
        Debug.Log("New Reset Height" + resetHeight.ToString());
    }
    //called after updateResetHeight to put the ball at the new height, or by the reset button to get the ball back to that height
    public void updateHeight()
    {
        disableGravity();
        rb.velocity = UnityEngine.Vector3.zero;
        gameObject.transform.position = new UnityEngine.Vector3(gameObject.transform.position.x, resetHeight, gameObject.transform.position.z);
        Time.timeScale = 1;
        groundTouched = false;
        targetHitText.gameObject.SetActive(false);
    }

    //changes the Unity force of gravity determined by Mass and Radius inputs
    //seperate from calculating g to allow for manual setting 
    public void updateGravityForce(float g)
    {
        Physics.gravity = new UnityEngine.Vector3(0f, -g, 0f);
        Debug.Log("New g:" + g.ToString());
        updateGDisplay(g);
    }
    public void calulcateGravityForce()
    {
        float g = GravitationalConstant * Mass / (Radius * Radius);
        updateGravityForce(g);
    }

    public void updateMass(float m)
    {
        Mass = m * Mathf.Pow(10, 22);
        Debug.Log("Mass:" + Mass.ToString());
        calulcateGravityForce();

    }
    public void updateRadius(float r)
    {
        Radius = r;
        Debug.Log("Radius" + Radius.ToString());
        calulcateGravityForce();
    }

    public void updateGDisplay(float g)
    {
        currentGtext.text = "Current g: " + g.ToString();
    }
}
