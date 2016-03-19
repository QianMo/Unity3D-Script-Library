
//关于C#多态性的熟悉，文件MyCharacter.cs

using UnityEngine;
using System.Collections;

//角色类
public class MyCharacter
{
    //定义一下角色的属性
	public string CharName = "";
	public int Health = 100;
	public int Strength = 100;
	public float Speed = 10.0f;
	public bool isAwake = true;

    //提供给玩家在进入谈话时的问候虚函数
    public virtual void SayGreeting()
	{
		Debug.Log ("Hello, my friend");
	}
}

//派生类“男人”ManCharacter
public class ManCharacter: MyCharacter
{
    //重载SayGreeting()函数
	public override void SayGreeting()
	{
		Debug.Log ("Hello, I'm a man");
	}
}

//派生类“女人”WomanCharacter
public class WomanCharacter: MyCharacter
{
    //重载SayGreeting()函数
	public override void SayGreeting()
	{
		Debug.Log ("Hello, I'm a woman");
	}
}

//派生类“兽人”OrcCharacter
public class OrcCharacter: MyCharacter
{
    //重载SayGreeting()函数
	public override void SayGreeting()
	{
		Debug.Log ("Hello, I'm an Orc");
	}
}
