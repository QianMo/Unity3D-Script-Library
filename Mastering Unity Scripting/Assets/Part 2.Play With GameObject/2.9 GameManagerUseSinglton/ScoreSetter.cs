//ScoreSetter

using UnityEngine;
using System.Collections;

public class ScoreSetter : MonoBehaviour 
{
    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数仅在Update函数第一次被调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------  
	void Start () 
	{
		//设置最高分
		GameManager.Instance.HighScore = 100;
	}

}
