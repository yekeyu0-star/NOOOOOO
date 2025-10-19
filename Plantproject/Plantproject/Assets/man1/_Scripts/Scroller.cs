using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc : MonoBehaviour
{
    [SerializeField] private RawImage test;
    [SerializeField] private float x;

    // Update is called once per frame
    void Update()
    {
        test.uvRect = new Rect(test.uvRect.position + new Vector2(x, 0) * Time.deltaTime, test.uvRect.size);
    }
}
