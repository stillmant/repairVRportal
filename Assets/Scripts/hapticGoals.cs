using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hapticGoals : MonoBehaviour
{

    public bool buzz1;
    public bool buzz2;
    public bool buzz3;

    public GameObject lightHaptic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        switch(other.tag){
            case "1buzz":
                if(buzz1)
                {
                    CorrectAnswer(other);
                    lightHaptic.GetComponent<blinkLight>().done = true;
                }
                break;
            case "2buzz":
                if(buzz2)
                {
                    CorrectAnswer(other);
                    lightHaptic.GetComponent<blinkLight>().done = true;
                }
                break;
            case "3buzz":
                if(buzz3)
                {
                    CorrectAnswer(other);
                    lightHaptic.GetComponent<blinkLight>().done = true;
                }
                break;
            default:
                break;
        }

    }

    void CorrectAnswer(Collider other)
    {
        other.GetComponent<Renderer>().materials[0].color = Color.green;
		other.transform.position = transform.position;
		other.transform.rotation = transform.rotation;
		other.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }

    
}
