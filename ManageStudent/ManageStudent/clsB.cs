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
	/// Description of clsB.
	/// </summary>
	public class clsB: clsStudent
	{
		private double imarkp, imarkc, imarkb;
		public double Markp
		{
			get
			{
				return imarkp;
			}
			set
			{
				imarkp = value;
			}
		}
		public double Markb
		{
			get
			{
				return imarkb;
			}
			set
			{
				imarkb = value;
			}
		}
		public double Markc
		{
			get
			{
				return imarkc;
			}
			set
			{
				imarkc =  value;
			}
		}
		public clsB()
		{
		}
	}
}
