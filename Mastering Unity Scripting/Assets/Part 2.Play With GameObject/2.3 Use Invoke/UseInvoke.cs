﻿//UseInvoke

using UnityEngine;
using System.Collections;

public class UseInvoke : MonoBehaviour 
{
	//--------------------------------变量定义部分---------------------------------
	

    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数仅在Update函数第一次被调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------  
    void Start ( ) 
	{
        //经过1秒之后再调用指定函数
        Invoke("CallOfDuty", 1.0f);
    }

    //-----------------------------------------【Update()函数】----------------------------------------  
    // 说明：此函数在每一帧中都会被调用
    //------------------------------------------------------------------------------------------------------  
    void Update ( ) 
	{

    }
    void CallOfDuty()
    {
        Debug.Log("hi，我被调用了~！");
    }
}