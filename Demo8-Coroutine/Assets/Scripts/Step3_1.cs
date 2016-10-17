using UnityEngine;
using System.Collections;

public class Step3_1: MonoBehaviour {

    GameObject[] cubes = new GameObject[10];
    int N = 0;

	// Use this for initialization
	void Start () {
        for(int i=0;i<10;i++) cubes[i] = transform.Find("/Cube ("+i.ToString()+")").gameObject;
        StartCoroutine(destroyGameObject1());
        //StartCoroutine(destroyGameObject2());
    }

    // Update is called once per frame
    void Update () {
        
    }

    IEnumerator destroyGameObject1()
    {
        Destroy(cubes[0]);
        yield return new WaitForSeconds(1);
        Destroy(cubes[1]);
        yield return new WaitForSeconds(1);
        Destroy(cubes[2]);
        yield return new WaitForSeconds(1);
        Destroy(cubes[3]);
        yield return new WaitForSeconds(1);
        Destroy(cubes[4]);
        yield return new WaitForSeconds(1);
        Destroy(cubes[5]);
        yield return new WaitForSeconds(1);
        Destroy(cubes[6]);
        yield return new WaitForSeconds(1);
        Destroy(cubes[7]);
        yield return new WaitForSeconds(1);
        Destroy(cubes[8]);
        yield return new WaitForSeconds(1);
        Destroy(cubes[9]);
    }

    IEnumerator destroyGameObject2()
    {
        for (int i = 0; i < 10; i++)
        {
            Destroy(cubes[i]);
            yield return new WaitForSeconds(1);
        }
    }
}
