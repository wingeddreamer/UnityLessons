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
        public string name;
        public int age;
        public genders gender;
        public bool passTest;
    }

    // Use this for initialization
	void Start () {
        students[] testList = new students[3];
        testList[0].name="Tommy";
        testList[0].age = 23;
        testList[0].gender = genders.male;
        testList[0].passTest = true;
        testList[1].name = "Mary";
        testList[1].age = 22;
        testList[1].gender = genders.female;
        testList[1].passTest = true;
        testList[2].name = "Susan";
        testList[2].age = 23;
        testList[2].gender = genders.female;
        testList[2].passTest = false;

        print(testList[0].name + "\t" + testList[0].age + "\t" + testList[0].gender + "\t" + testList[0].passTest);
        print(testList[1].name + "\t" + testList[1].age + "\t" + testList[1].gender + "\t" + testList[1].passTest);
        print(testList[2].name + "\t" + testList[2].age + "\t" + testList[2].gender + "\t" + testList[2].passTest);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
