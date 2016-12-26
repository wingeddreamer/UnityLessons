using UnityEngine;
using System.Collections;

public class Step5_1 : MonoBehaviour {

    public class baseClass
    {
        public void methodToHide() { print("Method to hide."); }
        public virtual void methodToOverride() { print("Method to override."); }
    }

    public class derivedClass:baseClass
    {
        new public void methodToHide() { print("A new method hides the baseClass method."); }
        public override void methodToOverride() { print("Overrides the baseClass method."); }
        public void useBaseMethod() { base.methodToOverride(); }
    }

	// Use this for initialization
	void Start () {
        baseClass baseClassInstance;
        derivedClass derivedClassInstance = new derivedClass();
        derivedClassInstance.methodToHide();
        derivedClassInstance.methodToOverride();
        //多态
        baseClassInstance = derivedClassInstance;
        baseClassInstance.methodToHide();
        baseClassInstance.methodToOverride();
        //只在派生类中才定义的方法，在利用多态赋予给基类变量后不能使用
        //baseClassInstance.useBaseMethod();
        //即便被override,但通过base关键词仍可调用基类方法
        derivedClassInstance.useBaseMethod();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
