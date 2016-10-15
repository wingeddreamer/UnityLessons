using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step2_1 : MonoBehaviour {

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
        int.TryParse(inMin.text, out intMin);
        int.TryParse(inMax.text, out intMax);

        //以下三句可任选一句
        
        //调用第1种函数
        //finalResult = calcResultFunc1(intMin, intMax);
        
        //调用第2种函数
        //calcResultFunc2(intMin, intMax,out finalResult
        
        //调用第3种函数
        finalResult = -1;
        calcResultFunc3(intMin, intMax, ref finalResult);

        calcResult.text = finalResult.ToString();
    }

    //注意介绍名称空间

    //1.有返回值的函数
    int calcResultFunc1(int intMin, int intMax)
    {
        float midNumber;
        if (toggGold.isOn)
        {
            if (Random.Range(0f, 1f) > 0.5f) midNumber = (float)(intMin + (intMax - intMin) * 0.618);
            else midNumber = (float)(intMin + (intMax - intMin) * 0.382);
        }
        else
            midNumber = (intMin + intMax) / 2.0f;
        return (int)Mathf.Floor(midNumber);
    }

    //2.无返回值但有out参数的函数
    void calcResultFunc2(int intMin, int intMax, out int outputResult)
    {
        //下面这句命令无法执行，因为函数体中的out参数无法读取，只能接受输出结果
        //print(outputResult);
        float midNumber;
        if (toggGold.isOn)
        {
            if (Random.Range(0f, 1f) > 0.5f) midNumber = (float)(intMin + (intMax - intMin) * 0.618);
            else midNumber = (float)(intMin + (intMax - intMin) * 0.382);
        }
        else
            midNumber = (intMin + intMax) / 2.0f;
        outputResult =(int) Mathf.Floor(midNumber);
    }

    //3.使用ref参数的函数
    void calcResultFunc3(int intMin, int intMax, ref int outputResult)
    {
        //ref参数的值可以在函数体内用，且必须在调用函数前被赋值。
        print(outputResult);
        float midNumber;
        if (toggGold.isOn)
        {
            if (Random.Range(0f, 1f) > 0.5f) midNumber = (float)(intMin + (intMax - intMin) * 0.618);
            else midNumber = (float)(intMin + (intMax - intMin) * 0.382);
        }
        else
            midNumber = (intMin + intMax) / 2.0f;
        outputResult = (int)Mathf.Floor(midNumber);
    }
}