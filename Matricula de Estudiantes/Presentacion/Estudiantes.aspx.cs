using System;
using System.Data;
using System.Web.UI.WebControls;
using libEntidades;
using libReglasNegocio;

namespace Matricula_de_Estudiantes
{
    public partial class Estudiantes : System.Web.UI.Page
    {
        clsEstudiantesEN entidadEstudiantes = new clsEstudiantesEN();
        clsEstudiantesRN objRN = new clsEstudiantesRN();
        clsEstudiantesRN objRNe = new clsEstudiantesRN();

        #region Métodos Públicos 

        private void CargarGrid()
        {
            try
            {
                if (!IsPostBack)
                {
                    gvDatos.DataSource = objRN.EstudiantesCrud("LISTAR", entidadEstudiantes);
                    gvDatos.DataBind();
                }
            }
            catch (Exception Error)
            {

                throw Error;
            }
        }

        private void AsignarentidadEstudiantes()
        {
            try
            {
                entidadEstudiantes.Codigo = Convert.ToInt32(txtCodigo.Text);
                entidadEstudiantes.Nombre = txtNombre.Text;
                entidadEstudiantes.Promedio = Convert.ToInt32(txtPromedio.Text);
                entidadEstudiantes.Telefono = Convert.ToInt32(txtTelefono.Text);

            }

            catch (Exception Error)
            {
                lblError.Text = (Error.Message);
            }
        }

        private void Guardar()
        {
            try
            {
                AsignarentidadEstudiantes();

                DataTable dtInsertarEstudiantes = new DataTable();
                dtInsertarEstudiantes = objRN.EstudiantesCrud("INSERTAR", entidadEstudiantes);

                if (dtInsertarEstudiantes.Rows.Count > 0)
                {
                    if (dtInsertarEstudiantes.Rows[0]["SW"].ToString() != "0")
                    {
                        lblError.Text = (dtInsertarEstudiantes.Rows[0]["Mensaje"].ToString());
                        LimpiarCampos();
                        return;
                    }

                    lblError.Text = (dtInsertarEstudiantes.Rows[0]["Mensaje"].ToString());
                    LimpiarCampos();

                }
                
            }
            catch (Exception Error)
            {
                lblError.Text = (Error.Message);
            }
        }

        private void LimpiarCampos()
        {
            lblError.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtConsecutivo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPromedio.Text = string.Empty;
            txtTelefono.Text = string.Empty;           

        }

        #endregion

        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtConsecutivo.Visible = false;
                CargarGrid();                
            }

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            CargarGrid();

        }

        #endregion
       
    }
}