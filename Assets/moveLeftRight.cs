using UnityEngine;
using System.Collections;

public class moveLeftRight : MonoBehaviour
{

    public float speed = 0.0f;
    public string axisName = "Horizontal";
    public Animator anim;
    public bool idle = true;

    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        anim.SetFloat("Speed", (Input.GetAxis(axisName)));
        anim.SetBool("Idle", idle);
        Debug.Log(Input.GetAxis(axisName));
        Debug.Log(idle);
        if (Input.GetAxis(axisName) < 0)
        {
            idle = false;
            //Hit collider left bool equals true.
            //Hit collider right bool equals false.
        }
        else if (Input.GetAxis(axisName) > 0)
        {
            idle = false;
            //Hit collider left bool equals false.
            //Hit collider right bool equals true.
        }
        if (Input.GetAxis(axisName) == 0)
        {
            idle = true;
        }
        transform.position += transform.right * Input.GetAxis(axisName) * speed * Time.deltaTime;

    }
}