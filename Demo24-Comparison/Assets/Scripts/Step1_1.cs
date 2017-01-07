using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    public class teacher
    {
        string name;
        int age;
        float salary;

        //构造函数
        public teacher() { }
        public teacher (string inName, int inAge, float inSalary)
        {
            name = inName;age = inAge;salary = inSalary;
        }

        public void printInfo()
        {
            print("Name: " + name + "\t" + "Age: " + age + "\t" + "Salary: " + salary);
        }

        //重载运算符+
        public static teacher operator + (teacher op1, teacher op2)
        {
            teacher tempVal = new teacher();
            tempVal.name = op1.name + " and " + op2.name;
            tempVal.age = op1.age + op2.age;
            tempVal.salary = op1.salary + op2.salary;
            return tempVal;
        }

        //重载运算符>，判据为年龄
        public static bool operator > (teacher op1, teacher op2)
        {
            if (op1.age > op2.age) return true;
            else return false;
        }
        //必须成对重载>和<，在重载<时可以调用已经重载过的>运算符
        public static bool operator <(teacher op1, teacher op2)
        {
            if (op1 > op2) return false;
            else return true;
        }
    }

	// Use this for initialization
	void Start () {
        teacher teacher1 = new teacher("Tom", 40, 4000);
        teacher teacher2 = new teacher("Susan", 32, 3200);
        teacher sumTeacher = teacher1 + teacher2;
        sumTeacher.printInfo();
        print("teacher1 > teacher2: "+(teacher1 < teacher2));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
