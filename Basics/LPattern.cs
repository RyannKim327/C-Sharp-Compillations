using System;
namespace MyProgram{
	class LPattern{
		public LPattern(){
			int height = 5, width = 4;
			string result = "";
			for(int h = 1; h <= height; h++){
				for(int w = 1; w <= width; w++){
					if(h <= 3){
						if(w <= 2){
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
			Console.WriteLine(result);
		}
	}
}