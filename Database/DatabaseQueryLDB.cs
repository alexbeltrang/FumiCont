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


        public static List<Perfil> getListaPerfilesCombos()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	PerfilId, NombrePerfil FROM    Perfiles WHERE   isDelete = 0";
                    var result = query.ExecuteQuery<Perfil>().ToList();
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

        public static List<Usuario> getListaUsuarios()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	idUser, UserName, Nombres, Apellidos, DisplayName, Email, PerfilId, isDelete, password FROM    Usuarios";
                    var result = query.ExecuteQuery<Usuario>().ToList();
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


        public static List<Perfil> getListaPerfilesAll()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	PerfilId, NombrePerfil, isDelete FROM    Perfiles";
                    var result = query.ExecuteQuery<Perfil>().ToList();
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

        public static Usuario getUsuarioxId(int userId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	idUser, UserName, Nombres, Apellidos, DisplayName, Email, PerfilId, isDelete, password FROM    Usuarios where idUser = " + userId.ToString(); ;
                    var result = query.ExecuteQuery<Usuario>().FirstOrDefault();
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

        public static Perfil getListaPerfilesxId(int PerfilId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	PerfilId, NombrePerfil, isDelete FROM    Perfiles where PerfilId = " + PerfilId.ToString(); ;
                    var result = query.ExecuteQuery<Perfil>().FirstOrDefault();
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

        public static Productos getProductoxId(int productoId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT ProductoId,Descripcion, Referencia, IsDelete FROM Productos where ProductoId = " + productoId.ToString();
                    var result = query.ExecuteQuery<Productos>().FirstOrDefault();
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



        public static List<Productos> GetListaProductos(bool GetAll, bool GetActive, bool GetDelete)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	* FROM Productos ";
                    if (GetAll)
                    {
                        GetActive = false;
                        GetDelete = false;
                    }
                    else if (GetActive)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 0";
                    }
                    else if (GetDelete)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 1";
                    }
                    var result = query.ExecuteQuery<Productos>().ToList();
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

        public static List<Proveedor> GetListaProveedores(bool GetAll, bool GetActive, bool GetDelete)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	* FROM Proveedores ";
                    if (GetAll)
                    {
                        GetActive = false;
                        GetDelete = false;
                    }
                    else if (GetActive)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 0";
                    }
                    else if (GetDelete)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 1";
                    }
                    var result = query.ExecuteQuery<Proveedor>().ToList();
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


        public static Proveedor getProveedorxId(int proveedorId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT * FROM Proveedores where ProveedorId = " + proveedorId.ToString();
                    var result = query.ExecuteQuery<Proveedor>().FirstOrDefault();
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

        public static List<UnidadMedida> GetListaUnidadMedida(bool GetAll, bool GetActive, bool GetDelete)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	* FROM UnidadMedida ";
                    if (GetAll)
                    {
                        GetActive = false;
                        GetDelete = false;
                    }
                    else if (GetActive)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 0";
                    }
                    else if (GetDelete)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 1";
                    }
                    var result = query.ExecuteQuery<UnidadMedida>().ToList();
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


        public static UnidadMedida getUnidadMedidaxId(int MedidaIdId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT * FROM UnidadMedida where MedidaId = " + MedidaIdId.ToString();
                    var result = query.ExecuteQuery<UnidadMedida>().FirstOrDefault();
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



        public static List<Cultivo> getListaCultivosAll(bool GetAll, bool GetActive, bool GetDelete)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	* FROM Cultivos ";
                    if (GetAll)
                    {
                        GetActive = false;
                        GetDelete = false;
                    }
                    else if (GetActive)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 0";
                    }
                    else if (GetDelete)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 1";
                    }
                    var result = query.ExecuteQuery<Cultivo>().ToList();
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


        public static Cultivo getCultivoxId(int cultivoId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT * FROM Cultivos where CultivoId = " + cultivoId.ToString();
                    var result = query.ExecuteQuery<Cultivo>().FirstOrDefault();
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



        public static List<Lote> getListaLotesAll(bool GetAll, bool GetActive, bool GetDelete)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	* FROM Lotes ";
                    if (GetAll)
                    {
                        GetActive = false;
                        GetDelete = false;
                    }
                    else if (GetActive)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 0";
                    }
                    else if (GetDelete)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 1";
                    }
                    var result = query.ExecuteQuery<Lote>().ToList();
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


        public static Lote getLotexId(int LoteId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT * FROM Lotes where LoteId = " + LoteId.ToString();
                    var result = query.ExecuteQuery<Lote>().FirstOrDefault();
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


        public static List<Empleado> getListaEmpleadosAll(bool GetAll, bool GetActive, bool GetDelete)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT	* FROM Empleados ";
                    if (GetAll)
                    {
                        GetActive = false;
                        GetDelete = false;
                    }
                    else if (GetActive)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 0";
                    }
                    else if (GetDelete)
                    {
                        query.CommandText = query.CommandText + "WHERE IsDelete = 1";
                    }
                    var result = query.ExecuteQuery<Empleado>().ToList();
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


        public static Empleado getEmpleadoxId(int EmpleadoId)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(dbFile))
                {
                    var query = new SQLiteCommand(conn);
                    query.CommandText = "SELECT * FROM Empleados where EmpleadoId = " + EmpleadoId.ToString();
                    var result = query.ExecuteQuery<Empleado>().FirstOrDefault();
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
