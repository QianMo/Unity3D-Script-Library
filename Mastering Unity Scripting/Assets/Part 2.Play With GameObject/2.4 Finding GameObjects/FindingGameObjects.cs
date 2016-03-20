//FindingGameObjects

using UnityEngine;
using System.Collections;

public class FindingGameObjects : MonoBehaviour 
{
	//--------------------------------变量定义部分---------------------------------
	//要找到的物体的Tag名称
    public string TagName = "Finish";
    //数组
    public GameObject[] FoundObjects;

    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数仅在Update函数第一次被调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------  
    void Start ( ) 
	{
        FoundObjects = GameObject.FindGameObjectsWithTag(TagName);
        foreach(GameObject go in FoundObjects)
        {
            Debug.Log("报告，找到一个Tag为"+TagName+"的物体，名为"+go.name);
        }
    }

    //-----------------------------------------【Update()函数】----------------------------------------  
    // 说明：此函数在每一帧中都会被调用
    //------------------------------------------------------------------------------------------------------  
    void Update ( ) 
	{

    }

}