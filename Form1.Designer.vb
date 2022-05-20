<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lst_numeri = New System.Windows.Forms.ListBox()
        Me.lst_numeriPrimi = New System.Windows.Forms.ListBox()
        Me.btn_carica = New System.Windows.Forms.Button()
        Me.bttn_visualizza = New System.Windows.Forms.Button()
        Me.btn_visualizzaPrimi = New System.Windows.Forms.Button()
        Me.btn_esci = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst_numeri
        '
        Me.lst_numeri.FormattingEnabled = True
        Me.lst_numeri.ItemHeight = 15
        Me.lst_numeri.Location = New System.Drawing.Point(108, 12)
        Me.lst_numeri.Name = "lst_numeri"
        Me.lst_numeri.Size = New System.Drawing.Size(201, 139)
        Me.lst_numeri.TabIndex = 0
        '
        'lst_numeriPrimi
        '
        Me.lst_numeriPrimi.FormattingEnabled = True
        Me.lst_numeriPrimi.ItemHeight = 15
        Me.lst_numeriPrimi.Location = New System.Drawing.Point(315, 12)
        Me.lst_numeriPrimi.Name = "lst_numeriPrimi"
        Me.lst_numeriPrimi.Size = New System.Drawing.Size(192, 139)
        Me.lst_numeriPrimi.TabIndex = 1
        '
        'btn_carica
        '
        Me.btn_carica.Location = New System.Drawing.Point(108, 194)
        Me.btn_carica.Name = "btn_carica"
        Me.btn_carica.Size = New System.Drawing.Size(75, 23)
        Me.btn_carica.TabIndex = 2
        Me.btn_carica.Text = "Carica"
        Me.btn_carica.UseVisualStyleBackColor = True
        '
        'bttn_visualizza
        '
        Me.bttn_visualizza.Location = New System.Drawing.Point(189, 194)
        Me.bttn_visualizza.Name = "bttn_visualizza"
        Me.bttn_visualizza.Size = New System.Drawing.Size(75, 23)
        Me.bttn_visualizza.TabIndex = 3
        Me.bttn_visualizza.Text = "Visualizza"
        Me.bttn_visualizza.UseVisualStyleBackColor = True
        '
        'btn_visualizzaPrimi
        '
        Me.btn_visualizzaPrimi.Location = New System.Drawing.Point(315, 179)
        Me.btn_visualizzaPrimi.Name = "btn_visualizzaPrimi"
        Me.btn_visualizzaPrimi.Size = New System.Drawing.Size(75, 38)
        Me.btn_visualizzaPrimi.TabIndex = 4
        Me.btn_visualizzaPrimi.Text = "Visualizza primi"
        Me.btn_visualizzaPrimi.UseVisualStyleBackColor = True
        '
        'btn_esci
        '
        Me.btn_esci.Location = New System.Drawing.Point(396, 194)
        Me.btn_esci.Name = "btn_esci"
        Me.btn_esci.Size = New System.Drawing.Size(75, 23)
        Me.btn_esci.TabIndex = 5
        Me.btn_esci.Text = "Esci"
        Me.btn_esci.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 229)
        Me.Controls.Add(Me.btn_esci)
        Me.Controls.Add(Me.btn_visualizzaPrimi)
        Me.Controls.Add(Me.bttn_visualizza)
        Me.Controls.Add(Me.btn_carica)
        Me.Controls.Add(Me.lst_numeriPrimi)
        Me.Controls.Add(Me.lst_numeri)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lst_numeri As ListBox
    Friend WithEvents lst_numeriPrimi As ListBox
    Friend WithEvents btn_carica As Button
    Friend WithEvents bttn_visualizza As Button
    Friend WithEvents btn_visualizzaPrimi As Button
    Friend WithEvents btn_esci As Button
End Class
