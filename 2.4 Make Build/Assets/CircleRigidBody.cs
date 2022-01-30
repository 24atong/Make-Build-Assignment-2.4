using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRigidBody : MonoBehaviour
{

    Vector3 original;
    public GameObject square;

    void Start()
    {
        square = GameObject.Find("Square");
    }

    void Update()
    {
        if(square.transform.position.x>3){
            this.transform.localScale = this.transform.localScale + new Vector3(2f,2f,2f) * Time.deltaTime;
        }

        if(square.transform.position.x<3){
            transform.localScale = new Vector3(1,1,1);
        }
    }
}
