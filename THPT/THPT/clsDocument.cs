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
	/// Description of clsDocument.
	/// </summary>
	public class clsDocument
	{
		clsStudent istudent;
		private string iclass, iterm;
		private  int ik;
		public clsStudent Student
		{
			get
			{
				return istudent;
			}
			set
			{
				istudent.Add = value.Add;
				istudent.Age = value.Age;
				istudent.Name = value.Name;
				istudent.Year = value.Year;
			}
		}
		public string Class
		{
			get
			{
				return iclass;
			}
			set
			{
				iclass = value;
			}
		}
		public string Term
		{
			get
			{
				return iterm;
			}
			set
			{
				iterm = value;
			}
		}
		public int K
		{
			get
			{
				return ik;
			}
			set
			{
				ik = value;
			}
		}
		public clsDocument()
		{
			istudent = new clsStudent();
		}
	}
}
