/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 15.01.2020
 * Time: 14:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * 
 * 
 * 
 */
 
using System;


namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			Point p1 = new Point(1,3,'*');
			p1.Draw();
			
			Point p2 = new Point(4,5,'#');
			p2.Draw();
			
			Console.ReadLine();
		}
		
		static void Draw(int x, int y, char sym)
		{
			Console.SetCursorPosition(x, y);
			Console.Write( sym );
		}
	}
}