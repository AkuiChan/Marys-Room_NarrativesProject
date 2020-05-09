using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerDetection : MonoBehaviour
{
    // The computer has a hit box, but the monitor dont.
    // This changes a bool that is accesed in TextureChange.cs.
    public bool ComputerActive = false;

    private void OnTriggerEnter(Collider other)
    {
        ComputerActive = true;
    }

    private void OnTriggerExit(Collider other)
    {
        ComputerActive = false;
    }
}
