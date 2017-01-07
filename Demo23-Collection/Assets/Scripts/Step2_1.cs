using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Step2_1 : MonoBehaviour {

    public class human
    {
        public string name;
        public human(string inputName)
        {
            name = inputName;
        }
    }

    public class animal
    {
        public string name;
    }

    void Start () {
        List<human> myList=new List<human>();
        //使用Add添加成员，不能添加不同类型的成员
        myList.Add(new human("Tom"));
        myList.Add(new human("Mary"));
        //myList.Add(new animal());
        //使用Insert添加成员
        myList.Insert(1, new human("Jane"));
        //取列表中成员总数
        print("Total Number of members: " + myList.Count);
        //使用IndexOf和LastIndexOf获取成员编号
        human targetHuman = new human("X");
        myList.Insert(2, targetHuman);
        myList.Add(targetHuman);
        print("Index of targetHuman: " + myList.IndexOf(targetHuman));
        print("Last index of targetHuman: " + myList.LastIndexOf(targetHuman));
        //访问成员
        myList[2].name = "Y";
        print("Now, changed to: " + myList[myList.LastIndexOf(targetHuman)].name);
        //foreach循环
        foreach (human iterator in myList) { print(iterator.name); }
	}
	
	void Update () {
	
	}
}
