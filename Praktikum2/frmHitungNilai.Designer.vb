<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHitungNilai
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmHitungNilai))
        Title = New Label()
        lTatapMuka = New Label()
        iTatapMuka = New TextBox()
        iMidTest = New TextBox()
        lMidTest = New Label()
        iFinalTest = New TextBox()
        lFinalTest = New Label()
        bHitung = New Button()
        iNilaiAkhir = New TextBox()
        lNilaiAkhir = New Label()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Title.Location = New Point(50, 23)
        Title.Name = "Title"
        Title.Size = New Size(163, 21)
        Title.TabIndex = 0
        Title.Text = "Program Hitung Nilai"
        ' 
        ' lTatapMuka
        ' 
        lTatapMuka.AutoSize = True
        lTatapMuka.Location = New Point(39, 66)
        lTatapMuka.Name = "lTatapMuka"
        lTatapMuka.Size = New Size(68, 15)
        lTatapMuka.TabIndex = 1
        lTatapMuka.Text = "Tatap Muka"
        ' 
        ' iTatapMuka
        ' 
        iTatapMuka.Location = New Point(132, 63)
        iTatapMuka.MaxLength = 3
        iTatapMuka.Name = "iTatapMuka"
        iTatapMuka.Size = New Size(92, 23)
        iTatapMuka.TabIndex = 2
        iTatapMuka.TextAlign = HorizontalAlignment.Center
        ' 
        ' iMidTest
        ' 
        iMidTest.Location = New Point(132, 92)
        iMidTest.MaxLength = 3
        iMidTest.Name = "iMidTest"
        iMidTest.Size = New Size(92, 23)
        iMidTest.TabIndex = 4
        iMidTest.TextAlign = HorizontalAlignment.Center
        ' 
        ' lMidTest
        ' 
        lMidTest.AutoSize = True
        lMidTest.Location = New Point(39, 95)
        lMidTest.Name = "lMidTest"
        lMidTest.Size = New Size(51, 15)
        lMidTest.TabIndex = 3
        lMidTest.Text = "Mid Test"
        ' 
        ' iFinalTest
        ' 
        iFinalTest.Location = New Point(132, 121)
        iFinalTest.MaxLength = 3
        iFinalTest.Name = "iFinalTest"
        iFinalTest.Size = New Size(92, 23)
        iFinalTest.TabIndex = 6
        iFinalTest.TextAlign = HorizontalAlignment.Center
        ' 
        ' lFinalTest
        ' 
        lFinalTest.AutoSize = True
        lFinalTest.Location = New Point(39, 124)
        lFinalTest.Name = "lFinalTest"
        lFinalTest.Size = New Size(55, 15)
        lFinalTest.TabIndex = 5
        lFinalTest.Text = "Final Test"
        ' 
        ' bHitung
        ' 
        bHitung.Location = New Point(39, 150)
        bHitung.Name = "bHitung"
        bHitung.Size = New Size(185, 23)
        bHitung.TabIndex = 7
        bHitung.Text = "Hitung"
        bHitung.UseVisualStyleBackColor = True
        ' 
        ' iNilaiAkhir
        ' 
        iNilaiAkhir.Location = New Point(132, 179)
        iNilaiAkhir.MaxLength = 3
        iNilaiAkhir.Name = "iNilaiAkhir"
        iNilaiAkhir.ReadOnly = True
        iNilaiAkhir.Size = New Size(92, 23)
        iNilaiAkhir.TabIndex = 9
        iNilaiAkhir.TextAlign = HorizontalAlignment.Center
        ' 
        ' lNilaiAkhir
        ' 
        lNilaiAkhir.AutoSize = True
        lNilaiAkhir.Location = New Point(39, 182)
        lNilaiAkhir.Name = "lNilaiAkhir"
        lNilaiAkhir.Size = New Size(62, 15)
        lNilaiAkhir.TabIndex = 8
        lNilaiAkhir.Text = "Nilai Akhir"
        ' 
        ' frmHitungNilai
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(264, 236)
        Controls.Add(iNilaiAkhir)
        Controls.Add(lNilaiAkhir)
        Controls.Add(bHitung)
        Controls.Add(iFinalTest)
        Controls.Add(lFinalTest)
        Controls.Add(iMidTest)
        Controls.Add(lMidTest)
        Controls.Add(iTatapMuka)
        Controls.Add(lTatapMuka)
        Controls.Add(Title)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "frmHitungNilai"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Program Hitung Nilai"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents lTatapMuka As Label
    Friend WithEvents iTatapMuka As TextBox
    Friend WithEvents iMidTest As TextBox
    Friend WithEvents lMidTest As Label
    Friend WithEvents iFinalTest As TextBox
    Friend WithEvents lFinalTest As Label
    Friend WithEvents bHitung As Button
    Friend WithEvents iNilaiAkhir As TextBox
    Friend WithEvents lNilaiAkhir As Label
End Class
