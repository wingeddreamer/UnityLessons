using UnityEngine;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    public Material ballMat;
    Coroutine testCoR;

	// Use this for initialization
	void Start () {
        ballMat.color = new Color(1f, 1f, 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	}

    IEnumerator fadeMat1()
    {
        do
        {
            ballMat.color = new Color(ballMat.color.r, ballMat.color.g, ballMat.color.b, ballMat.color.a - 0.01f);
            yield return null;

            //可以用yield break来终止Coroutine
            //if (ballMat.color.a <= 0.5f) yield break;
        }
        while (ballMat.color.a > 0);
    }

    IEnumerator fadeMat2(Color inColor)
    {
        do
        {
            ballMat.color = new Color(inColor.r, inColor.g, inColor.b, ballMat.color.a - 0.01f);
            yield return null;
        }
        while (ballMat.color.a > 0);
    }



    public void butt1Clk()
    {
        //Method 1.1，用字符串启动Coroutine，OK
        //StartCoroutine("fadeMat1");

        //Method 1.2，用字符串启动Coroutine并赋予给变量，OK
        //testCoR = StartCoroutine("fadeMat1");

        //Method 2，用字符串+一个参数启动Coroutine，OK
        //StartCoroutine("fadeMat2", new Color(1, 0, 0));

        //Method 3.1，用IEnumerator启动Coroutine，效率最高，但无法用StopCoroutine停止
        //StartCoroutine(fadeMat1());

        //Method 3.2，同3.1，但赋予变量后可停止
        testCoR= StartCoroutine(fadeMat1());
    }

    public void butt2Clk()
    {
        //Method 1.1，OK
        //StopCoroutine("fadeMat1");

        //Method 1.2，OK
        //StopCoroutine(testCoR);

        //Method 2，OK
        //StopCoroutine("fadeMat2");

        //Method 3.1，无效
        //StopCoroutine(fadeMat1());

        //Method 3.2，OK
        StopCoroutine(testCoR);
    }
}
