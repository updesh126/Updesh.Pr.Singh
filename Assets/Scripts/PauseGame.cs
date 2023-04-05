﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject menu;
    public GameObject resume;
    public GameObject quit;

    public bool on;
    public bool off;





    void Start()
    {
        menu.SetActive(false);
        off = true;
        on = false;
    }




    void Update()
    {
        if (off && Input.GetButtonDown("Pause"))
        {
            Time.timeScale = 0; //nothing will change
            menu.SetActive(true);
            off = false;
            on = true;
        }

        else if (on && Input.GetButtonDown("Pause"))
        {
            Time.timeScale = 1;
            menu.SetActive(false);
            off = true;
            on = false;
        }
        
    }

    public void Resume()
    {
            Time.timeScale = 1;
            menu.SetActive(false);
            off = true;
            on = false;

    }

    public void Exit()
    {
        Application.Quit();// qunit application
    }
}
