using UnityEngine;
using System.Collections;

public class Step3_1 : MonoBehaviour {

    //通过定义IHasAge界面来简化后面的代码
    interface IHasAge {
        int age { get; set; }
    }

    public class teacher : IHasAge
    {
        public string name { get; set; }
        public int age { get; set; }
        public float salary { get; set; }

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
    }

    public class student : IHasAge
    {
        public string name { get; set; }
        public int age { get; set; }
        public float score { get; set; }

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
    }

    public class compClass : IComparer
    {
        //创建一个同一类型的静态成员，以便于通过类名调用Compare方法而无需实例化IComparer类
        public static compClass Default = new compClass();

        public int Compare(System.Object objA, System.Object objB)
        {
            if (objA is IHasAge && objB is IHasAge)
            {
                return ((IHasAge)objA).age - ((IHasAge)objB).age;
            }
            else throw new System.ArgumentException("At least one object is not of valid type.");
        }
    }

    void Start () {
        teacher teacher1 = new teacher("Tom", 40, 4000);
        teacher teacher2 = new teacher("Susan", 32, 3200);
        teacher teacher3 = new teacher("Jackson", 38, 3500);
        teacher teacher4 = new teacher("John", 45, 4200);
        teacher teacher5 = new teacher("Jackson", 42, 5000);
        student student1 = new student("Jane", 18, 68.5f);
        student student2 = new student("Mary", 19, 85.5f);
        student student3 = new student("Peter", 22, 80);
        student student4 = new student("Lucy", 23, 75);
        student student5 = new student("Nick", 20, 62);

        //利用IComparer比较teacher1和Student1
        print(compClass.Default.Compare(teacher1,student1));

        //创建同时包含teacher和student类型对象的ArrayList
        ArrayList persons = new ArrayList();
        persons.Add(teacher1); persons.Add(teacher2); persons.Add(teacher3); persons.Add(teacher4); persons.Add(teacher5);
        persons.Add(student1); persons.Add(student2); persons.Add(student3); persons.Add(student4); persons.Add(student5);

        //利用IComparer进行排序
        persons.Sort(compClass.Default);
        //打印排序后的年龄
        print("");
        foreach (System.Object currPerson in persons)
        {
            if (currPerson is teacher) ((teacher)currPerson).printInfo();
            else if (currPerson is student) ((student)currPerson).printInfo();
        }
    }


    void Update () {
	
	}
}
