/*
 * Created by SharpDevelop.
 * User: user
 * Date: 12/26/2018
 * Time: 9:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Vehicle
{
	/// <summary>
	/// Description of clsContainer.
	/// </summary>
	public class clsContainer:clsVehicle
	{
		
		private string ipayload;
		public string Payload
		{
			get 
			{
				return ipayload;
			}
			set
			{
				ipayload = value;
			}
		}
		public clsContainer()
		{
		}
	}
}
