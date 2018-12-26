/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/26/2018
 * Time: 9:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Vehicle
{
	/// <summary>
	/// Description of clsMotobike.
	/// </summary>
	public class clsMotobike:clsVehicle
	{
		private string icapacity;
		public string Capacity
		{
			get 
			{
				return icapacity;	
			}
			set
			{
				icapacity = value;
			}
		}

		public clsMotobike()
		{
		}
	}
}
