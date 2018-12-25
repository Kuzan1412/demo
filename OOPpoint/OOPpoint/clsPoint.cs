/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/25/2018
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OOPpoint
{
	/// <summary>
	/// Description of clsPoint.
	/// </summary>
	public class clsPoint
	{
		public int ix, iy;
		public clsPoint()
		{
			ix = 0;
			iy = 0;
		}
		public clsPoint(int a, int b)
		{
			ix = a;
			iy = b;
		}
		public static double Howfar(clsPoint a, clsPoint b)
		{
			double result;
			result = Math.Sqrt(Math.Pow(a.ix - b.ix, 2) + Math.Pow(a.iy - b.iy, 2));
			return result;
		}
		
	}
}
