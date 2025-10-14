using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D rigi2D;
    public float jumpforce = 1.5f;

    private void Start()
    {
      rigi2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigi2D.AddForce(transform.up * jumpforce);
        }
    }
}
