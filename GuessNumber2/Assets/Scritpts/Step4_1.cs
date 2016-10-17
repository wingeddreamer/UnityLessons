using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step4_1 : MonoBehaviour {

    public GameObject firstStep, judgeGuess, feedBack, playAgain;
    int guessTarget, minV, maxV, currentGuess,oppLeft;
    const bool useGoldDiv = true;
    const int rangeMin=1,rangeMax=100,oppTotal = 10;

    // Use this for initialization
    void Start() {
        minV = rangeMin;
        maxV = rangeMax;
        guessTarget = Random.Range(minV, maxV);
        oppLeft = oppTotal;
        firstStep.transform.FindChild("text_AskToBegin").GetComponent<Text>().text = "请你在"+rangeMin.ToString()+"-"+rangeMax.ToString()+"之间选择一个整数\n我一共猜"+oppTotal.ToString()+"次，看我能不能猜对";
    }

    // Update is called once per frame
    void Update() {

    }

    public void beginGameClk()
    {
        firstStep.SetActive(false);
        judgeGuess.SetActive(true);
        currentGuess= calcResultFunc(minV, maxV);
        judgeGuess.transform.FindChild("text_Number").GetComponent<Text>().text = currentGuess.ToString();
    }

    public void tooSmallClk()
    {
        minV = currentGuess;
        if (oppLeft == 1 && currentGuess != guessTarget)
        {
            judgeGuess.SetActive(false);
            playAgain.SetActive(true);
            playAgain.transform.FindChild("text_FinalFeedback").GetComponent<Text>().text = "惜败！\n我们要不要再玩一次？";
        }
        else if (maxV - minV == 2)
        {
            judgeGuess.SetActive(false);
            playAgain.SetActive(true);
            playAgain.transform.FindChild("text_FinalFeedback").GetComponent<Text>().text = "我猜到了！\n你选的一定是"+(minV+1).ToString()+"\n我们要不要再玩一次？";
        }
        else if (maxV-minV==1)
        {
            judgeGuess.SetActive(false);
            playAgain.SetActive(true);
            playAgain.transform.FindChild("text_FinalFeedback").GetComponent<Text>().text = "不可能吧，你应该是在逗我玩！\n我们要不要再玩一次？";
        }
        else
        {
            judgeGuess.SetActive(false);
            feedBack.SetActive(true);
            feedBack.transform.FindChild("text_GuessResultFeedback").GetComponent<Text>().text = "哎呀，真遗憾！\n不过我还有" + (--oppLeft).ToString() + "次机会\n让我再来猜猜看";
        }
        print(minV.ToString() + "\t" + maxV.ToString());
    }

    public void tooBigClk()
    {
        maxV = currentGuess;
        if (oppLeft==1&&currentGuess!=guessTarget)
        {
            judgeGuess.SetActive(false);
            playAgain.SetActive(true);
            playAgain.transform.FindChild("text_FinalFeedback").GetComponent<Text>().text = "惜败！\n我们要不要再玩一次？";
        }
        else if (maxV - minV == 2)
        {
            judgeGuess.SetActive(false);
            playAgain.SetActive(true);
            playAgain.transform.FindChild("text_FinalFeedback").GetComponent<Text>().text = "我猜到了！\n你选的一定是" + (minV + 1).ToString() + "\n我们要不要再玩一次？";
        }
        else if (maxV - minV == 1)
        {
            judgeGuess.SetActive(false);
            playAgain.SetActive(true);
            playAgain.transform.FindChild("text_FinalFeedback").GetComponent<Text>().text = "不可能吧，你应该是在逗我玩！\n我们要不要再玩一次？";
        }
        else
        {
            judgeGuess.SetActive(false);
            feedBack.SetActive(true);
            feedBack.transform.FindChild("text_GuessResultFeedback").GetComponent<Text>().text = "哎呀，真遗憾！\n不过我还有" + (--oppLeft).ToString() + "次机会\n让我再来猜猜看";
        }
        print(minV.ToString() + "\t" + maxV.ToString());
    }
    public void rightClk()
    {
        judgeGuess.SetActive(false);
        playAgain.SetActive(true);
        playAgain.transform.FindChild("text_FinalFeedback").GetComponent<Text>().text = "看，我很聪明吧！\n我们要不要再玩一次？";
    }

    public void contClk()
    {
        feedBack.SetActive(false);
        judgeGuess.SetActive(true);
        currentGuess=calcResultFunc(minV, maxV);
        judgeGuess.transform.FindChild("text_Number").GetComponent<Text>().text = currentGuess.ToString();
    }

    public void playAgainClk()
    {
        Start();
        playAgain.SetActive(false);
        firstStep.SetActive(true);
    }

    public void quitClk()
    {
        Application.Quit();
    }

    int calcResultFunc(int intMin, int intMax)
    {
        float midNumber;
        if (useGoldDiv)
        {
            if (Random.Range(0f, 1f) > 0.5f) midNumber = (float)(intMin + (intMax - intMin) * 0.618);
            else midNumber = (float)(intMin + (intMax - intMin) * 0.382);
        }
        else
            midNumber = (intMin + intMax) / 2.0f;
        return (int)Mathf.Floor(midNumber);
    }
}
