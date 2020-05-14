using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NarrativeDisplay : MonoBehaviour
{
    public Text textDisplay;        // UI text
    public GameObject activeND;     // Display object holding UI text and panel

    private int activeIndex = 0;    // Keeps track of the sentence index.

    [SerializeField]
    ActivateObject _activateObject;

    [SerializeField]
    TextureChange _textureChange;

    void Update()
    {
        if (DetectObject.ObjectInRange == true)
        {
            _activateObject = DetectObject.AO;
        }

        if (Input.GetKeyDown(KeyCode.F) && DetectObject.ObjectInRange == true)  // Player must be within an object and press key
        {
            activeND.SetActive(true);                   // Show Display object
            DisplayText();
        }
        else if (DetectObject.ObjectInRange == false)   // Hide Display Object and reset sentence index
        {
            activeND.SetActive(false);
            activeIndex = 0;
        }
    }

    void DisplayText()
    {
        if (activeIndex < _activateObject.sentence.NewSentence.Length)      // Display sentence[index] and increase index
        {
            textDisplay.text = _activateObject.sentence.NewSentence[activeIndex];
            activeIndex += 1;
        }
        else                                                                // Hide Display object and reset sentence index
        {
            activeIndex = 0;
            activeND.SetActive(false);
        }
        
        if (_textureChange.CountDone == true)
        {
            textDisplay.text = _textureChange.endSentence.NewSentence[0];
        }
    }
}
