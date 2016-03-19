//UseDeltaTime

using UnityEngine;
using System.Collections;

public class UseDeltaTime : MonoBehaviour 
{
	//--------------------------------变量定义部分---------------------------------
    
    //Speed of cube || 方块的速度
    public float cubeSpeed = 2.0f;
	

    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数仅在Update函数第一次被调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------  
    void Start () 
	{
       
    }

    //-----------------------------------------【Update()函数】----------------------------------------  
    // 说明：此函数在每一帧中都会被调用
    //------------------------------------------------------------------------------------------------------  
    void Update () 
	{
        //Move cube along forward direction by speed || 使方块的位置随时间变化
        transform.localPosition += transform.forward * cubeSpeed * Time.deltaTime;
    }

}