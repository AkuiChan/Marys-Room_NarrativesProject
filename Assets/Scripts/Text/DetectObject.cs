using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    public static bool ObjectInRange = false; 
    private void OnTriggerEnter(Collider other)
    {
        ObjectInRange = true;
        Debug.Log(ObjectInRange);
    }

    private void OnTriggerExit(Collider other)
    {
        ObjectInRange = false;
        Debug.Log(ObjectInRange);
    }
}
