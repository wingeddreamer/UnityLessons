using UnityEngine;
using System.Collections;

public class Step3_1 : MonoBehaviour {

    class baseClass
    {
        int intVal;
        public baseClass() { print("Con. in base"); }
        //基类中定义了含一个参数的构造函数
        public baseClass(int i) { int Val = i; print("1 par. con. in base"); }
    }

    class derivedClass:baseClass
    {
        public derivedClass() { print("Con. in derived"); }
        //假若不指定调用哪个基类构造函数，则调用默认无参数的构造函数
        //public derivedClass(int i) { int Val = i; print("1 par. con. in derived"); }
        //制定调用baseClass(int i)这个构造函数，则先将j传递给基类构造函数，完成后再调用此构造函数
        public derivedClass(int j):base(j) { int Val = j; print("1 par. con. in derived"); }
    }

    class derivedClass2 : derivedClass
    {
        public derivedClass2() { print("Con. in derived2"); }
        //指定调用本实例的无参数构造函数，即derivedClass2()，调用该构造函数时再会层层回退到baseClass的无参数构造函数
        public derivedClass2(int k):this() { int Val = k; print("1 par. con. in derived2"); }
    }

    // Use this for initialization
    void Start () {
        //多层指定调用
        derivedClass2 derivedClassInstance2 = new derivedClass2(2);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
