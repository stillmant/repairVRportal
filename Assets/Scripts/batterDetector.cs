using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batterDetector : MonoBehaviour
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
			Destroy(other.GetComponent<OVRGrabbable>());
			other.GetComponent<Renderer>().materials[0].color = Color.green;
			other.transform.position = transform.position;
			other.transform.rotation = transform.rotation;
			other.transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
			//Debug.Log("ENTERED");
		}
	}
}
