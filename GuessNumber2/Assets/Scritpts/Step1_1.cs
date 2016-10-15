using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    Text inMin, inMax,calcResult;
    Button buttSubmit;
    Toggle toggGold;

	// Use this for initialization
	void Start () {
        inMin = transform.Find("/Canvas/inputMin/Text").gameObject.GetComponent<Text>();
        inMax = transform.Find("/Canvas/inputMax/Text").gameObject.GetComponent<Text>();
        calcResult = transform.Find("/Canvas/Result").gameObject.GetComponent<Text>();
        toggGold = transform.Find("/Canvas/toggleGold").gameObject.GetComponent<Toggle>();

        buttSubmit = GameObject.FindWithTag("submitButton").GetComponent<Button>();
        buttSubmit.onClick.AddListener(submit);
    }
    
    // Update is called once per frame
    void Update()
    {

    }
    void submit()
    {
        int intMin, intMax, finalResult;
        float midNumber;
        int.TryParse(inMin.text, out intMin);
        int.TryParse(inMax.text, out intMax);
        if (toggGold.isOn)
        {
            if(Random.Range(0f,1f)>0.5f) midNumber = (float)(intMin + (intMax - intMin) * 0.618);
            else midNumber = (float)(intMin + (intMax - intMin) * 0.382);
        }
        else
            midNumber = (intMin + intMax) / 2.0f;
        finalResult = (int) Mathf.Floor(midNumber);
        calcResult.text = finalResult.ToString();
    }
}
