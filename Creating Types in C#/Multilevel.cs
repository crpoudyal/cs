using System;

namespace CreatingTypesInCsharp
{
	public class As{
		
		public static void Xy(){
			Console.WriteLine("I am method of Class A");
		}
	}
	public class Bs: As{
		public static void Xyz(){
			Console.WriteLine("I am method of Class B");
			
		}
	}
	public class Cs:Bs{
		int a;
		public int A{
		get{return a;}
		set{a=value;}
		}
		public void Xyzz(){
			Console.WriteLine("I am method of Class C");
			
		}
	}
	public class Multilevel:Cs{
		public void xx(){
			base.Xyzz();
			base.A = 20;
			Console.WriteLine("A "+A);
		}
		public static void Main(String[] args){
			Bs.Xy();
			Bs.Xyz();
			Cs cs = new Cs();
			cs.Xyzz();
			Cs.Xyz();
			Multilevel ml = new Multilevel();
			ml.xx();
			
			
		}
	}
	
}