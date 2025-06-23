Public Class AgregarConcepto
    Private Sub btnAceptarAgregarConcepto_Click(sender As Object, e As EventArgs) Handles btnAceptarAgregarConcepto.Click
        If txtNuevoConcepto.Text IsNot "" Then
            Form1.dgvGastosAdmYVentas.Rows.Add()
            Form1.dgvGastosAdmYVentas.Rows(Form1.dgvGastosAdmYVentas.Rows.Count - 1).Cells(0).Value = txtNuevoConcepto.Text
            txtNuevoConcepto.Clear()
        End If

    End Sub

    Private Sub AgregarConcepto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNuevoConcepto.Clear()
    End Sub
End Class