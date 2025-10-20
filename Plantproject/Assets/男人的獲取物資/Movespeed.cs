using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movespeed : MonoBehaviour
     
{
    public float move=4f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += new Vector3(-move * Time.deltaTime, 0, 0);
        if (transform.position.x < -15)
        { 
        
        Destroy(gameObject);
        
        }
    }
}
