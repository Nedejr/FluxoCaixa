Imports System.Data.SqlClient


Public Class ConexaoBancovb

    Private conexao As New SqlConnection

    Public Sub conectar()

        Try
            conexao = New SqlConnection("Data Source=DESKTOP-TUCA154\SQLEXPRESS;Initial Catalog=FLUXO;Integrated Security=True")
            conexao.Open()

        Catch ex As Exception
            MsgBox("Erro ao conectar no banco :" + ex.ToString)
        End Try

    End Sub

    Public Sub fechar()

        Try
            If Not IsNothing(conexao) Then
                If conexao.State = ConnectionState.Open Then
                    conexao.Close()

                End If

            End If

        Catch ex As Exception
            MsgBox("Erro ao fechar conexao :" + ex.ToString)
        End Try

    End Sub

    Public Function BuscarExtrato(ByVal sql As String) As DataSet

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand

        Try
            cmd = conexao.CreateCommand
            cmd.CommandText = sql
            da = New SqlDataAdapter(cmd)
            da.Fill(ds)
        Catch ex As Exception
            MsgBox("Erro ao consultar extrato :" + ex.ToString)
        End Try

        Return ds

    End Function

    Public Function IncluirRegistro(ByVal sql As String) As Integer

        Dim retorno As Integer
        Dim cmd As New SqlCommand


        Try
            cmd = conexao.CreateCommand
            cmd.CommandText = sql
            retorno = cmd.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show("Erro ao incluir registro " + ex.ToString)
        End Try


        Return retorno



    End Function

    Public Function ExcluirRegistro(ByVal sql As String) As Integer

        Dim retorno As Integer
        Dim cmd As New SqlCommand

        Try
            cmd = conexao.CreateCommand
            cmd.CommandText = sql
            retorno = cmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Erro ao excluir registro :" + ex.ToString)

        End Try

        Return retorno

    End Function

    Public Function BuscarPorData(ByVal sql As String) As DataSet

        Dim ds As New DataSet
        Dim cmd As New SqlClient.SqlCommand
        Dim da As New SqlClient.SqlDataAdapter

        Try
            cmd = conexao.CreateCommand
            cmd.CommandText = sql
            da = New SqlClient.SqlDataAdapter(cmd)
            da.Fill(ds)

        Catch ex As Exception
            MsgBox("Erro ao buscar por data" + ex.ToString)
        End Try

        Return ds

    End Function

End Class
