using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{   
 public float speed = 20f;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
     void Update()
    {
        //move the veicle foward
      
      transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
