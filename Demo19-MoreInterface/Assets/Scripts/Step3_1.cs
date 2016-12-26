using UnityEngine;
using System.Collections;

public class Step3_1 : MonoBehaviour {

    interface ImyInterface
    {
        void myMethod1();
        void myMethod2();
    }

    //注意：baseClass并不支持myInterface接口
    class baseClass
    {
        public void myMethod1() { }
    }

    //注意：在derivedClass中仅实现了myMethod2，而myMethod1是在baseClass中实现的
    class derivedClass : baseClass, ImyInterface
    {
        public void myMethod2() { }
    }

	void Start () {
    }
	
}
