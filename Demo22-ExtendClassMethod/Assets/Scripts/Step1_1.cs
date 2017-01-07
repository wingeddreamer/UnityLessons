using UnityEngine;
using System.Collections;

public class student
{
    public string name;
    public int age;
    public void printName() { MonoBehaviour.print("The name is: " + name); }
}

//必须是public static的类，并且是最外层的类
public static class ExtensionMethods
{
    //扩展自定义类
    public static void printAge(this student _student)
    {
        MonoBehaviour.print(_student.age);
    }
}

public class Step1_1 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        student studentInstance = new student();
        studentInstance.name = "Tom";
        studentInstance.age = 23;
        studentInstance.printName();
        studentInstance.printAge();
	}
	
	// Update is called once per frame
	void Update () {
    }
}
