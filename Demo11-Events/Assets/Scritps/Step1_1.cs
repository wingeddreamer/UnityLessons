using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

	void fun1 () {
		print ("This is function1.");
	}

	void fun2 () {
		print ("This is funciton2.");
	}

	void fun3 () {
		print ("This is funciton3.");
	}

	delegate void multFun();
	multFun testMultFun;

	// Use this for initialization
	void Start () {
		testMultFun += fun1;
		testMultFun += fun2;
		testMultFun += fun3;
		testMultFun += fun1;

		print ("step1");
		testMultFun ();

		testMultFun -= fun2;

		print ("step2");
		testMultFun ();

		testMultFun -= fun1;

		print ("step3");
		testMultFun ();

		testMultFun -= fun1;

		print ("step4");
		testMultFun ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
