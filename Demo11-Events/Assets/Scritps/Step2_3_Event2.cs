using UnityEngine;
using System.Collections;

public class Step2_3_Event2 : MonoBehaviour {

	void OnEnable() {
		Step2_1_EventManager.onClicked += changeColor;
	}

	void OnDisable() {
		Step2_1_EventManager.onClicked -= changeColor;
	}

	public void changeColor()
	{
		transform.GetComponent<MeshRenderer>().material.color=Color.red;
		print("change color");
	}
}
