using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step2_1 : MonoBehaviour {

    public Text inV1, inV2, outResult;
    public Button buttAdd, buttSub, buttMul, buttDiv;
    float v1, v2;
    int buttNo;

    delegate float multiFunc (float v1, float v2);
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

    float Add(float v1, float v2)
    {
        return v1 + v2;
    }

    float Sub(float v1, float v2)
    {
        return v1 - v2;
    }

    float Mul(float v1, float v2)
    {
        return v1 * v2;
    }

    float Div(float v1, float v2)
    {
        return v1 / v2;
    }

    void calcResult(multiFunc Func)
    {
        float.TryParse(inV1.text, out v1);
        float.TryParse(inV2.text, out v2);
        outResult.text = Func(v1, v2).ToString();
    }

    void addClk() { calcResult(Add); }
    void subClk() { calcResult(Sub); }
    void mulClk() { calcResult(Mul); }
    void divClk() { calcResult(Div); }
}
