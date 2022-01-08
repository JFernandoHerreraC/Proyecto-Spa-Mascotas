Imports System.Data.Odbc
Module BD
    'Variables para la cadena de conexión de la base de datos
    Private Const NombreBD = "cesuver"
    Private Const usuarioBD = "prueba_db_proyecto_skf_Vet"
    Private Const PasswordBD = "SkfVet"
    Private Function Conexion() As OdbcConnection
        'Const cadena_conn As String = "DSN=cesuver;uid=prueba_db_proyecto_skf_Vet;pwd=SkfVet"
        Const cadena_conn As String = "DSN=" + NombreBD + ";" + "uid=" + usuarioBD + ";" + "pwd=" + PasswordBD + ";"
        'prueba_db_proyecto_skf_Vet identified by SkfVet
        Dim conn As OdbcConnection = New OdbcConnection(cadena_conn)
        Return conn
    End Function

    Private Function ObtenerId(Prefijo As String, Nombre_Tabla As String) As Integer
        Dim ultimoId As Integer
        Dim Conn As OdbcConnection = Conexion()
        '"Select Id_Emp from Empleados Order by Id_Emp Desc;"
        Dim Query As String = "Select Id_" + Prefijo + " from " + Nombre_Tabla + " ORDER By Id_" + Prefijo + " Desc;"
        Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
        Comm.CommandType = CommandType.Text
        Dim Da As OdbcDataAdapter = New OdbcDataAdapter(Comm)
        Dim Dt As DataTable = New DataTable
        Try
            Conn.Open()
            Comm.ExecuteNonQuery()
            Da.Fill(Dt)
            ultimoId = Dt.Rows(0).Item(0)
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en la busqueda del ID")
        End Try
        Return ultimoId
    End Function

    Public Class Consultas
        Public Class ConsultasGenerales
            Public Function ConsultaTodo(Nombre_Tabla As String)
                Dim Respuesta As DataTable = Nothing
                Dim Conn As OdbcConnection = Conexion()
                Dim Query As String = "Select * from " + Nombre_Tabla + ";"
                Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                Comm.CommandType = CommandType.Text
                Dim Da As OdbcDataAdapter = New OdbcDataAdapter(Comm)
                Dim Dt As DataTable = New DataTable
                Try
                    Conn.Open()
                    Comm.ExecuteNonQuery()
                    Da.Fill(Dt)
                    Respuesta = Dt
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en consultar todo")
                End Try
                Return Respuesta
            End Function
            Public Function ConsultaTodoPor(Nombre_Tabla As String, NombreCampo As String, PrefijoCampo As String, Elem_Busc As String)
                Dim Respuesta As DataTable = Nothing
                Dim Conn As OdbcConnection = Conexion()
                '"Select * from Empleados Where Nombre_Emp Like '%Oscar%'"
                Dim Query As String = "Select * from " + Nombre_Tabla + " WHERE " + NombreCampo + "_" + PrefijoCampo + " LIKE '%" + Elem_Busc + "%';"
                Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                Comm.CommandType = CommandType.Text
                Dim Da As OdbcDataAdapter = New OdbcDataAdapter(Comm)
                Dim Dt As DataTable = New DataTable
                Try
                    Conn.Open()
                    Da.Fill(Dt)
                    Respuesta = Dt
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el consultar por")
                End Try
                Return Respuesta
            End Function
        End Class
        Public Class Categorias
            Public Function CrearCategorias(Nombre As String, Desc As String)
                Dim Respuesta As Boolean = False
                Dim Id As Integer = ObtenerId("Ctg", "Categorias") + 1
                Dim Conn As OdbcConnection = Conexion()
                'Insert into Categorias values (0,'Defecto','Categoría por defecto');
                Dim Query As String = "Insert into Categorias values(" + Id.ToString() + ",'" + Nombre + "','" + Desc + "');"
                Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                Comm.CommandType = CommandType.Text
                Try
                    Conn.Open()
                    Comm.ExecuteNonQuery()
                    Conn.Close()
                    Respuesta = True
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el guardado")
                End Try
                Return Respuesta
            End Function
            Public Function BajaCategorias(Id As String)
                Dim Respuesta As Boolean = False
                Dim Conn As OdbcConnection = Conexion()
                Dim Query As String = "Delete From Categorias WHERE Id_Ctg = " + Id + ";"
                Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                Comm.CommandType = CommandType.Text
                Try
                    Conn.Open()
                    Comm.ExecuteNonQuery()
                    Conn.Close()
                    Respuesta = True
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al eliminar la categoria")
                End Try
                Return Respuesta
            End Function
            Public Function CambioCategorias(Id As String, Nombre As String, Desc As String)
                Dim Respuesta As Boolean = False
                Dim Conn As OdbcConnection = Conexion()
                Dim Query As String = "Update Categorias Set Id_Ctg = " + Id + ", Nombre_Ctg = '" + Nombre + "', Desc_Ctg = '" + Desc + "' WHERE Id_Ctg = " + Id + ";"
                Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                Comm.CommandType = CommandType.Text
                Try
                    Conn.Open()
                    Comm.ExecuteNonQuery()
                    Conn.Close()
                    Respuesta = True
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al hacer los cambios")
                End Try
                Return Respuesta
            End Function
        End Class
        Public Class Proveedores
            Public Function AltaProveedor(ByVal BusDeDatos As Array)
                Dim Respuesta As Boolean = False
                Dim Conn As OdbcConnection = Conexion()
                Dim Id = ObtenerId("Prov", "Proveedores") + 1
                Dim P1Query As String = "'" + BusDeDatos(0) + "'," + "'" + BusDeDatos(1) + "'," + "'" + BusDeDatos(2) + "'," + "'" + BusDeDatos(3) + "'," + "'" + BusDeDatos(4) + "',"
                Dim P2Query As String = "'" + BusDeDatos(5) + "'," + "'" + BusDeDatos(6) + "'," + "'" + BusDeDatos(7) + "'," + "'" + BusDeDatos(8) + "'," + "'" + BusDeDatos(9) + "',"
                Dim P3Query As String = "'" + BusDeDatos(10) + "'," + "'" + BusDeDatos(11) + "'," + "'" + BusDeDatos(12) + "'," + "'" + BusDeDatos(13) + "'," + "'" + BusDeDatos(14) + "',"
                Dim P4Query As String = "'" + BusDeDatos(15) + "'," + "'" + BusDeDatos(16) + "'," + "'" + BusDeDatos(17) + "'"
                Dim Query As String = "Insert into Proveedores values(" + Id.ToString() + "," + P1Query + P2Query + P3Query + P4Query + ");"
                Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                Comm.CommandType = CommandType.Text
                Try
                    Conn.Open()
                    Comm.ExecuteNonQuery()
                    Respuesta = True
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al guardar el proveedor")
                End Try
                Return Respuesta
            End Function
            Public Function CambiosProveedor(BusDeDatos As Array)
                Dim Resultado As Boolean = False
                Dim Conn As OdbcConnection = Conexion()
                Dim Id As String = BusDeDatos(0).ToString()
                Dim P1Query As String = "Nombre_Prov = '" + BusDeDatos(1) + "',Rfc_Prov = " + "'" + BusDeDatos(2) + "'," + "Calle_Prov = '" + BusDeDatos(3) + "'," + " Num_Ext_Prov = '" + BusDeDatos(4) + "'," + "Num_Int_Prov = '" + BusDeDatos(5) + "',"
                Dim P2Query As String = "Cp_Prov = '" + BusDeDatos(6) + "'," + "Colonia_Prov = '" + BusDeDatos(7) + "'," + "Mnpio_Prov = '" + BusDeDatos(8) + "'," + "Estado_Prov = '" + BusDeDatos(9) + "'," + "TelefUno_Prov = '" + BusDeDatos(10) + "',"
                Dim P3Query As String = "TelefDos_Prov = '" + BusDeDatos(11) + "'," + "Email_Prov = '" + BusDeDatos(12) + "'," + "Rubro_Prov = '" + BusDeDatos(13) + "'," + "FrmDePago_Prov = '" + BusDeDatos(14) + "'," + "Secue_Prov = '" + BusDeDatos(15) + "',"
                Dim P4Query As String = "Moneda_Prov = '" + BusDeDatos(16) + "'," + "CDeDeposito_Prov = '" + BusDeDatos(17) + "'," + "Desc_Prov = '" + BusDeDatos(18) + "'"
                Dim Query As String = "Update Proveedores set Id_Prov = " + Id + "," + P1Query + P2Query + P3Query + P4Query + "WHERE Id_Prov = " + Id + ";"
                Console.WriteLine(Query)
                Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                Comm.CommandType = CommandType.Text
                Try
                    Conn.Open()
                    Comm.ExecuteNonQuery()
                    Resultado = True
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cambiar los datos del proveedor")
                End Try
                Return Resultado
            End Function
            Public Function BajaProveedor(Id As String)
                Dim Resultado As Boolean = False
                Dim Conn As OdbcConnection = Conexion()
                Dim Query As String = "Delete From Proveedores WHERE Id_Prov = " + Id + ";"
                Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                Comm.CommandType = CommandType.Text
                Try
                    Conn.Open()
                    Comm.ExecuteNonQuery()
                    Resultado = True
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al eliminar el proveedor")
                End Try
                Return Resultado
            End Function
        End Class

        Public Class Producto
            Public Function AltaProducto(BusDatos As Array, Imagen As Image)
                Dim Respuesta As Boolean = False
                Dim Query As String = ""
                Dim Comm As OdbcCommand
                Dim Consulta = New Consultas.ConsultasGenerales()
                Dim RespuestaCtg As DataTable = Consulta.ConsultaTodoPor("Categorias", "Nombre", "Ctg", BusDatos(4))
                BusDatos(4) = RespuestaCtg.Rows(0).Item(0)
                Dim RespuestaProv As DataTable = Consulta.ConsultaTodoPor("Proveedores", "Nombre", "Prov", BusDatos(5))
                BusDatos(5) = RespuestaCtg.Rows(0).Item(0)
                Dim Conn As OdbcConnection = Conexion()
                Dim P1Query As String = "'" + BusDatos(0) + "'," + "'" + BusDatos(1) + "'," + "'" + BusDatos(2) + "'," + "'" + BusDatos(3) + "'," + BusDatos(4) + ","
                Dim P2Query As String = BusDatos(5) + "," + BusDatos(6).ToString() + "," + "'" + BusDatos(7) + "'," + "'" + BusDatos(8) + "'," + "'" + BusDatos(9) + "',"
                Dim P3Query As String = "'" + BusDatos(10) + "',"
                If Not Imagen Is Nothing Then
                    Query = "INSERT INTO Productos (CodBarra_Prod,Nombre_Prod,Desc_Prod,Conten_Prod,Catego_Prod,Provee_Prod,CantExi_Prod,PregCadu_Prod,FechCadu_Prod,PrecProv_Prod,PrecPubl_Prod,ImgProd_Prod) VALUES (:CodBarra,:Nombre,:DescProd,:Conten,:Catego,:Provee,:CantExi,:PregCadu,:FechCadu,:PrecProv,:PrecPubl,:ImgProd);"
                    Dim Binarios As New System.IO.MemoryStream
                    Imagen.Save(Binarios, Imaging.ImageFormat.Bmp)
                    Dim Resultado_Bin As Byte() = Binarios.GetBuffer()
                    Comm = New OdbcCommand(Query, Conn)
                    Comm.Parameters.Add(":CodBarra", OdbcType.VarChar).Value = BusDatos(0)
                    Comm.Parameters.Add(":Nombre", OdbcType.VarChar).Value = BusDatos(1)
                    Comm.Parameters.Add(":DescProd", OdbcType.VarChar).Value = BusDatos(2)
                    Comm.Parameters.Add(":Conten", OdbcType.VarChar).Value = BusDatos(3)
                    Comm.Parameters.Add(":Catego", OdbcType.Int).Value = BusDatos(4)
                    Comm.Parameters.Add(":Provee", OdbcType.Int).Value = BusDatos(5)
                    Comm.Parameters.Add(":CantExi", OdbcType.Int).Value = BusDatos(6)
                    Comm.Parameters.Add(":PregCadu", OdbcType.VarChar).Value = BusDatos(7)
                    Comm.Parameters.Add(":FechCadu", OdbcType.Date).Value = BusDatos(8)
                    Comm.Parameters.Add(":PrecProv", OdbcType.Decimal).Value = BusDatos(9)
                    Comm.Parameters.Add(":PrecPubl", OdbcType.Decimal).Value = BusDatos(10)
                    Comm.Parameters.Add(":ImgProd", OdbcType.Binary).Value = Resultado_Bin
                    Comm.CommandType = CommandType.Text
                    Try
                        Conn.Open()
                        Comm.ExecuteNonQuery()
                        Respuesta = True
                        Conn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString(), MsgBoxStyle.Critical, "Error en el guardado de producto")
                        Console.WriteLine(ex.Message)
                    End Try
                Else
                    Query = "Insert into Productos values(" + P1Query + P2Query + P3Query + "''" + ");"
                    Comm = New OdbcCommand(Query, Conn)
                    Comm.CommandType = CommandType.Text
                    Comm.ExecuteNonQuery()
                    Try
                        Conn.Open()
                        Comm.ExecuteNonQuery()
                        Respuesta = True
                        Conn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el guardado de producto")
                        Console.WriteLine(ex.Message)
                    End Try
                End If
                Return Respuesta
            End Function

            Public Function BajaProductos(Id As String)
                Dim Resultado As Boolean = False
                Dim Conn As OdbcConnection = Conexion()
                Dim Query As String = "Delete From Productos WHERE CodBarra_Prod = " + Id + ";"
                Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                Comm.CommandType = CommandType.Text
                Try
                    Conn.Open()
                    Comm.ExecuteNonQuery()
                    Resultado = True
                    Conn.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.Message, MsgBoxStyle.Critical, "Error en la eliminación")
                End Try
                Return Resultado
            End Function
            Public Function CambiosProducto(BusDatos As Array, Imagen As Image)
                Dim Respuesta As Boolean = False
                Dim Conn As OdbcConnection = Conexion()
                Dim Consulta = New ConsultasGenerales()
                Dim RespuestaCtg As DataTable = Consulta.ConsultaTodoPor("Categorias", "Nombre", "Ctg", BusDatos(4))
                BusDatos(4) = RespuestaCtg.Rows(0).Item(0)
                Dim RespuestaProv As DataTable = Consulta.ConsultaTodoPor("Proveedores", "Nombre", "Prov", BusDatos(5))
                BusDatos(5) = RespuestaCtg.Rows(0).Item(0)
                Dim Query As String
                If Not Imagen Is Nothing Then
                    Dim QueryP1 As String = "Update Productos set CodBarra_Prod = :CodBarra,Nombre_Prod=:Nombre,Desc_Prod=:DescProd,Conten_Prod=:Conten"
                    Dim QueryP2 As String = "Catego_Prod=:Catego,Provee_Prod=:Provee,CantExi_Prod=:CantExi,PregCadu_Prod=:PregCadu,FechCadu_Prod=:FechCadu, PrecProv_Prod=:PrecProv"
                    Dim QueryP3 As String = " PrecPubl_Prod=:PrecPubl, ImgProd_Prod=:ImgProd Where CodBarra_Prod = :CodBarra "
                    Query = QueryP1 + "," + QueryP2 + "," + QueryP3
                    Dim Binarios As New System.IO.MemoryStream
                    Imagen.Save(Binarios, Imaging.ImageFormat.Bmp)
                    Dim Resultado_Bin As Byte() = Binarios.GetBuffer()
                    Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                    Comm.Parameters.Add(":CodBarra", OdbcType.VarChar).Value = BusDatos(0)
                    Comm.Parameters.Add(":Nombre", OdbcType.VarChar).Value = BusDatos(1)
                    Comm.Parameters.Add(":DescProd", OdbcType.VarChar).Value = BusDatos(2)
                    Comm.Parameters.Add(":Conten", OdbcType.VarChar).Value = BusDatos(3)
                    Comm.Parameters.Add(":Catego", OdbcType.Int).Value = BusDatos(4)
                    Comm.Parameters.Add(":Provee", OdbcType.Int).Value = BusDatos(5)
                    Comm.Parameters.Add(":CantExi", OdbcType.Int).Value = BusDatos(6)
                    Comm.Parameters.Add(":PregCadu", OdbcType.VarChar).Value = BusDatos(7)
                    Comm.Parameters.Add(":FechCadu", OdbcType.Date).Value = BusDatos(8)
                    Comm.Parameters.Add(":PrecProv", OdbcType.Decimal).Value = BusDatos(9)
                    Comm.Parameters.Add(":PrecPubl", OdbcType.Decimal).Value = BusDatos(10)
                    Comm.Parameters.Add(":ImgProd", OdbcType.Binary).Value = Resultado_Bin
                    Comm.CommandType = CommandType.Text
                    Try
                        Conn.Open()
                        Comm.ExecuteNonQuery()
                        Respuesta = True
                        Conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                Else
                    'Update Categorias Set Id_Ctg
                    Dim QueryP1 As String = "Update Productos Set CodBarra_Prod = '" + BusDatos(0) + "',Nombre_Prod='" + BusDatos(1) + "',Desc_Prod='" + BusDatos(2) + "',Conten_Prod = '" + BusDatos(3) + "'"
                    Dim QueryP2 As String = "Catego_Prod=" + BusDatos(4).ToString + ",Provee_Prod = " + BusDatos(5).ToString + ",CantExi_Prod = " + BusDatos(6) + ",PregCadu_Prod = '" + BusDatos(7) + "',FechCadu_Prod = '" + BusDatos(8) + "'"
                    Dim QueryP3 As String = "PrecProv_Prod=" + BusDatos(9).ToString() + ",PrecPubl_Prod=" + BusDatos(10).ToString() + ",ImgProd_Prod=''"
                    Query = QueryP1 + "," + QueryP2 + "," + QueryP3 + " Where CodBarra_Prod = " + BusDatos(0) + ";"
                    Console.WriteLine(Query)
                    Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                    Comm.CommandType = CommandType.Text
                    Try
                        Conn.Open()
                        Comm.ExecuteNonQuery()
                        Respuesta = True
                        Conn.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                End If
                Return Respuesta
            End Function
        End Class
    End Class
End Module
