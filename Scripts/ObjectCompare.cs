using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ObjectCompare : MonoBehaviour
{

    private DetectHeadMove headMove;
    //public int[] colors = { red, blue, green };
    public int[] shapes = { 1, 2, 3 };
    public int choice;
    public int choice2;
    public int same;
    public int answer2;
    public GameObject[] gameObjects;
    public Text response;

    System.Random rnd = new System.Random();
    // Use this for initialization
    void Start()
    {
        headMove = GetComponent<DetectHeadMove>();
        answer2 = setShapes();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int setShapes()
    {
    
        
        choice = getRandom();
        choice2 = getRandom();
        Destroy();
        if(choice ==1){
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.tag= "destroy";
        cube.transform.position = new Vector3(-1, 0.5f, -5.0f);
        }
        else if(choice ==2){
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.tag= "destroy";
        sphere.transform.position = new Vector3(-1, 0.5f, -5.0f);
        }
        else if(choice ==3){
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.tag= "destroy";
        cylinder.transform.position = new Vector3(-1, 0.5f, -5.0f);
        }
        
        if(choice2 ==1){
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.tag= "destroy";
        cube.transform.position = new Vector3(1, 0.5f, -5.0f);
        }
        else if(choice2 ==2){
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.tag= "destroy";
        sphere.transform.position = new Vector3(1, 0.5f, -5.0f);
        }
        else if(choice2 ==3){
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.tag= "destroy";
        cylinder.transform.position = new Vector3(1, 0.5f, -5.0f);
        }
        
        if (choice==choice2){
        return 1;
        }
        else{
        return 0;
        }
    }


    public int getRandom()
    {
    
    int number = rnd.Next(1,4);
    print("Random = " + number);
    return number;
    }

    public void answerCompare(){
    
        //Destroy();
        if(headMove.answer ==1 && answer2==1 ){
        print("Good job!");
        response.text = "Good job!";
        setShapes();
        answer2= setShapes();
        headMove.answer=3;
        }
        else if(headMove.answer ==0 && answer2==0 ){
        print("Good job!");
        response.text = "Good job!";
        setShapes();
        answer2= setShapes();
        headMove.answer=3;
        }
        else if(headMove.answer ==1 && answer2==0)
        {
        print ("Woops!");
        response.text = "Woops wrong answer!";
        setShapes();
        answer2= setShapes();
        headMove.answer=3;
        }
        else if(headMove.answer ==0 && answer2==1)
        {
        print ("Woops!");
        response.text = "Woops wrong answer!";
        setShapes();
        answer2= setShapes();
        headMove.answer=3;
        }
        
    
    }
    
    public void Destroy(){
        int i =0;
    
        GameObject[] arrayofkill = GameObject.FindGameObjectsWithTag("destroy");
        for(i=0;i<arrayofkill.Length;i++){
        Destroy(arrayofkill[i]);
        }
 }
 
 

}
