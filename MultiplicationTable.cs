using System;

namespace MyProgram{
	internal class MultiplicationTable{
		public MultiplicationTable(){
			Console.Write("Enter a number: ");
			string num = Console.ReadLine();
			string result = "";
			try{
				int x = int.Parse(num);
				for(int i = 1; i <= x; i++){
					for(int j = 1; j <= x; j++){
						result += (i * j) + "\t";
					}
					result += "\n";
				}
			}
			catch (System.Exception e){
				result = e.ToString();
				throw;
			}
			Console.WriteLine(result);
		}
	}
}