using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadGesture : MonoBehaviour
{
    //public bool isFacingDown = false;
    public bool isMovingDown = false;
    public bool isMovingUp = false;
    private float sweepRate = 1.0f;
    private float previousCameraAngle;
    void Start()
    {
        previousCameraAngle = CameraAngleFromGround();
    }
    void Update()
    {
        //isFacingDown = DetectFacingDown();
        isMovingDown = DetectMovingDown();
        isMovingUp = DetectMovingUp();
    }
    private float CameraAngleFromGround()
    {
        return Vector3.Angle(Vector3.down, Camera.main.transform.rotation
        * Vector3.forward);
    }
    //private bool DetectFacingDown()
    //{
    //    return (CameraAngleFromGround() < 60.0f);
    //}
    private bool DetectMovingDown()
    {
        float angle = CameraAngleFromGround();
        float deltaAngle = previousCameraAngle - angle;
        float rate = deltaAngle / Time.deltaTime;
        previousCameraAngle = angle;
        //print("moving down");
        return (rate >= sweepRate);
       
    }

    private bool DetectMovingUp()
    {
        float angle = CameraAngleFromGround();
        float deltaAngle = angle - previousCameraAngle;
        float rate = deltaAngle / Time.deltaTime;
        previousCameraAngle = angle;
        //print("moving down");
        return (rate >= sweepRate);
       
    }
}
