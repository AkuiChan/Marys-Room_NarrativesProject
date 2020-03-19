using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateObject : MonoBehaviour
{
    public Sentence ObjectSentence;
    public static Sentence sentence;

    // Start is called before the first frame update
    void Start()
    {
        // sentence = ObjectSentence;
    }

    void Update()
    {
        if (DetectObject.ObjectInRange == true)
        {
            sentence = ObjectSentence;
        }
    }
}
