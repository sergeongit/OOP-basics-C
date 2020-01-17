/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 16.01.2020
 * Time: 16:02
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

	class HorizontalLine: Figure
	{
//		List<Point> pList;
		
		public HorizontalLine( int xLeft, int xRight, int y, char sym )
		{				
			pList = new List<Point>();
			for( int x = xLeft; x <= xRight; x++ )
			{
				Point p = new Point( x, y, sym);
				pList.Add(p);
			}
		}
	}
}
