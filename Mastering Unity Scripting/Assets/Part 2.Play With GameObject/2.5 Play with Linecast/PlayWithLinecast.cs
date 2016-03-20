//PlayWithLinecast

using UnityEngine;
using System.Collections;

public class PlayWithLinecast : MonoBehaviour 
{
	//--------------------------------变量定义部分---------------------------------
    //敌人对象的引用 || Reference to sample enemy object
    public GameObject Enemy = null;
	//限制线段检测的掩膜层级 || Layer mask to limit line detection
    public LayerMask LM;

    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数仅在Update函数第一次被调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------  
    void Start ( ) 
	{

    }

    //-----------------------------------------【Update()函数】----------------------------------------  
    // 说明：此函数在每一帧中都会被调用
    //------------------------------------------------------------------------------------------------------  
    void Update ( ) 
	{
        //若路径上没有障碍
        if(!Physics.Linecast(transform.position,Enemy.transform.position, LM))
        {
            Debug.Log ("路径上没有障碍~！");
        }
        //否则，路径上有障碍
        else
        {
            Debug.Log("路径被挡住了~！");
        }
    }

    //-----------------------------------------【OnDrawGizmos()函数】--------------------------------
    // 说明：在此函数中书写绘制Gizmo的相关代码
    //--------------------------------------------------------------------------------------------------------
    void OnDrawGizmos()
    {
        //设置Gizmo的颜色为蓝色
        Gizmos.color = Color.red;
        //绘制一条直线
        Gizmos.DrawLine(transform.position, Enemy.transform.position);
    }
}