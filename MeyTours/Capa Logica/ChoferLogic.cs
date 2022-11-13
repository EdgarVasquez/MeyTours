using MeyTours.CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeyTours.Capa_Logica
{
	public class ChoferLogic
	{
		CapaDeDatos.DataSet1TableAdapters.ChoferesTableAdapter DB = new CapaDeDatos.DataSet1TableAdapters.ChoferesTableAdapter();
		public bool Crear(ChoferEntity ChoferEntity)
		{
			try
			{
				int result = DB.InsertQuery(ChoferEntity.Nombre, ChoferEntity.Apellido, ChoferEntity.FechaDeNacimiento, ChoferEntity.Cedula, DateTime.Now);
				if (result >= 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
		public bool Editar(ChoferEntity ChoferEntity)
		{
			try
			{
				int result = DB.UpdateQuery(ChoferEntity.Nombre, ChoferEntity.Apellido, ChoferEntity.FechaDeNacimiento, ChoferEntity.Cedula,  DateTime.Now, ChoferEntity.Id);
				if (result >= 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
		public bool Eliminar(ChoferEntity ChoferEntity)
		{
			try
			{
				int result = DB.DeleteQuery(ChoferEntity.Id);
				if (result >= 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
