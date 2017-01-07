using UnityEngine;
using System.Collections;

//必须是public static的类，并且是最外层的类
public static class ExtensionMethods2
{
    //扩展Unity内部定义的不可修改的类
    public static void restTransform (this Transform _tranform)
    {
        _tranform.position = Vector3.zero;
        _tranform.localRotation = Quaternion.identity;
        _tranform.localScale = new Vector3(1, 1, 1);
    }
}

public class Step2_1 : MonoBehaviour {

    public GameObject testObj;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            testObj.transform.restTransform();
        }
    }
}
