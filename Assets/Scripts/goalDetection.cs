using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalDetection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "battery") {
            other.GetComponent<OVRGrabbable>().enabled = false;
            other.GetComponent<Renderer>().materials[0].color = Color.green;
            Debug.Log("ENTERED");
        }
    }
}
