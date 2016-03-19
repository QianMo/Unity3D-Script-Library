//关于C#中properties属性的熟悉

using UnityEngine;
using System.Collections;


//Database类-演示Get、Set方法
public class Database : MonoBehaviour 
{

    //-------------------------------------------【Set( )&Get( )】-----------------------------------------    
    // iMyNumber变量的Public属性接口
    //--------------------------------------------------------------------------------------------------------
	public int MyNumber
	{
        //Get方法，当需要获取iMyNumber的值时调用
		get
		{
            return iMyNumber; //返回iMyNumber的值
		}

        //Set方法，当为iMyNumber赋值时被调用
		set
		{
            //当值位于1到10之间时用Set的值改变当前数值，否则忽略
			if(value >= 1 && value <= 10)
			{
				//更新私有变量
				iMyNumber = value;

                //调用NumberChanged( )函数
				NumberChanged();
			}
		}
	}

    //定义私有的int变量iMyNumber
	private int iMyNumber = 0;

    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数仅在Update函数第一次被调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------
	void Start () 
	{
		//设置MyNumber
		MyNumber = 11; //大于10，Set无效
		
		//再次设置MyNumber
		MyNumber = 7; //位于1到10之间，Set成功
	}

    //----------------------------------【NumberChanged()函数】--------------------------------------    
    // 事件：iMyNumber值变化时调用此函数
    //--------------------------------------------------------------------------------------------------------
	void NumberChanged()
	{
        //输出iMyNumber值的变化
		Debug.Log("Variable iMyNumber changed to : " + iMyNumber.ToString());
	}

}

