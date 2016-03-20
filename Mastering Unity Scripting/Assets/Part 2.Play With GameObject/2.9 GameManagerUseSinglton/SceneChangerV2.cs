//SceneChangerV2
//按下空格便跳转到指定场景

using UnityEngine;
using System.Collections;
//Will change scene when we press space
public class SceneChangerV2 : MonoBehaviour 
{
    //--------------------------------变量定义部分---------------------------------
    //要跳转到的场景号
	public int DestinationScene = 0;

    //-----------------------------------------【Update()函数】----------------------------------------  
    // 说明：此函数在每一帧中都会被调用
    //------------------------------------------------------------------------------------------------------ 
	void Update () 
	{
        //若按下空格，就跳转到目标场景
		if(Input.GetKeyDown(KeyCode.Space))
			Application.LoadLevel(DestinationScene);
	}
}
