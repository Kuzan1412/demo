/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/27/2018
 * Time: 9:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SWPaint
{
	/// <summary>
	/// Description of clsPoint.
	/// </summary>
	public class clsPoint
	{
		protected int ix, iy;
		public int X
		{
			get
			{
				return ix;
			}
			set
			{
				ix = value;
			}
		}
		public int Y
		{
			get
			{
				return iy;
			}
			set
			{
				iy = value;
			}
		}
		public clsPoint(int a, int b)
		{
			ix = a;
			iy = b;
		}
		public clsPoint()
		{
			ix = 0;
			iy = 0;
		}
		public static double Howfar(clsPoint a, clsPoint b)
		{
			double result;
			result = Math.Sqrt(Math.Pow(a.ix - b.ix, 2) + Math.Pow(a.iy - b.iy, 2));
			return result;
		}
	}
}
