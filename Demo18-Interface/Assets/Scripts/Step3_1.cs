using UnityEngine;
using System.Collections;

public class Step3_1 : MonoBehaviour {

    interface ImyInterface
    {
        float internalValue { get; set; }
        void printDoubleValue(float inputVal);
    }

    class myClass1 : ImyInterface
    {
        float _intValue;
        public float internalValue
        {
            get { return _intValue; }
            set { _intValue = value; }
        }
        public void printDoubleValue (float inputVal)
        {
            print("Double value:"+inputVal*2);
        }
    }

    class myClass2: ImyInterface
    {
        public float internalValue { get; set; }
        public void printDoubleValue(float inputVal)
        {
            print("Double value:" + internalValue * 2);
        }

    }

    class myClass3
    {
        public static void testInterfaceParameter (ImyInterface inputInstance)
        {
            inputInstance.printDoubleValue(3.14f);
        }
    }

    // Use this for initialization
    void Start () {
        myClass1 instance1= new myClass1();
        instance1.internalValue = 2.5f;
        myClass2 instance2 = new myClass2();
        instance2.internalValue = 2.5f;

        ImyInterface interfaceInstance;

        interfaceInstance = instance1;
        myClass3.testInterfaceParameter(interfaceInstance);

        interfaceInstance = instance2;
        myClass3.testInterfaceParameter(interfaceInstance);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
