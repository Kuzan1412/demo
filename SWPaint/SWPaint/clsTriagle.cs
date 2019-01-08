/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/27/2018
 * Time: 9:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
namespace SWPaint
{
	/// <summary>
	/// Description of clsElip.
	/// </summary>
	public class clsTriagle: clsShape
	{
		clsPoint iA3;
		
		public static double Space(clsPoint xA, clsPoint xB)
		{
			return Math.Sqrt(Math.Pow(xB.X - xA.X, 2) + Math.Pow(xB.Y - xA.Y, 2));
		}
		
		public clsTriagle(clsPoint xA, clsPoint xB, clsPoint xC)
		{
			iA1 = xA;
			iA2 = xB;
			iA3 = xC;
		}
		public override void Draw(System.Drawing.Graphics g, System.Drawing.Pen p)
		{
			g.DrawLine(p, iA1.X, iA1.Y, iA2.X, iA2.Y);
			g.DrawLine(p, iA2.X, iA2.Y, iA3.X, iA3.Y);
			g.DrawLine(p, iA3.X, iA3.Y, iA1.X, iA1.Y);
		}
		
	}
}
