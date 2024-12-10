using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadLesson1()
    {
        SceneManager.LoadScene(2);
    }
    public void loadLesson2()
    {
        SceneManager.LoadScene(3);
    }
    public void loadLesson3()
    {
        SceneManager.LoadScene(4);
    }
    public void loadSandbox()
    {
        SceneManager.LoadScene(1);
    }
}
