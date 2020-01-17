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
using System.Threading;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.SetBufferSize( 120, 80 );
			
			
			HorizontalLine lineTop = new HorizontalLine(1, 88 , 0, '@');
			lineTop.Draw();
			HorizontalLine lineBottom = new HorizontalLine(1, 88 , 22, '@');
			lineBottom.Draw();
			
			VerticalLine lineLeft = new VerticalLine(0, 22 , 0, '@');
			lineLeft.Draw();
			VerticalLine lineRight = new VerticalLine(0, 22 , 88, '@');
			lineRight.Draw();
			
			Point p = new Point(8, 8, '*');
			p.Draw();
			//snake
			Snake snake = new Snake(p, 4, Direction.RIGHT);

			snake.Draw();
			snake.Move();
			Thread.Sleep( 300 );
			snake.Move();
			Thread.Sleep( 300 );
			snake.Move();
			Thread.Sleep( 300 );
			snake.Move();
			Thread.Sleep( 300 );
			snake.Move();
			Thread.Sleep( 300 );
			snake.Move();
			Thread.Sleep( 300 );
			snake.Move();
			Thread.Sleep( 300 );
			snake.Move();
			Thread.Sleep( 300 );
		}
		
	}
}