using UnityEngine;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    interface ImyInterface
    {
        void myMethod();
    }

    class baseClass : ImyInterface
    {
        public void myMethod() { print("Defined in base class."); }
    }

    class derivedClass : baseClass
    {
        new public void myMethod() { print("Overriden in derived class."); }
    }

	void Start () {
        derivedClass myInstance = new derivedClass();
        //当使用实例调用方法时，执行的是hide基类方法后的新方法
        myInstance.myMethod();

        ImyInterface interfaceInstance;
        interfaceInstance = myInstance;
        //派生类默认支持基类的接口
        //当使用接口调用方法时，虽然基类中的方法被hide了，但调用的仍是基类中的方法
        interfaceInstance.myMethod();
    }
	
}
