using UnityEngine;
using System.Collections;

public class Step3_1 : MonoBehaviour
{

    public class myClassA
    {
        public int myValueA;
        void myMethodA() { print("This is method A."); }

        //定义将myClassA实例转换为myClassB类的隐式转换
        public static implicit operator myClassB(myClassA op)
        {
            myClassB returnInstance = new myClassB();
            returnInstance.myValueB = op.myValueA;
            return returnInstance;
        }
    }

    public class myClassB
    {
        public float myValueB;
        void myMethodB() { print("This is method B."); }

        //定义将myClassB实例转换为myClassA类的显式转换
        public static explicit operator myClassA(myClassB op)
        {
            myClassA returnInstance = new myClassA();
            //使用checked后，假若无法成功转成整型便会抛出异常
            checked { returnInstance.myValueA = (int)op.myValueB; }
            return returnInstance;
        }
    }

    void Start()
    {
        //将myClassA类的实例隐式转换为myClassB类
        myClassA instanceA = new myClassA();
        myClassB instanceB = instanceA;

        //将myClassB类的实例显式转换为myClassA类
        myClassB instanceB2 = new myClassB();
        myClassA instanceA2 = (myClassA)instanceB2;
    }

}
