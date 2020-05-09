using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DetectObject : MonoBehaviour
{
    public static bool ObjectInRange = false;
    public static ActivateObject AO;
    public GameObject InteractionPrompt;
    public int ObjectFinalCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        ObjectInRange = true;
        AO  = other.gameObject.GetComponent<ActivateObject>(); 
        InteractionPrompt.SetActive(true);

        if(AO.ObjectCount == 0)
        {
            // Testing Object Increase Value
            AO.ObjectCount += 1;
            ObjectFinalCount += AO.ObjectCount;
            Debug.Log(AO.ObjectCount);
            Debug.Log(ObjectFinalCount);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ObjectInRange = false;
        InteractionPrompt.SetActive(false);
    }
}
