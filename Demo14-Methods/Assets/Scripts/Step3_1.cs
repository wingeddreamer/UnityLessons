using UnityEngine;
using System.Collections;

public class Step3_1 : MonoBehaviour {

    public class Studentscore
    {
        public string name;
        public float score;
        static float totalScore;
        public Studentscore (string inputName, float inputScore)
        {
            name = inputName;
            score = inputScore;
            totalScore += inputScore;
        }
        public void printInfo() { print("Name:" + name + "     Score:" + score); }
        public static void printTotalScore() { print("Total score is:" + totalScore); }
    }

	// Use this for initialization
	void Start () {
        Studentscore student1 = new Studentscore("Tom", 60);
        Studentscore student2 = new Studentscore("Jerry", 80);
        Studentscore student3 = new Studentscore("Mary", 70);
        Studentscore student4 = new Studentscore("Susan", 95);
        student1.printInfo();
        student2.printInfo();
        student3.printInfo();
        student4.printInfo();
        Studentscore.printTotalScore();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}