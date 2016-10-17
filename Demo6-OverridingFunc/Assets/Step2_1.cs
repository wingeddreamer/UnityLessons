using UnityEngine;
using System.Collections;

public class Step2_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print(Combine(1,2,3,4,5));
        print(Combine(1.2f,5.3f,30.2f));
        print(Combine('a','b', 'c','d','e'));
        print(Combine("This", " is", " a", " test."));
	}
	
	// Update is called once per frame
	void Update () {
        	
	}


    int Combine(params int[] v)
    {
        int sum=0;
        for (int i = 0; i < v.Length; i++) sum += v[i];
        return sum;
    }
    float Combine(params float[] v)
    {
        float sum = 0;
        for (int i = 0; i < v.Length; i++) sum += v[i];
        return sum;
    }
    string Combine(params char[] v)
    {
        string sum = "";
        for (int i = 0; i < v.Length; i++) sum += v[i].ToString();
        return sum;
    }
    string Combine(params string[] v)
    {
        string sum = "";
        for (int i = 0; i < v.Length; i++) sum += v[i].ToString();
        return sum;
    }
}
