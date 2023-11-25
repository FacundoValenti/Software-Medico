Public Class ABM_Estudio
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If lblseñalEstudio.Text = "Agregar" Then

            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Estudios (IdPaciente, Fecha, MedicoSolicitante, Estudios, Informe, Mutual, Importe) 
                                    VALUES ('" & txtpaciente.Text & "','" & dtFechaestudio.Value.ToString("yyyy-MM-dd") & "','" & txtmedicosolicitante.Text & "','" & txtEstudios.Text & "','" & txtinforme.Text & "','" & txtmutual.Text & "','" & txtimporte.Text & "')"
                acciones.ExecuteNonQuery()
                MsgBox("Datos Guardados")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            FormularioPaciente.CargaPacientesEstudios()
            Me.Close()
        End If

        If lblseñalEstudio.Text = "Modificar" Then
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Estudios SET 
                                IdPaciente = '" & txtpaciente.Text & "',
                                Fecha = '" & dtFechaestudio.Value.ToString("yyyy-MM-dd") & "',
                                MedicoSolicitante = '" & txtmedicosolicitante.Text & "',
                                Estudios = '" & txtEstudios.Text & "',
                                Informe = '" & txtinforme.Text & "',
                                Mutual = '" & txtmutual.Text & "', 
                                Importe = " & Val(txtimporte.Text) & "
                                WHERE IdInforme = " & Val(txtidinforme.Text)
                acciones.ExecuteNonQuery()
                MsgBox("Datos Modificados")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            FormularioPaciente.CargaPacientesEstudios()
            Me.Close()
        End If
    End Sub

    Private Sub txtpaciente_TextChanged(sender As Object, e As EventArgs) Handles txtpaciente.TextChanged

    End Sub

    Private Sub txtidinforme_TextChanged(sender As Object, e As EventArgs) Handles txtidinforme.TextChanged

    End Sub
End Class