using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    public Text people;
    public Text descriptionItemUp;
    public Text descriptionItemDwn;
    public Text answers;

    public Image imageRoom;
    public Image imageFace;

    public Step startStep;
    public Step currentStep;

    public Template currentTemplate;

   
    void Start()
    {
        //content.text = startStep.content;
        //imageBG.sprite = startStep.imageBG;
        //imageFace.sprite = startStep.imageFace;

        startStep.template.gameObject.SetActive(true);

  
        currentStep = startStep;
        currentTemplate = startStep.template;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchStepEndTemplate(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchStepEndTemplate(2);
        }
    }

    public void SwitchStepEndTemplate(int i)
    {
        i--;
        if (currentStep.inTemplate)
        {
            imageRoom.sprite = currentStep.nextSteps[i].spriteRoom;
            imageFace.sprite = currentStep.nextSteps[i].spriteFace;
            people.text = currentStep.nextSteps[i].content;
        }

        

        if (currentTemplate != currentStep.nextSteps[i].template)
        {
            currentStep.template.gameObject.SetActive(false);
            currentStep.nextSteps[i].template.gameObject.SetActive(true);
        }

        currentTemplate = currentStep.nextSteps[i].template;

        currentStep = currentStep.nextSteps[i];
    }
}
