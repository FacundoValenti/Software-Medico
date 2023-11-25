Public Class ABMagenda
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If lblseñal.Text = "Agregar" Then
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Agenda (apellido, nombre, Localidad, telefono, celular, otrotelefono, email, paginaweb, personacontacto, telefonocontacto, direccion) 
                                    VALUES ('" & txtapellido.Text & "','" & txtnombre.Text & "','" & txtlocalidad.Text & "','" & txttelefono.Text & "','" & txtcelular.Text & "','" & txtotrotelefono.Text & "','" & txtemail.Text & "','" & txtpaginaweb.Text & "','" & txtpersonacontacto.Text & "','" & txttelefonocontacto.Text & "','" & txtdireccion.Text & "')"
                acciones.ExecuteNonQuery()
                MsgBox("Datos Guardados")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            FormularioAgenda.cargaagenda()
            Me.Close()
        End If


        If lblseñal.Text = "Modificar" Then
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Agenda SET apellido = '" & txtapellido.Text & "', nombre = '" & txtnombre.Text & "', Localidad = '" & txtlocalidad.Text & "', telefono = '" & txttelefono.Text & "', celular = '" & txtcelular.Text & "', OtroTelefono = '" & txtotrotelefono.Text & "', Email = '" & txtemail.Text & "', PaginaWeb = '" & txtpaginaweb.Text & "', PersonaContacto = '" & txtpersonacontacto.Text & "', TelefonoContacto = '" & txttelefonocontacto.Text & "', Direccion = '" & txtdireccion.Text & "'WHERE Id_Contacto = " & Val(txtid.Text) & ""
                acciones.ExecuteNonQuery()
                MsgBox("Datos modificados")
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
            FormularioAgenda.cargaagenda()
            Close()
        End If

    End Sub

    Private Sub lblseñal_Click(sender As Object, e As EventArgs) Handles lblseñal.Click

    End Sub

    Private Sub ABMagenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class