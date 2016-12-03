using UnityEngine;
using System.Collections;

public class Step1_2_MultipleConstructors : MonoBehaviour {

    public class Animal
    {
        public string name;
        int weight;
        public void printInfo()
        {
            print("The animal's name is " + name + ", and its weight is " + weight + ".");
        }
        public Animal()
        {
            name = "unnamed animal";
            weight = 0;
            print("The default constructor is called.");
            printInfo();
        }
        public Animal(string inputName)
        {
            name = inputName;
            weight = 0;
            print("The 1-parameter constructor is called.");
            printInfo();
        }
        public Animal(string inputName,int inputWeight)
        {
            name = inputName;
            weight = inputWeight;
            print("The 2-parameter constructor is called.");
            printInfo();
        }
    }

    // Use this for initialization
    void Start () {
        Animal myAnimal1 = new Animal();
        Animal myAnimal2 = new Animal("Cow");
        Animal myAnimal3 = new Animal("Chicken",3);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}