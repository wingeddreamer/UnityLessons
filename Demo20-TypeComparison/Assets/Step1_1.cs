using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    int testVal;
    class testClass { }

	// Use this for initialization
	void Start () {
        print(testVal.GetType());
        print(testVal.GetType()==typeof(int));
        testClass testInstance = new testClass();
        print(testInstance.GetType());
        print(testInstance.GetType() == typeof(testClass));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
