using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step1_1 : MonoBehaviour {

    public Text inV1, inV2, outResult;
    public Button buttAdd, buttSub, buttMul, buttDiv;
    float v1, v2;
    int buttNo;

    delegate void multiFunc (float v1, float v2);
    multiFunc funcToUse;

	// Use this for initialization
	void Start () {
        buttAdd.onClick.AddListener(addClk);
        buttSub.onClick.AddListener(subClk);
        buttMul.onClick.AddListener(mulClk);
        buttDiv.onClick.AddListener(divClk);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void Add(float v1, float v2)
    {
        assignResultText(v1 + v2);
    }

    void Sub(float v1, float v2)
    {
        assignResultText(v1 - v2);
    }

    void Mul(float v1, float v2)
    {
        assignResultText(v1 * v2);
    }

    void Div(float v1, float v2)
    {
        assignResultText(v1 / v2);
    }

    void assignNumber()
    {
        float.TryParse(inV1.text, out v1);
        float.TryParse(inV2.text, out v2);
    }

    void assignResultText(float V)
    {
        outResult.text = V.ToString();
    }

    void addClk() { assignNumber(); funcToUse = Add; funcToUse(v1,v2); }
    void subClk() { assignNumber(); funcToUse = Sub; funcToUse(v1,v2); }
    void mulClk() { assignNumber(); funcToUse = Mul; funcToUse(v1,v2); }
    void divClk() { assignNumber(); funcToUse = Div; funcToUse(v1,v2); }
}
