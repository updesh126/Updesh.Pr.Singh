﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Animator door;
    public GameObject openText;

    public AudioSource doorSound;
    public bool isopen;
    public bool inReach;




    void Start()
    {
        inReach = false;
        isopen = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
        }
    }





    void Update()
    {

        if (!isopen && inReach && Input.GetButtonDown("Interact"))
        {
            DoorOpens();
        }

        else if(isopen && inReach && Input.GetButtonDown("Interact"))
        {
            DoorCloses();
        }




    }
    void DoorOpens ()
    {
        Debug.Log("It Opens");
        door.SetBool("open", true);
        door.SetBool("closed", false);
        doorSound.Play();
        isopen = true;
    }

    void DoorCloses()
    {
        Debug.Log("It Closes");
        door.SetBool("open", false);
        door.SetBool("closed", true);
        isopen = false;
    }


}
