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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.SetBufferSize( 120, 80 );
			
			
			HorizontalLine lineTop = new HorizontalLine(1, 88 , 0, '@');
			lineTop.Drow();
			HorizontalLine lineBottom = new HorizontalLine(1, 88 , 22, '@');
			lineBottom.Drow();
			
			VerticalLine lineLeft = new VerticalLine(0, 22 , 0, '@');
			lineLeft.Drow();
			VerticalLine lineRight = new VerticalLine(0, 22 , 88, '@');
			lineRight.Drow();
			
			Point p1 = new Point(8, 8, '*');
			p1.Draw();
			
			Console.ReadLine();
		}
		
	}
}