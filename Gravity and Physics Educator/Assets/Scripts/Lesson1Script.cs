using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lesson1Script : MonoBehaviour
{
    private int textIndex = 0;

    public GameObject ballDemo;
    public GameObject ball;
    TheBall ballScript;
    public GameObject target;
    TargetScript targetScript;
    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;
    public TMP_Text text4;
    public TMP_Text text5;
    public TMP_Text text6;
    public TMP_InputField gInput;
    public Button nextButton;
    // Start is called before the first frame update
    void Start()
    {
        ballScript = ball.GetComponent<TheBall>();
        targetScript = target.GetComponent<TargetScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickNext(){
        switch(textIndex){
            case 0:
                textIndex++;
                text1.gameObject.SetActive(false);
                text2.gameObject.SetActive(true);
                break;
            case 1:
                textIndex++;
                text2.gameObject.SetActive(false);
                ballDemo.gameObject.SetActive(true);
                break;
            case 2: 
                textIndex++;
                ballDemo.gameObject.SetActive(false);
                text3.gameObject.SetActive(true);
                break;
            case 3:
                textIndex++;
                text3.gameObject.SetActive(false);
                ballDemo.gameObject.SetActive(true);
                ballScript.updateGravityForce(1f);
                ballScript.updateHeight();
                break;
            case 4:
                textIndex++;
                ballDemo.gameObject.SetActive(false);
                text4.gameObject.SetActive(true);
                break;
            case 5:
                textIndex++;
                text4.gameObject.SetActive(false);
                ballDemo.gameObject.SetActive(true); //set up gravity input
                ballScript.updateHeight();
                gInput.gameObject.SetActive(true);
                break;  
            case 6:
                textIndex++;
                ballDemo.SetActive(false);
                text5.gameObject.SetActive(true);
                break;      
            case 7: //level 1
                textIndex++;
                text5.gameObject.SetActive(false);
                ballDemo.SetActive(true);
                target.SetActive(true);
                ballScript.updateHeight();
                nextButton.gameObject.SetActive(false);
                break;
            case 8: //level 2
                textIndex++;
                ballScript.updateHeight();
                targetScript.setTravelSpeed(.1f);
                nextButton.gameObject.SetActive(false);
                break; 
            case 9: //level 3
                textIndex++;
                ballScript.updateHeight();
                targetScript.setTravelSpeed(5f);
                nextButton.gameObject.SetActive(false);
                break;    
            case 10:
                textIndex++;
                ballDemo.SetActive(false);
                text6.gameObject.SetActive(true);
                break;   
            case 11:
                SceneManager.LoadScene(0);
                break;    
        } 
        Time.timeScale = 1;
    }
}
