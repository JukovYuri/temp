using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    public Text content;
    public Image imageBG;
    public Image imageFace;

    public Step startStep;
    public Step currentStep;

    public string currentTemplate;

   
    void Start()
    {

        content.text = startStep.content;
        imageBG.sprite = startStep.imageBG;
        imageFace.sprite = startStep.imageFace;
        content.text = startStep.content;

        currentStep = startStep;
        currentTemplate = currentStep.template.name;
    }


    void Update()
    {

            switch (currentTemplate)
            {
                case "Template_1":
                    { 
                        
                        break;
                    }

                case "Template_Room":
                    {

                        break;
                    }
                case "Template_Code":
                    {

                        break;
                    }
            }










            if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            imageBG.sprite = currentStep.nextSteps[0].imageBG;
            imageFace.sprite = currentStep.nextSteps[0].imageFace;
            content.text = currentStep.nextSteps[0].content;

            currentStep = currentStep.nextSteps[0];
            

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            imageBG.sprite = currentStep.nextSteps[1].imageBG;
            imageFace.sprite = currentStep.nextSteps[1].imageFace;
            content.text = currentStep.nextSteps[1].content;

            currentStep = currentStep.nextSteps[1];

        }
    }
}
