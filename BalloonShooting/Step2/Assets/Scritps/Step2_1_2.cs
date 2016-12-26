using UnityEngine;
using System.Collections;

public class Step2_1_2 : MonoBehaviour {

    const float MaxSpeed = 0.1f, MinSpeed = 0.05f;

    float speed = 0f;
    float Speed
    {
        get { return speed; }
        set
        {
            if (value > MaxSpeed) speed = MaxSpeed;
            else if (value < MinSpeed) speed = MinSpeed;
            else speed = value;
        }
    }

    public void move()
    {
        transform.Translate(new Vector3(0, speed, 0));
    }

	// Use this for initialization
	void Start () {
        Speed = Random.Range(MinSpeed, MaxSpeed);
    }

	// Update is called once per frame
	void Update () {
        move();
    }
}