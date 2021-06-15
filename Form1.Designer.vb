<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lbl_SelezionePercorso_AnaSog_Completa = New System.Windows.Forms.Label()
        Me.Lbl_SelezionePercorso_Anagist = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Grp_LogElaborazioni = New System.Windows.Forms.GroupBox()
        Me.Lbl_Elaborazioni = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Grp_LogElaborazioni.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Lbl_SelezionePercorso_Anagist)
        Me.GroupBox1.Controls.Add(Me.Lbl_SelezionePercorso_AnaSog_Completa)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1074, 274)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selezione archivi"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(62, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(365, 75)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Avvia processo di correzione"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lbl_SelezionePercorso_AnaSog_Completa
        '
        Me.Lbl_SelezionePercorso_AnaSog_Completa.AutoSize = True
        Me.Lbl_SelezionePercorso_AnaSog_Completa.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_SelezionePercorso_AnaSog_Completa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_SelezionePercorso_AnaSog_Completa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SelezionePercorso_AnaSog_Completa.Location = New System.Drawing.Point(6, 34)
        Me.Lbl_SelezionePercorso_AnaSog_Completa.Name = "Lbl_SelezionePercorso_AnaSog_Completa"
        Me.Lbl_SelezionePercorso_AnaSog_Completa.Size = New System.Drawing.Size(345, 22)
        Me.Lbl_SelezionePercorso_AnaSog_Completa.TabIndex = 0
        Me.Lbl_SelezionePercorso_AnaSog_Completa.Text = "Seleziona archivio di tipo: AnaSog_Completa"
        '
        'Lbl_SelezionePercorso_Anagist
        '
        Me.Lbl_SelezionePercorso_Anagist.AutoSize = True
        Me.Lbl_SelezionePercorso_Anagist.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_SelezionePercorso_Anagist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_SelezionePercorso_Anagist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SelezionePercorso_Anagist.Location = New System.Drawing.Point(6, 147)
        Me.Lbl_SelezionePercorso_Anagist.Name = "Lbl_SelezionePercorso_Anagist"
        Me.Lbl_SelezionePercorso_Anagist.Size = New System.Drawing.Size(345, 22)
        Me.Lbl_SelezionePercorso_Anagist.TabIndex = 0
        Me.Lbl_SelezionePercorso_Anagist.Text = "Seleziona archivio di tipo: AnaSog_Completa"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Grp_LogElaborazioni
        '
        Me.Grp_LogElaborazioni.Controls.Add(Me.Lbl_Elaborazioni)
        Me.Grp_LogElaborazioni.Location = New System.Drawing.Point(489, 290)
        Me.Grp_LogElaborazioni.Name = "Grp_LogElaborazioni"
        Me.Grp_LogElaborazioni.Size = New System.Drawing.Size(597, 77)
        Me.Grp_LogElaborazioni.TabIndex = 2
        Me.Grp_LogElaborazioni.TabStop = False
        Me.Grp_LogElaborazioni.Text = "Log di elaborazione"
        '
        'Lbl_Elaborazioni
        '
        Me.Lbl_Elaborazioni.AutoSize = True
        Me.Lbl_Elaborazioni.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_Elaborazioni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Elaborazioni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Elaborazioni.Location = New System.Drawing.Point(6, 33)
        Me.Lbl_Elaborazioni.Name = "Lbl_Elaborazioni"
        Me.Lbl_Elaborazioni.Size = New System.Drawing.Size(22, 20)
        Me.Lbl_Elaborazioni.TabIndex = 0
        Me.Lbl_Elaborazioni.Text = "..."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1000, 26)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(7, 175)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(1000, 26)
        Me.TextBox2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1014, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 27)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = ". . ."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1013, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 27)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = ". . ."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1098, 376)
        Me.Controls.Add(Me.Grp_LogElaborazioni)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Correzione Portafoglio Norvegese"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Grp_LogElaborazioni.ResumeLayout(False)
        Me.Grp_LogElaborazioni.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Lbl_SelezionePercorso_Anagist As Label
    Friend WithEvents Lbl_SelezionePercorso_AnaSog_Completa As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Grp_LogElaborazioni As GroupBox
    Friend WithEvents Lbl_Elaborazioni As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
