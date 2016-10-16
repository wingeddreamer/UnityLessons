using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step1_1 : MonoBehaviour {

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
        int currentIteration = 0;
        double calcResult = 1;
        int.TryParse(inText.text, out inNum);
        do
        {
            currentIteration++;
            calcResult *= currentIteration;
        }
        while(currentIteration<inNum);
        outText.text =calcResult.ToString();
    }
}
