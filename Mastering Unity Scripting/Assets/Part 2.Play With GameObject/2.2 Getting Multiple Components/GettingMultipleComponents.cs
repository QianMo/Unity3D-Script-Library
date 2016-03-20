//Gettingmultiplecomponents

using UnityEngine;
using System.Collections;

public class GettingMultipleComponents : MonoBehaviour 
{
	//--------------------------------变量定义部分---------------------------------
	//所有组件的引用集合数组
    private Component[ ] AllComponents = null;
	

    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数仅在Update函数第一次被调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------  
    void Start ( ) 
	{
        //获取所有的组件的集合
        AllComponents = GetComponents<Component>();

        foreach(Component component in AllComponents)
        {
            //输出到控制台
            Debug.Log("该物体具有组件"+component.ToString());
        }
    }

    //-----------------------------------------【Update()函数】----------------------------------------  
    // 说明：此函数在每一帧中都会被调用
    //------------------------------------------------------------------------------------------------------  
    void Update ( ) 
	{

    }

}