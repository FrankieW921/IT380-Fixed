using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lesson3Script : MonoBehaviour
{
    private int textIndex = 0;

    public GameObject ballDemo;
    public GameObject ball;
    TheBall ballScript;
    public GameObject target;
    TargetScript targetScript;
    public GameObject obstacle1;
    public GameObject obstacle2;
    ObstacleScript obstacleScript1;
    ObstacleScript2 obstacleScript2;
    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;
    public TMP_Text text4;
    public TMP_Text text5;
    public TMP_Text text6;
    public TMP_Text text7;
    public TMP_Text text8;
    public TMP_InputField gInput;
    public TMP_InputField massInput;
    public TMP_InputField radiusInput;
    public TMP_Text gravityEq;
    public Button nextButton;
    public Button stopButton;
    public Camera firstCamera;
    public Camera ballCamera;
    public Camera targetCamera;
    // Start is called before the first frame update
    void Start()
    {
        ballScript = ball.GetComponent<TheBall>();
        targetScript = target.GetComponent<TargetScript>();
        obstacleScript1 = obstacle1.GetComponent<ObstacleScript>();
        obstacleScript2 = obstacle2.GetComponent<ObstacleScript2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickNext()
    {
        switch (textIndex)
        {
            case 0:
                textIndex++;
                text1.gameObject.SetActive(false);
                text2.gameObject.SetActive(true);
                break;
            case 1:
                textIndex++;
                text2.gameObject.SetActive(false);
                ballDemo.gameObject.SetActive(true);
                radiusInput.gameObject.SetActive(true); //initial radius example
                ballScript.updateMass(597);
                ballScript.updateRadius(1000000);
                ballScript.updateHeight();
                break;
            case 2:
                textIndex++;
                ballDemo.gameObject.SetActive(false);
                text3.gameObject.SetActive(true);
                break;
            case 3:
                textIndex++;
                text3.gameObject.SetActive(false);
                text4.gameObject.SetActive(true);
                break;
            case 4:
                textIndex++;
                text4.gameObject.SetActive(false); //level 1
                ballCamera.gameObject.SetActive(true);
                targetCamera.gameObject.SetActive(true);
                firstCamera.gameObject.SetActive(false);
                ballDemo.SetActive(true);
                ballScript.updateHeight();
                target.SetActive(true);
                targetScript.setTravelSpeed(2f);
                nextButton.gameObject.SetActive(false);
                stopButton.gameObject.SetActive(true);
                break;
            case 5: //level 2
                textIndex++;
                ballScript.updateResetHeight(15f);
                ballScript.updateHeight();
                targetScript.setTravelSpeed(.3f);
                nextButton.gameObject.SetActive(false);
                obstacle1.gameObject.SetActive(true);
                obstacleScript1.setTravelSpeed(.5f);
                break;
            case 6:
                textIndex++;
                ballDemo.SetActive(false);
                firstCamera.gameObject.SetActive(true);
                text5.gameObject.SetActive(true);
                break;
            case 7: //level 3
                textIndex++;
                text5.gameObject.SetActive(false);
                ballDemo.SetActive(true);
                ballScript.updateResetHeight(15f);
                ballScript.updateHeight();
                ballScript.updateRadius(1000000);
                ballScript.updateMass(597);
                firstCamera.gameObject.SetActive(false);
                massInput.gameObject.SetActive(true);
                targetScript.setTravelSpeed(1f);
                obstacleScript1.setTravelSpeed(.5f);
                nextButton.gameObject.SetActive(false);
                break;
            case 8: //level 4
                textIndex++;
                ballScript.updateResetHeight(20f);
                ballScript.updateHeight();
                nextButton.gameObject.SetActive(false);
                obstacle2.gameObject.SetActive(true);
                obstacleScript2.setTravelSpeed(.5f);
                obstacleScript1.setTravelSpeed(1.3f);
                targetScript.setTravelSpeed(1.5f);
                break;
            case 9: //level 5
                textIndex++;
                ballScript.updateResetHeight(20f);
                ballScript.updateHeight();
                nextButton.gameObject.SetActive(false);
                obstacleScript2.setTravelSpeed(1.1f);
                obstacleScript1.setTravelSpeed(.55f);
                targetScript.setTravelSpeed(1f);
                break;
            case 10: //final congrats
                textIndex++;
                firstCamera.gameObject.SetActive(false);
                ballDemo.gameObject.SetActive(false);
                text6.gameObject.SetActive(false);
                break;
            case 11:
                SceneManager.LoadScene(0);
                break;
        }
        Time.timeScale = 1;
    }
}
