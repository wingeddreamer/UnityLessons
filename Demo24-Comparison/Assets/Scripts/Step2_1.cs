using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Step2_1 : MonoBehaviour {

    public class teacher : IComparable
    {
        public string name;
        public int age;
        public float salary;

        //构造函数
        public teacher() { }
        public teacher(string inName, int inAge, float inSalary)
        {
            name = inName; age = inAge; salary = inSalary;
        }

        public void printInfo()
        {
            print("Name: " + name + "\t" + "Age: " + age + "\t" + "Salary: " + salary);
        }

        public int CompareTo(object obj)
        {
            if (obj is teacher) return (age - ((teacher)obj).age);
            else if (obj is student) return (age - ((student)obj).age);
            else throw new ArgumentException("Operand is not an instance of a valid class.");
        }
    }

    public class student : IComparable
    {
        public string name;
        public int age;
        public float score;

        //构造函数
        public student() { }
        public student(string inName, int inAge, float inScore)
        {
            name = inName; age = inAge; score = inScore;
        }

        public void printInfo()
        {
            print("Name: " + name + "\t" + "Age: " + age + "\t" + "Score: " + score);
        }

        public int CompareTo(object obj)
        {
            if (obj is student) return (age - ((student)obj).age);
            else if (obj is teacher) return (age - ((teacher)obj).age);
            else throw new ArgumentException("Operand is not an instance of a valid class.");
        }
    }

    void Start () {
        teacher teacher1 = new teacher("Tom", 40, 4000);
        teacher teacher2 = new teacher("Susan", 32, 3200);
        teacher teacher3 = new teacher("Jackson",38, 3500);
        teacher teacher4 = new teacher("John", 45, 4200);
        teacher teacher5 = new teacher("Jackson", 42, 5000);
        
        //比较teacher1与teacher2
        print(teacher1.CompareTo(teacher2));

        List<teacher> teachers = new List<teacher>();
        teachers.Add(teacher1); teachers.Add(teacher2); teachers.Add(teacher3);
        teachers.Add(teacher4); teachers.Add(teacher5);

        //打印所有信息
        foreach (teacher currTeacher in teachers) currTeacher.printInfo();
        
        //排序后再次打印信息
        teachers.Sort();
        print("");
        foreach (teacher currTeacher in teachers) currTeacher.printInfo();

        student student1 = new student("Jane", 18, 68.5f);
        student student2 = new student("Mary", 19, 85.5f);
        student student3 = new student("Peter", 22, 80);
        student student4 = new student("Lucy", 23, 75);
        student student5 = new student("Nick", 20, 62);

        //比较teacher1与student1
        print("");
        print(teacher1.CompareTo(student1));

        //创建同时包含teacher和student类型对象的ArrayList
        ArrayList persons = new ArrayList();
        persons.Add(teacher1); persons.Add(teacher2); persons.Add(teacher3); persons.Add(teacher4); persons.Add(teacher5);
        persons.Add(student1); persons.Add(student2); persons.Add(student3); persons.Add(student4); persons.Add(student5);

        //打印ArrayList信息
        foreach(System.Object person in persons)
        {
            if (person is teacher) ((teacher)person).printInfo();
            else if (person is student) ((student)person).printInfo();
        }

        //对不同含类型对象的ArrayList进行排序，然后重新打印
        print("");
        persons.Sort();
        foreach (System.Object person in persons)
        {
            if (person is teacher) ((teacher)person).printInfo();
            else if (person is student) ((student)person).printInfo();
        }

    }

    void Update () {
	
	}
}
