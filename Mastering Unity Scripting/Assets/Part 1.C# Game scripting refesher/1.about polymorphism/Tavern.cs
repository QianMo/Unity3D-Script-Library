//关于C#多态性的熟悉，文件Tavern.cs

using UnityEngine;
using System.Collections;

//酒馆类
public class Tavern : MonoBehaviour 
{
	//定义一个酒馆的NPC数组
	public MyCharacter[] Characters = null;

    //-----------------------------------------【Start()函数】---------------------------------------------    
    // 说明：此函数仅在Update函数第一次被调用前被调用，常用于进行数据的初始化  
    //--------------------------------------------------------------------------------------------------------
	void Start () {
		
		//初始化，设定酒馆的NPC数组大小
		Characters = new MyCharacter[5];
        //进一步初始化酒馆的NPC数组，用不同类型的人物类填充该数组
		Characters[0] = new ManCharacter();
		Characters[1] = new WomanCharacter();
		Characters[2] = new OrcCharacter();
		Characters[3] = new ManCharacter();
		Characters[4] = new WomanCharacter();

        //调用EnterTavern()函数
		EnterTavern();
	}

    //-------------------------------------【EnterTavern()函数】-----------------------------------------    
    // 说明：自定义的进入酒馆函数EnterTavern()
    //--------------------------------------------------------------------------------------------------------
	public void EnterTavern()
	{
		//进入酒馆后，每人都会相互问候
		foreach(MyCharacter C in Characters)
		{
            //此处会调用派生类中的SayGreeting函数，多态性(Polymorphism)使得派生类可以通过基类进行访问
			C.SayGreeting();
		}
	}
	//-------------------------------------------------------
}