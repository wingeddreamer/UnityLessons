using UnityEngine;
using System.Collections;

public class Balloons : ShootableTargets
{
    //气球的候选纹理数组
    public Texture[] BalloonPatternOptions;

    //气球种类、颜色、大小与奖励分
    protected int _balloonType;  //0-大、1-中、2-小
    public Color _balloonColor;
    public float _balloonScale;
    public int _score;

    override protected void Start ()
    {
        base.Start();
        transform.localScale = new Vector3(_balloonScale, _balloonScale, _balloonScale);
        GetComponentInChildren<SkinnedMeshRenderer>().material.color=_balloonColor;
        GetComponentInChildren<SkinnedMeshRenderer>().material.mainTexture = BalloonPatternOptions[Random.Range(0, BalloonPatternOptions.Length)];
    }
}