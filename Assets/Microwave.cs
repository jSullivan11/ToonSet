using UnityEngine;
using System.Collections;

public class Microwave : MonoBehaviour {
    private Animator anim;
    public bool micOpen;
    private bool micOn;

    // Use this for initialization
    void Start () {
        anim = gameObject.GetComponent<Animator>();
        micOpen = false;
        micOn = false;
    }
	
	// Update is called once per frame
	void Update () {
        anim.SetBool("MicOpen", micOpen);
        anim.SetBool("MicOn", micOn);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            micOpen = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            micOpen = false;
        }
    }

    public void TvSwitch()
    {
        if (micOpen)
        {
            if (micOn)
            {
                //turn off the light
                micOn = !micOn;
                Debug.Log("micOn");
            }
            else
            {
                //turn on the light
                micOn = !micOn;
                Debug.Log("tvOff");
            }
        }
    }
}
