using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    class baseClass { }
    class derivedClass:baseClass { }
    class independentClass { }

	// Use this for initialization
	void Start () {
        baseClass baseClassInstance1,baseClassInstance2;
        derivedClass derivedClassInstance = new derivedClass();
        //隐式类型转换
        baseClassInstance1 = derivedClassInstance;
        //显式类型转换
        baseClassInstance2 = (baseClass)derivedClassInstance;

        independentClass independentClassInstance;
        //不相关的类不能进行隐式转换或者显式转换
        //independentClassInstance = derivedClassInstance;
        //independentClassInstance = (independentClass)derivedClassInstance;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
