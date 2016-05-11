using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Data.SQLite;
using System.Reflection;
using System.Resources;
using System.Collections;
using System.Globalization;
using System.Windows.Forms;

using System.Collections.Generic;
using ChefTools.Helper;

namespace ChefTools.Data
{
    public class DBHelper
    {


        public SQLiteConnection m_dbConnection = null;
        private SQLiteCommand command = null;
        public static String DATABASE_NAME = "ChefToolsDB.sqlite";

        //Tablas nombres...
        public static String TABLE_RECETAS = "tbl_Recetas";
        public static String TABLE_MENUSCARTAS = "tbl_Menus_Cartas";
        public static String TABLE_PROVEEDORES = "tbl_Proveedores";
        public static String TABLE_PEDIDOS = "tbl_Pedidos";
        public static String TABLE_INVENTARIOS = "tbl_Inventarios";
        public static String TABLE_PRODUCTOS = "tbl_Productos";
        public static String TABLE_PRODUCTOS_FORMATO = "tbl_Productos_formato";
        public static String TABLE_PRODUCTOS_CATEGORY = "tbl_Productos_categoria";
        public static String TABLE_RECETAS_CATEGORIA = "tbl_Recetas_categoria";
        public static String TABLE_PEDIDOS_LISTAS = "tbl_Pedidos_listas";
        public static String TABLE_INVENTARIOS_LISTAS = "tbl_Inventarios_listas";

        //Campos generales...
        public static String ID = "id";
        public static String NAME = "name";
        public static String FECHA = "date";
        public static String COMENTARIO = "comentario";

        //Campos recetas tabla
        //ID y NAME generales
        public static String RECETA_INGREDIENTES = "ingredientes";
        public static String RECETA_ELABORACION = "elaboracion";
        public static String RECETA_IMG = "img";
        public static String RECETA_CATEGORIA_ID = "categoria_id";
        public static String RECETA_URL = "url";


        //Campos Menus Cartas tabla
        //ID ,FECHA y NAME generales
        public static String MENUS_CARTAS_ENTRANTES = "mc_entrantes";
        public static String MENUS_CARTAS_PRIMEROS = "mc_primeros";
        public static String MENUS_CARTAS_SEGUNDOS = "mc_segundos";
        public static String MENUS_CARTAS_POSTRES = "mc_postres";

        //Campos Proveedores tabla
        //ID y NAME generales

        public static String PROVEEDOR_CATEGORIA = "prov_categoria";
        public static String PROVEEDOR_TELEFONO = "prov_telefono";
        public static String PROVEEDOR_DIRECCION = "prov_direccion";
        public static String PROVEEDOR_EMAIL = "prov_email";


        //Campos Productos tabla
        //ID y NAME generales
        public static String PRODUCTO_PROVEEDOR_ID = "product_provider_id";
        public static String PRODUCTO_CATEGORIA_ID = "product_categoria_id";
        public static String PRODUCTO_FORMATO_ID = "product_formato_id";
        public static String PRODUCTO_FORMATO_NAME = "product_formato_name";
        public static String PRODUCTO_CATEGORIA_NAME_ = "product_categoria_name";
        public static String PRODUCTO_PROVEEDOR_NAME = "product_proveedor_name";

        //Campos Pedidos e inventarios listas tabla
        // PRODUCTO_CATEGORIA_ID PRODUCTO_FORMATO_ID tambien

        public static String INVENTARIO_ID = "inventario_id";
        public static String PEDIDO_ID = "pedido_id";
        public static String PRODUCTO_ID = "producto_id";
        public static String PRODUCTO_CANTIDAD = "producto_cantidad";
        public static String PROVEEDOR_ID = "proveedor_id";


        private static String SqlCreateTable_recetas = "CREATE TABLE IF NOT EXISTS "
                + TABLE_RECETAS + "(" + ID + " INTEGER PRIMARY KEY,"
                + NAME + " TEXT, "
                + RECETA_IMG + "  TEXT, "
                + RECETA_INGREDIENTES + "  TEXT, "
                + RECETA_ELABORACION + "  TEXT, "
                + RECETA_URL + "  TEXT, "
                + FECHA + " DEFAULT CURRENT_TIMESTAMP, "
                + RECETA_CATEGORIA_ID + " INTEGER)";


