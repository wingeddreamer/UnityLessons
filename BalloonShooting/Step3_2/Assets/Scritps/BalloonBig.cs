using UnityEngine;
using System.Collections;

public class BalloonBig : Balloons {

    override protected void Start()
    {
        base.Start();
        _balloonType = 0;
        _balloonColor = Color.red;
        _balloonScale = 1f;
        _score = 100;
        _verticalSpeed = 0.1f;
    }
}
