using UnityEngine;
using System.Collections;

public class Step1_1_BalloonGenerator : MonoBehaviour {

    public GameObject balloon;

	// Use this for initialization
	void Start () {
        Instantiate(balloon);
        Instantiate(balloon, new Vector3(0, 5, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
