using UnityEngine;
using System.Collections;

public class Step1_1_Constructor : MonoBehaviour {

    public class Animal
    {
        string name;
        int weight;
        public void printInfo()
        {
            print("The animal's name is " + name + ", and its weight is " + weight + ".");
        }
        public Animal() {
            name = "unnamed animal";
            weight = 0;
            print("The default constructor is called.");
            printInfo();
        }
    }

	// Use this for initialization
	void Start () {
        Animal myAnimal = new Animal();  //calling the constructor
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
