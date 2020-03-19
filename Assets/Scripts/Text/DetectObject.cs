using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DetectObject : MonoBehaviour
{
    public static bool ObjectInRange = false;
    public static ActivateObject AO;


    private void OnTriggerEnter(Collider other)
    {
        ObjectInRange = true;
        AO  = other.gameObject.GetComponent<ActivateObject>();
        // Debug.Log(ObjectInRange);
        // Debug.Log(AO);      
    }

    private void OnTriggerExit(Collider other)
    {
        ObjectInRange = false;
        // Debug.Log(ObjectInRange);
    }
}
