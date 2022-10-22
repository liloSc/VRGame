using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOrShow : MonoBehaviour
{
    public GameObject CanvasObj;

    public void hide()
    {
        CanvasObj.SetActive(false);
    }

    public void show()
    {
        CanvasObj.SetActive(true);
    }
  
}
