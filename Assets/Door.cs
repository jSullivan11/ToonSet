using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    private Animator anim;
    public bool doorTrigger;

    void Start () {
        anim = gameObject.GetComponent<Animator>();
        doorTrigger = false;
    }
	
	void Update () {
        anim.SetBool("DoorTrigger", doorTrigger);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorTrigger = true;
            Debug.Log("Door Opened");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            doorTrigger = false;
            Debug.Log("Door Opened");
        }
    }
}
