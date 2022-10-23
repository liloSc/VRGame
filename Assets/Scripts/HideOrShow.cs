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
    public float PosX;
    public float PosY;
    public float PosZ;


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
        setPosition(PosX, PosY, PosZ);
        CanvasObj.SetActive(true);
    }

    public void setText(string name)
    {
        txt.GetComponent<UnityEngine.UI.Text>().text = name;
    }

    public void setPosition(float x, float y, float z)
    {
        Transform transform1 = CanvasObj.transform;
        transform1.position = new Vector3(x, y, z);
    }
  
}
