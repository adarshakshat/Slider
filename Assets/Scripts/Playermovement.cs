using UnityEngine;

//This script have been apllied to our player using add component 
public class Playermovement : MonoBehaviour {

//    public float forwardforce = 200f;
    public float sidewayforce = 30f;
    public Rigidbody rb;
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        //Constant forward force force 
        //rb.AddForce(0,0,forwardforce * Time.deltaTime); 

        //better way to is to use transform new Position
        //This is Physics way
        if(Input.GetKey("d")){
            rb.AddForce(sidewayforce,0,0 * Time.deltaTime);

        }
        if(Input.GetKey("a")){
            rb.AddForce(-sidewayforce,0,0 * Time.deltaTime);

        }
        
    }
    
}