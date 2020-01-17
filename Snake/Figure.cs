/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 17.01.2020
 * Time: 09:31
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
	
	
	public class Figure
	{
		protected List<Point> pList;
		
		public void Drow()
			{
				foreach(Point p in pList)
				{
					p.Draw();
				}
			}
	}
}
