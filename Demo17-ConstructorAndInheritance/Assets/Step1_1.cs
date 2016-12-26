using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    class baseClass
    {
        int intVal;
        public baseClass() { print("Con. in base"); }
        //基类中定义了含一个参数的构造函数
        public baseClass(int i) { int Val = i; }
    }

    class derivedClass:baseClass
    {
        public derivedClass() { print("Con. in derived"); }
    }

    class derivedClass2 : derivedClass
    {
        public derivedClass2() { print("Con. in derived2"); }
    }

    // Use this for initialization
    void Start () {
        baseClass baseClassInstance = new baseClass(2);
        //派生类并不能继承基类中定义的含一个参数的构造函数
        //derivedClass derivedClass = new derivedClass(3);

        //在实例化派生类时，先要实例化其基类，逐步向上推，因此会从最基础的基类的构造函数开始逐步向下执行
        derivedClass2 derivedClass2Instance = new derivedClass2();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
