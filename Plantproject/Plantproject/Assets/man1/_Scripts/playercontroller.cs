using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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

        transform.position = new Vector3(-6, transform.position.y, transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigi2D.AddForce(transform.up * jumpforce);
        }
    }
}
