Public Class RemoverConcepto
    Private Sub RemoverConcepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarData()
    End Sub

    Private Sub btnAceptarQuitarConcepto_Click(sender As Object, e As EventArgs) Handles btnAceptarQuitarConcepto.Click
        If Form1.dgvGastosAdmYVentas.Rows.Count > 0 And dgvEliminarConceptos.Rows.Count > 0 Then
            If Form1.rellenarState = True Then
                Form1.dgvGastosAdmYVentas.Rows.RemoveAt(dgvEliminarConceptos.CurrentRow.Index + 10)
            ElseIf Form1.rellenarState = False Then
                Form1.dgvGastosAdmYVentas.Rows.RemoveAt(dgvEliminarConceptos.CurrentRow.Index)
            End If
            LimpiarData()
        End If
    End Sub
    Public Sub LimpiarData()
        dgvEliminarConceptos.Rows.Clear()
        Dim a As Integer = Form1.dgvGastosAdmYVentas.Rows.Count
        Dim b As Integer = 0
        Dim c As Integer
        If Form1.rellenarState = True Then
            b = 10
        ElseIf Form1.rellenarState = False Then
            b = 0
        End If
        If b = 10 Then
            c = 10
        ElseIf b = 0 Then
            c = 0
        End If
        For i As Integer = b To (a - 1)
            dgvEliminarConceptos.Rows.Add()
            dgvEliminarConceptos.Rows(i - c).Cells(0).Value = Form1.dgvGastosAdmYVentas.Rows(i).Cells(0).Value
        Next
    End Sub

    Private Sub dgvEliminarConceptos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEliminarConceptos.CellContentClick

    End Sub
End Class