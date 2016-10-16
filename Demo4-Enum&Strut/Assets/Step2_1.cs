using UnityEngine;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    enum genders
    {
        male,
        female
    }

    struct students
    {
        string name;
        int age;
        genders gender;
        bool passTest;
        public void addInfo(string inName, int inAge, genders inGender, bool inPass)
        {
            name = inName;
            age = inAge;
            gender = inGender;
            passTest = inPass;
        }
        public void printStudentInfo(bool nameAndTestOnly)
        {
            if (nameAndTestOnly)
                print("name:" + name + "\tPasstest?:" + passTest);
            else
                print("Name:" + name + "\tAge:" + age + "\tGender:" + gender +"\tPasstest?:"+passTest);
        }
    }

    // Use this for initialization
	void Start () {
        students[] testList = new students[5];
        testList[0].addInfo("Tommy", 23, genders.male, true);
        testList[1].addInfo("Mary", 22, genders.female, true);
        testList[2].addInfo("Susan", 23, genders.female, false);
        testList[3].addInfo("Monika", 21, genders.female, true);
        testList[4].addInfo("Scott", 22, genders.male, false);

        foreach (students currentStudent in testList)
        {
            currentStudent.printStudentInfo(false);
        }

        foreach (students currentStudent in testList)
        {
            currentStudent.printStudentInfo(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
