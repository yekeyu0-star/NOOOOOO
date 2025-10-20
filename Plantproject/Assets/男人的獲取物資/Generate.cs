using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject SunPrefab;
    public GameObject WaterPrefab;
    public GameObject FerPrefab;
    float span = 4f;
    float delta = 0;
    int ratio = 4;
    void Start()
    {
        
    }

    
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 11);
            if (dice <= ratio)
                item = Instantiate(SunPrefab);
            else if (dice <= ratio + 3)
                item = Instantiate(WaterPrefab);
            else
                item = Instantiate(FerPrefab);

            float y = Random.Range(-2.7f, 2f);
            item.transform.position=new Vector3 (15f, y, 0);



        }
        
        
    }
}
