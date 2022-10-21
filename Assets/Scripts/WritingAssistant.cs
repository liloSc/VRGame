using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WritingAssistant : MonoBehaviour
{
private Text messageText;
private string desiredText="Welcome to the universe!"+ Environment.NewLine +
"You have been invited to an exciting expedition in space. Scientists talk about a mysterious incident, which has unfortunately caused all the planets to lose their position. Your task now is to put them back in the right place.";


   private void Awake() {
        messageText= transform.Find("Intro_text").GetComponent<Text>();
        Application.targetFrameRate=3;
    }
    private void Start(){
      //  messageText.text="Hello Text";
        TextWriter.AddWriter_Static(messageText, desiredText, .05f, true);
          //textWriter.AddWriter(messageText, "Hello Text", .1f, true);
    }
 
}
