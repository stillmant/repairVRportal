using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blinkLight : MonoBehaviour
{
	public GameObject lightDome;

	public bool done = false;

	public Material dRed;
	public Material bRed;
	public Material bGreen;
    // Start is called before the first frame update
    void Start()
    {
		lightDome.GetComponent<MeshRenderer>().material = dRed;
		StartCoroutine(red());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	IEnumerator red()
	{
		while (!done){
			lightDome.GetComponent<MeshRenderer>().material = dRed;
			yield return new WaitForSeconds(0.3f);
			lightDome.GetComponent<MeshRenderer>().material = bRed;
			yield return new WaitForSeconds(0.3f);
		}
		lightDome.GetComponent<MeshRenderer>().material = bGreen;
	}
}
