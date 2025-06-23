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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarConcepto))
        txtNuevoConcepto = New TextBox()
        btnAceptarAgregarConcepto = New Button()
        SuspendLayout()
        ' 
        ' txtNuevoConcepto
        ' 
        txtNuevoConcepto.Location = New Point(12, 20)
        txtNuevoConcepto.Name = "txtNuevoConcepto"
        txtNuevoConcepto.Size = New Size(213, 27)
        txtNuevoConcepto.TabIndex = 0
        ' 
        ' btnAceptarAgregarConcepto
        ' 
        btnAceptarAgregarConcepto.BackgroundImage = CType(resources.GetObject("btnAceptarAgregarConcepto.BackgroundImage"), Image)
        btnAceptarAgregarConcepto.BackgroundImageLayout = ImageLayout.Zoom
        btnAceptarAgregarConcepto.Location = New Point(239, 12)
        btnAceptarAgregarConcepto.Name = "btnAceptarAgregarConcepto"
        btnAceptarAgregarConcepto.Size = New Size(35, 35)
        btnAceptarAgregarConcepto.TabIndex = 1
        btnAceptarAgregarConcepto.UseVisualStyleBackColor = True
        ' 
        ' AgregarConcepto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(286, 61)
        Controls.Add(btnAceptarAgregarConcepto)
        Controls.Add(txtNuevoConcepto)
        Name = "AgregarConcepto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AgregarConcepto"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNuevoConcepto As TextBox
    Friend WithEvents btnAceptarAgregarConcepto As Button
End Class
