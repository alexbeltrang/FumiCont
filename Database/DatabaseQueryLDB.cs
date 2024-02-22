using FumiCont.Entidades;
using FumiCont.ModelosRespuestas;
using FumiCont.Utilidades;
using SQLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FumiCont.Database
{
    public class DatabaseQueryLDB
    {
        private static string NameDatabase = FunctionsEncrip.Cifrado(2, ConfigurationManager.AppSettings["NameLDB"]);
        private static string dbFile = Path.Combine(Environment.CurrentDirectory, NameDatabase);

        public static RespuestaUsuarioLogin Login(string username, string password)
        {
            RespuestaUsuarioLogin respuestaUsuario = new RespuestaUsuarioLogin();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "select idUser,displayName,Nombres,Apellidos,PerfilId,Email from Usuarios where UserName = '" + username + "' and password = '" + password + "'";
                    var result = query.ExecuteQuery<Usuario>().FirstOrDefault();
                    if (result != null)
                    {
                        respuestaUsuario.esValido = true;
                        respuestaUsuario.respuesta = "Ok";
                        respuestaUsuario.Usuario = result;
                    }
                    else
                    {
                        respuestaUsuario.esValido = false;
                        respuestaUsuario.respuesta = "Usuario o contraseña incorrectos";
                        respuestaUsuario.Usuario = null;
                    }
                }
            }
            catch (Exception ex)
            {
                respuestaUsuario.esValido = false;
                respuestaUsuario.respuesta = ex.Message;
                respuestaUsuario.Usuario = null;
            }
            return respuestaUsuario;
        }

        public static List<RespuestaModuloPadre> getModuloPadre(int PerfilId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	PRM.ModuloId, MDL.Descripcion, MDL.NombreMenuApp FROM    Perfiles AS PER INNER JOIN PerfilModulo AS PRM ON PER.PerfilId = PRM.PerfilId INNER JOIN Modulos AS MDL ON PRM.ModuloId = MDL.ModuloId WHERE   (PRM.isDeleted = 0) AND (MDL.IsDelete = 0) AND MDL.ModuloPadre = 0 AND (PRM.PerfilId =" + PerfilId.ToString() + ") ORDER BY OrdenPresentacion";
                    var result = query.ExecuteQuery<RespuestaModuloPadre>().ToList();
                    if (result != null)
                    {
                        return result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static List<RespuestaModuloPadre> getModuloHijo(int PerfilId, int CodigoPadreId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	PRM.ModuloId, MDL.Descripcion, MDL.NombreMenuApp FROM    Perfiles AS PER INNER JOIN PerfilModulo AS PRM ON PER.PerfilId = PRM.PerfilId INNER JOIN Modulos AS MDL ON PRM.ModuloId = MDL.ModuloId WHERE   (PRM.isDeleted = 0)  AND (MDL.IsDelete = 0)  AND MDL.ModuloPadre = " + CodigoPadreId.ToString() + " AND PER.PerfilId  = " + PerfilId.ToString() + " ORDER BY MDL.OrdenPresentacion";
                    var result = query.ExecuteQuery<RespuestaModuloPadre>().ToList();
                    if (result != null)
                    {
                        return result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static List<Modulo> getModuloPerfil(int PerfilId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	MDL.ModuloId, MDL.Descripcion, MDL.IsDelete, MDL.ModuloPadre, MDL.OrdenPresentacion, MDL.NombreMenuApp FROM Modulos AS MDL INNER JOIN PerfilModulo AS PFM ON MDL.ModuloId = PFM.ModuloId WHERE (PFM.PerfilId = " + PerfilId.ToString() + " )";
                    var result = query.ExecuteQuery<Modulo>().ToList();
                    if (result != null)
                    {
                        return result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<Modulo> getModuloDisponiblePerfil(int PerfilId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	MDL.ModuloId, MDL.Descripcion, MDL.IsDelete,  MDL.ModuloPadre,  MDL.OrdenPresentacion,  MDL.NombreMenuApp  FROM Modulos AS MDL WHERE MDL.IsDelete = 0 AND MDL.ModuloId NOT IN (SELECT	MDL.ModuloId FROM Modulos AS MDL INNER JOIN PerfilModulo AS PFM ON MDL.ModuloId = PFM.ModuloId WHERE (PFM.PerfilId = " + PerfilId.ToString() + "))";
                    var result = query.ExecuteQuery<Modulo>().ToList();
                    if (result != null)
                    {
                        return result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool delModuloPerfil(PerfilModulo perfilModulo)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "DELETE FROM [PerfilModulo]  WHERE PerfilId = " + perfilModulo.PerfilId.ToString() + " AND ModuloId = " + perfilModulo.ModuloId.ToString();
                    var result = query.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<RespuestaDetalleControl> getDetalleControl(long CodigoEncabezado)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "select DET.ControlFumigacionDetId, PRD.Descripcion, TPC.NombreTipoControl, DET.CantidadProducto, UNM.NombreMedida from ControlFumigacionDetalles DET INNER JOIN Productos PRD ON DET.ProductoId = PRD.ProductoId INNER JOIN TipoControles TPC ON TPC.TipoControlId = DET.TipoControlId INNER JOIN UnidadMedida UNM ON UNM.MedidaId = DET.MedidaId where ControlFumigacionId = " + CodigoEncabezado.ToString();
                    var result = query.ExecuteQuery<RespuestaDetalleControl>().ToList();
                    if (result != null)
                    {
                        return result;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