        private static String SqlCreateTable_menus_cartas = "CREATE TABLE IF NOT EXISTS "
                + TABLE_MENUSCARTAS + "(" + ID + " INTEGER PRIMARY KEY,"
                + NAME + " TEXT, "
                + MENUS_CARTAS_ENTRANTES + "  TEXT, "
                + MENUS_CARTAS_PRIMEROS + "  TEXT, "
                + MENUS_CARTAS_SEGUNDOS + "  TEXT, "
                + MENUS_CARTAS_POSTRES + "  TEXT, "
                + COMENTARIO + "  TEXT, "
                + FECHA + " DEFAULT CURRENT_TIMESTAMP)";

        private static String SqlCreateTable_providers = "CREATE TABLE IF NOT EXISTS "
                + TABLE_PROVEEDORES + "(" + ID + " INTEGER PRIMARY KEY,"
                + NAME + " TEXT, "
                + PROVEEDOR_TELEFONO + "  TEXT, "
                + PROVEEDOR_EMAIL + "  TEXT, "
                + PROVEEDOR_DIRECCION + "  TEXT, "
                + COMENTARIO + "  TEXT, "
                + PROVEEDOR_CATEGORIA + " TEXT)";//igual a productos categoria

        private static String SqlCreateTable_pedidos = "CREATE TABLE IF NOT EXISTS "
                + TABLE_PEDIDOS + "(" + ID + " INTEGER PRIMARY KEY,"
                + NAME + " TEXT, "
                + PROVEEDOR_ID + " INTEGER, "
                + COMENTARIO + "  TEXT, "
                + FECHA + " DEFAULT CURRENT_TIMESTAMP)";

        private static String SqlCreateTrigger_OnDeletePedido = " CREATE  TRIGGER IF NOT EXISTS ONDELETE_PEDIDO BEFORE DELETE "
                + " ON " + TABLE_PEDIDOS
                + " FOR EACH ROW "
                + " BEGIN "
                + " DELETE FROM " + TABLE_PEDIDOS_LISTAS + " WHERE " + PEDIDO_ID + " = OLD.id; "
                + " END; ";

        private static String SqlCreateTrigger_OnDeleteInventario = " CREATE  TRIGGER IF NOT EXISTS ONDELETE_INVENTARIO BEFORE DELETE "
                + " ON " + TABLE_INVENTARIOS
                + " FOR EACH ROW "
                + " BEGIN "
                + " DELETE FROM " + TABLE_INVENTARIOS_LISTAS + " WHERE " + INVENTARIO_ID + " = OLD.id; "
                + " END; ";

        private static String SqlCreateTable_pedidos_lista = "CREATE TABLE IF NOT EXISTS "
                + TABLE_PEDIDOS_LISTAS + "(" + ID + " INTEGER PRIMARY KEY,"
                + PEDIDO_ID + " INTEGER,"
                + PRODUCTO_ID + " INTEGER, "
                + PRODUCTO_CANTIDAD + " INTEGER, "
                + PRODUCTO_CATEGORIA_ID + " INTEGER, "
                + PRODUCTO_FORMATO_ID + " INTEGER)";

        private static String SqlCreateTable_inventarios = "CREATE TABLE IF NOT EXISTS "
                + TABLE_INVENTARIOS + "(" + ID + " INTEGER PRIMARY KEY,"
                + NAME + " TEXT, "
                + COMENTARIO + " TEXT, "
                + FECHA + " DEFAULT CURRENT_TIMESTAMP)";

        private static String SqlCreateTable_invetarios_lista = "CREATE TABLE IF NOT EXISTS "
                + TABLE_INVENTARIOS_LISTAS + "(" + ID + " INTEGER PRIMARY KEY,"
                + INVENTARIO_ID + " INTEGER,"
                + PRODUCTO_ID + " INTEGER, "
                + PRODUCTO_CANTIDAD + " INTEGER, "
                + PRODUCTO_CATEGORIA_ID + " INTEGER, "
                + PRODUCTO_FORMATO_ID + " INTEGER)";

