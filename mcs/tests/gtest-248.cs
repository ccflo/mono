using System;

public class Foo<T>
{ }

class X
{
	static bool Test (object o)
	{
		return o is Foo<int> ? true : false;
	}

	static void Main ()
	{ }
}
