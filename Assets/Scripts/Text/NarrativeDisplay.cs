using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NarrativeDisplay : MonoBehaviour
{
    public Text textDisplay;
    public GameObject activeNDObject;

    private int activeIndex = 0;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && DetectObject.ObjectInRange == true)
        {
            activeNDObject.SetActive(true);
            DisplayText();
            // Debug.Log(activeIndex);
        }
        else if (DetectObject.ObjectInRange == false)
        {
            activeNDObject.SetActive(false);
            activeIndex = 0;
        }
    }

    void DisplayText()
    {
        if(activeIndex < ActivateObject.sentence.NewSentence.Length)
        {
            textDisplay.text = ActivateObject.sentence.NewSentence[activeIndex];
            activeIndex += 1;
        }
        else
        {
            activeIndex = 0;
            activeNDObject.SetActive(false);
        }
    }
}
