using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WritingAssistant : MonoBehaviour
{
private Text messageText;
private string desiredText= "Introduction to our Space Game";

   private void Awake() {
        messageText= transform.Find("Intro_text").GetComponent<Text>();
        Application.targetFrameRate=3;
    }
    private void Start(){
      //  messageText.text="Hello Text";
        TextWriter.AddWriter_Static(messageText, desiredText, .1f, true);
          //textWriter.AddWriter(messageText, "Hello Text", .1f, true);
    }
 
}
