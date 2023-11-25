'Se declara el formulario en este caso el de agenda'
Public Class FormularioAgenda
    'Se pone un boton de salir y con el me.close se cierra'
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Public Sub FormularioAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al iniciarse la aplicacion se dispara el evento de cargaagenda'
        cargaagenda()
    End Sub


    Public Sub cargaagenda()
        'Una vez iniciada la aplicacion, al label se le da el nombre de BUSQUEDA RAPIDA para facilitar la busqueda en la agenda'
        Me.lblbuscar.Text = "BUSQUEDA RAPIDA"
        'Se verifica si la grilla tiene datos, si tiene fila las limpia antes de cargar nuevos datos'
        If GrillaAgenda.Rows.Count <> 0 Then
            GrillaAgenda.Rows.Clear()
        End If
        'llama a la funcion de carga de registros de alumnos
        acciones.Connection = conexionSql
        acciones.CommandType = CommandType.Text 'Se indica que el tipo de dato que se va a ingresar es de tipo texto'
        acciones.CommandText = "select * from Agenda order by Id_Contacto" 'Se seleccionan todos los datos que estan en la tabla agenda y se ordenan desde Id_Contacto'
        lectordatos = acciones.ExecuteReader 'Ejecuta la cosulta SQL y utiliza el lectordatos previamente cargado en el modulo'
        If lectordatos.HasRows Then
            While lectordatos.Read()
                'agrego los datos a la grilla
                GrillaAgenda.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11))
            End While
        Else
        End If
        lectordatos.Close()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        ' Obtener el valor de Id_Alumno del registro seleccionado en tu tabla o lista
        Dim Id_Contacto As Integer = ObtenerId_ContactoSeleccionado() ' Reemplaza esta línea con el código para obtener el valor de Id_Alumno seleccionado

        ' Mostrar un mensaje de confirmación antes de la eliminación
        Dim confirmacion As DialogResult = MessageBox.Show("¿Seguro que deseas borrar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar la respuesta del usuario
        If confirmacion = DialogResult.Yes Then
            ' El usuario confirmó la eliminación
            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "DELETE FROM Agenda WHERE Id_Contacto = " & Id_Contacto
                acciones.ExecuteNonQuery()
                MsgBox("Registro eliminado")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Me.cargaagenda()
        End If
    End Sub


    Private Function ObtenerId_ContactoSeleccionado() As Integer
        ' Reemplaza esta función con tu propio código para obtener el valor de Id_Alumno del registro seleccionado en tu tabla o lista
        ' Puede ser a través de un control DataGridView, ListView, ListBox, etc.
        ' Aquí te muestro un ejemplo con un DataGridView:
        If GrillaAgenda.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = GrillaAgenda.SelectedRows(0)
            Dim IdContacto As Integer = CInt(row.Cells("IdContacto").Value)
            Return IdContacto
        End If
        Return 0 ' Devuelve un valor predeterminado si no hay registro seleccionado
    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ABMagenda.lblseñal.Text = "Agregar"
        ABMagenda.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ABMagenda.lblseñal.Text = "Modificar" 'Cuando se vaya a modificar se le agrega en el label del AMB la palabra modificar para que el usuario sepa que accion va a realizar'
        'Se muestra en los diferentes txt los datos de las diferentes celdas'
        ABMagenda.txtid.Text = GrillaAgenda.CurrentRow.Cells(0).Value
        ABMagenda.txtapellido.Text = GrillaAgenda.CurrentRow.Cells(1).Value
        ABMagenda.txtnombre.Text = GrillaAgenda.CurrentRow.Cells(2).Value
        ABMagenda.txtlocalidad.Text = GrillaAgenda.CurrentRow.Cells(3).Value
        ABMagenda.txttelefono.Text = GrillaAgenda.CurrentRow.Cells(4).Value
        ABMagenda.txtcelular.Text = GrillaAgenda.CurrentRow.Cells(5).Value
        ABMagenda.txtotrotelefono.Text = GrillaAgenda.CurrentRow.Cells(6).Value
        ABMagenda.txtemail.Text = GrillaAgenda.CurrentRow.Cells(7).Value
        ABMagenda.txtpaginaweb.Text = GrillaAgenda.CurrentRow.Cells(8).Value
        ABMagenda.txtpersonacontacto.Text = GrillaAgenda.CurrentRow.Cells(9).Value
        ABMagenda.txttelefonocontacto.Text = GrillaAgenda.CurrentRow.Cells(10).Value
        ABMagenda.txtdireccion.Text = GrillaAgenda.CurrentRow.Cells(11).Value
        ABMagenda.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblbuscar.Click
        Me.lblbuscar.Text = "BUSQUEDA RAPIDA"
    End Sub

    Public Sub hola()
        Dim fila As DataGridViewRow = New DataGridViewRow


    End Sub

    Private Sub txtbuscarturno_TextChanged(sender As Object, e As EventArgs) Handles txtbuscaragenda.TextChanged
        Dim searchText As String = txtbuscaragenda.Text.Trim().ToUpper()
        Dim found As Boolean = False

        For Each fila As DataGridViewRow In GrillaAgenda.Rows
            ' Utiliza el índice de la columna o el nombre de la columna que contiene el texto que deseas buscar '
            Dim nombreCellValue As Object = fila.Cells("Nombre").Value
            Dim apellidoCellValue As Object = fila.Cells("Apellido").Value

            If nombreCellValue IsNot Nothing AndAlso Not IsDBNull(nombreCellValue) AndAlso
               apellidoCellValue IsNot Nothing AndAlso Not IsDBNull(apellidoCellValue) Then

                Dim nombreText As String = nombreCellValue.ToString().Trim().ToUpper()
                Dim apellidoText As String = apellidoCellValue.ToString().Trim().ToUpper()

                If nombreText.Contains(searchText) OrElse apellidoText.Contains(searchText) Then
                    ' Puedes establecer la celda actual en la columna "Nombre" o "Apellido" según tus preferencias '
                    GrillaAgenda.CurrentCell = fila.Cells("Nombre")
                    found = True
                    Exit For
                End If
            End If
        Next

        ' Si no se encontró ninguna coincidencia, restablecer la celda actual '
        If Not found Then
            GrillaAgenda.ClearSelection()
        End If
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        limpiatemporal()
    End Sub

    Private Sub limpiatemporal()
        Dim consulta As String
        acciones.Connection = conexionSql
        acciones.CommandType = CommandType.Text
        acciones.CommandText = "DELETE FROM TablaTemoralAgenda"
        acciones.ExecuteNonQuery()

        'GRABA LOS DATOS EN LA TABLA TEMPORAL
        For Each fila As DataGridViewRow In GrillaAgenda.Rows
            consulta = "INSERT INTO  TablaTemoralAgenda (CAMPO0, CAMPO1, CAMPO2, CAMPO3, CAMPO4, CAMPO5, CAMPO6, CAMPO7, CAMPO8, CAMPO9, CAMPO10, CAMPO11) " &
           "VALUES('" & fila.Cells(0).Value & "','" & fila.Cells(1).Value & "', '" & fila.Cells(2).Value & "', " & Val(fila.Cells(3).Value) & "," & Val(fila.Cells(4).Value) & ",'" & fila.Cells(5).Value & "','" & fila.Cells(6).Value & "', '" & fila.Cells(7).Value & "', " & Val(fila.Cells(8).Value) & "," & Val(fila.Cells(9).Value) & ",'" & fila.Cells(10).Value & "','" & fila.Cells(11).Value & "')"

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = consulta ' Corregido el nombre de la variable.

            acciones.ExecuteNonQuery()
        Next
    End Sub



    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
    Public Sub FormularioAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaagenda()

    End Sub
    Private Sub GrillaAgenda_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaAgenda.CellContentClick
        If GrillaAgenda.Rows.Count <> 0 Then
            GrillaAgenda.Rows.Clear()
        End If
        'llama a la funcion de carga de registros de alumnos
        acciones.Connection = conexionSql
        acciones.CommandType = CommandType.Text
        acciones.CommandText = "select * from Agenda order by Id_Contacto"
        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then
            While lectordatos.Read()
                'agrego los datos a la grilla
                GrillaAgenda.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11))
            End While
        Else
        End If
        lectordatos.Close()
    End Sub
    Private Sub GrillaAgenda_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles GrillaAgenda.CellBeginEdit
        ' Cancela la edición al hacer clic en la celda
        e.Cancel = True
    End Sub
End Class