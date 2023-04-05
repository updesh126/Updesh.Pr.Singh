using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator door;
    public GameObject openText;

    public AudioSource doorSound;

    public bool inReach;

    // Start is called before the first frame update
    void Start()
    {
        inReach = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inReach && Input.GetButtonDown("Interact"))
        {
            DoorOpen();
        }
        else
        {
            DoorClose();
        }
    }

    void DoorOpen()
    {
        Debug.Log("It open");
        door.SetBool("Open", true);
        door.SetBool("Closed", false);
        doorSound.Play();
    }
    void DoorClose()
    {
        Debug.Log("It close");
        door.SetBool("Open", false);
        door.SetBool("Closed", true);
    }
}
