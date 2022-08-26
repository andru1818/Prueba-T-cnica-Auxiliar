using System;
using System.Data;
using libAccesoDatos;
using libEntidades;

namespace libReglasNegocio
{
    public class clsEstudiantesRN
    {
        clsEstudiantesAD objEstudiantes = new clsEstudiantesAD();
       
        public DataTable EstudiantesCrud(string Accion, clsEstudiantesEN entidadEstudiantes)
        {
            try
            {
                clsEstudiantesAD objRN = new clsEstudiantesAD();
                return objRN.EstudiantesCrud(Accion, entidadEstudiantes);
            }
            catch (Exception error)
            {
                throw error;
            }
        }
       

    }
}
