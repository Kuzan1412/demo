/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/27/2018
 * Time: 9:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace SWPaint
{
	/// <summary>
	/// Description of clsRectangle.
	/// </summary>
	public class clsRhombus: clsShape
	{
		clsPoint iA3, iA4;
		Point[] polygonPoints = new Point[4];
		public override void Draw(Graphics g, Pen p)
		{
			g.DrawLine(p, iA1.X, iA1.Y, iA2.X, iA2.Y);
			g.DrawLine(p, iA1.X, iA3.Y, iA3.X, iA3.Y);
			g.DrawLine(p, iA3.X, iA3.Y, iA4.X, iA4.Y);
			g.DrawLine(p, iA4.X, iA4.Y, iA1.X, iA1.Y);
		}
		public clsRhombus(clsPoint d1, clsPoint d2, clsPoint d3, clsPoint d4)
		{
			iA1 = d1;
			iA2 = d2;
			iA3 = d3;
			iA4 = d4;
		}
	}
}
