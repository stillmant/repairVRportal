using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalMain : MonoBehaviour
{
    public blinkLight batt, hap1, hap2, hap3;
    public GameObject portal;
    private bool switchCol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (batt.done && hap1.done && hap2.done && hap3.done && !switchCol){
            portal.GetComponent<MeshRenderer>().materials[0].color = Color.green;
            gameObject.AddComponent<winEnding>();
            switchCol = true;
        }
    }
    
}