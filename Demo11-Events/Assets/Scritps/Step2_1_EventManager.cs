using UnityEngine;
using System.Collections;

public class Step2_1_EventManager : MonoBehaviour {

    public delegate void clickAction();
    public static event clickAction onClicked;
	public static int val1=5;
	
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void onButtonClick()
    {
		if (onClicked!=null) onClicked();
    }
}
