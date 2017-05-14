using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class moveLeftRight : MonoBehaviour
{

    private Rigidbody rb;
    public float speed = 0.0f;
    private float deadZone = .5f;
    private string axisNameX = "Horizontal";
    private string axisNameZ = "Vertical";
    private bool idle = true;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.right * CrossPlatformInputManager.GetAxis(axisName) * speed * Time.deltaTime;
            rb.MovePosition(transform.position + transform.right * (CrossPlatformInputManager.GetAxis(axisNameX) * speed) * Time.deltaTime);
            //rb.MovePosition(transform.position + transform.forward * (CrossPlatformInputManager.GetAxis(axisNameZ) * speed) * Time.deltaTime);
    }
}