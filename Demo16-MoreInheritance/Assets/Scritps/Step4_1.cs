using UnityEngine;
using System.Collections;

public class Step4_1 : MonoBehaviour {

    //抽象类只可继承不可实例化，继承时必须override所有成员
    public abstract class absClass
    {
        //抽象成员不可为private，不可含实现代码
        public abstract void absMethod();
        public abstract int absProp { get; set; }
    }
    //继承抽象类
    public class absInhClass : absClass
    {
        int intfield;
        override public void absMethod()
        {
            print("Override an abstract method.");
        }
        override public int absProp {
            get { return intfield; }
            set { intfield = value; }
        }
    }
    
    //普通类中不能包含抽象成员，但可包含虚成员
    public class baseClass
    {
        //抽象方法只能写在抽象类中
        //public abstract void absMethod();
        //public abstract int absInt { get; set; }
        
        //虚成员不可为private，可以含实现代码
        public virtual int virProp { get; set; }
        public virtual void virMethod() { print ("Virtual Method"); }
        public virtual void virMethod2() { print("Virtual Method 2"); }
    }

    public class derivedClass : baseClass
    {
        public override void virMethod() { print("Override Medthod"); }
    }

    //sealed class无法继承
    sealed class seaClass { }
    //public class seaInhClass : seaClass { }

    // Use this for initialization
    void Start () {
        baseClass baseClassInstance = new baseClass();
        derivedClass deriveClassInstacne = new derivedClass();
        baseClassInstance.virMethod();
        deriveClassInstacne.virMethod();
        //没有override过的虚方法采用基类中的实现
        baseClassInstance.virMethod2();
        deriveClassInstacne.virMethod2();
    }

    // Update is called once per frame
    void Update ()
    { 
	}
}
