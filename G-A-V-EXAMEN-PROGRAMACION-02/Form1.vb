Public Class Form1
    Dim formAgregarConcepto As AgregarConcepto
    Dim formRemoverConcepto As RemoverConcepto
    Public rellenarState As Boolean
    Dim listaPorDefecto As New List(Of String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaPorDefecto.Add("Sueldos y Salarios Administrativos")
        listaPorDefecto.Add("Servicios Públicos (agua, luz, tel)")
        listaPorDefecto.Add("Papelería y Útiles de Oficina")
        listaPorDefecto.Add("Depreciación de Equipos Adm.")
        listaPorDefecto.Add("Alquiler de Oficinas")
        listaPorDefecto.Add("Gastos Legales y Contables")
        listaPorDefecto.Add("Publicidad")
        listaPorDefecto.Add("Comisiones por Ventas")
        listaPorDefecto.Add("Transporte y Viáticos")
        listaPorDefecto.Add("Mantenimiento y Reparaciones")
        LimpiarData()
        formAgregarConcepto = AgregarConcepto
        formRemoverConcepto = RemoverConcepto
        txtTotal.Enabled = False
        txtTotalSGContable.Enabled = False
        txtTotalSGWeb.Enabled = False
        dgvGastosAdmYVentas.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnLimpiarCuadro_Click(sender As Object, e As EventArgs) Handles btnLimpiarCuadro.Click
        If dgvGastosAdmYVentas.Rows.Count > 0 Then
            LimpiarData()
        End If
    End Sub

    Private Sub btnQuitarConcepto_Click(sender As Object, e As EventArgs) Handles btnQuitarConcepto.Click
        formRemoverConcepto.ShowDialog()
    End Sub
    Private Sub btnAgregarConcepto_Click(sender As Object, e As EventArgs) Handles btnAgregarConcepto.Click
        formAgregarConcepto.ShowDialog()
    End Sub
    Public Sub CalcularSumasFilas(a As DataGridView, val1 As Integer, val2 As Integer, total As Integer)
        Dim totalFilas As Integer
        totalFilas = a.Rows.Count

        For i As Integer = 0 To (totalFilas - 1)
            a.Rows(i).Cells(total).Value = CDec(a.Rows(i).Cells(val1).Value) + CDec(a.Rows(i).Cells(val2).Value)
        Next
    End Sub
    Public Sub CalcularSumasColumnas(a As DataGridView, colm As Integer, total As TextBox)
        Dim suma As Decimal
        Dim totalFilas As Integer
        totalFilas = a.Rows.Count

        suma = 0

        For i As Integer = 0 To (totalFilas - 1)
            suma += CDec(a.Rows(i).Cells(colm).Value)
        Next

        total.Text = suma
    End Sub
    Public Sub LimpiarData()
        Dim totalFilas As Integer = dgvGastosAdmYVentas.Rows.Count
        txtTotal.Text = 0
        txtTotalSGContable.Text = 0
        txtTotalSGWeb.Text = 0
        For i As Integer = 0 To (totalFilas - 1)
            dgvGastosAdmYVentas.Rows(i).Cells(1).Value = 0
            dgvGastosAdmYVentas.Rows(i).Cells(2).Value = 0
            dgvGastosAdmYVentas.Rows(i).Cells(3).Value = 0
        Next
    End Sub

    Private Sub dgvGastosAdmYVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGastosAdmYVentas.CellContentClick

    End Sub

    Private Sub dgvGastosAdmYVentas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvGastosAdmYVentas.EditingControlShowing
        If dgvGastosAdmYVentas.CurrentCell.ColumnIndex = 1 OrElse dgvGastosAdmYVentas.CurrentCell.ColumnIndex = 2 Then

            RemoveHandler e.Control.KeyPress, AddressOf SoloNumeros

            If TypeOf e.Control Is TextBox Then
                AddHandler e.Control.KeyPress, AddressOf SoloNumeros
            End If
        Else
            RemoveHandler e.Control.KeyPress, AddressOf SoloNumeros
        End If
    End Sub
    Private Sub SoloNumeros(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvGastosAdmYVentas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGastosAdmYVentas.CellEndEdit
        If dgvGastosAdmYVentas.Rows.Count > 0 Then
            CalcularSumasFilas(dgvGastosAdmYVentas, 1, 2, 3)
            CalcularSumasColumnas(dgvGastosAdmYVentas, 1, txtTotalSGContable)
            CalcularSumasColumnas(dgvGastosAdmYVentas, 2, txtTotalSGWeb)
        End If
        txtTotal.Text = CDec(txtTotalSGContable.Text) + CDec(txtTotalSGWeb.Text)
    End Sub

    Private Sub ckbRellenar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbRellenar.CheckedChanged
        If ckbRellenar.Checked = True Then
            rellenarState = True
        ElseIf ckbRellenar.Checked = False Then
            rellenarState = False
        End If
        RellenarCuadro()
    End Sub
    Public Sub RellenarCuadro()
        If ckbRellenar.Checked = True Then
            Dim cantidadConceptosAnteriores As Integer = dgvGastosAdmYVentas.Rows.Count
            Dim listaTemporal As New List(Of String)
            If cantidadConceptosAnteriores > 0 Then
                For i As Integer = 0 To cantidadConceptosAnteriores - 1
                    listaTemporal.Add(dgvGastosAdmYVentas.Rows(i).Cells(0).Value)
                    listaTemporal.Add(dgvGastosAdmYVentas.Rows(i).Cells(1).Value)
                    listaTemporal.Add(dgvGastosAdmYVentas.Rows(i).Cells(2).Value)
                Next
            End If
            dgvGastosAdmYVentas.Rows.Clear()
            For i As Integer = 0 To 9
                dgvGastosAdmYVentas.Rows.Add()
                dgvGastosAdmYVentas.Rows(i).Cells(0).Value = listaPorDefecto(i)
            Next
            If cantidadConceptosAnteriores > 0 Then
                Dim a As Integer = 0
                For i As Integer = 0 To listaTemporal.Count - 1
                    dgvGastosAdmYVentas.Rows.Add()
                    dgvGastosAdmYVentas.Rows(a + 10).Cells(0).Value = listaTemporal(i)
                    dgvGastosAdmYVentas.Rows(a + 10).Cells(1).Value = listaTemporal(i + 1)
                    dgvGastosAdmYVentas.Rows(a + 10).Cells(2).Value = listaTemporal(i + 2)
                    i = i + 2
                    a = a + 1
                Next
            End If
        ElseIf ckbRellenar.Checked = False Then
            If dgvGastosAdmYVentas.Rows.Count > 0 Then
                For i As Integer = 0 To 9
                    dgvGastosAdmYVentas.Rows.RemoveAt(0)
                Next
            End If
        End If
    End Sub

    Private Sub btnActualizarCuadro_Click(sender As Object, e As EventArgs) Handles btnActualizarCuadro.Click
        If dgvGastosAdmYVentas.Rows.Count > 0 Then
            CalcularSumasFilas(dgvGastosAdmYVentas, 1, 2, 3)
            CalcularSumasColumnas(dgvGastosAdmYVentas, 1, txtTotalSGContable)
            CalcularSumasColumnas(dgvGastosAdmYVentas, 2, txtTotalSGWeb)
        Else
            MsgBox("El cuadro se encuentra vacio", MsgBoxStyle.Information, "La informacion no pudo actualizarse")
        End If
        txtTotal.Text = CDec(txtTotalSGContable.Text) + CDec(txtTotalSGWeb.Text)
    End Sub
End Class

