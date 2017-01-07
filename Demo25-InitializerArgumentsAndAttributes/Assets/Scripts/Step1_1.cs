using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Step1_1 : MonoBehaviour {

    public class teacher
    {
        public string name;
        public int age;
        public float salary;
    }

    void Start () {

        //使用对象初始化器进行字段或属性赋值
        teacher teacher1 = new teacher { name = "Tom", age = 40, salary = 4000 };
        //可以对部分字段或属性赋值
        teacher teacher2 = new teacher { name = "Susan", age = 32 };
        teacher2.salary = 3200;

        //可以用var和初始化器对数组或集合进行初始化
        var teachers = new teacher[]
        {
            new teacher {name = "Jackson", age = 38, salary = 3500 },
            new teacher {name = "John", age = 45, salary = 4200 },
            new teacher {name ="Jackson", age = 42, salary = 5000 }
        };

        var teachers2 = new List<teacher>
        {
            new teacher {name = "Jackson", age = 38, salary = 3500 },
            new teacher {name = "John", age = 45, salary = 4200 },
            new teacher {name ="Jackson", age = 42, salary = 5000 }
        };
    }                    
	
	void Update () {
	
	}
}
