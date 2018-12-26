/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/26/2018
 * Time: 9:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Vehicle
{
	/// <summary>
	/// Description of clsCar.
	/// </summary>
	public class clsCar:clsVehicle
	{
		private int iseat;
		private string iengine;
		public int Seat
		{
			get
			{
				return iseat;
			}
			set
			{
				iseat = value;
			}
		}
		public string Engine
		{
			get
			{
				return iengine;
			}
			set
			{
				iengine = value;
			}
		}
		public clsCar()
		{
		}
	}
}
