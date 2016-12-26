using UnityEngine;
using System.Collections;

public class baseClass
{
    public int Pub_Base;
    internal int Int_Base;
    protected int Pro_Base;
    private int Pri_Base;
    int default_Base;
}

public class derivedClass:baseClass
{
    public void testAccessibility()
    {
        Pub_Base = 5;
        Int_Base = 10;
        Pro_Base = 15;
        //Pri_Base = 20;
        //default_Base = 25;
    }
}

public class independentClass
{
    baseClass baseClassInstance = new baseClass();
    public void testAccessibility()
    {
        baseClassInstance.Pub_Base = 5;
        baseClassInstance.Int_Base = 10;
        //baseClassInstance.Pro_Base = 15;
        //baseClassInstance.Pri_Base = 20;
    }
}

public class Step1_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
