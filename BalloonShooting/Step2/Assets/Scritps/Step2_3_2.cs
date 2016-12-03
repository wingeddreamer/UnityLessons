using UnityEngine;
using System.Collections;

public class Step2_3_2 : MonoBehaviour {

    const float MaxSpeed= 0.25f, MinSpeed = 0.025f;

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

    public void destroyOutOfView()
    {
        if (!GetComponentInChildren<SkinnedMeshRenderer>().isVisible && transform.localPosition.y > 0) Destroy(gameObject);
    }

	// Use this for initialization
	void Start () {
        Speed = Random.Range(MinSpeed, MaxSpeed);
    }

    void OnMouseDown ()
    {
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
        move();
        destroyOutOfView();
    }
}
