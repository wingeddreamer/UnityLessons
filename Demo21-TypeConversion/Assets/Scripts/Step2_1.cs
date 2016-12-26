using UnityEngine;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    interface myInterface { }

    class baseClass : myInterface { }
    class derivedClass:baseClass { }

    void Start () {
        baseClass baseClassInstance = new baseClass();
        derivedClass derivedClassInstance = new derivedClass();
        //基类实例无法转换为派生类，结果为null
        print (baseClassInstance as derivedClass);
        //派生类实例可以转换为基类，结果为派生类
        print (derivedClassInstance as baseClass);
        //基类实例可以转换为所支持的接口
        print(baseClassInstance as myInterface);
        //若基类实例支持某接口，则其派生类实例亦可转换为所支持的接口
        print(derivedClassInstance as myInterface);
	}
	
}
