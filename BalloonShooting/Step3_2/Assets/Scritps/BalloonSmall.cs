using UnityEngine;
using System.Collections;

public class BalloonSmall : Balloons
{
    override protected void Start()
    {
        base.Start();
        _balloonType = 2;
        _balloonColor = Color.blue;
        _balloonScale = 0.5f;
        _score = 500;
        _verticalSpeed = 0.15f;
    }
}