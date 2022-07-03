using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour{

    private Transform pumkinPos;
    private Pumpkin pumkinScript;

    public float zDistance = 7f;
    public float yDistance = 4f;

    private string PUMPKING_OBJ = "Pumkin";
    

    void Awake(){
        
        pumkinPos = GameObject.Find(PUMPKING_OBJ).transform;
        pumkinScript = pumkinPos.gameObject.GetComponent<Pumpkin>();
        

    }

    
    void Update(){
       
        
        SetPosition();
        
    }

    void SetPosition(){
        if (pumkinScript.isAlive){
            Vector3 temp = transform.position;
            temp.y = pumkinPos.position.y + yDistance;
            temp.z = pumkinPos.position.z - zDistance;
            transform.position = temp;
        }
    
    }


}// class
