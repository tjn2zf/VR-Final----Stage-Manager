using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TriggerSound : MonoBehaviour {
    public AudioSource hitSound;
    //public AudioSource complete;
    public GameObject correctObject;
    public Vector3 desiredPosition = new Vector3();
    public Vector3 desiredRotation = new Vector3();
    public Vector3 desiredScale = new Vector3();
    public bool objectSet = false;
    //public Text scoreText;
    //public int i = 0;
	// Use this for initialization
	void Start () {
		hitSound = GetComponent<AudioSource>();
        //print("start");
        //scoreText.text = "Score: 0";
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
    {
        
        if(other.transform.gameObject == correctObject)
      {
           hitSound.Play();
            print ("collision on " + correctObject + desiredPosition);
            
            correctObject.transform.position = desiredPosition;
            correctObject.transform.localEulerAngles = desiredRotation;
            correctObject.transform.localScale = desiredScale;
            Rigidbody rb = correctObject.GetComponent<Rigidbody> ();
            objectSet = true;
         rb.isKinematic = true;
      }
        else {
            print ("other object" + correctObject);
        }
		//hitSound.Play();
        //print("land played");
        //i++;
        //scoreText.text = "Score: " + i;
	}
    void OnCollisionEnter(Collision collision)
    {
        print("collisionenter");
    }
    void Update() {
        
//        if     (GameObject.Find("Guitar1 Target").GetComponent<TriggerSound>().objectSet == true &&
//                GameObject.Find("Guitar2 Target").GetComponent<TriggerSound>().objectSet == true &&
//                GameObject.Find("amp1 Target").GetComponent<TriggerSound>().objectSet == true &&
//                GameObject.Find("amp2 Target").GetComponent<TriggerSound>().objectSet == true &&
//                GameObject.Find("mic Target").GetComponent<TriggerSound>().objectSet == true)
//            {
//                print("COMPLETED");
//                complete.Play();
//            }
    }
}
