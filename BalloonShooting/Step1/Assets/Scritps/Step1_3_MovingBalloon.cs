using UnityEngine;
using System.Collections;

public class Step1_3_MovingBalloon : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector3(0f, 0.05f, 0f));
	}
}
