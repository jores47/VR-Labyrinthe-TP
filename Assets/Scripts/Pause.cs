using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject UiPause;

    public GameObject player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                UiPause.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                UiPause.SetActive(true);
            }
        }

        

    }



      

}