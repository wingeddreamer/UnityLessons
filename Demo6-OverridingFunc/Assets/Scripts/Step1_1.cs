using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print(Combine(2,3));
        print(Combine(1.2f,5.3f));
        print(Combine('a', 'c'));
        print(Combine("This", "is"));
	}
	
	// Update is called once per frame
	void Update () {
        	
	}


    int Combine(int v1, int v2)
    {
        return v1 + v2;
    }
    float Combine(float v1, float v2)
    {
        return v1 + v2;
    }
    string Combine(char v1, char v2)
    {
        return v1.ToString() + v2.ToString();
    }
    string Combine(string v1, string v2)
    {
        return v1 + v2;
    }
}
