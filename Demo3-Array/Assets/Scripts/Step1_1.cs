using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    public Text inText1, inText2, outText;
    int[,] multArray;

	// Use this for initialization
	void Start () {
        multArray = new int[9, 9];
        for(int i=1;i<=9; i++)
        {
            for(int j=1;j<=9;j++)
            {
                multArray[i-1, j-1] = i * j;
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void calcMult()
    {
        int v1, v2;
        int.TryParse(inText1.text,out v1);
        int.TryParse(inText2.text, out v2);
        outText.text = multArray[v1-1, v2-1].ToString();
    }
}