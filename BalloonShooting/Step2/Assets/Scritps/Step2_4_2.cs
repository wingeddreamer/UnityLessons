using UnityEngine;
using System.Collections;

public class Step2_4_2 : MonoBehaviour {

    //定义备选颜色数组
    Color[] colorOptions = { Color.red, new Color(1f, 0.3f, 0f), Color.yellow, Color.green, Color.cyan, Color.blue };

    const float MaxSpeed = 0.1f, MinSpeed = 0.05f;
    Color color;

    int type = 0;
    int Type {
        get { return type; }
        set { type = value > 2 ? 2 : (value < 0 ? 0 : value); }
    }

    float speed = 0f;
    float Speed {
        get { return speed; }
        set { speed = value > MaxSpeed ? MaxSpeed : (value < MinSpeed ? MinSpeed : value); }
    }

    public void move()
    {
        transform.Translate(new Vector3(0, speed, 0));
    }

    public void destroyOutOfView()
    {
        if (!GetComponentInChildren<SkinnedMeshRenderer>().isVisible && transform.localPosition.y > 0) Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
        //设定气球速度
        Speed = Random.Range(MinSpeed, MaxSpeed);

        //设定气球颜色
        color = colorOptions[Random.Range(0, colorOptions.Length)];
        GetComponentInChildren<SkinnedMeshRenderer>().material.color = color;

        //设定气球表面图案
        GetComponentInChildren<SkinnedMeshRenderer>().material.mainTexture = Step2_4_1.balloonPatterns[Random.Range(0, Step2_4_1.balloonPatterns.Length)];
    }

    void OnMouseDown()
    {
        if (Mathf.CeilToInt(Step2_4_3.TimeLeft) > 0)
        {
            Destroy(gameObject);
            Step2_4_3.Score += 100;
        }
    }

    // Update is called once per frame
    void Update () {
        move();
        destroyOutOfView();
    }
}