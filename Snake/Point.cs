/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 15.01.2020
 * Time: 16:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Snake
{
	public class Point
	{
		public int x;
		public int y;
		public char sym;
		
		public Point(int _x, int _y, char _sym) 
		{
			x = _x;
			y = _y;
			sym = _sym;
		}
		
		public void Draw()
		{
			Console.SetCursorPosition(x, y);
			Console.Write( sym );
		}
	}
}
