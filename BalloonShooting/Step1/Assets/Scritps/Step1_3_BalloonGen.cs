using UnityEngine;
using System.Collections;

public class Step1_3_BalloonGen : MonoBehaviour {

    public GameObject balloon;

    // Use this for initialization
    void Start () {
        Instantiate(balloon);
        Instantiate(balloon, new Vector3(3, 0, 0), Quaternion.identity);
        Instantiate(balloon, new Vector3(-3, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
