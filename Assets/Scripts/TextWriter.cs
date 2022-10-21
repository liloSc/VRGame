using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{

    private static TextWriter instance; 
    //Responsible for receiving the function

    private List<TextWriterSingle> textWriterSingleList;

    private void Awake(){
        instance=this;
        textWriterSingleList= new List<TextWriterSingle>();
    }

    public static void AddWriter_Static(Text uiText, string textToWrite, float timePerCharacter, bool invisibleCharacters){
        instance.AddWriter(uiText,textToWrite, timePerCharacter,invisibleCharacters);
    }

    public void AddWriter(Text uiText, string textToWrite, float timePerCharacter, bool invisibleCharacters){
    textWriterSingleList.Add(new TextWriterSingle(uiText,textToWrite, timePerCharacter,invisibleCharacters));
    }
    private void Update(){
          Debug.Log(textWriterSingleList.Count);
        for( int i=0; i<textWriterSingleList.Count; i++){
 /*if(textWriterSingle!=null){
            textWriterSingle.Update();
        }*/
      bool destroyInstance=  textWriterSingleList[i].Update();
      if(destroyInstance){
        textWriterSingleList.RemoveAt(i);
        i--;
      }
        }
       
    }
 /*  private Text uiText;
   private string textToWrite;
   private int characterIndex;
   private float timePerCharacter;
   private float timer; 
   private bool invisibleCharacters;

   public void AddWriter(Text uiText, string textToWrite, float timePerCharacter, bool invisibleCharacters){
    this.uiText= uiText;
    this.textToWrite= textToWrite;
    this.timePerCharacter= timePerCharacter;
    this.invisibleCharacters=invisibleCharacters;
    characterIndex=0; 

   }*/
 
/* Represents a single TextWriter instance
*/
   public class TextWriterSingle{
     private Text uiText;
   private string textToWrite;
   private int characterIndex;
   private float timePerCharacter;
   private float timer; 
   private bool invisibleCharacters;

    public TextWriterSingle(Text uiText, string textToWrite, float timePerCharacter, bool invisibleCharacters){
         this.uiText= uiText;
    this.textToWrite= textToWrite;
    this.timePerCharacter= timePerCharacter;
    this.invisibleCharacters=invisibleCharacters;
    characterIndex=0; 

    }
    //returns true when complete
  public bool Update(){
 
        timer-=Time.deltaTime; 
        while(timer<=0f){
            //Display next character
           timer+=timePerCharacter; 
           characterIndex++; 
           string text=textToWrite.Substring(0,characterIndex);
           if(invisibleCharacters){
             text+="<color=#00000000>"+textToWrite.Substring(characterIndex)+"</color>";
           }
           uiText.text=text;

        if(characterIndex>= textToWrite.Length){
            uiText=null; 
            return true;
        }
        }
        return false; 
    }
   
   }
}
