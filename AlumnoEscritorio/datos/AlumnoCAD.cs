using AlumnoEscritorio.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoEscritorio.datos
{
    internal class AlumnoCAD
    {

        public static bool guardar(Alumno e)
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "INSERT tb_alumno (nombre,calificacion)VALUES('"+e.Nombre+"',"+e.Calificacion+"') ";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                int cantidad = comando.ExecuteNonQuery();
                if (cantidad == 1)
                {
                    return true;
                    
                }
                else return false;  
                {
                    con.desconectar();
                }
                
            }catch(Exception ex)
            {
                return false;  
            }

        }

        public static DataTable listar()
        {
            try
            {
                Conexion con = new Conexion();
                string sql = "SELECT * FROM tb_alumno;";
                SqlCommand comando = new SqlCommand(sql, con.conectar());
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();
                dt.Load(dr);
               
                    con.desconectar();
                return dt;

                }catch(Exception ex)
            {
                return null;
            }

            
                
            }

        }


    }


