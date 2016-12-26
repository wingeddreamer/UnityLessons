using UnityEngine;
using System.Collections;

public class Step3_1 : MonoBehaviour {
    public class Animals
    {
        public string name;
        public float weight;
        public void printInfo() { print("Name: "+name+"\t\tWeight: "+weight); }
        public virtual void go() { print("Go"); }
    }

    public class Bird:Animals
    {
        public override void go() { print("Fly"); }
    }

    public class Dog:Animals
    {
        public override void go() { print("Run"); }
    }

    public class Fish : Animals
    {
        public override void go() { print("Swim"); }
    }


    // Use this for initialization
    void Start () {
        Bird birdInstance = new Bird();
        birdInstance.name = "Dove"; birdInstance.weight = 0.5f;
        Dog dogInstance = new Dog();
        dogInstance.name = "Husky"; dogInstance.weight = 20f;
        Fish fishInstance = new Fish();
        fishInstance.name = "Seabass";fishInstance.weight = 2f;
        Animals animalInstance;
        animalInstance = birdInstance;
        animalInstance.printInfo(); animalInstance.go();
        animalInstance = dogInstance;
        animalInstance.printInfo(); animalInstance.go();
        animalInstance = fishInstance;
        animalInstance.printInfo(); animalInstance.go();
    }

    // Update is called once per frame
    void Update () {
	
	}
}