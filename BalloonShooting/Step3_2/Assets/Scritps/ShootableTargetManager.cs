using UnityEngine;
using System.Collections;

public class ShootableTargetManager : MonoBehaviour {

    public GameObject _BalloonBig,_BalloonMiddle,_BalloonSmall,_Clock,_Bomb;
    
    // Use this for initialization
    void Start () {
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
            if (GameGUI.TimeLeft == 0) yield break;
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
        float randomVal = Random.Range(0f, 100f);
        if(randomVal<=80)
        Instantiate(_BalloonBig, new Vector3(Random.Range(-8, 8), -6f, Random.Range(0,5)), Quaternion.identity);
        else if (randomVal<=95)
        Instantiate(_BalloonMiddle, new Vector3(Random.Range(-8, 8), -6f, Random.Range(0, 5)), Quaternion.identity);
        else
        Instantiate(_BalloonSmall, new Vector3(Random.Range(-8, 8), -6f, Random.Range(0, 5)), Quaternion.identity);
    }

}
