using UnityEngine;
using System.Collections;

public class Step2_2_Event1 : MonoBehaviour {

	void OnEnable() {
		Step2_1_EventManager.onClicked += changeSize;
	}

	void OnDisable() {
		Step2_1_EventManager.onClicked -= changeSize;
	}

	public void changeSize()
	{
		transform.localScale = new Vector3 (2f, 2f, 2f);
		print("change size");
	}
}
