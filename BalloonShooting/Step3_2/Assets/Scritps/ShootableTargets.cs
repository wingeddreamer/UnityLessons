using UnityEngine;
using System.Collections;

public class ShootableTargets : MonoBehaviour
{
    //射击目标的垂直速度
    protected float _verticalSpeed;
    //射击目标起始位置区域
    protected Vector3 _startPosCornerMn, _startPosCornerMax;
    //碎片模型
    public GameObject _scrapPrefab;
    protected Color _scrapColor;
    protected float _scrapScale;
    //实例化的碎片模型
    protected GameObject _scrapObject;

    virtual protected void Start() { }

    virtual protected void Update() {
        Move();
        DestroyOutOfView();
    }

    /*以下为自定义方法*/

    virtual protected void OnMouseDown()
    {
        //假若是气球，则根据气球颜色与大小决定碎片的颜色与大小
        if (this is Balloons) {
            _scrapColor = ((Balloons)this)._balloonColor;
            _scrapScale = ((Balloons)this)._balloonScale;
        }
        if (Mathf.CeilToInt(GameGUI.TimeLeft) > 0) DestroyByPlayer();
    }

    virtual protected void Move()
    {
        transform.Translate(new Vector3(0, _verticalSpeed, 0));
    }

    virtual protected void DestroyOutOfView()
    {
        if (!GetComponentInChildren<SkinnedMeshRenderer>().isVisible && transform.localPosition.y > 0) Destroy(gameObject);
    }

    virtual protected void DestroyByPlayer()
    {
        //删除目标模型
        Destroy(gameObject);
        //生成碎片
        GameObject scrapObj = Instantiate(_scrapPrefab,transform.localPosition,Quaternion.identity) as GameObject;
        scrapObj.GetComponent<Renderer>().material.color = _scrapColor;
        scrapObj.transform.localScale = new Vector3(_scrapScale,_scrapScale,_scrapScale);
        //若打中气球则加分
        if (this is Balloons) GameGUI.Score += ((Balloons)this)._score;
    }
}