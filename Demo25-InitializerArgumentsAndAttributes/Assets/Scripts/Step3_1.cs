using UnityEngine;
using System.Collections;
using System;

//指定所创建的特性可被用到类、方法、字段和属性上，并且允许被多次运用
[AttributeUsage(AttributeTargets.Class|AttributeTargets.Method|AttributeTargets.Field|AttributeTargets.Property , AllowMultiple =true)]
public class MyAttribute1 : Attribute
{
    public int Amount { get; set; }
    public string Label = "This is attribute 1.";
    public MyAttribute1 (int inAmount)
    {
        Amount = inAmount;
    }
}

//指定所创建的特性可被用到类、方法、字段和属性上，并且允许被多次运用
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Field |AttributeTargets.Property, AllowMultiple = true)]
public class MyAttribute2 : Attribute
{
    public string Label = "This is attribute 2.";
}

//应用特性到类
[MyAttribute1(6),MyAttribute2]
public class MyClass
{
    //应用特性到方法
    [MyAttribute1(88),MyAttribute2,MyAttribute1(99)]
    public void myMethod() { }

    //应用特性到字段
    [MyAttribute1(555), MyAttribute2]
    public string myField;
}

public class Step3_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //读取Class所附的特性
        print("Class Attributes:");
        Type myType = typeof(MyClass);
        System.Object[] attributes = myType.GetCustomAttributes(true);
        foreach(System.Object currAttribute in attributes)
        {
            if (currAttribute is MyAttribute1) print("Label: " + ((MyAttribute1)currAttribute).Label + "\tAmount: " + ((MyAttribute1)currAttribute).Amount);
            else if (currAttribute is MyAttribute2) print("Label: " + ((MyAttribute2)currAttribute));
        }
        
        //读取Method所附的特性
        print("Method Attributes:");
        foreach(Attribute currAttribute in Attribute.GetCustomAttributes(myType.GetMethod("myMethod")))
        {
            if (currAttribute is MyAttribute1) print("Label: " + ((MyAttribute1)currAttribute).Label + "\tAmount: " + ((MyAttribute1)currAttribute).Amount);
            else if (currAttribute is MyAttribute2) print("Label: " + ((MyAttribute2)currAttribute));
        }

        //读取Field所附的特性
        print("Field Attributes:");
        foreach(Attribute currAttribute in Attribute.GetCustomAttributes(myType.GetField("myField")))
        {
            if (currAttribute is MyAttribute1) print("Label: " + ((MyAttribute1)currAttribute).Label + "\tAmount: " + ((MyAttribute1)currAttribute).Amount);
            else if (currAttribute is MyAttribute2) print("Label: " + ((MyAttribute2)currAttribute));
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
