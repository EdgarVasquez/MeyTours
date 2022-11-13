using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeyTours.CapaDeDatos;
namespace MeyTours.Capa_Logica
{
	public class BusesLogic
	{
		CapaDeDatos.DataSet1TableAdapters.BusesTableAdapter DB = new CapaDeDatos.DataSet1TableAdapters.BusesTableAdapter();
		public bool Crear(BusesEntity busesEntity)
		{
			try
			{
				int result = DB.InsertQuery(busesEntity.Marca, busesEntity.Modelo, busesEntity.Placa, busesEntity.Color, busesEntity.Año,DateTime.Now.ToString());
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
		public bool Editar(BusesEntity busesEntity)
		{
			try
			{
				int result = DB.UpdateQuery(busesEntity.Marca, busesEntity.Modelo, busesEntity.Placa, busesEntity.Color, busesEntity.Año, DateTime.Now.ToString(),busesEntity.Id);
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
		public bool Eliminar(BusesEntity busesEntity)
		{
			try
			{
				int result = DB.DeleteQuery(busesEntity.Id);
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
