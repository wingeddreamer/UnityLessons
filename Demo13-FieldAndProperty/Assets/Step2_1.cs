using UnityEngine;
using System.Collections;

public class Step2_1 : MonoBehaviour
{
    public enum AgeGroup
    {
        Children,      //0-17
        Youth,         //18-30
        MiddleAged,    //31-60
        Elderly        //>60 
    }

    public class myClass
    {
        //use automated property
        public float propInt { get; set; }

        //use property to access a private field
        float myFloat = 5.0f;
        public float propFloat { get { return myFloat; } set { myFloat = value; } }

        //use a read-only property to process data
        public float age;
        public AgeGroup propAgeGrop
        {
            get
            {
                if (age <= 17)
                    return AgeGroup.Children;
                else if (age <= 30)
                    return AgeGroup.Youth;
                else if (age <= 60)
                    return AgeGroup.MiddleAged;
                else
                    return AgeGroup.Elderly;
            }
        }
    }

    // Use this for initialization
    void Start()
    {
        myClass myclassInstance = new myClass();
        myclassInstance.propInt = 8.8f;
        print(myclassInstance.propInt);

        myclassInstance.propFloat = 2.5f;
        print(myclassInstance.propFloat);
        myclassInstance.age = 25;
        print(myclassInstance.propAgeGrop);
    }

    // Update is called once per frame
    void Update()
    {

    }

}