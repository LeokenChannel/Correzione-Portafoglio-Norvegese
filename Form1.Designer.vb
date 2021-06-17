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
        Me.Txt_Percorso_Anagist_Corretto = New System.Windows.Forms.TextBox()
        Me.Btn_Percorso_Anagist = New System.Windows.Forms.Button()
        Me.Btn_Percorso_AnaSog_Completa = New System.Windows.Forms.Button()
        Me.Txt_Percorso_Anagist = New System.Windows.Forms.TextBox()
        Me.Txt_Percorso_Anasog_Completa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_SelezionePercorso_Anagist = New System.Windows.Forms.Label()
        Me.Lbl_SelezionePercorso_AnaSog_Completa = New System.Windows.Forms.Label()
        Me.Btn_AvviaCorrezione = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Grp_LogElaborazioni = New System.Windows.Forms.GroupBox()
        Me.Lbl_Elaborazioni = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_CFPIVA_Elaborato = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Grp_LogElaborazioni.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Percorso_Anagist_Corretto)
        Me.GroupBox1.Controls.Add(Me.Btn_Percorso_Anagist)
        Me.GroupBox1.Controls.Add(Me.Btn_Percorso_AnaSog_Completa)
        Me.GroupBox1.Controls.Add(Me.Txt_Percorso_Anagist)
        Me.GroupBox1.Controls.Add(Me.Txt_Percorso_Anasog_Completa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Lbl_SelezionePercorso_Anagist)
        Me.GroupBox1.Controls.Add(Me.Lbl_SelezionePercorso_AnaSog_Completa)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1208, 339)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selezione archivi"
        '
        'Txt_Percorso_Anagist_Corretto
        '
        Me.Txt_Percorso_Anagist_Corretto.Enabled = False
        Me.Txt_Percorso_Anagist_Corretto.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Txt_Percorso_Anagist_Corretto.Location = New System.Drawing.Point(8, 285)
        Me.Txt_Percorso_Anagist_Corretto.Name = "Txt_Percorso_Anagist_Corretto"
        Me.Txt_Percorso_Anagist_Corretto.Size = New System.Drawing.Size(1189, 30)
        Me.Txt_Percorso_Anagist_Corretto.TabIndex = 3
        '
        'Btn_Percorso_Anagist
        '
        Me.Btn_Percorso_Anagist.Location = New System.Drawing.Point(1140, 168)
        Me.Btn_Percorso_Anagist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Percorso_Anagist.Name = "Btn_Percorso_Anagist"
        Me.Btn_Percorso_Anagist.Size = New System.Drawing.Size(56, 34)
        Me.Btn_Percorso_Anagist.TabIndex = 3
        Me.Btn_Percorso_Anagist.Text = ". . ."
        Me.Btn_Percorso_Anagist.UseVisualStyleBackColor = True
        '
        'Btn_Percorso_AnaSog_Completa
        '
        Me.Btn_Percorso_AnaSog_Completa.Location = New System.Drawing.Point(1141, 78)
        Me.Btn_Percorso_AnaSog_Completa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Percorso_AnaSog_Completa.Name = "Btn_Percorso_AnaSog_Completa"
        Me.Btn_Percorso_AnaSog_Completa.Size = New System.Drawing.Size(56, 34)
        Me.Btn_Percorso_AnaSog_Completa.TabIndex = 1
        Me.Btn_Percorso_AnaSog_Completa.Text = ". . ."
        Me.Btn_Percorso_AnaSog_Completa.UseVisualStyleBackColor = True
        '
        'Txt_Percorso_Anagist
        '
        Me.Txt_Percorso_Anagist.Location = New System.Drawing.Point(8, 168)
        Me.Txt_Percorso_Anagist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Percorso_Anagist.Name = "Txt_Percorso_Anagist"
        Me.Txt_Percorso_Anagist.Size = New System.Drawing.Size(1124, 30)
        Me.Txt_Percorso_Anagist.TabIndex = 2
        '
        'Txt_Percorso_Anasog_Completa
        '
        Me.Txt_Percorso_Anasog_Completa.Location = New System.Drawing.Point(8, 78)
        Me.Txt_Percorso_Anasog_Completa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Percorso_Anasog_Completa.Name = "Txt_Percorso_Anasog_Completa"
        Me.Txt_Percorso_Anasog_Completa.Size = New System.Drawing.Size(1124, 30)
        Me.Txt_Percorso_Anasog_Completa.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 251)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Persorso e nome archivio del Nuovo Anagist corretto:"
        '
        'Lbl_SelezionePercorso_Anagist
        '
        Me.Lbl_SelezionePercorso_Anagist.AutoSize = True
        Me.Lbl_SelezionePercorso_Anagist.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_SelezionePercorso_Anagist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_SelezionePercorso_Anagist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SelezionePercorso_Anagist.Location = New System.Drawing.Point(7, 133)
        Me.Lbl_SelezionePercorso_Anagist.Name = "Lbl_SelezionePercorso_Anagist"
        Me.Lbl_SelezionePercorso_Anagist.Size = New System.Drawing.Size(486, 27)
        Me.Lbl_SelezionePercorso_Anagist.TabIndex = 0
        Me.Lbl_SelezionePercorso_Anagist.Text = "Seleziona percorso archivio di tipo: Anagist (Depurato)"
        '
        'Lbl_SelezionePercorso_AnaSog_Completa
        '
        Me.Lbl_SelezionePercorso_AnaSog_Completa.AutoSize = True
        Me.Lbl_SelezionePercorso_AnaSog_Completa.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_SelezionePercorso_AnaSog_Completa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_SelezionePercorso_AnaSog_Completa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SelezionePercorso_AnaSog_Completa.Location = New System.Drawing.Point(7, 42)
        Me.Lbl_SelezionePercorso_AnaSog_Completa.Name = "Lbl_SelezionePercorso_AnaSog_Completa"
        Me.Lbl_SelezionePercorso_AnaSog_Completa.Size = New System.Drawing.Size(488, 27)
        Me.Lbl_SelezionePercorso_AnaSog_Completa.TabIndex = 0
        Me.Lbl_SelezionePercorso_AnaSog_Completa.Text = "Seleziona percorso archivio di tipo: AnaSog_Completa"
        '
        'Btn_AvviaCorrezione
        '
        Me.Btn_AvviaCorrezione.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AvviaCorrezione.Location = New System.Drawing.Point(70, 366)
        Me.Btn_AvviaCorrezione.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_AvviaCorrezione.Name = "Btn_AvviaCorrezione"
        Me.Btn_AvviaCorrezione.Size = New System.Drawing.Size(411, 113)
        Me.Btn_AvviaCorrezione.TabIndex = 4
        Me.Btn_AvviaCorrezione.Text = "Avvia processo di correzione"
        Me.Btn_AvviaCorrezione.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Grp_LogElaborazioni
        '
        Me.Grp_LogElaborazioni.Controls.Add(Me.Lbl_Elaborazioni)
        Me.Grp_LogElaborazioni.Location = New System.Drawing.Point(550, 362)
        Me.Grp_LogElaborazioni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grp_LogElaborazioni.Name = "Grp_LogElaborazioni"
        Me.Grp_LogElaborazioni.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Grp_LogElaborazioni.Size = New System.Drawing.Size(672, 117)
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
        Me.Lbl_Elaborazioni.Location = New System.Drawing.Point(7, 35)
        Me.Lbl_Elaborazioni.Name = "Lbl_Elaborazioni"
        Me.Lbl_Elaborazioni.Size = New System.Drawing.Size(27, 24)
        Me.Lbl_Elaborazioni.TabIndex = 0
        Me.Lbl_Elaborazioni.Text = "..."
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_CFPIVA_Elaborato)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(544, 362)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(672, 117)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Log di elaborazione"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "..."
        '
        'Lbl_CFPIVA_Elaborato
        '
        Me.Lbl_CFPIVA_Elaborato.AutoSize = True
        Me.Lbl_CFPIVA_Elaborato.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Lbl_CFPIVA_Elaborato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_CFPIVA_Elaborato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CFPIVA_Elaborato.Location = New System.Drawing.Point(402, 89)
        Me.Lbl_CFPIVA_Elaborato.Name = "Lbl_CFPIVA_Elaborato"
        Me.Lbl_CFPIVA_Elaborato.Size = New System.Drawing.Size(27, 24)
        Me.Lbl_CFPIVA_Elaborato.TabIndex = 0
        Me.Lbl_CFPIVA_Elaborato.Text = "..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 492)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Grp_LogElaborazioni)
        Me.Controls.Add(Me.Btn_AvviaCorrezione)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Correzione Portafoglio Norvegese"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Grp_LogElaborazioni.ResumeLayout(False)
        Me.Grp_LogElaborazioni.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_Percorso_Anagist As TextBox
    Friend WithEvents Txt_Percorso_Anasog_Completa As TextBox
    Friend WithEvents Lbl_SelezionePercorso_Anagist As Label
    Friend WithEvents Lbl_SelezionePercorso_AnaSog_Completa As Label
    Friend WithEvents Btn_AvviaCorrezione As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Grp_LogElaborazioni As GroupBox
    Friend WithEvents Lbl_Elaborazioni As Label
    Friend WithEvents Btn_Percorso_Anagist As Button
    Friend WithEvents Btn_Percorso_AnaSog_Completa As Button
    Friend WithEvents Txt_Percorso_Anagist_Corretto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lbl_CFPIVA_Elaborato As Label
    Friend WithEvents Label2 As Label
End Class
