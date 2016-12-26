using UnityEngine;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    class baseClass { }
    class derivedClass:baseClass { }

    interface myInterface { }
    class classWithInterface:myInterface { }

	// Use this for initialization
	void Start () {
        baseClass baseClassInstance = new baseClass();
        derivedClass derivedClassInstance = new derivedClass();
        //假若<A>is<B>中，<A>是<B>或<B>的派生类的实例，则返回true
        print(derivedClassInstance is derivedClass);
        print(derivedClassInstance is baseClass);

        classWithInterface classWithInterfaceInstance = new classWithInterface();
        myInterface myInterfaceInstance = classWithInterfaceInstance;
        //接口变量与接口进行比较
        print(myInterfaceInstance is myInterface);
        //实例与接口进行比较
        print(classWithInterfaceInstance is myInterface);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
