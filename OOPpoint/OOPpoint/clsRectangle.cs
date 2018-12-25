/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/25/2018
 * Time: 8:51 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

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
		
		public clsRectangle(clsPoint xA, clsPoint xB, clsPoint xC)
		{
			A = xA;
			B = xB;
			C = xC;
		}
	}
}
