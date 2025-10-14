using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thingmovetest : MonoBehaviour
{
    public float bigthingsmove=1f;

    Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }
    void Update()
    {
        transform.position +=   new Vector3(-bigthingsmove, 0,0) * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = pos;
        }
    }
}
