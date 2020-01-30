using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DetectHeadMove : MonoBehaviour
{
    private ObjectCompare compare;
    private Vector3[] angles;
    private int index;
    private Vector3 centerAngle;
    public GameObject responsiveObject;
    public int answer=3;
    // Use this for initialization
    void Start()
    {
        compare = GetComponent<ObjectCompare>();
        //print("Hello");
        ResetGesture();
        //responsiveObject = GameObject.Find("Cube");
        //responsiveObject.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        angles[index] = Camera.main.transform.eulerAngles;
        index++;
        if (index == 80)
        {
        
            answer = CheckMovement();
            if(answer ==1 || answer ==0){
            compare.answerCompare();
            }
            ResetGesture();
        }
    }

    public int CheckMovement()
    {
        bool right = false, left = false, up = false, down = false;
        
        for (int i = 0; i < 80; i++)
        {
            if (angles[i].x < centerAngle.x - 20.0f && !up)
            {
                up = true;
                print("up");
            }
            else if (angles[i].x > centerAngle.x + 20.0f && !down)
            {
                down = true;
                                print("down");

            }

            if (angles[i].y < centerAngle.y - 20.0f && !left)
            {
                left = true;
                                print("left");

            }
            else if (angles[i].y > centerAngle.y + 20.0f && !right)
            {
                right = true;
                                print("right");

            }
        }

        if (left && right && !(up && down))
        {
            print("Response = No");
            //responsiveObject.GetComponent<Renderer>().material.color = Color.red;
            return 0;
        }

        if (up && down && !(left && right))
        {
            print("Response = Yes");
            //responsiveObject.GetComponent<Renderer>().material.color = Color.green;
            return 1;
        }
        else {return 3;}
    }

    void ResetGesture()
    {
        angles = new Vector3[80];
        index = 0;
        centerAngle = Camera.main.transform.eulerAngles;
        //print("done");
    }
}
