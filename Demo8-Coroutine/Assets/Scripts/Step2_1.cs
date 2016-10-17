using UnityEngine;
using System.Collections;

public class Step2_1: MonoBehaviour {

    GameObject[] cubes = new GameObject[10];
    int N = 0;

	// Use this for initialization
	void Start () {
        for(int i=0;i<10;i++) cubes[i] = transform.Find("/Cube ("+i.ToString()+")").gameObject;
        InvokeRepeating("DestroyGameObject", 5f, 1f);
    }

    // Update is called once per frame
    void Update () {
        if (N > 9) CancelInvoke("DestroyGameObject");
    }

    void DestroyGameObject ()
    {
        Destroy(cubes[N++]);
    }
}
