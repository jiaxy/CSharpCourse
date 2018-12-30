using System;
namespace N1
{
	public class C1{}
	internal class C2{}
	class C3{}
}

namespace N2
{
	using NN = N2.N3.N4;
	using OutC3 = N1.C3;
	using CodeIds= System.Xml.Serialization.CodeIdentifiers ;
	
	public class C3{ public C3( double d ){}}
	namespace N3
	{
		namespace N4
		{
			class C3{ public C3( string s ){}}
		}
	}

	internal class C4{
		static void Main()
		{
			C3 t1 = new C3( 3.14 );
			NN.C3 t2 = new NN.C3( "Hello" );
			OutC3 t3 = new OutC3();
		}
	}
	class MyCodeIds :CodeIds {}
}
