using System;
using System.Data;
using System.Data.SqlClient;
using libConexion;
using libEntidades;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data.Common;

namespace libAccesoDatos
{   
    public class clsEstudiantesAD
    {
        //Instancia de la base de datos con enterprise library llamando directamente al config
        private Database DBEstudiantes = DatabaseFactory.CreateDatabase("cnn");

        private clsAccesoSQL objDatos = new clsAccesoSQL();
        

        public DataTable EstudiantesCrud(string Accion, clsEstudiantesEN entidadEstudiantes)
        {
            try
            {
                DataTable dtDatos = new DataTable();
                SqlParameter[] Parametros;
                switch (Accion)
                {
                    case "INSERTAR":

                        Parametros = new SqlParameter[6];
                        
                        Parametros[0] = new SqlParameter("@Codigo", entidadEstudiantes.Codigo);                        
                        Parametros[1] = new SqlParameter("@Nombre", entidadEstudiantes.Nombre);
                        Parametros[2] = new SqlParameter("@Promedio", entidadEstudiantes.Promedio);
                        Parametros[3] = new SqlParameter("@Id_Telefono", entidadEstudiantes.Id_Telefono);                        
                        Parametros[4] = new SqlParameter("@Telefono", entidadEstudiantes.Telefono);                        
                        Parametros[5] = new SqlParameter("@Accion", Accion);

                        break;

                    case "ACTUALIZAR":

                        Parametros = new SqlParameter[6];

                        Parametros[0] = new SqlParameter("@Codigo", entidadEstudiantes.Codigo);
                        Parametros[1] = new SqlParameter("@Nombre", entidadEstudiantes.Nombre);
                        Parametros[2] = new SqlParameter("@Promedio", entidadEstudiantes.Promedio);
                        Parametros[3] = new SqlParameter("@Id_Telefono", entidadEstudiantes.Id_Telefono);
                        Parametros[4] = new SqlParameter("@Telefono", entidadEstudiantes.Telefono);
                        Parametros[5] = new SqlParameter("@Accion", Accion);

                        break;

                    case "ELIMINAR":

                        Parametros = new SqlParameter[2];

                        Parametros[0] = new SqlParameter("@Codigo", entidadEstudiantes.Codigo);                        
                        Parametros[1] = new SqlParameter("@Accion", Accion);

                        break;

                    case "CONSULTAR":

                        Parametros = new SqlParameter[2];

                        Parametros[0] = new SqlParameter("@Codigo", entidadEstudiantes.Codigo);
                        Parametros[1] = new SqlParameter("@Accion", Accion);

                        break;

                    case "LISTAR":

                        Parametros = new SqlParameter[1];
                        
                        Parametros[0] = new SqlParameter("@Accion", Accion);

                        break;


                    default:
                        return null;
                }
                dtDatos = objDatos.TraerDataTable(objDatos.ObtenerConexion("cnn"), "sp_Estudiantes_CRUD", Parametros);
                return dtDatos;

            }
            catch (Exception error)
            {
                throw error;
            }

        }

        

    }
}
