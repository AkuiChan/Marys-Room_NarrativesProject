using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TextureChange : MonoBehaviour
{
    public Material InactiveScreen, ActiveScreen, ColorScreen;
    public ComputerDetection CD;
    public DetectObject DO;
    public bool CountDone = false;
    public UnityEvent ActiveEvent;
    public int Objects;
    public GameObject EndDisplay;

    public Sentence endSentence;

    Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // When the player is at the computer the screen turns on
        if(CD.ComputerActive == true && CountDone == false)
        {
            rend.material = ActiveScreen;
        }
        // If the player has interacted with x-amount of objects the scren turns on and shows color
        else if (DO.ObjectFinalCount >= Objects)
        {
            rend.material = ColorScreen;
            CountDone = true;
            EndDisplay.SetActive(true);
            
            ActiveEvent.Invoke();
        }
        // Turn screen off (unless x-amount of objects are interacted with)
        else
        {
            rend.material = InactiveScreen;
        }
    }
}
