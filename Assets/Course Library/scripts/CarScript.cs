using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{   

    
    // Start is called before the first frame update
    void Start()
    {
        public float speed = 20f;
    }

    // Update is called once per frame
     void Update()
    {
        //move the veicle foward
      
      transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
