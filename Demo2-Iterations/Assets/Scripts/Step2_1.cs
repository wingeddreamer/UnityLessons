using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    public Text inText,outText;
    int inNum;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void buttClick()
    {
        int currentIteration = 1;
        double calcResult = 1;
        int.TryParse(inText.text, out inNum);
        while (currentIteration <= inNum)
        {
            calcResult *= currentIteration;
            currentIteration++;
        }
        outText.text =calcResult.ToString();
    }
}
