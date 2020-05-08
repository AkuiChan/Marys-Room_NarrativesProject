using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DetectObject : MonoBehaviour
{
    public static bool ObjectInRange = false;
    public static ActivateObject AO;
    public GameObject InteractionPrompt;

    private void OnTriggerEnter(Collider other)
    {
        ObjectInRange = true;
        AO  = other.gameObject.GetComponent<ActivateObject>(); 
        InteractionPrompt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        ObjectInRange = false;
        InteractionPrompt.SetActive(false);
    }
}
