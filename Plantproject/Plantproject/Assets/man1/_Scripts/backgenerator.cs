using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backmove : MonoBehaviour
{
    public GameObject boa;
    public float span;
    float delta = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        span = Random.Range(5.0f, 10.0f);
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject board = Instantiate(boa);
            board.transform.position = new Vector3(14, 0.1f, 0);
        }
    }
}
