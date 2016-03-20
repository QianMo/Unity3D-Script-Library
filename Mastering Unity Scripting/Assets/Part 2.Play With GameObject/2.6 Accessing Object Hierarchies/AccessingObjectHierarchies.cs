//AccessingObjectHierarchies

using UnityEngine;
using System.Collections;

public class AccessingObjectHierarchies : MonoBehaviour 
{
	//--------------------------------变量定义部分---------------------------------
    //子对象
    private GameObject Child;
	//父对象
    private GameObject Parent;

    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数仅在Update函数第一次被调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------  
    void Start ( ) 
	{
        //获取子对象
        Child = GameObject.Find("Child");
        Parent = GameObject.Find("Parent");

        //设置父对象子对象层级
        Child.transform.parent = Parent.transform;

        //进行测试
        for (int i = 0; i < Parent.transform.childCount; i++)
        {
            //Print name of child to console
            Debug.Log("发现子对象，名为"+Parent.transform.GetChild(i).name);
        }
    }

    //-----------------------------------------【Update()函数】----------------------------------------  
    // 说明：此函数在每一帧中都会被调用
    //------------------------------------------------------------------------------------------------------  
    void Update ( ) 
	{

    }

}