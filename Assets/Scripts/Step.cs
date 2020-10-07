using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step : MonoBehaviour
{
    [TextArea (10, 50)] public string content;
    public Sprite spriteRoom;
    public Sprite spriteFace;

    public Step[] nextSteps;
    public Template template;

    public bool inTemplate;

}
