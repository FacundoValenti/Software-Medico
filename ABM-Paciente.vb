Public Class ABM_Paciente
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If lblseñalPaciente.Text = "Agregar" Then

            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Paciente (apellido, nombre, Domicilio, IdLocalidad, NroDocumento, FechaNacimiento, telefono, Celular, Mail, FechaAlta, IdTipoDocumento) 
                                    VALUES ('" & txtapellido.Text & "','" & txtnombre.Text & "','" & txtdomicilio.Text & "','" & txtlocalidad.Text & "','" & txtnrodocumento.Text & "','" & dtFechaNacimiento.Value.ToString("yyyy-MM-dd") & "','" & txttelefono.Text & "','" & txtcelular.Text & "','" & txtmail.Text & "','" & dtfechaalta.Value.ToString("yyyy-MM-dd") & "','" & txttipodocumento.Text & "')"
                acciones.ExecuteNonQuery()
                MsgBox("Datos Guardados")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            FormularioPaciente.CargaPacientesEstudios()
            Me.Close()
        End If
        If lblseñalPaciente.Text = "Modificar" Then
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Paciente SET apellido = '" & txtapellido.Text & "', nombre = '" & txtnombre.Text & "', Domicilio = '" & txtdomicilio.Text & "', IdLocalidad = '" & txtlocalidad.Text & "', NroDocumento = '" & txtnrodocumento.Text & "', FechaNacimiento = '" & dtFechaNacimiento.Value.ToString("yyyy-MM-dd") & "', Telefono = '" & txttelefono.Text & "', Celular = '" & txtcelular.Text & "', Mail = '" & txtmail.Text & "', FechaAlta = '" & dtfechaalta.Value.ToString("yyyy-MM-dd") & "', IdTipoDocumento = '" & txttipodocumento.Text & "' WHERE IdPaciente = " & Val(txtIdpaciente.Text) & ""
                acciones.ExecuteNonQuery()
                MsgBox("Datos modificados")
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            FormularioPaciente.CargaPacientesEstudios()
            Me.Close()

        End If

    End Sub

    Private Sub ABM_Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class