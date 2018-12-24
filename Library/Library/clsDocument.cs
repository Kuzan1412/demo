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
	/// Description of clsDocument.
	/// </summary>
	public class clsDocument
	{
		protected int iid, iedit;
		protected string iName;
		public int id
		{
			get
			{
				return iid;
			}
			set
			{
				iid = value;
			}
		}
		public int edit
		{
			get
			{
				return iedit;
			}
			set 
			{
				iedit = value;
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
		public clsDocument()
		{
		}
	}
}
