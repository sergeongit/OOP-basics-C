﻿/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 16.01.2020
 * Time: 16:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine
	{
		List<Point> pList;
		
		public VerticalLine(int yTop, int yBottom, int x, char sym)
		{
			pList = new List<Point>();
			for( int y = yTop; y <= yBottom; y++ )
			{
				Point p = new Point(x, y, sym);
				pList.Add( p );
			}
		}
		public void Drow()
			{
				foreach(Point p in pList)
				{
					p.Draw();
				}
			}
		
	}
}
