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
	/// Description of clsA.
	/// </summary>
	public class clsA: clsStudent
	{
		private double imarkc, imarkm, imarkp;
		public double Markc
		{
			get
			{
				return imarkc;
			}
			set
			{
				imarkc = value;
			}
		}
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
		public double Markm
		{
			get
			{
				return imarkm;
			}
			set
			{
				imarkm = value;
			}
		}
		public clsA()
		{
		}
	}
}
