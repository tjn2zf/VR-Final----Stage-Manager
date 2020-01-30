using UnityEngine;
using System.Collections;

public class HeadLookWalk : MonoBehaviour
{
    public float velocity = 0.7f;
    private CharacterController controller;
    public bool isWalking = false;
    //public GameObject camera = GameObject.Find("OVRCameraRig");
    public OVRInput.Controller Controller = OVRInput.Controller.LTouch;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One, Controller))
        {
            print("i clicked it");
        }


        //Vector3 moveDirection = Camera.main.transform.forward;
        // moveDirection *= velocity * Time.deltaTime;
        // moveDirection.y = 0.0f;
        //transform.position += moveDirection;
        //controller.Move(moveDirection);
        //controller.SimpleMove(Camera.main.transform.forward * velocity);

        OVRInput.Update();
        OVRInput.FixedUpdate();
        if (Clicked())
        {
           // print("wakjubg");
            isWalking = !isWalking;
        }

        if (isWalking)
        {
            controller.SimpleMove(Camera.main.transform.forward * velocity);
        }
    }

    public bool Clicked()
    {
        return Input.GetKeyDown("space");
        
        
    }

}