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
	/// Description of clsLine.
	/// </summary>
	public class clsLine: clsShape
	{
		public override void Draw(System.Drawing.Graphics g, System.Drawing.Pen p)
		{
			g.DrawLine(p, iA1.X, iA1.Y, iA2.X, iA2.Y);
		}
		public clsLine(clsPoint d1, clsPoint d2)
		{
			iA1 = d1;
			iA2 = d2;
			
		}
		public clsLine()
		{
			
		}
	}
}
