using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step3_1 : MonoBehaviour {

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
        double calcResult = 1;
        int.TryParse(inText.text, out inNum);
        for (int currentIteration = 1; currentIteration <= inNum; currentIteration++)
        {
            calcResult *= currentIteration;
        }
        
        outText.text =calcResult.ToString();
    }
}
