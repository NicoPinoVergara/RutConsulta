<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnBuscar = New Button()
        txtRut = New TextBox()
        txtResult = New TextBox()
        SuspendLayout()
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(465, 120)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(132, 98)
        btnBuscar.TabIndex = 0
        btnBuscar.Text = "Buscar Rut"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(204, 141)
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(217, 23)
        txtRut.TabIndex = 1
        txtRut.Text = "Ingrese Rut a Buscar"
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(204, 239)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(217, 23)
        txtResult.TabIndex = 2
        txtResult.Text = "Resultado de la Busqueda"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtResult)
        Controls.Add(txtRut)
        Controls.Add(btnBuscar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label

End Class
