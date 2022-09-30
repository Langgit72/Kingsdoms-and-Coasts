using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialouge // JUST A CLASS
{
    public bool canBeSkipped;
    public string name;
    public string title;
    public string[] sentences;

    public NPC my_speaker;
}
