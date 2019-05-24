using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsObject : MonoBehaviour
{

    protected Vector2  velocity; // other classes are going to inherit from physics objects and we want them to be able to access velocity
                                 // but we don´t want it to be accesible from outside of the class or from other classes that are not inheriting from it.
    protected Rigidbody2D rb2d;
    
    public float gravityModifier = 1f; // allow us to scale the gravity using a float 


    /// This function is called when the object becomes enabled and active.
    void OnEnable()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FixedUpdate(){
        velocity += gravityModifier * Physics2D.gravity * Time.deltaTime;

        Vector2 deltaPosition = velocity * Time.deltaTime;
        Debug.Log(deltaPosition.y);

        Vector2 move = Vector2.up * deltaPosition.y;
        Movement(move);
    }

    void Movement(Vector2 move){
        rb2d.position = rb2d.position + move;

    }
}
