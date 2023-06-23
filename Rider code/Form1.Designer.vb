<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDropIt
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormDropIt))
        GroupBox1 = New GroupBox()
        btnExit = New Button()
        btnChooseCustomer = New Button()
        lbChooseCustomer = New ListBox()
        GroupBox3 = New GroupBox()
        lblViewCustomer = New Label()
        btnDeleteCusto = New Button()
        lbViewCustomer = New ListBox()
        Label1 = New Label()
        btnClearAll = New Button()
        lblChooseCustomer = New Label()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightGreen
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(btnChooseCustomer)
        GroupBox1.Location = New Point(0, 36)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(79, 561)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), Image)
        btnExit.BackgroundImageLayout = ImageLayout.None
        btnExit.FlatStyle = FlatStyle.Popup
        btnExit.Location = New Point(12, 479)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(50, 52)
        btnExit.TabIndex = 1
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnChooseCustomer
        ' 
        btnChooseCustomer.BackgroundImage = CType(resources.GetObject("btnChooseCustomer.BackgroundImage"), Image)
        btnChooseCustomer.BackgroundImageLayout = ImageLayout.None
        btnChooseCustomer.FlatStyle = FlatStyle.Popup
        btnChooseCustomer.Location = New Point(13, 30)
        btnChooseCustomer.Name = "btnChooseCustomer"
        btnChooseCustomer.Size = New Size(49, 51)
        btnChooseCustomer.TabIndex = 0
        btnChooseCustomer.UseVisualStyleBackColor = True
        ' 
        ' lbChooseCustomer
        ' 
        lbChooseCustomer.BackColor = Color.Black
        lbChooseCustomer.BorderStyle = BorderStyle.None
        lbChooseCustomer.ForeColor = SystemColors.InactiveBorder
        lbChooseCustomer.FormattingEnabled = True
        lbChooseCustomer.ItemHeight = 25
        lbChooseCustomer.Location = New Point(79, 97)
        lbChooseCustomer.Name = "lbChooseCustomer"
        lbChooseCustomer.Size = New Size(526, 500)
        lbChooseCustomer.TabIndex = 5
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.White
        GroupBox3.Controls.Add(lblViewCustomer)
        GroupBox3.Controls.Add(btnDeleteCusto)
        GroupBox3.Controls.Add(lbViewCustomer)
        GroupBox3.Location = New Point(605, 36)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(568, 561)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        ' 
        ' lblViewCustomer
        ' 
        lblViewCustomer.BackColor = Color.Transparent
        lblViewCustomer.Font = New Font("Sitka Small", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblViewCustomer.ForeColor = SystemColors.ActiveCaptionText
        lblViewCustomer.Location = New Point(0, 13)
        lblViewCustomer.Name = "lblViewCustomer"
        lblViewCustomer.Size = New Size(568, 51)
        lblViewCustomer.TabIndex = 4
        lblViewCustomer.Text = "View Customer details:"
        lblViewCustomer.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnDeleteCusto
        ' 
        btnDeleteCusto.BackColor = SystemColors.ControlText
        btnDeleteCusto.FlatStyle = FlatStyle.Popup
        btnDeleteCusto.Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeleteCusto.ForeColor = SystemColors.ButtonHighlight
        btnDeleteCusto.Location = New Point(371, 479)
        btnDeleteCusto.Name = "btnDeleteCusto"
        btnDeleteCusto.Size = New Size(153, 41)
        btnDeleteCusto.TabIndex = 2
        btnDeleteCusto.Text = "Delete Customer"
        btnDeleteCusto.UseVisualStyleBackColor = False
        ' 
        ' lbViewCustomer
        ' 
        lbViewCustomer.BorderStyle = BorderStyle.None
        lbViewCustomer.FormattingEnabled = True
        lbViewCustomer.ItemHeight = 25
        lbViewCustomer.Location = New Point(0, 67)
        lbViewCustomer.Name = "lbViewCustomer"
        lbViewCustomer.Size = New Size(568, 500)
        lbViewCustomer.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.ForestGreen
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(1173, 49)
        Label1.TabIndex = 4
        Label1.Text = "Hello DropIt Rider !!"
        ' 
        ' btnClearAll
        ' 
        btnClearAll.BackColor = SystemColors.ControlText
        btnClearAll.FlatStyle = FlatStyle.Popup
        btnClearAll.Font = New Font("Arial Narrow", 9F, FontStyle.Underline, GraphicsUnit.Point)
        btnClearAll.ForeColor = SystemColors.ButtonHighlight
        btnClearAll.Location = New Point(429, 522)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(153, 41)
        btnClearAll.TabIndex = 4
        btnClearAll.Text = "Clear All"
        btnClearAll.UseVisualStyleBackColor = False
        ' 
        ' lblChooseCustomer
        ' 
        lblChooseCustomer.BackColor = SystemColors.ActiveCaptionText
        lblChooseCustomer.Font = New Font("Sitka Small", 10F, FontStyle.Regular, GraphicsUnit.Point)
        lblChooseCustomer.ForeColor = SystemColors.ButtonFace
        lblChooseCustomer.Location = New Point(79, 49)
        lblChooseCustomer.Name = "lblChooseCustomer"
        lblChooseCustomer.Size = New Size(526, 51)
        lblChooseCustomer.TabIndex = 0
        lblChooseCustomer.Text = "Choose Customer:"
        lblChooseCustomer.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' FormDropIt
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1170, 593)
        Controls.Add(lblChooseCustomer)
        Controls.Add(btnClearAll)
        Controls.Add(Label1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(lbChooseCustomer)
        Name = "FormDropIt"
        Text = "DropIt"
        GroupBox1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDeleteCusto As Button
    Friend WithEvents btnChooseCustomer As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbViewCustomer As ListBox
    Friend WithEvents lbChooseCustomer As ListBox
    Friend WithEvents btnClearAll As Button
    Friend WithEvents lblChooseCustomer As Label
    Friend WithEvents lblViewCustomer As Label
End Class
