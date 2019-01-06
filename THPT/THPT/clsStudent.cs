/*
 * Created by SharpDevelop.
 * User: user
 * Date: 1/6/2019
 * Time: 3:50 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace THPT
{
	/// <summary>
	/// Description of clsStudent.
	/// </summary>
	public class clsStudent
	{
		private string iname, iadd;
		private int iage, iyear;
		public string Name
		{
			get
			{
				return iname;
			}
			set
			{
				iname = value;
			}
		}
		public string Add
		{
			get
			{
				return iadd;
			}
			set
			{
				iadd = value;
			}
		}
		public int Age
		{
			get
			{
				return DateTime.Now.Year - iyear;
			}
			set
			{
				
			}
			
		}
		public int Year
		{
			get
			{
				return iyear;
			}
			set
			{
				iyear = value;
			}
		}
		public clsStudent()
		{
		}
	}
}
