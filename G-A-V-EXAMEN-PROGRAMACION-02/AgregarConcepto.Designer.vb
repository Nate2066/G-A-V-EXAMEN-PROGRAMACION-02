<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarConcepto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtNuevoConcepto = New TextBox()
        btnAceptarAgregarConcepto = New Button()
        SuspendLayout()
        ' 
        ' txtNuevoConcepto
        ' 
        txtNuevoConcepto.BackColor = Color.FromArgb(CByte(228), CByte(225), CByte(202))
        txtNuevoConcepto.Location = New Point(12, 20)
        txtNuevoConcepto.Name = "txtNuevoConcepto"
        txtNuevoConcepto.Size = New Size(213, 27)
        txtNuevoConcepto.TabIndex = 0
        ' 
        ' btnAceptarAgregarConcepto
        ' 
        btnAceptarAgregarConcepto.BackColor = Color.FromArgb(CByte(228), CByte(225), CByte(202))
        btnAceptarAgregarConcepto.BackgroundImageLayout = ImageLayout.Zoom
        btnAceptarAgregarConcepto.Location = New Point(239, 12)
        btnAceptarAgregarConcepto.Name = "btnAceptarAgregarConcepto"
        btnAceptarAgregarConcepto.Size = New Size(35, 35)
        btnAceptarAgregarConcepto.TabIndex = 1
        btnAceptarAgregarConcepto.Text = "Add"
        btnAceptarAgregarConcepto.UseVisualStyleBackColor = False
        ' 
        ' AgregarConcepto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(72), CByte(58), CByte(71))
        ClientSize = New Size(286, 61)
        Controls.Add(btnAceptarAgregarConcepto)
        Controls.Add(txtNuevoConcepto)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "AgregarConcepto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AgregarConcepto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNuevoConcepto As TextBox
    Friend WithEvents btnAceptarAgregarConcepto As Button
End Class
