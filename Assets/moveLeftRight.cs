using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class moveLeftRight : MonoBehaviour
{

    private Rigidbody rb;
    public float speed = 0.0f;
    private string axisName = "Horizontal";
    private Animator anim;
    private bool idle = true;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        anim.SetFloat("Speed", (CrossPlatformInputManager.GetAxis(axisName)));
        anim.SetBool("Idle", idle);
        Debug.Log(CrossPlatformInputManager.GetAxis(axisName));
        Debug.Log(idle);
        if (CrossPlatformInputManager.GetAxis(axisName) < 0)
        {
            idle = false;
            //Hit collider left bool equals true.
            //Hit collider right bool equals false.
        }
        else if (CrossPlatformInputManager.GetAxis(axisName) > 0)
        {
            idle = false;
            //Hit collider left bool equals false.
            //Hit collider right bool equals true.
        }
        if (CrossPlatformInputManager.GetAxis(axisName) == 0)
        {
            idle = true;
        }
        //transform.position += transform.right * CrossPlatformInputManager.GetAxis(axisName) * speed * Time.deltaTime;
        rb.MovePosition(transform.position + transform.right * (CrossPlatformInputManager.GetAxis(axisName) * speed) * Time.deltaTime);
    }
}