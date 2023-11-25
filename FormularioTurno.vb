Imports System.Data.SqlClient

Public Class FormularioTurno
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ABM_Turnos.lblseñalturno.Text = "Agregar"
        ABM_Turnos.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        ABM_Turnos.lblseñalturno.Text = "Modificar"
        ABM_Turnos.txtIdTurno.Text = grillaturno.CurrentRow.Cells(0).Value
        ABM_Turnos.txtmutual.Text = grillaturno.CurrentRow.Cells(3).Value
        ABM_Turnos.txtmedicosolicitante.Text = grillaturno.CurrentRow.Cells(7).Value
        ABM_Turnos.txtprestaciones.Text = grillaturno.CurrentRow.Cells(2).Value
        ABM_Turnos.txtobservaciones.Text = grillaturno.CurrentRow.Cells(8).Value
        ABM_Turnos.dtfecha.Value = grillaturno.CurrentRow.Cells(5).Value
        ABM_Turnos.txtidpaciente.Text = grillaturno.CurrentRow.Cells(4).Value
        ABM_Turnos.txtminutos.Text = grillaturno.CurrentRow.Cells(11).Value
        ABM_Turnos.txthora.Text = grillaturno.CurrentRow.Cells(9).Value
        ABM_Turnos.txttelefono.Text = grillaturno.CurrentRow.Cells(10).Value
        ABM_Turnos.txtnroafiliado.Text = grillaturno.CurrentRow.Cells(6).Value


        ABM_Turnos.Show()

    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles grillaturno.SelectionChanged
        ' Verificar si se ha seleccionado una fila en el DataGridView.
        If grillaturno.SelectedRows.Count > 0 Then
            ' Obtener la fila seleccionada.
            Dim filaSeleccionada As DataGridViewRow = grillaturno.SelectedRows(0)

            ' Obtener los valores de las celdas correspondientes.
            Dim mutual As String = filaSeleccionada.Cells(3).Value.ToString()
            Dim NroAfiliado As String = filaSeleccionada.Cells(6).Value.ToString()
            Dim MedicoSolicitante As String = filaSeleccionada.Cells(7).Value.ToString()
            Dim Prestaciones As String = filaSeleccionada.Cells(2).Value.ToString()
            Dim Observaciones As String = filaSeleccionada.Cells(8).Value.ToString()
            Dim Telefono As String = filaSeleccionada.Cells(10).Value.ToString()

            ' Asignar valores a los campos de texto.
            txtmutual1.Text = Mutual
            txtnumerodeafiliado1.Text = NroAfiliado
            txtmedicosolicitante1.Text = MedicoSolicitante
            txtprestaciones1.Text = Prestaciones
            txtobservaciones1.Text = Observaciones
            txttelefono1.Text = Telefono
        End If
    End Sub


    Private Sub FormularioTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargaturno()
        Me.lblbuscarturno.Text = "BUSQUEDA RAPIDA"


    End Sub
    Public Sub Cargaturno()


        If grillaturno.Rows.Count <> 0 Then
            grillaturno.Rows.Clear()
        End If

        ' Llamada a la función de carga de registros de pacientes
        acciones.Connection = conexionSql
        acciones.CommandType = CommandType.Text
        acciones.CommandText = "SELECT * FROM Turno ORDER BY IdTurno"

        ' Verificar si el DataReader está abierto y cerrarlo si es necesario
        If Not lectordatos Is Nothing AndAlso Not lectordatos.IsClosed Then
            lectordatos.Close()
        End If

        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then
            While lectordatos.Read()
                ' Concatenar lectordatos(9), ":" y lectordatos(7)
                Dim valorConcatenado As String = lectordatos(9).ToString() & ":" & lectordatos(8).ToString()

                ' Agregar los datos a la grilla de pacientes
                grillaturno.Rows.Add(lectordatos(0), valorConcatenado, lectordatos(4), lectordatos(1), lectordatos(7), lectordatos(6), lectordatos(2), lectordatos(3), lectordatos(5), lectordatos(9), lectordatos(10), lectordatos(8))
            End While
        End If
        lectordatos.Close()


    End Sub

    Private Sub grillaturno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grillaturno.CellContentClick
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim resultado As Integer = MessageBox.Show("¿Seguro que deseas borrar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo)

        ' Verificar la respuesta del usuario
        If resultado = DialogResult.Yes Then
            ' El usuario confirmó la eliminación
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "DELETE FROM Turno WHERE IdTurno = " & Val(grillaturno.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox("Registro eliminado")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Me.Cargaturno()

        End If
    End Sub

    Private Sub txtbuscarturno_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarturno.TextChanged
        Dim searchText As String = txtbuscarturno.Text.Trim().ToUpper()
        Dim found As Boolean = False

        For Each fila As DataGridViewRow In grillaturno.Rows
            ' Utiliza el índice de la columna o el nombre de la columna que contiene el texto que deseas buscar '
            Dim cellValue As Object = fila.Cells("Paciente").Value


            If cellValue IsNot Nothing AndAlso Not IsDBNull(cellValue) Then
                Dim cellText As String = cellValue.ToString().Trim().ToUpper()

                If cellText.Contains(searchText) Then
                    grillaturno.CurrentCell = fila.Cells("Paciente")
                    found = True
                    Exit For
                End If
            End If
        Next

        ' Si no se encontró ninguna coincidencia, restablecer la celda actual '
        If Not found Then
            grillaturno.ClearSelection()
        End If
    End Sub
    Private Sub GrillaTurno_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grillaturno.CellBeginEdit
        ' Cancela la edición al hacer clic en la celda
        e.Cancel = True
    End Sub


End Class