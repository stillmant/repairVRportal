using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hapticPuzzle : MonoBehaviour
{

    public OVRInput.Controller m_controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        switch(other.tag){
            case "1buzz":
                OVRInput.SetControllerVibration (1, 1, m_controller);
                break;
            case "2buzz":
                StartCoroutine(buzzTwice());
                break;
            case "3buzz":
                StartCoroutine(buzzThree());
                break;
            case "battery":
                OVRInput.SetControllerVibration (1, 1, m_controller);
                break;
            default:
                break;
        }
    }

    void OnTriggerExit(Collider other)
    {
        OVRInput.SetControllerVibration (0, 0, m_controller);
    }

    IEnumerator buzzTwice()
    {
        OVRInput.SetControllerVibration (1, 1, m_controller);
        yield return new WaitForSeconds(0.3f);
        OVRInput.SetControllerVibration (0, 0, m_controller);
        yield return new WaitForSeconds(0.3f);
        OVRInput.SetControllerVibration (1, 1, m_controller);
        yield return new WaitForSeconds(0.3f);
        OVRInput.SetControllerVibration (0, 0, m_controller);
        yield return new WaitForSeconds(0.6f);

    }

    IEnumerator buzzThree()
    {
        OVRInput.SetControllerVibration (1, 1, m_controller);
        yield return new WaitForSeconds(0.3f);
        OVRInput.SetControllerVibration (0, 0, m_controller);
        yield return new WaitForSeconds(0.3f);
        OVRInput.SetControllerVibration (1, 1, m_controller);
        yield return new WaitForSeconds(0.3f);
        OVRInput.SetControllerVibration (0, 0, m_controller);
        yield return new WaitForSeconds(0.3f);
        OVRInput.SetControllerVibration (1, 1, m_controller);
        yield return new WaitForSeconds(0.3f);
        OVRInput.SetControllerVibration (0, 0, m_controller);
        yield return new WaitForSeconds(0.6f);
    }
}
