/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/27/2018
 * Time: 9:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace SWPaint
{
	/// <summary>
	/// Description of clsShape.
	/// </summary>
	public class clsShape
	{
		clsPoint A1, A2;
		
		public clsPoint iA1 
		{
			get
			{
				return A1;
			}
			set 
			{
				A1.X = value.X;
				A1.Y = value.Y;
			}
		}
		public clsPoint iA2
		{
			get 
			{
				return A2;
			}
			set
			{
				A2.X = value.X;
				A2.Y = value.Y;
			}
		}
		public virtual void Draw(Graphics g, Pen p)
		{
			
		}
		
		public clsShape()
		{
			A1 = new clsPoint();
			A2 = new clsPoint();
		}
	}
}
