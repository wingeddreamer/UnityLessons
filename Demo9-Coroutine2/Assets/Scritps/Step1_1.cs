using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    public Material ballMat;

	// Use this for initialization
	void Start () {
        ballMat.color = new Color(ballMat.color.r, ballMat.color.g, ballMat.color.b, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator fadeMat()
    {
        do
        {
            ballMat.color = new Color(ballMat.color.r, ballMat.color.g, ballMat.color.b, ballMat.color.a - 0.01f);
            yield return null;
        }
        while (ballMat.color.a > 0);
    }

    public void buttClk()
    {
        StartCoroutine(fadeMat());
    }
}
