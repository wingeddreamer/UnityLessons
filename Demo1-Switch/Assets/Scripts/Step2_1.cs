using UnityEngine;
using System.Collections;

public class Step2_1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Material cubeMat = gameObject.GetComponentInChildren<MeshRenderer>().material;
        switch (Input.inputString[0])
        {
            case '1':
            case 'r':
                cubeMat.color = Color.red;
                break;
            case '2':
            case 'o':
                cubeMat.color = new Color(1f, 0.4f, 0f);
                break;
            case '3':
            case 'y':
                cubeMat.color = Color.yellow;
                break;
            case '4':
            case 'g':
                cubeMat.color = Color.green;
                break;
            case '5':
            case 'c':
                cubeMat.color = Color.cyan;
                break;
            case '6':
            case 'b':
                cubeMat.color = Color.blue;
                break;
            case '7':
            case 'm':
                cubeMat.color = Color.magenta;
                break;
            default:
                cubeMat.color = Color.gray;
                break;
        }

    }
}
