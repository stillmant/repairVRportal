using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class countDown : MonoBehaviour
{
    public TextMeshProUGUI time;
    public int duration;
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
             SceneManager.LoadScene("loseEnding");
         }
     }
     void Update()
    {
        time.text = timeRemaining.ToString();  
    }
}
