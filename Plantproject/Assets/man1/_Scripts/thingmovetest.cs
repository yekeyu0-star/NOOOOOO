using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thingmovetest : MonoBehaviour
{
    public float bigthingsmove=1f;
    

    void Update()
    {
        transform.position +=   new Vector3(-bigthingsmove, 0,0) * Time.deltaTime;
    }
}
