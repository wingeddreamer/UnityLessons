using UnityEngine;
using System.Collections;

public class BalloonManager: MonoBehaviour {

    public GameObject balloon;
    public Texture[] balloonPatternsSetup;
    static public Texture[] balloonPatterns;

    // Use this for initialization
    void Start () {
        balloonPatterns = balloonPatternsSetup;
        startBalloonGen();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator BalloonGen ()
    {
        do
        {
            if (GUI.TimeLeft == 0) yield break;
            createBalloon();
            yield return new WaitForSecondsRealtime(Random.Range(0f,1f));
        } while (true);

    }

    public void startBalloonGen()
    {
        StartCoroutine("BalloonGen");
    }

    void createBalloon ()
    {
        Instantiate(balloon, new Vector3(Random.Range(-8, 8), -6f, Random.Range(0,5)), Quaternion.identity);
    }

}
