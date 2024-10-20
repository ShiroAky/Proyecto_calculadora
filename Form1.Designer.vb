<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        operaciones = New RichTextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Numero1 = New Button()
        Numero2 = New Button()
        Numero3 = New Button()
        Signo_division = New Button()
        Numero4 = New Button()
        Numero5 = New Button()
        Numero6 = New Button()
        Signo_multiplicacion = New Button()
        Numero7 = New Button()
        Numero8 = New Button()
        Numero9 = New Button()
        Signo_resta = New Button()
        Numero0 = New Button()
        Btn_Clear = New Button()
        Signo_suma = New Button()
        Signo_igual = New Button()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' operaciones
        ' 
        operaciones.AccessibleRole = AccessibleRole.Equation
        operaciones.BackColor = Color.White
        operaciones.BorderStyle = BorderStyle.None
        operaciones.BulletIndent = 10
        operaciones.DetectUrls = False
        operaciones.Font = New Font("Bebas Kai", 35F)
        operaciones.Location = New Point(0, 0)
        operaciones.Name = "operaciones"
        operaciones.ScrollBars = RichTextBoxScrollBars.None
        operaciones.Size = New Size(372, 195)
        operaciones.TabIndex = 0
        operaciones.Text = "0"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Numero1)
        FlowLayoutPanel1.Controls.Add(Numero2)
        FlowLayoutPanel1.Controls.Add(Numero3)
        FlowLayoutPanel1.Controls.Add(Signo_division)
        FlowLayoutPanel1.Controls.Add(Numero4)
        FlowLayoutPanel1.Controls.Add(Numero5)
        FlowLayoutPanel1.Controls.Add(Numero6)
        FlowLayoutPanel1.Controls.Add(Signo_multiplicacion)
        FlowLayoutPanel1.Controls.Add(Numero7)
        FlowLayoutPanel1.Controls.Add(Numero8)
        FlowLayoutPanel1.Controls.Add(Numero9)
        FlowLayoutPanel1.Controls.Add(Signo_resta)
        FlowLayoutPanel1.Controls.Add(Numero0)
        FlowLayoutPanel1.Controls.Add(Btn_Clear)
        FlowLayoutPanel1.Controls.Add(Signo_suma)
        FlowLayoutPanel1.Controls.Add(Signo_igual)
        FlowLayoutPanel1.Location = New Point(2, 198)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(370, 282)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Numero1
        ' 
        Numero1.Font = New Font("Bebas Kai", 20F)
        Numero1.Location = New Point(3, 3)
        Numero1.Name = "Numero1"
        Numero1.Size = New Size(86, 47)
        Numero1.TabIndex = 0
        Numero1.Text = "1"
        Numero1.UseVisualStyleBackColor = True
        ' 
        ' Numero2
        ' 
        Numero2.Font = New Font("Bebas Kai", 20F)
        Numero2.Location = New Point(95, 3)
        Numero2.Name = "Numero2"
        Numero2.Size = New Size(86, 47)
        Numero2.TabIndex = 1
        Numero2.Text = "2"
        Numero2.UseVisualStyleBackColor = True
        ' 
        ' Numero3
        ' 
        Numero3.Font = New Font("Bebas Kai", 20F)
        Numero3.Location = New Point(187, 3)
        Numero3.Name = "Numero3"
        Numero3.Size = New Size(86, 47)
        Numero3.TabIndex = 2
        Numero3.Text = "3"
        Numero3.UseVisualStyleBackColor = True
        ' 
        ' Signo_division
        ' 
        Signo_division.Font = New Font("Bebas Kai", 20F)
        Signo_division.Location = New Point(279, 3)
        Signo_division.Name = "Signo_division"
        Signo_division.Size = New Size(86, 47)
        Signo_division.TabIndex = 10
        Signo_division.Text = "/"
        Signo_division.UseVisualStyleBackColor = True
        ' 
        ' Numero4
        ' 
        Numero4.Font = New Font("Bebas Kai", 20F)
        Numero4.Location = New Point(3, 56)
        Numero4.Name = "Numero4"
        Numero4.Size = New Size(86, 47)
        Numero4.TabIndex = 3
        Numero4.Text = "4"
        Numero4.UseVisualStyleBackColor = True
        ' 
        ' Numero5
        ' 
        Numero5.Font = New Font("Bebas Kai", 20F)
        Numero5.Location = New Point(95, 56)
        Numero5.Name = "Numero5"
        Numero5.Size = New Size(86, 47)
        Numero5.TabIndex = 4
        Numero5.Text = "5"
        Numero5.UseVisualStyleBackColor = True
        ' 
        ' Numero6
        ' 
        Numero6.Font = New Font("Bebas Kai", 20F)
        Numero6.Location = New Point(187, 56)
        Numero6.Name = "Numero6"
        Numero6.Size = New Size(86, 47)
        Numero6.TabIndex = 5
        Numero6.Text = "6"
        Numero6.UseVisualStyleBackColor = True
        ' 
        ' Signo_multiplicacion
        ' 
        Signo_multiplicacion.Font = New Font("Bebas Kai", 20F)
        Signo_multiplicacion.Location = New Point(279, 56)
        Signo_multiplicacion.Name = "Signo_multiplicacion"
        Signo_multiplicacion.Size = New Size(86, 47)
        Signo_multiplicacion.TabIndex = 12
        Signo_multiplicacion.Text = "*"
        Signo_multiplicacion.UseVisualStyleBackColor = True
        ' 
        ' Numero7
        ' 
        Numero7.Font = New Font("Bebas Kai", 20F)
        Numero7.Location = New Point(3, 109)
        Numero7.Name = "Numero7"
        Numero7.Size = New Size(86, 47)
        Numero7.TabIndex = 6
        Numero7.Text = "7"
        Numero7.UseVisualStyleBackColor = True
        ' 
        ' Numero8
        ' 
        Numero8.Font = New Font("Bebas Kai", 20F)
        Numero8.Location = New Point(95, 109)
        Numero8.Name = "Numero8"
        Numero8.Size = New Size(86, 47)
        Numero8.TabIndex = 7
        Numero8.Text = "8"
        Numero8.UseVisualStyleBackColor = True
        ' 
        ' Numero9
        ' 
        Numero9.Font = New Font("Bebas Kai", 20F)
        Numero9.Location = New Point(187, 109)
        Numero9.Name = "Numero9"
        Numero9.Size = New Size(86, 47)
        Numero9.TabIndex = 8
        Numero9.Text = "9"
        Numero9.UseVisualStyleBackColor = True
        ' 
        ' Signo_resta
        ' 
        Signo_resta.Font = New Font("Bebas Kai", 20F)
        Signo_resta.Location = New Point(279, 109)
        Signo_resta.Name = "Signo_resta"
        Signo_resta.Size = New Size(86, 47)
        Signo_resta.TabIndex = 11
        Signo_resta.Text = "-"
        Signo_resta.UseVisualStyleBackColor = True
        ' 
        ' Numero0
        ' 
        Numero0.Font = New Font("Bebas Kai", 20F)
        Numero0.Location = New Point(3, 162)
        Numero0.Name = "Numero0"
        Numero0.Size = New Size(86, 47)
        Numero0.TabIndex = 9
        Numero0.Text = "0"
        Numero0.UseVisualStyleBackColor = True
        ' 
        ' Btn_Clear
        ' 
        Btn_Clear.Font = New Font("Bebas Kai", 20F)
        Btn_Clear.Location = New Point(95, 162)
        Btn_Clear.Name = "Btn_Clear"
        Btn_Clear.Size = New Size(178, 47)
        Btn_Clear.TabIndex = 14
        Btn_Clear.Text = "AC"
        Btn_Clear.UseVisualStyleBackColor = True
        ' 
        ' Signo_suma
        ' 
        Signo_suma.Font = New Font("Bebas Kai", 20F)
        Signo_suma.Location = New Point(279, 162)
        Signo_suma.Name = "Signo_suma"
        Signo_suma.Size = New Size(86, 47)
        Signo_suma.TabIndex = 13
        Signo_suma.Text = "+"
        Signo_suma.UseVisualStyleBackColor = True
        ' 
        ' Signo_igual
        ' 
        Signo_igual.Font = New Font("Bebas Kai", 20F)
        Signo_igual.Location = New Point(3, 215)
        Signo_igual.Name = "Signo_igual"
        Signo_igual.Size = New Size(362, 65)
        Signo_igual.TabIndex = 15
        Signo_igual.Text = "="
        Signo_igual.UseVisualStyleBackColor = True
        ' 
        ' Calculadora
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(373, 481)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(operaciones)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Calculadora"
        Text = "Proyecto Calculadora"
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents operaciones As RichTextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Numero1 As Button
    Friend WithEvents Numero2 As Button
    Friend WithEvents Numero3 As Button
    Friend WithEvents Signo_division As Button
    Friend WithEvents Numero4 As Button
    Friend WithEvents Numero5 As Button
    Friend WithEvents Numero6 As Button
    Friend WithEvents Numero7 As Button
    Friend WithEvents Numero8 As Button
    Friend WithEvents Numero9 As Button
    Friend WithEvents Numero0 As Button
    Friend WithEvents Signo_resta As Button
    Friend WithEvents Signo_multiplicacion As Button
    Friend WithEvents Signo_suma As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Signo_igual As Button

End Class
