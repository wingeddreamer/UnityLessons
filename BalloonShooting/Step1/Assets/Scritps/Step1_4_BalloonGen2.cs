using UnityEngine;
using System.Collections;

public class Step1_4_BalloonGen2 : MonoBehaviour {

    public GameObject balloon;
    float BalloonGenTimer = 0f;
    float BalloonGenInterval = 1f;

    // Use this for initialization
    void Start () {
        //Method 1: Using Coroutine
        StartCoroutine("BalloonGen");
    }

    // Update is called once per frame
    void Update()
    {
        //Methods 2: Using timer
        /*
        if (Time.realtimeSinceStartup - BalloonGenTimer > BalloonGenInterval)
        {
            createBalloon();
            BalloonGenInterval = Random.Range(0f, 3f);
            BalloonGenTimer = Time.realtimeSinceStartup
        }
        */
    }

    IEnumerator BalloonGen ()
    {
        do
        {
            createBalloon();
            yield return new WaitForSecondsRealtime(Random.Range(0f,3f));
        } while (true);

    }

    void createBalloon ()
    {
        DestroyObject(Instantiate(balloon, new Vector3(Random.Range(-8, 8), -5f, Random.Range(0,5)), Quaternion.identity), 5);
    }
}
