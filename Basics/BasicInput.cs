using System;

namespace MyProgram{
	internal class BasicInput{
		public BasicInput(){
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();
			Console.WriteLine("Hello " + name + ", how are you");
		}
	}
}