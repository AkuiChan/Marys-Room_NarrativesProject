using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public struct line
{
    [TextArea(2, 5)]
    public string text;
}

[CreateAssetMenu(fileName =("Element"),menuName =("Scriptable/NarrativeNodes"))]

public class NarrativeNode : ScriptableObject
{
    public string character;
    public line[] lines;
}
