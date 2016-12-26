using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    interface ImyInterface
    {
        void myMethod1();
        void myMethod2();
    }

    class myClass: ImyInterface
    {
        //隐式实现接口方法
        public void myMethod1() { }
        //显示实现接口方法
        void ImyInterface.myMethod2() { }
    }

	void Start () {
        myClass myInstance = new myClass();
        ImyInterface interfaceInstance = myInstance;

        //隐式实现的方法，既可以通过实例或接口变量调用
        myInstance.myMethod1();
        interfaceInstance.myMethod1();
        //显式实现的方法，只能通过接口变量调用，不能通过实例变量调用
        //myInstance.myMethod2();
        interfaceInstance.myMethod2();
    }
	
}
