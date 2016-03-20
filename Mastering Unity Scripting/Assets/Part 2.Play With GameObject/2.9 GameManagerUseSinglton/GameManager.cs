//GameManager
//游戏管理类-使用单例模式


using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	//-----------------------------------------
    //--------------------------------变量定义部分---------------------------------
	//用C#属性来Get单例模式的实例 || C# Property to get access to singleton instance
	//只读-只能读取不能set || Read only - only has get accessor
	public static GameManager Instance
	{
		//返回私有实例的引用 || return reference to private instance
		get
		{
			return instance;
		}
	}
    //instance定义
	private static GameManager instance = null;

	//最高分
	public int HighScore = 0;

	//游戏是否处于暂停状态
	public bool IsPaused = false;
	
	//是否可以输入
	public bool InputAllowed = true;

    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数在Start函数调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------  
	void Awake ()
	{
        //如果有实例在此场景中存在，销毁此实例
		if(instance)
		{
			DestroyImmediate(gameObject);
			return;
		}

		//使当前实例成为唯一的实例
		instance = this;

        //使此对象在新场景载入时不被销毁
		DontDestroyOnLoad(gameObject);
	}
}
