using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareRigidBody : MonoBehaviour
{
    public int startxposition = 0;
    public int startyposition = 0;
    public int endxposition = 5;
    public int endyposition = 5;
    int speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //moving "Square" and snapping back "Square" to original location
        if (transform.position.x>endxposition || transform.position.y>endyposition){
            transform.position = new Vector2(startxposition, startyposition);
            Debug.Log(startxposition);
            Debug.Log(startyposition);
        }
        else{
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }
}
