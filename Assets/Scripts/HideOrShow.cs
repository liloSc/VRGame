using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideOrShow : MonoBehaviour
{
    public GameObject CanvasObj;
    public bool visible;
    public Text txt;
    public string planetName;


    private void Start()
    {
        CanvasObj.SetActive(visible);
    }

    public void hide()
    {
        CanvasObj.SetActive(false);
    }

    public void show()
    {
        setText(planetName);
        CanvasObj.SetActive(true);
    }

    public void setText(string name)
    {
        txt.GetComponent<UnityEngine.UI.Text>().text = name;
    }
  
}
