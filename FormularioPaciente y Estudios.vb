Imports System.Data.SqlClient

Public Class FormularioPaciente
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()

    End Sub

    Private Sub FormularioPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaPacientesEstudios()
        Me.lblbuscarpaciente.Text = "BUSQUEDA RAPIDA"
        Me.lblbuscarestudio.Text = "BUSQUEDA RAPIDA"


    End Sub

    Public Sub CargaPacientesEstudios()
        If GrillaPaciente.Rows.Count <> 0 Then
            GrillaPaciente.Rows.Clear()
        End If

        ' Llamada a la función de carga de registros de pacientes
        acciones.Connection = conexionSql
        acciones.CommandType = CommandType.Text
        acciones.CommandText = "SELECT * FROM Paciente ORDER BY IdPaciente"
        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then
            While lectordatos.Read()
                ' Agrego los datos a la grilla de pacientes
                GrillaPaciente.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11))
            End While
        End If

        lectordatos.Close()

        If GrillaEstudios.Rows.Count <> 0 Then
            GrillaEstudios.Rows.Clear()
        End If

        ' Ahora, cargamos la información de la tabla Estudios
        acciones.CommandText = "SELECT * FROM Estudios ORDER BY IdInforme"
        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then
            While lectordatos.Read()
                ' Agrego los datos a la grilla de estudios
                ' Asumiendo que GrillaEstudios es el nombre del DataGridView
                GrillaEstudios.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(7), lectordatos(6), lectordatos(5))
            End While
        End If

        lectordatos.Close()



    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ABM_Paciente.lblseñalPaciente.Text = "Modificar"
        ABM_Paciente.txtIdpaciente.Text = GrillaPaciente.CurrentRow.Cells(0).Value
        ABM_Paciente.txtapellido.Text = GrillaPaciente.CurrentRow.Cells(1).Value
        ABM_Paciente.txtnombre.Text = GrillaPaciente.CurrentRow.Cells(2).Value
        ABM_Paciente.txtdomicilio.Text = GrillaPaciente.CurrentRow.Cells(3).Value
        ABM_Paciente.txtlocalidad.Text = GrillaPaciente.CurrentRow.Cells(4).Value
        ABM_Paciente.txtnrodocumento.Text = GrillaPaciente.CurrentRow.Cells(5).Value
        ABM_Paciente.dtFechaNacimiento.Value = GrillaPaciente.CurrentRow.Cells(6).Value
        ABM_Paciente.txttelefono.Text = GrillaPaciente.CurrentRow.Cells(7).Value
        ABM_Paciente.txtcelular.Text = GrillaPaciente.CurrentRow.Cells(8).Value
        ABM_Paciente.txtmail.Text = GrillaPaciente.CurrentRow.Cells(9).Value
        ABM_Paciente.dtfechaalta.Value = GrillaPaciente.CurrentRow.Cells(10).Value
        ABM_Paciente.txttipodocumento.Text = GrillaPaciente.CurrentRow.Cells(11).Value
        ABM_Paciente.Show()

    End Sub

    Private Sub txtbuscarpacientes_TextChanged0(sender As Object, e As EventArgs)
        Dim searchText As String = txtbuscarpaciente.Text.Trim().ToUpper()

        For Each fila As DataGridViewRow In GrillaPaciente.Rows
            Dim cellValue As Object = fila.Cells(1).Value

            If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                Dim cellText As String = cellValue.ToString().Trim().ToUpper()

                If cellText.Contains(searchText) Then
                    GrillaPaciente.CurrentCell = fila.Cells(1)

                    ' Asegúrate de que la fila sea visible en la grilla '
                    GrillaPaciente.FirstDisplayedScrollingRowIndex = fila.Index

                    Exit For
                End If
            End If
        Next
    End Sub


    Private Sub txtbuscarpaciente_TextChanged1(sender As Object, e As EventArgs) Handles txtbuscarpaciente.TextChanged
        Dim searchText As String = txtbuscarpaciente.Text.Trim().ToUpper()
        Dim found As Boolean = False

        For Each fila As DataGridViewRow In GrillaPaciente.Rows
            Dim cellValue As Object = fila.Cells(2).Value

            If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                Dim cellText As String = cellValue.ToString().Trim().ToUpper()

                If cellText.Contains(searchText) Then
                    GrillaPaciente.CurrentCell = fila.Cells(2)
                    found = True
                    Exit For
                End If
            End If
        Next

        ' Si no se encontró ninguna coincidencia, restablecer la celda actual '
        If Not found Then
            GrillaPaciente.ClearSelection()
        End If
    End Sub



    Private Sub txtbuscarpaciente_TextChanged2(sender As Object, e As EventArgs) Handles txtbuscarpaciente.TextChanged
        Dim searchText As String = txtbuscarpaciente.Text.Trim().ToUpper()
        Dim found As Boolean = False

        For Each fila As DataGridViewRow In GrillaPaciente.Rows
            Dim cellValue As Object = fila.Cells(3).Value

            If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                Dim cellText As String = cellValue.ToString().Trim().ToUpper()

                If cellText.Contains(searchText) Then
                    GrillaPaciente.CurrentCell = fila.Cells(3)
                    found = True
                    Exit For
                End If
            End If
        Next

        ' Si no se encontró ninguna coincidencia, restablecer la celda actual '
        If Not found Then
            GrillaPaciente.ClearSelection()
        End If
    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim resultado As Integer = MessageBox.Show("¿Seguro que deseas borrar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo)

        ' Verificar la respuesta del usuario
        If resultado = DialogResult.Yes Then
            ' El usuario confirmó la eliminación
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "DELETE FROM Paciente WHERE IdPaciente = " & Val(GrillaPaciente.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox("Registro eliminado")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Me.CargaPacientesEstudios()

        End If
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ABM_Paciente.lblseñalPaciente.Text = "Agregar"
        ABM_Paciente.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        ABM_Estudio.lblseñalEstudio.Text = "Agregar"
        ABM_Estudio.Show()
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Dim resultado As Integer = MessageBox.Show("¿Seguro que deseas borrar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo)

        ' Verificar la respuesta del usuario
        If resultado = DialogResult.Yes Then
            ' El usuario confirmó la eliminación
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "DELETE FROM Estudios WHERE IdInforme = " & Val(GrillaEstudios.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox("Registro eliminado")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Me.CargaPacientesEstudios()

        End If
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Me.Close()
    End Sub
    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        ABM_Estudio.lblseñalEstudio.Text = "Modificar"
        ABM_Estudio.txtidinforme.Text = GrillaEstudios.CurrentRow.Cells(0).Value
        ABM_Estudio.dtFechaestudio.Value = GrillaEstudios.CurrentRow.Cells(2).Value
        ABM_Estudio.txtmutual.Text = GrillaEstudios.CurrentRow.Cells(6).Value
        ABM_Estudio.txtpaciente.Text = GrillaEstudios.CurrentRow.Cells(1).Value
        ABM_Estudio.txtimporte.Text = GrillaEstudios.CurrentRow.Cells(5).Value
        ABM_Estudio.txtmedicosolicitante.Text = GrillaEstudios.CurrentRow.Cells(3).Value
        ABM_Estudio.txtEstudios.Text = GrillaEstudios.CurrentRow.Cells(4).Value
        ABM_Estudio.txtinforme.Text = GrillaEstudios.CurrentRow.Cells(7).Value
        ABM_Estudio.Show()
    End Sub

    Private Sub txtbuscarturno_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarpaciente.TextChanged
        Dim searchText As String = txtbuscarpaciente.Text.Trim().ToUpper()
        Dim found As Boolean = False

        For Each fila As DataGridViewRow In GrillaPaciente.Rows
            ' Utiliza el índice de la columna o el nombre de la columna que contiene el texto que deseas buscar '
            Dim nombreCellValue As Object = fila.Cells("Nombre").Value
            Dim apellidoCellValue As Object = fila.Cells("Apellido").Value

            If nombreCellValue IsNot Nothing AndAlso Not IsDBNull(nombreCellValue) AndAlso
               apellidoCellValue IsNot Nothing AndAlso Not IsDBNull(apellidoCellValue) Then

                Dim nombreText As String = nombreCellValue.ToString().Trim().ToUpper()
                Dim apellidoText As String = apellidoCellValue.ToString().Trim().ToUpper()

                If nombreText.Contains(searchText) OrElse apellidoText.Contains(searchText) Then
                    ' Puedes establecer la celda actual en la columna "Nombre" o "Apellido" según tus preferencias '
                    GrillaPaciente.CurrentCell = fila.Cells("Nombre")
                    found = True
                    Exit For
                End If
            End If
        Next

        ' Si no se encontró ninguna coincidencia, restablecer la celda actual '
        If Not found Then
            GrillaPaciente.ClearSelection()
        End If
    End Sub

    Private Sub txtbuscarestudio_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarestudio.TextChanged
        Dim searchText As String = txtbuscarestudio.Text.Trim().ToUpper()
        Dim found As Boolean = False

        For Each fila As DataGridViewRow In GrillaEstudios.Rows
            ' Utiliza el índice de la columna o el nombre de la columna que contiene el texto que deseas buscar '
            Dim cellValue As Object = fila.Cells("paciente").Value

            If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                Dim cellText As String = cellValue.ToString().Trim().ToUpper()

                If cellText.Contains(searchText) Then
                    GrillaEstudios.CurrentCell = fila.Cells("paciente")
                    found = True
                    Exit For
                End If
            End If
        Next

        ' Si no se encontró ninguna coincidencia, restablecer la celda actual '
        If Not found Then
            GrillaEstudios.ClearSelection()
        End If
    End Sub

    Private Sub GrillaEstudios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaEstudios.CellContentClick
        ' Asegúrate de que el índice de la columna sea válido y que no estés en una fila nueva (si la hay)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso Not GrillaEstudios.Rows(e.RowIndex).IsNewRow Then
            ' Establece la celda como de solo lectura al hacer clic en ella
            GrillaEstudios.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True
        End If

    End Sub
    Private Sub GrillaEstudios_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles GrillaEstudios.CellBeginEdit
        ' Cancela la edición al hacer clic en la celda
        e.Cancel = True
    End Sub

    Private Sub GrillaPaciente_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles GrillaPaciente.CellBeginEdit
        ' Cancela la edición al hacer clic en la celda
        e.Cancel = True
    End Sub

End Class