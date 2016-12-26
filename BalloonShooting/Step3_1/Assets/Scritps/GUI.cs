using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUI : MonoBehaviour {

    const float totalTime = 20;
    public Text txt_Time, txt_Score;
    public GameObject panel_Restart;
    static public float TimeLeft = totalTime, Score = 0;
    public Texture2D cursorTextureSmall;
    public Texture2D cursorTextureBig;
    int drawCursorSize = 128;

    // Use this for initialization
    void Start () {
        //使用硬件鼠标，大小为32x32，但是没有延迟
        //Cursor.SetCursor(cursorTextureSmall, new Vector2(16f, 16f), CursorMode.Auto);
        Cursor.visible = false;
    }

    void OnGUI()
    {
        //使用软件绘制鼠标，大小随意，变化丰富，但是会有延迟
        if (Cursor.visible==false)
        UnityEngine.GUI.DrawTexture(new Rect(Input.mousePosition.x-drawCursorSize/2,Screen.height-Input.mousePosition.y- drawCursorSize / 2, drawCursorSize, drawCursorSize), cursorTextureBig);
    }

    // Update is called once per frame
    void Update () {
        if (TimeLeft - Time.deltaTime <= 0) {
            TimeLeft = 0;
            panel_Restart.SetActive(true);
            Cursor.visible = true;
        }
        else {
            TimeLeft -= Time.deltaTime;
        }
        txt_Time.text = "Time Left: "+(Mathf.CeilToInt(TimeLeft)).ToString();
        txt_Score.text = "Score: " + Score;
	}

    public void buttClick_Restart()
    {
        Cursor.visible = false;
        TimeLeft = totalTime;
        Score = 0;
        panel_Restart.SetActive(false);
    }
}
