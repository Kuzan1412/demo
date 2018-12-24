/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/24/2018
 * Time: 9:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Library
{
	/// <summary>
	/// Description of clsMagazine.
	/// </summary>
	public class clsMagazine:clsDocument
	{
		private int inum, imonth;
		public int Num
		{
			get
			{
				return inum;
			}
			set
			{
				inum = value;
			}
		}
		public int Month
		{
			get
			{
				return imonth;
			}
			set
			{
				imonth = value;
			}
		}
		public clsMagazine()
		{
		}
	}
}
