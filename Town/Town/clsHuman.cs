/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/26/2018
 * Time: 9:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text.RegularExpressions;
namespace Town
{
	/// <summary>
	/// Description of clsHuman.
	/// </summary>
	public class clsHuman:clsTown
	{
		protected string iName, imajor;
		protected int iyear, iage;
		
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
		public int Age
		{
			get
			{
				return iage;
			}
			set
				
			{
				iage = value;
			}
		}
		public string Name
		{
			get
			{
				return iName;
			}
			set
			{
				iName = value;
			}
			
		}
		public string Major
		{
			get
			{
				return imajor;
			}
			set 
			{
				imajor = value;
			}
		}
		public clsHuman()
		{
		}
	}
}
