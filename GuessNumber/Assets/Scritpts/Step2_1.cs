using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    public Text inputNumber, hintText;
    public Button submitNum;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //只在有输入数字时才激活提交按钮
        if (inputNumber.text.Length > 0) submitNum.interactable = true;
        else submitNum.interactable = false;
    }

    public void judg1To100()
    {
        //判断输入值是否在合理范围内
        int inNum;
        inNum = int.Parse(inputNumber.text);
        if (inNum < 1) hintText.text = "你输入的数字小于1啦\n请输入1到100之间的整数";
        else if (inNum > 100) hintText.text = "你输入的数字大于100啦\n请输入1到100之间的整数";
        else hintText.text = "你的输入在合理的范围内\n等我想想下面怎么做";
    }
}
