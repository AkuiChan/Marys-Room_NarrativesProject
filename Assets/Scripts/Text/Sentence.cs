using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new sentence", menuName = "Sentence")]
public class Sentence : ScriptableObject
{
    [TextArea(2, 5)]
    public string[] NewSentence;

}
