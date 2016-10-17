using UnityEngine;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    enum Days
    {
        Sun,
        Mon,
        Tue=5,
        Wed,
        Thu,
        Fri=Mon,
        Sat
    };

    // Use this for initialization
    void Start () {
        Days testDay;
        Days[] week = new Days[7] { Days.Sun, Days.Mon, Days.Tue, Days.Wed, Days.Thu, Days.Fri, Days.Sat};
        foreach (Days currentDay in week)
        {
            print("Index of " + currentDay + " is " + (int)currentDay);
        }
        Days testDay2;
        testDay2=(Days)System.Enum.Parse(typeof(Days),"Tue");
        print("Finally, index of " + testDay2 + " is " + (int)testDay2);
        print((int)testDay2 + (int)testDay2);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
