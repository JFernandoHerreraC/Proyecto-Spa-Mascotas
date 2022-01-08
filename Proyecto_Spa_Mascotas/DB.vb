Imports System.Data.Odbc
Module DB
    Private Function Conexion() As OdbcConnection
        'Const cadena_conn As String = "DSN=cesuver;uid=practica_vb;pwd=practicas123"
        Const cadena_conn As String = "DSN=cesuver;uid=prueba_db_proyecto_skf_Vet;pwd=SkfVet"
        'prueba_db_proyecto_skf_Vet identified by SkfVet
        Dim conn As OdbcConnection = New OdbcConnection(cadena_conn)
        Return conn
    End Function

    Private Function ObtenerId(Prefijo As String, Nombre_Tabla As String) As Integer
        Dim ultimoId As Integer
        Dim Conn As OdbcConnection = Conexion()
        Dim Query As String = "Select Id_" + Prefijo + " from " + Nombre_Tabla + " ORDER By Id_" + Prefijo + " Desc;"
        Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
        Comm.CommandType = CommandType.Text
        Dim Da As OdbcDataAdapter = New OdbcDataAdapter(Comm)
        Dim Dt As DataTable = New DataTable
        Try
            Conn.Open()
            Da.Fill(Dt)
            ultimoId = Dt.Rows(0).Item(0)
            Conn.Close()
        Catch ex As Exception

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
                Dim Da As OdbcDataAdapter = New OdbcDataAdapter()
                Dim Dt As DataTable = New DataTable
                Try
                    Conn.Open()
                    Da.Fill(Dt)
                    Respuesta = Dt
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el guardado")
                End Try
                Return Respuesta
            End Function
            Public Function ConsultaTodoPor(Nombre_Tabla As String, NombreCampo As String, PrefijoCampo As String, Elem_Busc As String)
                Dim Respuesta As DataTable = Nothing
                Dim Conn As OdbcConnection = Conexion()
                Dim Query As String = "Select * from " + Nombre_Tabla + " WHERE " + NombreCampo + "_" + PrefijoCampo + " LIKE '%" + Elem_Busc + "%';"
                Dim Comm As OdbcCommand = New OdbcCommand(Query, Conn)
                Comm.CommandType = CommandType.Text
                Dim Da As OdbcDataAdapter = New OdbcDataAdapter()
                Dim Dt As DataTable = New DataTable
                Try
                    Conn.Open()
                    Da.Fill(Dt)
                    Respuesta = Dt
                    Conn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el guardado")
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
                Dim Query As String = "Insert into Categorias values(" + Id + ",'" + Nombre + "','" + Desc + "');"
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
            Public Function BajaCategorias(Nombre_Ctg As String)
                Dim Respuesta As Boolean = False
                Dim ConsGen = New ConsultasGenerales()
                Dim Dt As DataTable = ConsGen.ConsultaTodoPor("Categorias", "Nombre", "Ctg", Nombre_Ctg)
                If Dt.Rows(0).Item(0) <> Nothing Then
                    Dim Id = Convert.ToString(Dt.Rows(0).Item(0))
                    Dim Conn As OdbcConnection = Conexion()
                    Dim Query As String = "Delete from Categorias Where Id_Ctg = " + Id + ";"
                    Dim Comm = New OdbcCommand(Query, Conn)
                    Try
                        Conn.Open()
                        Comm.ExecuteNonQuery()
                        Conn.Close()
                        Respuesta = True
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el guardado")
                    End Try
                End If
                Return Respuesta
            End Function
            Public Function CambioCategorias(Nombre As String, Desc As String)
                Dim Repuesta As Boolean = False

                Return Repuesta
            End Function
        End Class

    End Class

End Module
