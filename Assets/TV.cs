using UnityEngine;
using System.Collections;

public class TV : MonoBehaviour {

    private Animator anim;
    public bool tvTrigger;
    public GameObject TvDialogObject;
    public Sprite tvSprite0;
    public Sprite tvSprite1;
    private bool tvOn;

    void Start() {
        anim = gameObject.GetComponent<Animator>();
        tvTrigger = false;
        tvOn = false;
    }

    void Update() {
        anim.SetBool("TVTrigger", tvTrigger);
        anim.SetBool("TVOn", tvOn);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tvTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tvTrigger = false;
        }
    }

    public void TvSwitch()
    {
        if (tvTrigger)
        {
            if (tvOn)
            {
                //turn off the light
                tvOn = !tvOn;
                Debug.Log("tvOn");
            }
            else
            {
                //turn on the light
                tvOn = !tvOn;
                Debug.Log("tvOff");
            }
        }
    }
}
