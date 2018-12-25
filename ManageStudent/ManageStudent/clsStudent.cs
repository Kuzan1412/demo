/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/25/2018
 * Time: 7:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ManageStudent
{
	/// <summary>
	/// Description of clsStudent.
	/// </summary>
	public class clsStudent
	{
		protected string iName, iaddress;
		protected int iid, ipriority;
		public int Priority
		{
			get 
			{
				return ipriority;
			}
			set
			{
				ipriority = value;
			}
		}
		public string Address
		{
			get 
			{
				return iaddress;
			}
			set
			{
				iaddress = value;
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
				iName= value;
			}
		}
		public int Id
		{
			get
			{
				return iid;
			}
			set 
			{
				iid= value;
			}
		}
	
		public clsStudent()
		{
			
		}
	}
}
