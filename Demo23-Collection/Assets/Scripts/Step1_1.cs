using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {


    public class human
    {
        public string name;
        public human (string inputName)
        {
            name = inputName;
        }
    }

    public class animal
    {
        public string name;
    }

    void Start () {
        ArrayList myArrayList = new ArrayList();
        ArrayList anotherArrayList = new ArrayList();

        //添加对象
        //第一种添加方式
        myArrayList.Add(new human("Tom"));
        //第二种添加方式
        animal myAnimal = new animal();
        myAnimal.name = "Cow";
        myArrayList.Add(myAnimal);
        //第三种添加方式
        myArrayList.Insert(2, new human("Jerry"));
        //返回成员数量
        print("Amount of members: " + myArrayList.Count);
        //返回成员编号
        print("Index of myAnimal is: " + myArrayList.IndexOf(myAnimal));
        //添加另一个ArrayList
        anotherArrayList.Add(new human("Mary"));
        anotherArrayList.Add(new human("Jack"));
        myArrayList.AddRange(anotherArrayList);
        print("Amount of members: " + myArrayList.Count);
        //访问成员
        print("#2 member in the Array list is: "+((human)myArrayList[2]).name);
        //删除一个成员
        myArrayList.Remove(myAnimal);
        myArrayList.RemoveAt(0);
        print("Amount of members: " + myArrayList.Count);
        print("#0 member in the Array list is: " + ((human)myArrayList[0]).name);
        //使用foreach循环
        myArrayList.Add(new human("Susan"));
        myArrayList.Add(new human("Mike"));
        myArrayList.Add(new human("Lucy"));
        foreach(human iterator in myArrayList) { print(iterator.name); }
        //若其中包含有其它类型的对象，则原来的foreach命令便会抛出异常
        myArrayList.Add(myAnimal);
        //foreach (human iterator in myArrayList) { print(iterator.name); }
        foreach (System.Object iterator in myArrayList) {
            if (iterator is human) print("Human: " + ((human)iterator).name);
            else print("Animal: " + ((animal)iterator).name);
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