        private static String SqlCreateTable_productos = "CREATE TABLE IF NOT EXISTS "
                + TABLE_PRODUCTOS + "(" + ID + " INTEGER PRIMARY KEY,"
                + NAME + " TEXT, "
                + PRODUCTO_FORMATO_ID + " INTEGER, "
                + PRODUCTO_CATEGORIA_ID + " INTEGER, "
                + PRODUCTO_PROVEEDOR_ID + " INTEGER)";

        private static String SqlCreateTable_productos_formato = "CREATE TABLE IF NOT EXISTS "
                + TABLE_PRODUCTOS_FORMATO + "(" + ID + " INTEGER PRIMARY KEY,"
                + NAME + " TEXT)";

        private static String SqlCreateTable_productos_categoria = "CREATE TABLE IF NOT EXISTS "
                + TABLE_PRODUCTOS_CATEGORY + "(" + ID + " INTEGER PRIMARY KEY,"
                + NAME + " TEXT)";

        private static String SqlCreateTable_categoria_recetas = "CREATE TABLE IF NOT EXISTS "
                + TABLE_RECETAS_CATEGORIA + "(" + ID + " INTEGER PRIMARY KEY,"
                + NAME + " TEXT)";

        //construir base de datos .....
        public DBHelper()
        {


            try
            {
                if (!File.Exists(DATABASE_NAME))
                {
                    SQLiteConnection.CreateFile(DATABASE_NAME);


                    m_dbConnection = new SQLiteConnection(ChefTools.Properties.Settings.Default.ConnectionString);
                    m_dbConnection.Open();
                    Debug.Write("Open data base");
                    command = new SQLiteCommand(SqlCreateTable_recetas, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTable_menus_cartas, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTable_providers, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTable_pedidos, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTrigger_OnDeletePedido, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTable_pedidos_lista, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTable_inventarios, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTable_invetarios_lista, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTrigger_OnDeleteInventario, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTable_productos, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTable_productos_formato, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTable_productos_categoria, m_dbConnection);
                    command.ExecuteNonQuery();
                    command = new SQLiteCommand(SqlCreateTable_categoria_recetas, m_dbConnection);
                    command.ExecuteNonQuery();

                    List<String> CatRecetas = new List<string>();
                    CatRecetas.Add("Aperitivos");
                    CatRecetas.Add("Postres");
                    CatRecetas.Add("Ensaladas");
                    CatRecetas.Add("Sopas");
                    CatRecetas.Add("Pasta");
                    CatRecetas.Add("Legumbres");
                    CatRecetas.Add("Verduras");
                    CatRecetas.Add("Carnes");
                    CatRecetas.Add("Pescados");
                    CatRecetas.Add("Salsas");
                    CatRecetas.Add("Sin Categoria");

                    foreach (String format in CatRecetas)
                    {
                        String sql = "insert into " + TABLE_RECETAS_CATEGORIA + " (" + NAME + ") values ('" + format + "')";
                        command = new SQLiteCommand(sql, m_dbConnection);
                        command.ExecuteNonQuery();
                    }


                    List<String> formatos = new List<string>();
                    formatos.Add("Kilos");
                    formatos.Add("Gramos");
                    formatos.Add("Unidades");
                    formatos.Add("Litros");
                    formatos.Add("Botellas");
                    formatos.Add("Latas");
                    formatos.Add("Bolsas");
                    formatos.Add("Docenas");
                    formatos.Add("Paquetes");
                    formatos.Add("Rollos");
                    formatos.Add("Cajas");
                    formatos.Add("Sin Formato");
                    foreach (String format in formatos)
                    {
                        String sql = "insert into " + TABLE_PRODUCTOS_FORMATO + " (" + NAME + ") values ('" + format + "')";
                        command = new SQLiteCommand(sql, m_dbConnection);
                        command.ExecuteNonQuery();
                    }

                    List<String> catProductos = new List<string>();
                    catProductos.Add("Carnes");
                    catProductos.Add("Pescados");
                    catProductos.Add("Especias");
                    catProductos.Add("Frutas");
                    catProductos.Add("Pastas");
                    catProductos.Add("Verduras");
                    catProductos.Add("Reposteria");
                    catProductos.Add("Hiervas");
                    catProductos.Add("Conservas");
                    catProductos.Add("Mariscos");
                    catProductos.Add("Salsas");
                    catProductos.Add("Quimicos");
                    catProductos.Add("Bodega");
                    catProductos.Add("Sin Categoria");
                    foreach (String cat in catProductos)
                    {
                        String sql = "insert into " + TABLE_PRODUCTOS_CATEGORY + " (" + NAME + ") values ('" + cat + "')";
                        command = new SQLiteCommand(sql, m_dbConnection);
                        command.ExecuteNonQuery();
                    }

                }
                else
                {
                    m_dbConnection = new SQLiteConnection(ChefTools.Properties.Settings.Default.ConnectionString);
                    m_dbConnection.Open();
                    Debug.Write("Open Data base");
                }
            }
            catch (SQLiteException ex)
            {
                Debug.Write("Error : " + ex.Message);
            }

        }

