using UnityEngine;
using TMPro;  

public class Supplies : MonoBehaviour
{
    public float timer = 0f;           

    
    public float sunScore = 0f;
    public float waterScore = 0f;
    public float ferScore = 0f;

   
    private TMP_Text sunText;
    private TMP_Text waterText;
    private TMP_Text ferText;

    
    public float waterValue = 2f;
    public float ferValue = 2f;

    void Start()
    {
       
        sunText = GameObject.Find("SunUI").GetComponent<TMP_Text>();
        waterText = GameObject.Find("WaterUI").GetComponent<TMP_Text>();
        ferText = GameObject.Find("FerUI").GetComponent<TMP_Text>();
    }

    void Update()
    {
        timer += Time.deltaTime;

       
        if (sunText) sunText.text = "Sun: " + sunScore.ToString("0");
        if (waterText) waterText.text = "Water: " + waterScore.ToString("0");
        if (ferText) ferText.text = "Fer: " + ferScore.ToString("0");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sun"))
        {
            float addValue = GetValueByTime();
            sunScore += addValue;
            
        }
        else if (other.CompareTag("Water"))
        {
            waterScore += waterValue;
            
        }
        else if (other.CompareTag("Fer"))
        {
            ferScore += ferValue;
            
        }

        Destroy(other.gameObject);
    }

    
    float GetValueByTime()
    {
        if (timer < 10f)
            return 1f; 
        else if (timer >= 10f && timer < 30f)
            return 3f; 
        else if (timer >= 30f && timer < 50f)
            return 5f; 
        else
            return 5f; 
    }
}
