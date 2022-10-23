using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideOrShow : MonoBehaviour
{
    public GameObject CanvasObj;
    public bool visible;
    public Text title;
    public string planetName;
    public RawImage planetImage;
    public Texture sourceImg;

    public Text information;
    public string planetInfo;
    public Text diameter;
    public string diameterString;
    public Text distance;
    public string distanceString;
    public Text mass;
    public string massString;
    public Text orbitalPeriod;
    public string orbitalPeriodStr;
    public Text moons;
    public string moonsString;

    public float PosX;
    public float PosY;
    public float PosZ;

    public float RotX;
    public float RotY;
    public float RotZ;


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
        setText(planetName, planetInfo, diameterString, distanceString, massString, orbitalPeriodStr, moonsString);
        setPosANDRot(PosX, PosY, PosZ, RotX, RotY, RotZ);
        setImage(sourceImg);
        CanvasObj.SetActive(true);
    }

    public void setText(string name, string info, string di, string dist, string mas, string orb, string mo)
    {
        title.GetComponent<UnityEngine.UI.Text>().text = name;
        information.GetComponent<UnityEngine.UI.Text>().text = info;
        diameter.GetComponent<UnityEngine.UI.Text>().text = di;
        distance.GetComponent<UnityEngine.UI.Text>().text = dist;
        mass.GetComponent<UnityEngine.UI.Text>().text = mas;
        orbitalPeriod.GetComponent<UnityEngine.UI.Text>().text = orb;
        moons.GetComponent<UnityEngine.UI.Text>().text = mo;
    }

    public void setPosANDRot(float px, float py, float pz, float rx, float ry, float rz)
    {
        Transform transform1 = CanvasObj.transform;
        transform1.position = new Vector3(px, py, pz);
        transform1.rotation = new Quaternion(rx, ry, rz,0);
    }


    public void setImage(Texture source)
    {
        planetImage.texture = source;
    }
  
}
