using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    public class myClass
    {
        public int myInt;
        public float myFloat = 5.0f;
        string myString="This is a test.";
    }

	// Use this for initialization
	void Start () {
        myClass myclassInstance = new myClass();
        myclassInstance.myInt = 10;
        //myclassInstance.myString = "This is not possible.";
        print(myclassInstance.myInt);
        print(myclassInstance.myFloat);
        //print(myclassInstance.myString);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
