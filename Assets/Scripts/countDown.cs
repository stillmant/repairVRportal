using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class countDown : MonoBehaviour
{
    /*
    public TextMeshProUGUI time;
    private int totalTime = 180;
    float subtract = 0;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        time.text = totalTime.ToString();   
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;  
        subtract = timer % 60;
        time.text = (totalTime-subtract).ToString();  
    }
    */
    public TextMeshProUGUI time;
    public int duration = 180;
     public int timeRemaining;
     public bool isCountingDown = false;
     void Start()
     {
         if (!isCountingDown) {
             isCountingDown = true;
             timeRemaining = duration;
             Invoke ( "tick", 1f );
         }
     }
 
     private void tick() {
         timeRemaining--;
         if(timeRemaining > 0) {
             Invoke ( "tick", 1f );
         } else {
             isCountingDown = false;
         }
     }
     void Update()
    {
        time.text = timeRemaining.ToString();  
    }
}
