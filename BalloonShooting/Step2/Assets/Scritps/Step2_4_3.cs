using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Step2_4_3 : MonoBehaviour {

    const float totalTime = 120;
    public Text txt_Time, txt_Score;
    public GameObject panel_Restart;
    static public float TimeLeft = totalTime, Score = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (TimeLeft - Time.deltaTime <= 0) {
            TimeLeft = 0;
            panel_Restart.SetActive(true);
        }
        else {
            TimeLeft -= Time.deltaTime;
        }
        txt_Time.text = "Time Left: "+(Mathf.CeilToInt(TimeLeft)).ToString();
        txt_Score.text = "Score: " + Score;
	}

    public void buttClick_Restart()
    {
        TimeLeft = totalTime;
        Score = 0;
        panel_Restart.SetActive(false);
    }
}
