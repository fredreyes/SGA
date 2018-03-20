using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
  public  class DAlumnos
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

        public EAlumnos BuscarAlumno(EAlumnos alumno)
        {
            try
            {
                comando = new SqlCommand("ListarAlumno", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@AlumnoId", alumno.AlumnoId);
                comando.Connection = conexion;
                conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();
                EAlumnos a = new EAlumnos();
                while (leer.Read())
                { 
                    a.AlumnoId = (int)leer[0];
                    a.Nombres = leer["Nombres"].ToString();
                    a.Apellidos = leer["Apellidos"].ToString();
                    a.Sexo = leer[3].ToString();
                    a.FechaNacimiento = (DateTime)leer[4];
                    a.Direccion = leer[5].ToString();
                    a.CodigoMined = (int)leer[6];
                    a.Activo = (bool)leer[7];
                    a.DOCUMENTO_ALUMNO_ID = (int)leer[8];
                    a.PARTIDA_DE_NACIMINETO = leer[9].ToString();
                    a.CERTIFICADO_NOTAS = leer[10].ToString();
                    a.TARJETA_VACUNA = leer[11].ToString();
                    a.CARTA_TRASLADO = leer[12].ToString();
                    a.CERTIFICADO_DE_SALUD = leer[13].ToString();
                    a.FOTO = (byte[])leer[14];
                    a.ID_PARENTEZCO = (int)leer[15];
                    a.NOMBRE_PADRE = leer[16].ToString();
                    a.CEDULA_PADRE = leer[17].ToString();
                    a.TELEFONO_PADRE = leer[18].ToString();
                    a.EMAIL_PADRE = leer[19].ToString();
                    a.OCUPACION_PADRE = leer[20].ToString();
                    a.NOMBRE_MADRE = leer[21].ToString();
                    a.CEDULA_MADRE = leer[22].ToString();
                    a.TELEFONO_MADRE = leer[23].ToString();
                    a.EMAIL_MADRE = leer[24].ToString();
                    a.OCUPACION_MADRE = leer[25].ToString();
                    a.TutorAlumnoID = (int)leer[26];
                    a.NombreTutor = leer[27].ToString();
                    a.CedulaTutor = leer[28].ToString();
                    a.TelefonoTutor = leer[29].ToString();
                    a.ParentezcoAlumno = leer[30].ToString();
                }
                leer.Close();
                conexion.Close();
                return a;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IngresarAlumno(EAlumnos a, EPadres_Tutor p,EDocuemntosAlumnos d)
        {
            try
            {
                comando = new SqlCommand("IngresarEstudiante");
                //Alumnos
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombres", a.Nombres);
                comando.Parameters.AddWithValue("@Apellidos", a.Apellidos);
                comando.Parameters.AddWithValue("@Sexo", a.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", a.FechaNacimiento);
                comando.Parameters.AddWithValue("@Direccion", a.Direccion);
                comando.Parameters.AddWithValue("@CodigoMined", a.CodigoMined);
                //Padres Alumnos
                comando.Parameters.AddWithValue("@NombresPadres", p.NOMBRE_PADRE);
                comando.Parameters.AddWithValue("@CedulaPadre", p.CEDULA_PADRE);
                comando.Parameters.AddWithValue("@TelefonoPadre", p.TELEFONO_PADRE);
                comando.Parameters.AddWithValue("@EmailPadre", p.EMAIL_PADRE);
                comando.Parameters.AddWithValue("@OcupacionPadre", p.OCUPACION_PADRE);
                comando.Parameters.AddWithValue("@NombresMadres", p.NOMBRE_MADRE);
                comando.Parameters.AddWithValue("@CedulaMadre", p.CEDULA_MADRE);
                comando.Parameters.AddWithValue("@TelefonoMadre", p.TELEFONO_MADRE);
                comando.Parameters.AddWithValue("@EmailMadre", p.EMAIL_MADRE);
                comando.Parameters.AddWithValue("@OcupacionMadre", p.OCUPACION_MADRE);
                //Documentos Alumnos
                comando.Parameters.AddWithValue("@PartidaNaciminto", d.PARTIDA_DE_NACIMINETO);
                comando.Parameters.AddWithValue("@CertificadoNotas", d.CERTIFICADO_NOTAS);
                comando.Parameters.AddWithValue("@TarjetaVacuna", d.TARJETA_VACUNA);
                comando.Parameters.AddWithValue("@CartaTraslado", d.CARTA_TRASLADO);
                comando.Parameters.AddWithValue("@CertificadoSalud", d.CERTIFICADO_DE_SALUD);
                comando.Parameters.AddWithValue("@Foto", d.FOTO);
                //Tutor Alumno
                //Tutor Alumno
                comando.Parameters.AddWithValue("@NombreTutor", a.NombreTutor);
                comando.Parameters.AddWithValue("@CedulaTutor", a.CedulaTutor);
                comando.Parameters.AddWithValue("@TelefonoTutor", a.TelefonoTutor);
                comando.Parameters.AddWithValue("@ParentezcoAlumno", a.ParentezcoAlumno);
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                conexion.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ModificarAlumno(EAlumnos a, EPadres_Tutor p, EDocuemntosAlumnos d)
        {
            try
            {
                comando = new SqlCommand("ModificarEstudiante");
                //Alumnos
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombres", a.Nombres);
                comando.Parameters.AddWithValue("@Apellidos", a.Apellidos);
                comando.Parameters.AddWithValue("@Sexo", a.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", a.FechaNacimiento);
                comando.Parameters.AddWithValue("@Direccion", a.Direccion);
                comando.Parameters.AddWithValue("@CodigoMined", a.CodigoMined);
                comando.Parameters.AddWithValue("@Activo", a.Activo);
                //Padres Alumnos
                comando.Parameters.AddWithValue("@NombresPadres", p.NOMBRE_PADRE);
                comando.Parameters.AddWithValue("@CedulaPadre", p.CEDULA_PADRE);
                comando.Parameters.AddWithValue("@TelefonoPadre", p.TELEFONO_PADRE);
                comando.Parameters.AddWithValue("@EmailPadre", p.EMAIL_PADRE);
                comando.Parameters.AddWithValue("@OcupacionPadre", p.OCUPACION_PADRE);
                comando.Parameters.AddWithValue("@NombresMadres", p.NOMBRE_MADRE);
                comando.Parameters.AddWithValue("@CedulaMadre", p.CEDULA_MADRE);
                comando.Parameters.AddWithValue("@TelefonoMadre", p.TELEFONO_MADRE);
                comando.Parameters.AddWithValue("@EmailMadre", p.EMAIL_MADRE);
                comando.Parameters.AddWithValue("@OcupacionMadre", p.OCUPACION_MADRE);
                //Documentos Alumnos
                comando.Parameters.AddWithValue("@PartidaNaciminto", d.PARTIDA_DE_NACIMINETO);
                comando.Parameters.AddWithValue("@CertificadoNotas", d.CERTIFICADO_NOTAS);
                comando.Parameters.AddWithValue("@TarjetaVacuna", d.TARJETA_VACUNA);
                comando.Parameters.AddWithValue("@CartaTraslado", d.CARTA_TRASLADO);
                comando.Parameters.AddWithValue("@CertificadoSalud", d.CERTIFICADO_DE_SALUD);
                comando.Parameters.AddWithValue("@Foto", d.FOTO);
                //Tutor Alumno
                comando.Parameters.AddWithValue("@NombreTutor", a.NombreTutor);
                comando.Parameters.AddWithValue("@CedulaTutor", a.CedulaTutor);
                comando.Parameters.AddWithValue("@TelefonoTutor", a.TelefonoTutor);
                comando.Parameters.AddWithValue("@ParentezcoAlumno", a.ParentezcoAlumno);
                comando.Parameters.AddWithValue("@AlumnoID", a.AlumnoId);
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                conexion.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
