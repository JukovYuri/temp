using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step : MonoBehaviour
{
    [TextArea (10, 50)] public string content;
    public Sprite imageBG;
    public Sprite imageFace;

    public Step[] nextSteps;
    public Template template;

}
