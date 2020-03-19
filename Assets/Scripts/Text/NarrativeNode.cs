using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Line
{
    [TextArea(2, 5)]
    public string NarrativeText;
}

[CreateAssetMenu(fileName = ("Element"), menuName = ("Scriptable/NarrativeNodes"))]

public class NarrativeNode : ScriptableObject
{
    public string character;
    public Line[] lines;
}