using System;
namespace MyProgram{
	class Triangle{
		public Triangle(){
			int x = 5;
			string result = "";
			for(int h = 0; h < x; h++){
				for(int w = 0; w < h; w++){
					result += "* ";
				}
				result += "\n";
			}
			Console.WriteLine(result);
		}
	}
}