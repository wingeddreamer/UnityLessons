using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step4_1 : MonoBehaviour {

    public Text inputNumber, hintText;
    public Button submitNum,replayGame;
    public InputField inField;
    int targetNum;

	// Use this for initialization
	void Start () {
        targetNum = Random.Range(1, 100);
        Debug.Log("目标数值："+targetNum);
	}
	
	// Update is called once per frame
	void Update () {
        //只在有输入数字时才激活提交按钮
        if (inputNumber.text.Length > 0) submitNum.interactable = true;
        else submitNum.interactable = false;
    }

    public void judge()
    {
        //判断输入值是否在合理范围内
        int inNum;
        inNum = int.Parse(inputNumber.text);
        if (inNum < 1) hintText.text = "你输入的数字小于1啦\n请输入1到100之间的整数";
        else if (inNum > 100) hintText.text = "你输入的数字大于100啦\n请输入1到100之间的整数";
        //判断猜测结果是否正确
        else if (inNum > targetNum) hintText.text = "你猜的数字太大啦，再试试吧";
        else if (inNum < targetNum) hintText.text = "你猜的数字太小啦，再试试吧";
        else if (inNum == targetNum)
        {
            hintText.text = "真聪明，你猜对了！";
            submitNum.gameObject.SetActive(false);
            replayGame.gameObject.SetActive(true);
            inField.interactable = false;
        }
    }

    //重玩游戏
    public void playAgain()
    {
        replayGame.gameObject.SetActive(false);
        submitNum.gameObject.SetActive(true);
        hintText.text = "我有一个1到100之间的整数\n猜猜看这个数字是几？";
        inField.text = "";
        inField.interactable = true;
        targetNum = Random.Range(1, 100);
        Debug.Log("目标数值：" + targetNum);
    }
}
