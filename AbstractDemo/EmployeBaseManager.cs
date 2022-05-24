using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractDemo
{
	abstract class EmployeBaseManager
	{
		public string renk;
		abstract public void OzelikYaz();

	}

	class Kanepe : EmployeBaseManager
	{

		public override void OzelikYaz()
		{
			Console.WriteLine("Kanepenin Özelikleri");
			Console.WriteLine("Renk : {0}" , renk);
		}

	}
	class Masa : EmployeBaseManager
	{
		public override void OzelikYaz()
		{
			Console.WriteLine("Masanın Özelikleri");
			Console.WriteLine("kırmızı", renk);
		}
	}


}
