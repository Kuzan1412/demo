/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/25/2018
 * Time: 7:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ManageStudent
{
	/// <summary>
	/// Description of clsC.
	/// </summary>
	public class clsC:clsStudent
	{
		private double imarkl, imarkh, imarkg;
		public double Markl
		{
			get
			{
				return imarkl;
			}
			set
			{
				imarkl = value;
			}
		}
		public double Markh
		{
			get
			{
				return imarkh;
			}
			set
			{
				imarkh = value;
			}
		}
		public double Markg
		{
			get
			{
				return imarkg;
			}
			set
			{
				imarkg = value;
			}
		}
		public clsC()
		{
		}
	}
}
