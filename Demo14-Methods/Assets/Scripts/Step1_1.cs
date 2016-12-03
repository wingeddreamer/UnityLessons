using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    public class myClass
    {
        public string name;
        public bool state;
        public int value;

        public void printInfo()
        {
            print("name:"+name+ "\t\tstate:" + state+ "\t\tvalue:" + value);
        }

        private int mul2X(int inputValue)
        {
            return inputValue * 2;
        }

        public void doubleValue()
        {
            value = mul2X(value);
        }
    }

	// Use this for initialization
	void Start () {
        myClass myInstance = new myClass();
        myInstance.name = "Test Instance";
        myInstance.state = true;
        myInstance.value = 123;
        myInstance.printInfo();
        // myInstance.mul2X();   //Private method cannot be used here
        myInstance.doubleValue();
        myInstance.printInfo();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
