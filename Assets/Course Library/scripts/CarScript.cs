using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{   
 public float speed = 20;
 public float turnspeed = 45;
 public float horizontalInput;
 public float fowardInput;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
     void Update()
    {
        //move the veicle foward
        fowardInput = Input.GetAxis("Vertical"); 

        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * fowardInput);

        transform.Rotate(Vector3.up * turnspeed * horizontalInput * Time.deltaTime);
    }
}
