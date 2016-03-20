//AboutGetComponent

using UnityEngine;
using System.Collections;

public class AboutGetComponent : MonoBehaviour
{
    //--------------------------------变量定义部分---------------------------------
    private Transform ThisTransform = null;
    public float MoveSpeed = 5.0f;

    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数仅在Update函数第一次被调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------  
    void Start()
    {
        //初始化reference
        ThisTransform = GetComponent<Transform>();
    }

    //-----------------------------------------【Update()函数】----------------------------------------  
    // 说明：此函数在每一帧中都会被调用
    //------------------------------------------------------------------------------------------------------  
    void Update()
    {
        //更新物体的位置
        if (ThisTransform != null)
        {
            ThisTransform.localPosition += Time.deltaTime * MoveSpeed * ThisTransform.forward;
        }
    }

}