        //############################# Generic methods #############################
        public void close()
        {
            if (m_dbConnection.State.ToString().Equals("Open"))
            {
                m_dbConnection.Close();
                Debug.Write("Close data base");
            }
        }

        public SQLiteDataReader loadDataWithID(String tableName, int ID)
        {
            SQLiteDataReader reader = null;
            try
            {
                String sql = "select * from " + tableName + " where id=" + ID + " order by " + NAME + " asc";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                reader = command.ExecuteReader();
                return reader;
            }
            catch (SQLiteException ex)
            {
                Debug.Write("Error : " + ex.Message);

            }
            return reader;
        }

        public DataTable loadDataWhithTable(String tableName)
        {
            DataSet st = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT * FROM " + tableName + " ORDER BY " + NAME + " ASC";
                SQLiteDataAdapter dataAdapter =
                        new SQLiteDataAdapter(sql, m_dbConnection);
                dataAdapter.Fill(st);
                dt = st.Tables[0];

                return dt;
            }
            catch (SQLiteException ex)
            {
                Debug.Write("Error : " + ex.Message);

            }
            return dt;
        }

        public DataTable loadDataWithQuery(String sQuery)
        {
            DataSet st = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                String sql = sQuery;
                SQLiteDataAdapter dataAdapter =
                        new SQLiteDataAdapter(sql, m_dbConnection);
                dataAdapter.Fill(st);
                dt = st.Tables[0];

                return dt;
            }
            catch (SQLiteException ex)
            {
                Debug.Write("Error : " + ex.Message);

            }
            return dt;
        }


        public Boolean checkIfDataExists(String TableName, String Column, String Data)
        {
            bool ret = false;
            try
            {
                SQLiteCommand command = new SQLiteCommand(m_dbConnection);
                command.CommandText = "SELECT COUNT(*) FROM " + TableName + " WHERE " + Column + "='" + Data + "'";
                command.CommandType = CommandType.Text;
                int RowCount = Convert.ToInt32(command.ExecuteScalar());

                Debug.Write(RowCount);
                if (RowCount > 0)
                {
                    ret = true;
                }
            }
            catch (SQLiteException ex)
            {
                Debug.Write("Error : " + ex.Message);

            }
            return ret;
        }
        public String getDataString(String TableName, String Column, int id)
        {
            String ret = "";
            try
            {
                SQLiteCommand command = new SQLiteCommand(m_dbConnection);
                command.CommandText = "Select " + Column + " from " + TableName + " where " + ID + "=" + id;
                command.CommandType = CommandType.Text;
                ret = Convert.ToString(command.ExecuteScalar());


            }
            catch (SQLiteException ex)
            {
                Debug.Write("Error : " + ex.Message);

            }
            return ret;
        }


        public int DeleteData(int id, String TableName)
        {
            if (id > 0)
            {
                String sql = "DELETE FROM " + TableName +
                " where " + ID + " = " + id;

                command = new SQLiteCommand(sql, m_dbConnection);
                return command.ExecuteNonQuery();
            }
            else
            {
                return 0;
            }


        }

        public Object excuteQuery(String query)
        {

            SQLiteCommand cmd = new SQLiteCommand(query, m_dbConnection);

            object obj = cmd.ExecuteScalar();
            return obj;
        }

        //############################# Recipe methods #############################

        public int saveOrUpdateRecipe(int id, String name, String img, String Ingredientes, String Elaboracion, String url, int category)
        {
            int ret = 0;
            try
            {
                if (id > 0)
                {
                    String sql = "update " + TABLE_RECETAS + " set " + NAME + "='" + name + "' ,"
                        + RECETA_IMG + "='" + img + "' ,"
                        + RECETA_INGREDIENTES + "='" + Ingredientes + "' ,"
                        + RECETA_ELABORACION + "='" + Elaboracion + "' ,"
                        + RECETA_URL + "='" + url + "' ,"
                        + RECETA_CATEGORIA_ID + "='" + category + "'"
                        + " where " + ID + " = " + id;

                    command = new SQLiteCommand(sql, m_dbConnection);

                }
                else
                {
                    String sql = "insert into " + TABLE_RECETAS + " (" + NAME + " ,"
                        + RECETA_IMG + " ,"
                        + RECETA_INGREDIENTES + " ,"
                        + RECETA_ELABORACION + " ,"
                        + RECETA_URL + " ,"
                        + RECETA_CATEGORIA_ID + " ) values ('" + GlobalUttilities.UppercaseFirst(name) + "','" + img + "','" + Ingredientes + "','" + Elaboracion + "','" + url + "','" + category + "')";
                    command = new SQLiteCommand(sql, m_dbConnection);

                }
                ret = command.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;
        }
        //############################# Menus methods #############################

        public int saveOrUpdateMenus(int id, String name, String entrantes, String primeros, String segundos, String postres, String comment)
        {
            int ret = 0;
            try
            {
                if (id > 0)
                {
                    String sql = "update " + TABLE_MENUSCARTAS + " set " + NAME + "='" + name + "' ,"
                        + MENUS_CARTAS_ENTRANTES + "='" + entrantes + "' ,"
                        + MENUS_CARTAS_PRIMEROS + "='" + primeros + "' ,"
                        + MENUS_CARTAS_SEGUNDOS + "='" + segundos + "' ,"
                        + MENUS_CARTAS_POSTRES + "='" + postres + "' ,"
                        + COMENTARIO + "='" + comment + "'"
                        + " where " + ID + " = " + id;

                    command = new SQLiteCommand(sql, m_dbConnection);
                    Debug.Write("Sql: " + sql);
                }
                else
                {
                    String sql = "insert into " + TABLE_MENUSCARTAS + " (" + NAME + " ,"
                        + MENUS_CARTAS_ENTRANTES + " ,"
                        + MENUS_CARTAS_PRIMEROS + " ,"
                        + MENUS_CARTAS_SEGUNDOS + " ,"
                        + MENUS_CARTAS_POSTRES + " ,"
                        + COMENTARIO + ") values ('" + GlobalUttilities.UppercaseFirst(name) + "','" + entrantes + "','" + primeros + "','" + segundos + "','" + postres + "','" + comment + "')";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    Debug.Write("Sql: " + sql);
                }

                ret = command.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;
        }
        public int saveOrUpdateInventario(int id, String name, String comment)
        {
            int ret = 0;
            try
            {
                if (id > 0)
                {
                    String sql = "UPDATE " + TABLE_INVENTARIOS + " SET " + NAME + "='" + name + "' ,"
                        + COMENTARIO + "='" + comment + "'"
                        + " WHERE " + ID + " = " + id;

                    command = new SQLiteCommand(sql, m_dbConnection);
                    Debug.Write("Sql: " + sql);
                }
                else
                {
                    String sql = "INSERT INTO " + TABLE_INVENTARIOS + " (" + NAME + " ,"
                        + COMENTARIO + ") VALUES ('" + GlobalUttilities.UppercaseFirst(name) + "','" + comment + "')";

                    command = new SQLiteCommand(sql, m_dbConnection);
                    Debug.Write("Sql: " + sql);
                }

                ret = command.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;
        }


        public int saveInventarioLista(int id, int inventarioid, int productoid, int cantidad, int categoriaid, int formatoid)
        {
            int ret = 0;
            try
            {

                String sql = "INSERT INTO " + TABLE_INVENTARIOS_LISTAS + " (" + INVENTARIO_ID + " ,"
                   + PRODUCTO_ID + " ,"
                   + PRODUCTO_CANTIDAD + " ,"
                   + PRODUCTO_CATEGORIA_ID + " ,"
                   + PRODUCTO_FORMATO_ID + ") VALUES ('" + inventarioid + "','" + productoid + "','" + cantidad + "','" + categoriaid + "','" + formatoid + "')";
                command = new SQLiteCommand(sql, m_dbConnection);

                ret = command.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;
        }

        public int updateInventarioListaInvID(int id, int inventarioid, int productoid, int cantidad, int categoriaid, int formatoid)
        {
            int ret = 0;
            try
            {
                if (inventarioid > 0)
                {
                    String sql = "UPDATE " + TABLE_INVENTARIOS_LISTAS + " SET " + PRODUCTO_ID + "='" + productoid + "' ,"
                        + INVENTARIO_ID + "='" + inventarioid + "' ,"
                        + PRODUCTO_CANTIDAD + "='" + cantidad + "' ,"
                        + PRODUCTO_CATEGORIA_ID + "='" + categoriaid + "' ,"
                        + PRODUCTO_FORMATO_ID + "='" + formatoid + "'"
                        + " WHERE " + ID + " = " + id;
                    command = new SQLiteCommand(sql, m_dbConnection);
                    ret = command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;

        }
        public int updatePedidoListaInvID(int id, int pedidoid, int productoid, int cantidad, int categoriaid, int formatoid)
        {
            int ret = 0;
            try
            {
                if (pedidoid > 0)
                {
                    String sql = "UPDATE " + TABLE_PEDIDOS_LISTAS + " SET " + PRODUCTO_ID + "='" + productoid + "' ,"
                        + PEDIDO_ID + "='" + pedidoid + "' ,"
                        + PRODUCTO_CANTIDAD + "='" + cantidad + "' ,"
                        + PRODUCTO_CATEGORIA_ID + "='" + categoriaid + "' ,"
                        + PRODUCTO_FORMATO_ID + "='" + formatoid + "'"
                        + " WHERE " + ID + " = " + id;
                    command = new SQLiteCommand(sql, m_dbConnection);
                    ret = command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;

        }
        public int saveOrUpdateProveedor(int id, String name, String telefono, String email, String direccion, String categoria, String comentario)
        {
            int ret = 0;
            try
            {
                if (id > 0)
                {
                    String sql = "update " + TABLE_PROVEEDORES + " set " + NAME + "='" + name + "' ,"
                        + PROVEEDOR_TELEFONO + "='" + telefono + "' ,"
                        + PROVEEDOR_EMAIL + "='" + email + "' ,"
                        + PROVEEDOR_DIRECCION + "='" + direccion + "' ,"
                        + PROVEEDOR_CATEGORIA + "='" + categoria + "' ,"
                        + COMENTARIO + "='" + comentario + "'"
                        + " where " + ID + " = " + id;
                    command = new SQLiteCommand(sql, m_dbConnection);

                }
                else
                {
                    String sql = "insert into " + TABLE_PROVEEDORES + " (" + NAME + " ,"
                        + PROVEEDOR_TELEFONO + " ,"
                        + PROVEEDOR_EMAIL + " ,"
                        + PROVEEDOR_DIRECCION + " ,"
                        + COMENTARIO + " ,"
                        + PROVEEDOR_CATEGORIA + ") values ('" + GlobalUttilities.UppercaseFirst(name) + "','" + telefono + "','" + email + "','" + direccion + "','" + comentario + "','" + categoria + "')";
                    command = new SQLiteCommand(sql, m_dbConnection);


                }
                ret = command.ExecuteNonQuery();


            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;
        }
        public int saveOrUpdatePedido(int id, String name, int proveedor, String comment)
        {
            int ret = 0;
            try
            {
                if (id > 0)
                {
                    String sql = "UPDATE " + TABLE_PEDIDOS + " SET " + NAME + "='" + name + "' ,"
                        + PROVEEDOR_ID + "='" + proveedor + "' ,"
                        + COMENTARIO + "='" + comment + "'"
                        + " WHERE " + ID + " = " + id;

                    command = new SQLiteCommand(sql, m_dbConnection);
                    Debug.Write("Sql: " + sql);
                }
                else
                {
                    String sql = "INSERT INTO " + TABLE_PEDIDOS + " (" + NAME + " ,"
                        + PROVEEDOR_ID + " ,"
                        + COMENTARIO + ") VALUES ('" + GlobalUttilities.UppercaseFirst(name) + "','" + proveedor + "','" + comment + "')";

                    command = new SQLiteCommand(sql, m_dbConnection);
                    Debug.Write("Sql: " + sql);
                }

                ret = command.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;
        }

        public int savePedidoLista(int id, int pedidoid, int productoid, int cantidad, int categoriaid, int formatoid)
        {
            int ret = 0;
            try
            {

                String sql = "insert into " + TABLE_PEDIDOS_LISTAS + " (" + PEDIDO_ID + " ,"
                   + PRODUCTO_ID + " ,"
                   + PRODUCTO_CANTIDAD + " ,"
                   + PRODUCTO_CATEGORIA_ID + " ,"
                   + PRODUCTO_FORMATO_ID + ") values ('" + pedidoid + "','" + productoid + "','" + cantidad + "','" + categoriaid + "','" + formatoid + "')";
                command = new SQLiteCommand(sql, m_dbConnection);
                Debug.Write("Sql: " + sql);


                ret = command.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;
        }

        public int saveOrUpdateProducto(int id, String name, int formatoid, int categoriaid, int proveedorid)
        {
            int ret = 0;
            try
            {
                if (id > 0)
                {
                    String sql = "UPDATE " + TABLE_PRODUCTOS + " SET " + NAME + "='" + GlobalUttilities.UppercaseFirst(name) + "' ,"
                        + PRODUCTO_FORMATO_ID + "='" + formatoid + "' ,"
                        + PRODUCTO_CATEGORIA_ID + "='" + categoriaid + "' ,"
                        + PRODUCTO_PROVEEDOR_ID + "='" + proveedorid + "'"
                        + " WHERE " + ID + " = " + id;
                    Debug.Write("Sql: " + sql);
                    command = new SQLiteCommand(sql, m_dbConnection);
                    

                }
                else
                {
                    String sql = "insert into " + TABLE_PRODUCTOS + " (" + NAME + " ,"
                        + PRODUCTO_FORMATO_ID + " ,"
                        + PRODUCTO_CATEGORIA_ID + " ,"
                        + PRODUCTO_PROVEEDOR_ID + ") values ('" + name + "','" + formatoid + "','" + categoriaid + "','" + proveedorid + "')";
                    Debug.Write("Sql: " + sql); 
                    command = new SQLiteCommand(sql, m_dbConnection);
                    
                }

                ret = command.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;
        }
        public int saveOrUpdateAjustesTable(int id, String table, String name)
        {
            int ret = 0;
            try
            {
                if (id > 0)
                {
                    String sql = "UPDATE " + table + " SET " + NAME + " = '" + name + "'" + " WHERE " + ID + " = " + id;
                    command = new SQLiteCommand(sql, m_dbConnection);
                    Debug.Write("Sql: " + sql);
                }
                else
                {
                    String sql = "INSERT INTO " + table + " (" + NAME + ") VALUES ('" + GlobalUttilities.UppercaseFirst(name) + "')";
                    command = new SQLiteCommand(sql, m_dbConnection);
                    Debug.Write("Sql: " + sql);
                }

                ret = command.ExecuteNonQuery();

            }
            catch (SQLiteException ex)
            {
                ret = 0;
                Debug.Write("Error : " + ex.Message);
            }
            return ret;
        }
    }
}
