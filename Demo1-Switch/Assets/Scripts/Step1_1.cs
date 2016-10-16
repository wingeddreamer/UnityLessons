using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        char InputKey;
        InputKey = Input.inputString[0];
        if (InputKey == '1'|| InputKey == 'r') gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.red;
        else if (InputKey == '2' || InputKey == 'o') gameObject.GetComponentInChildren<MeshRenderer>().material.color = new Color(1f, 0.4f, 0f);
        else if (InputKey == '3' || InputKey == 'y') gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.yellow;
        else if (InputKey == '4' || InputKey == 'g') gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.green;
        else if (InputKey == '5' || InputKey == 'c') gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.cyan;
        else if (InputKey == '6' || InputKey == 'b') gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.blue;
        else if (InputKey == '7' || InputKey == 'm') gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.magenta;
        else gameObject.GetComponentInChildren<MeshRenderer>().material.color = Color.gray;
    }
}
