using System;

namespace MyProgram{
	class LIndentPattern{
		public LIndentPattern(){
			string indent = "", result = "";
			Console.Write("Enter number of duplication: ");
			try{
				int dup = int.Parse(Console.ReadLine());
				int height = 5, width = 4;
				for(int d = 1; d <= dup; d++){
					for(int h = 1; h <= height; h++){
						result += indent;
						for(int w = 1; w <= width; w++){
							if(h <= 3){
								if(w < 3){
									result += "* ";
								}else{
									result += "  ";
								}
							}else{
								result += "* ";
							}
						}
						result += "\n";
					}
					indent += "        ";
				}
			}catch(System.Exception e){
				Console.WriteLine("Error: " + e);
			}
			Console.WriteLine(result);
		}
	}
}