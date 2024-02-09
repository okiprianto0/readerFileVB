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
        Browse = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Reset = New Button()
        Close = New Button()
        filepathBtn = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Browse
        ' 
        Browse.Location = New Point(190, 318)
        Browse.Name = "Browse"
        Browse.Size = New Size(75, 23)
        Browse.TabIndex = 0
        Browse.Text = "Browse"
        Browse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(190, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(190, 75)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Reset
        ' 
        Reset.Location = New Point(316, 318)
        Reset.Name = "Reset"
        Reset.Size = New Size(75, 23)
        Reset.TabIndex = 4
        Reset.Text = "Reset"
        Reset.UseVisualStyleBackColor = True
        ' 
        ' Close
        ' 
        Close.Location = New Point(447, 318)
        Close.Name = "Close"
        Close.Size = New Size(75, 23)
        Close.TabIndex = 5
        Close.Text = "Close"
        Close.UseMnemonic = False
        Close.UseVisualStyleBackColor = True
        ' 
        ' filepathBtn
        ' 
        filepathBtn.AutoSize = True
        filepathBtn.Location = New Point(128, 47)
        filepathBtn.Name = "filepathBtn"
        filepathBtn.Size = New Size(49, 15)
        filepathBtn.TabIndex = 6
        filepathBtn.Text = "FilePath"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(128, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 7
        Label2.Text = "Gambar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(128, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(30, 15)
        Label3.TabIndex = 8
        Label3.Text = "Json"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(190, 135)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(240, 150)
        DataGridView1.TabIndex = 9
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(750, 421)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(filepathBtn)
        Controls.Add(Close)
        Controls.Add(Reset)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Browse)
        Name = "Form1"
        Text = "UAS Pemograman Visual - Oki Prianto"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Browse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Reset As Button
    Friend WithEvents Close As Button
    Friend WithEvents filepathBtn As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
