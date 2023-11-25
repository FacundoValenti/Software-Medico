Public Class ABM_Turnos

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If lblseñalturno.Text = "Agregar" Then

            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                ' Concatenar las horas y minuto

                ' Resto del código de inserción
                acciones.CommandText = "INSERT INTO Turno (Mutual, NroAfiliado, MedicoSolicitante, Prestaciones, Observaciones, Fecha, IdPaciente, Hora, Minutos, telefono) 
                        VALUES ('" & txtmutual.Text & "','" & txtnroafiliado.Text & "','" & txtmedicosolicitante.Text & "','" & txtprestaciones.Text & "','" & txtobservaciones.Text & "','" & dtfecha.Value.ToString("yyyy-MM-dd") & "','" & txtidpaciente.Text & "','" & txthora.Text & "','" & txtminutos.Text & "','" & txttelefono.Text & "')"

                acciones.ExecuteNonQuery()
                MsgBox("Datos Guardados")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            FormularioTurno.Cargaturno()
            Me.Close()
        End If

        If lblseñalturno.Text = "Modificar" Then
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Turno SET 
                                Mutual = '" & txtmutual.Text & "', 
                                NroAfiliado = '" & txtnroafiliado.Text & "',
                                MedicoSolicitante = '" & txtmedicosolicitante.Text & "',
                                Prestaciones = '" & txtprestaciones.Text & "',
                                Observaciones = '" & txtobservaciones.Text & "',
                                Fecha = '" & dtfecha.Value.ToString("yyyy-MM-dd") & "',
                                IdPaciente = '" & txtidpaciente.Text & "',
                                Hora = " & Val(txthora.Text) & ",
                                Minutos = " & Val(txtminutos.Text) & ",
                                telefono = '" & txttelefono.Text & "'
                                WHERE IdTurno = " & Val(txtIdTurno.Text)
                acciones.ExecuteNonQuery()
                MsgBox("Datos Modificados")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            FormularioTurno.Cargaturno()
            Me.Close()
        End If

    End Sub

    Private Sub ABM_Turnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class