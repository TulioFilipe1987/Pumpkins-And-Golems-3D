using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumpkin : MonoBehaviour
{
    public float moveForce = 10f;

    private Rigidbody myBody;

    [HideInInspector]
    public bool isAlive;

   

    //private Vector3 initialPosition;

    void Awake(){
        myBody = GetComponent<Rigidbody>();
        isAlive = true;
    }


     void Update()
    {
        CheckBounds();
    }
    

    void FixedUpdate(){
        MoveThePumkin();
        
    }

    void MoveThePumkin(){

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        myBody.AddForce(new Vector3(h * moveForce, 0f, v * moveForce));
    
    }

    void CheckBounds(){   
        if(transform.position.y < -7){
            Time.timeScale = 0f;
        }
        
    }


    void OnTriggerEnter(Collider target){
        if(target.tag == "Golem"){
            Time.timeScale = 0f;
        
        }

        if(target.tag == "Gates"){
            Time.timeScale = 0f;
        }

        
    }





}// clss
