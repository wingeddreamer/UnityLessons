using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Step3_1 : MonoBehaviour {

    public class student
    {
        public int age;
        public int score; 
        public student(int inputAge, int inputScore)
        {
            age = inputAge;
            score = inputScore;
        }
    }

    // Use this for initialization
    void Start () {
        //定义一个字典
        Dictionary<string, student> myDictionary = new Dictionary<string, student>();
        //在字典中添加项目
        myDictionary.Add("Tom",new student(21,78));
        myDictionary.Add("Susan", new student(20, 85));
        myDictionary.Add("Nick", new student(22, 90));
        myDictionary.Add("Mary", new student(21, 88));
        
        //删除字典项目
        myDictionary.Remove("Nick");
        
        //访问字典项目
        print("Name: Susan   Age: " + myDictionary["Susan"].age+"  Score: "+myDictionary["Susan"].score);
        
        //假若Dictionary中不存在指定的键值，则会抛出异常；建议使用TryGetValue
        //print(myDictionary["Jackson"]);
        student outHolder=null;
        if (myDictionary.TryGetValue("Jackson", out outHolder))
            print("Out Holder's age is:" + outHolder.age);
        if (myDictionary.TryGetValue("Tom", out outHolder))
            print("Out Holder's age is:" + outHolder.age);

        //使用foreach循环
        foreach (string currentKey in myDictionary.Keys) print(currentKey);
        foreach (student currentValue in myDictionary.Values) print(currentValue.age+"\t"+currentValue.score);
        foreach (KeyValuePair<string, student> currentPair in myDictionary) print(currentPair.Key + "\t" + currentPair.Value.age + "\t" + currentPair.Value.score);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}