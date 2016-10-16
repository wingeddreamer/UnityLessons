using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    public Text boxNum, ballNum, redNum, greenNum;
    GameObject[] allObjs;

    // Use this for initialization
    void Start () {
        allObjs = Resources.FindObjectsOfTypeAll<GameObject>();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void calcBox()
    {
        int boxCount = 0;
        foreach (GameObject currentObj in allObjs)
        {
            if (currentObj.activeInHierarchy && currentObj.ToString().Substring(0, 3) == "Box")
                boxCount++;
        }
        boxNum.text = boxCount.ToString();
    }

    public void calcBall()
    {
        int ballCount = 0;
        foreach (GameObject currentObj in allObjs)
        {
            if (currentObj.activeInHierarchy && currentObj.ToString().Substring(0, 4) == "Ball")
                ballCount++;
        }
        ballNum.text = ballCount.ToString();
    }

    public void calcRed()
    {
        int redCount = 0;
        foreach (GameObject currentObj in allObjs)
        {
            if (currentObj.activeInHierarchy && currentObj.GetComponent<MeshRenderer>()!=null)
            {
                if(currentObj.GetComponent<MeshRenderer>().material.name.Substring(0,3) == "Red") redCount++;
            }
        }
        redNum.text = redCount.ToString();
    }

    public void calcGreen()
    {
        int greenCount = 0;
        foreach (GameObject currentObj in allObjs)
        {
            if (currentObj.activeInHierarchy && currentObj.GetComponent<MeshRenderer>() != null)
            {
                if (currentObj.GetComponent<MeshRenderer>().material.name.Substring(0, 5) == "Green") greenCount++;
            }
        }
        greenNum.text = greenCount.ToString();
    }
}
