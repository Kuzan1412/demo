/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/25/2018
 * Time: 8:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
namespace OOPpoint
{
	/// <summary>
	/// Description of clsRectangle.
	/// </summary>
	public class clsRectangle
	{
		public clsPoint A = new clsPoint();
		public clsPoint B = new clsPoint();
		public clsPoint C = new clsPoint();
		public clsPoint iA
		{
			get
			{
				return A;
			}
			set
			{
				A = value;
			}
		}
		public clsPoint iB
		{
			get
			{
				return B;
			}
			set
			{
				B = value;
			}
		}
		public clsPoint iC
		{
			get
			{
				 return C;
			}
			set
			{
				C = value;
			}
		}
		
		public static double Space(clsPoint xA, clsPoint xB)
		{
			return Math.Sqrt(Math.Pow(xB.ix - xA.ix, 2) + Math.Pow(xB.iy - xA.iy, 2));
		}
		public static double perimeter(clsPoint xA, clsPoint xB, clsPoint xC)
		{
			double p;
			p = (Space(xA, xB) + Space(xA, xC) + Space(xB, xC));
			return p;
		}
		public static double area(clsPoint xA, clsPoint xB, clsPoint xC)
		{
			double p = perimeter(xA, xB, xC)/2;
			
			double area = Math.Sqrt(p*(p-Space(xA,xB))*(p-Space(xA, xB))*(p-Space(xB, xC)));
			return area;
		}
		public clsRectangle(clsPoint xA, clsPoint xB, clsPoint xC)
		{
			A = xA;
			B = xB;
			C = xC;
		}
	}
}
