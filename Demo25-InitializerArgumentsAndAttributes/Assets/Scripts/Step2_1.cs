using UnityEngine;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    public class teacher
    {
        public string name;
        public int age;
        public float salary;
        public bool inSchool;

        public void setFields (string inName, int inAge, float inSalary)
        {
            name = inName;
            age = inAge;
            salary = inSalary;
        }

        public void printInfo()
        {
            print("Name: " + name + "\tAge: " + age + "\tSalary: " + salary + "\tIn School: " + inSchool);
        }

        //通过给参数默认值，使它们成为可选参数
        public void setFields2 (string inName, int inAge=35, float inSalary=3500, bool inInSchool=true)
        {
            name = inName;
            age = inAge;
            salary = inSalary;
            inSchool = inInSchool;
        }
    }

    void Start () {
        teacher teacher1 = new teacher();
        teacher teacher2 = new teacher();

        //使用命名参数，则可以改变提供参数的顺序
        teacher1.setFields(inAge: 40, inSalary: 4000, inName: "Tom");
        teacher2.setFields(inAge: 32, inSalary: 3200, inName: "Susan");

        teacher teacher3 = new teacher();
        teacher teacher4 = new teacher();
        //若不提供可选参数，则这些参数将使用默认值
        teacher3.setFields2("Jackson");
        teacher3.printInfo();
        teacher4.setFields2("John", 45, 4200, false);
        teacher4.printInfo();
    }
	
	void Update () {
	
	}
}
