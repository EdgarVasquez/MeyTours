using MeyTours.CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeyTours.Capa_Logica
{
	public class AsignacionLogic
	{
		CapaDeDatos.DataSet1TableAdapters.AsignacionTableAdapter DB = new CapaDeDatos.DataSet1TableAdapters.AsignacionTableAdapter();
		string mensaje = "Error";
		public string Crear(AsignacionEntity AsignacionEntity)
		{
			try
			{
				var result = DB.PP_SETAsignacion(AsignacionEntity.IdBus, AsignacionEntity.IdChofer, AsignacionEntity.IdRuta, AsignacionEntity.ID, 1, ref mensaje);
				return mensaje;
			
			}
			catch (Exception)
			{

				throw;
			}
		}
		public string Editar(AsignacionEntity AsignacionEntity)
		{
			try
			{
				var result = DB.PP_SETAsignacion(AsignacionEntity.IdBus, AsignacionEntity.IdChofer, AsignacionEntity.IdRuta, AsignacionEntity.ID, 2, ref mensaje);
		
				return mensaje;
			}
			catch (Exception)
			{

				throw;
			}
		}
		public string Eliminar(AsignacionEntity AsignacionEntity)
		{
			try
			{
				var result = DB.PP_SETAsignacion(AsignacionEntity.IdBus, AsignacionEntity.IdChofer, AsignacionEntity.IdRuta, AsignacionEntity.ID, 3, ref mensaje);
				return mensaje;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
