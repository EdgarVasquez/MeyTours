using MeyTours.CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeyTours.Capa_Logica
{
	public class RutaLogic
	{
		CapaDeDatos.DataSet1TableAdapters.RutaTableAdapter DB = new CapaDeDatos.DataSet1TableAdapters.RutaTableAdapter();
		public bool Crear(RutaEntity RutaEntity)
		{
			try
			{
				int result = DB.InsertQuery(RutaEntity.Descripcion, DateTime.Now);
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
		public bool Editar(RutaEntity RutaEntity)
		{
			try
			{
				int result = DB.UpdateQuery(RutaEntity.Descripcion, RutaEntity.Id);
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
		public bool Eliminar(RutaEntity RutaEntity)
		{
			try
			{
				int result = DB.DeleteQuery(RutaEntity.Id);
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
