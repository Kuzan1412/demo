/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/10/2018
 * Time: 11:16 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CANBO
{
	/// <summary>
	/// Description of clsCANBO.
	/// </summary>
	public class clsCANBO
	{
		private string name, address, sex;
		private int dob;
		public string nsex
		{
			get
			{
				return sex;
			}
			set
			{
				sex = value;
			}
		}
		public int ndob
		{
			get
			{
				return dob;
			}
			set
			{
				dob = value;
			}
		}
		public string nname
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		
		public string naddress
		{
			get
			{
				return address;				
			}
			set 
			{
				address = value;
			}
		}
		public clsCANBO()
		{
		}
	}
}
