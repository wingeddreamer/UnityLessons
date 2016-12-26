using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    class baseClass
    {
        public int intInBaseClass = 123;
        public void methodInBaseClass() { print("Method in base class. " + intInBaseClass); }
    }

    class derivedClass: baseClass
    {
        public int intInDerivedClass = 234;
        public void methodInDerivedClass() { print("Method in derived class. "+intInDerivedClass); }
    }

	// Use this for initialization
	void Start () {
        baseClass instanceBaseClass = new baseClass();
        derivedClass instanceDerivedClass = new derivedClass();
        //基类实例调用基类方法
        instanceBaseClass.methodInBaseClass();
        //派生类实例调用派生类方法
        instanceDerivedClass.methodInDerivedClass();
        //派生类实例调用基类公共字段
        print(instanceDerivedClass.intInBaseClass);
        //派生类实例调用基类公共方法
        instanceDerivedClass.methodInBaseClass();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
