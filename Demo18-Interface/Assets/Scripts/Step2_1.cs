using UnityEngine;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    interface ImyInterface1
    {
        int myIntVal { get; set; }
        void myMethod1(string inStr);
    }

    interface ImyInterface2
    {
        float myFloatVal { get; }
        void myMethod2();
    }

    class myClass: ImyInterface1, ImyInterface2
    {
        int _myIntVal;
        float _myFloatVal;
        public int myIntVal
        {
            get { return _myIntVal; }
            set { _myIntVal = value; }
        }

        public void myMethod1 (string inputString)
        {
            print("The input string is: " + inputString);
        }

        public float myFloatVal
        {
            get { return 3.1415f; }
        }

        public void myMethod2 ()
        {
            print("This is MyMethod2.");
        }
    }

	// Use this for initialization
	void Start () {
        myClass myInstance = new myClass();
        ImyInterface1 inter1;
        ImyInterface2 inter2;
        inter1 = myInstance;
        inter2 = myInstance;
        inter1.myMethod1("test String");
        //inter1.myMethod2();
        inter2.myMethod2();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
