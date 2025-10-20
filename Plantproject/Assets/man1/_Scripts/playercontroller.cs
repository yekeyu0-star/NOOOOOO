using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D rigi2D;
    public float jumpforce = 5f;   
    public bool isground = false;

    private void Start()
    {
        rigi2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
        if (transform.position.x < -6)
        {
            transform.position = new Vector3(-6, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isground)
        {
            isground = false;
            rigi2D.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isground = true;
        }
    }
}
