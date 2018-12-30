// XMLsample.cs
// 编译时带参数: /doc:XMLsample.xml
using System;

/// <summary>
/// 这里可以写有关类的注释.</summary>
/// <remarks>
/// 一些更长更详细的注释， 
/// 可以通过remarks标记来表示</remarks>
public class SomeClass
{
	/// <summary>
	/// 名字属性
    /// </summary>
	private string myName = null;

	/// <summary>
	/// 构造方法
    /// </summary>
	public SomeClass()
	{
		 // TODO: 添加代码
	}
	
	/// <summary>
	/// 名字属性 Name
    /// </summary>
	/// <value>
	/// value 标记用于描述属性值</value>
	public string Name
	{
		get 
		{
			if ( myName == null )
			{
				throw new Exception("Name is null");
			}
				 
			return myName;
		}
	}

	/// <summary>
	/// 对 SomeMethod 方法的注释.</summary>
	/// <param name="s"> 参数 s 的描述在这里</param>
	/// <seealso cref="String">
	/// 用 cref 可以表明参见其他内容 
	/// 编译器会自动检查相关的内容是否存在. </seealso>
	public void SomeMethod(string s)
	{
        
	}

	/// <summary>
	/// 其他方法. 
    /// </summary>
	/// <returns>
	/// 用 returns 标记可以表明返回值.
    /// </returns>
	/// <seealso cref="SomeMethod(string)">
	/// 这里用 cref 表示参考相关的一个方法 </seealso>
	public int SomeOtherMethod()
	{
		return 0;
	}

	/// <summary>
	/// 应用程序的入口
	/// </summary>
	/// <param name="args"> 命令行参数 </param>
	public static int Main(String[] args)
	{
		// TODO: 添加代码

		 return 0;
	}
}
