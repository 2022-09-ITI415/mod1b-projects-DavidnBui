using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{

    public void LoadScene1()
    {
        SceneManager.LoadScene("ApplePicker");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("Mission Demolition");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("Prototype1");
    }

    

}
