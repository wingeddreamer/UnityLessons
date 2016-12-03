using UnityEngine;
using System.Collections;

public class Step2_3_1: MonoBehaviour {

    public GameObject balloon;

    // Use this for initialization
    void Start () {
        StartCoroutine("BalloonGen");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator BalloonGen ()
    {
        do
        {
            createBalloon();
            yield return new WaitForSecondsRealtime(Random.Range(0f,1f));
        } while (true);

    }

    void createBalloon ()
    {
        Instantiate(balloon, new Vector3(Random.Range(-8, 8), -5f, Random.Range(0,5)), Quaternion.identity);
    }
}
