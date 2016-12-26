using UnityEngine;
using System.Collections;

public class containerClass
{
    public class pubClass { }
    internal class intClass { }
    protected class proClass { }
    //成员的可访问性可以高于类的可访问性？在private类里面定义public成员有何意义？
    private class priClass { protected int test; }

    public class testInheritance1 : pubClass { }
    //public class testInheritance2 : intClass { }
    internal class testInheritance2 : intClass { }
    protected class testInheritance3: proClass { }
    //为什么private class可以继承？
    private class testInheritance4 : priClass { }
}
public class testAccessibility
{
    containerClass.pubClass testInstance1;
    containerClass.intClass testInstance2;
    //containerClass.proClass testInstance3;
    //containerClass.priClass testInstance4;
}
public class testAccessibility2:containerClass
{
    containerClass.pubClass testInstance1;
    containerClass.intClass testInstance2;
    containerClass.proClass testInstance3;
    //containerClass.priClass testInstance4;
}

public class Step2_1 : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
