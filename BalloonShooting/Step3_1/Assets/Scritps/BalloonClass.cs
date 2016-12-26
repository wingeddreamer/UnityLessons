using UnityEngine;
using System.Collections;

public class BalloonClass : MonoBehaviour {

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

    public GameObject scrap;

    // Use this for initialization
    void Start () {
        //设定气球速度
        Speed = Random.Range(MinSpeed, MaxSpeed);

        //设定气球颜色
        color = colorOptions[Random.Range(0, colorOptions.Length)];
        GetComponentInChildren<SkinnedMeshRenderer>().material.color = color;

        //设定气球表面图案
        GetComponentInChildren<SkinnedMeshRenderer>().material.mainTexture = BalloonManager.balloonPatterns[Random.Range(0, BalloonManager.balloonPatterns.Length)];
    }

    // Update is called once per frame
    void Update () {
        move();
        destroyOutOfView();
    }

    void OnMouseDown()
    {
        if (Mathf.CeilToInt(GUI.TimeLeft) > 0) DestroyByPlayer();
    }

    public void move()
    {
        transform.Translate(new Vector3(0, speed, 0));
    }

    public void destroyOutOfView()
    {
        if (!GetComponentInChildren<SkinnedMeshRenderer>().isVisible && transform.localPosition.y > 0) Destroy(gameObject);
    }

    public void DestroyByPlayer()
    {
        //删除气球
        Destroy(gameObject);
        //生成碎片并使其颜色等于气球颜色
        GameObject scrapObj = Instantiate(scrap, transform.localPosition, Quaternion.identity) as GameObject;
        scrapObj.GetComponent<Renderer>().material.color = color;
        //加分
        GUI.Score += 100;
    }
}