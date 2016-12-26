using UnityEngine;
using System.Collections;

public class BalloonMiddle : Balloons
{
    override protected void Start()
    {
        base.Start();
        _balloonType = 1;
        _balloonColor = Color.green;
        _balloonScale = 0.75f;
        _score = 250;
        _verticalSpeed = 0.15f;
    }
}