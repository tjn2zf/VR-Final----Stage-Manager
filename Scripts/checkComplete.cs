using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class checkComplete : MonoBehaviour {
    public AudioSource complete; 
    public bool flip = false;
    public bool lights = false;
    public bool fire = false;
    public bool objects = false;
    public bool success = false;
    public GameObject gameObject;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public GameObject gameObject4;
    public GameObject gameObject5;
    public GameObject gameObject6;
    public Text objective;
    private string sceneName;

    // Use this for initialization
    void Start () {
        //complete.Stop();
        objective.text = "Place all the items where they belong";
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        print("current scene name = " + sceneName);
    
    }

    // Update is called once per frame
    void Update() {
       /* if (sceneName.Equals("Level 1"))
        {
            print("yay");
        } */

       /* if (GameObject.Find("Guitar1 Target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("Guitar2 Target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("amp1 target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("amp2 target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("mic target").GetComponent<TriggerSound>().objectSet == true)
        {
            afterObjects();
        }*/
        if(GameObject.Find("Guitar1 Target").GetComponent<TriggerSound>().objectSet == true &&
            GameObject.Find("mic target").GetComponent<TriggerSound>().objectSet == true && sceneName == "Level 1"
            )
        {
            //print("objects placed");
            afterObjects();
        }
        else if (GameObject.Find("Guitar1 Target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("Guitar2 Target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("amp1 target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("amp2 target").GetComponent<TriggerSound>().objectSet == true &&
                GameObject.Find("mic target").GetComponent<TriggerSound>().objectSet == true)
        {
            afterObjects();
        }

    }

        public void afterObjects() {
        
//                print("COMPLETED");
            if( flip == false)
            {
                print("COMPLETED");
                complete.Play();
                flip = true;
                objects = true;
                objective.text = "Pull the levers to activate lights and effects";
            }
            

        if(GameObject.Find("light control").transform.position.y <= 3)
        {
            //print("lights are on");
            if( lights == false)
            {
                gameObject.SetActive(true);
                gameObject2.SetActive(true);
                gameObject3.SetActive(true);
                lights = true;
            }
            
        }
        if (GameObject.Find("firework control").transform.position.y <= 3)
        {
            //print("lights are on");
            if (fire == false)
            {
                gameObject4.SetActive(true);
                gameObject5.SetActive(true);
                gameObject6.SetActive(true);
                fire = true;
            }

        }


        if (fire == true && lights == true && objects == true)
        {
            objective.text = "LEVEL COMPLETE";
            success = true;
        }
    }
    public bool checkDone()
    {
        if (success == true)
        {
            return true;
        }
        else return false;
    }
}
