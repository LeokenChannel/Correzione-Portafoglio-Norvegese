Imports System.IO
Imports System.Xml
Imports System.Xml.Linq

Public Class Form1
    Private Sub Btn_Percorso_AnaSog_Completa_Click(sender As Object, e As EventArgs) Handles Btn_Percorso_AnaSog_Completa.Click
        Dim NomeFile As String = Seleziona_Percorso(Lbl_SelezionePercorso_AnaSog_Completa.Text)

        If NomeFile <> "" Then

            Txt_Percorso_Anasog_Completa.Text = NomeFile
        Else
            Txt_Percorso_Anasog_Completa.Text = ""
        End If
    End Sub

    Private Sub Btn_Percorso_Anagist_Click(sender As Object, e As EventArgs) Handles Btn_Percorso_Anagist.Click
        Dim NomeFile As String = Seleziona_Percorso(Lbl_SelezionePercorso_Anagist.Text)

        If NomeFile <> "" Then

            Txt_Percorso_Anagist.Text = NomeFile
        Else
            Txt_Percorso_Anagist.Text = ""
        End If
    End Sub

    Function Seleziona_Percorso(ByVal Contesto As String) As String
        Dim path As String = ""
        OpenFileDialog1.Title = Me.Text
        If Contesto <> "" Then
            OpenFileDialog1.Title = Me.Text & " - " & Contesto
        End If
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.DefaultExt = "txt"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            path = OpenFileDialog1.FileName

        End If

        Seleziona_Percorso = path
    End Function

    Private Sub Btn_AvviaCorrezione_Click(sender As Object, e As EventArgs) Handles Btn_AvviaCorrezione.Click

        If MessageBox.Show("Si vuole avviare la correzione dell'archivio di Portafoglio selezionato?", Me.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If ControlloFileDefiniti() = True Then
                If ElaboraCorrezione() = True Then
                    MessageBox.Show("La correzione del Portafoglio indicato è stata eseguita correttamente", Me.Text)

                    Lbl_Elaborazioni.Text = "Operazione precedente conclusa"
                    Lbl_CFPIVA_Elaborato.Text = "nessuno"

                    Txt_Percorso_Anasog_Completa.Text = ""
                    Txt_Percorso_Anagist.Text = ""
                    Txt_Percorso_Anagist_Corretto.Text = ""

                    Txt_Percorso_Anasog_Completa.Select()
                End If
            End If
        End If

    End Sub

    Function ControlloFileDefiniti() As Boolean
        Dim EsitoControllo As Boolean = False
        If My.Computer.FileSystem.FileExists(Txt_Percorso_Anasog_Completa.Text) = False Or
            My.Computer.FileSystem.FileExists(Txt_Percorso_Anagist.Text) = False Then
            DialogResult = MessageBox.Show("Gli archivi dei portafogli non sono stati indicati correttamente", Btn_AvviaCorrezione.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            EsitoControllo = True

        End If

        Return EsitoControllo

    End Function

    Function ElaboraCorrezione() As Boolean
        Dim EsitoCorrezione As Boolean = True
        Dim File_XML_DatiMancanti As String

        Try
            Lbl_Elaborazioni.Text = "Inizio creazione archivio XML..."
            File_XML_DatiMancanti = Scansiona_AnaSogCompleta()
            Lbl_Elaborazioni.Text = "Creazione archivio XML: " & File_XML_DatiMancanti & "avvenuta con successo"
            Me.Grp_LogElaborazioni.Refresh()
            EsitoCorrezione = Correggi_Anagist(File_XML_DatiMancanti)


        Catch ex As Exception

            EsitoCorrezione = False

        End Try

        Return EsitoCorrezione
    End Function

    Function Scansiona_AnaSogCompleta() As String
        Dim FileReader As System.IO.StreamReader

        Dim stringReader As String = ""

        'Campi presenti nell'XML
        Dim CFoPIVA As String = ""
        Dim NoLuogoNascita As String = ""
        Dim NoSedeLegale As String = ""
        Dim NoSpecieGiuridica As String = ""
        Dim NoCodiceCCIA As String = ""

        '----------------------------------------------------------------------------------------- AnaSogCompleta
        FileReader = My.Computer.FileSystem.OpenTextFileReader(Txt_Percorso_Anasog_Completa.Text)

        Dim testFile As System.IO.FileInfo
        testFile = My.Computer.FileSystem.GetFileInfo(Txt_Percorso_Anasog_Completa.Text)
        Dim PathXML As String = testFile.DirectoryName & "\"

        '------------------------------------------------------------------------------------------ Salvataggio dati Mancanti
        Dim NomeFileSalvataggio As String = PathXML & "SalvaDati_da_" & (testFile.Name).Substring(0, testFile.Name.Length - 4) & ".xml"
        If My.Computer.FileSystem.FileExists(NomeFileSalvataggio) = True Then
            My.Computer.FileSystem.DeleteFile(NomeFileSalvataggio)
        End If
        Dim Writer As New XmlTextWriter(NomeFileSalvataggio, System.Text.Encoding.UTF8)
        Writer.WriteStartDocument(True)
        Writer.Formatting = Formatting.Indented
        Writer.Indentation = 2
        Writer.WriteStartElement("Soggetti")

        Do
            stringReader = FileReader.ReadLine()

            CFoPIVA = stringReader.Substring(160, 16)
            NoLuogoNascita = stringReader.Substring(498, 6)
            NoSedeLegale = stringReader.Substring(604, 6)
            NoSpecieGiuridica = stringReader.Substring(516, 4)
            NoCodiceCCIA = stringReader.Substring(442, 7)

            SalvaDatiMancanti(CFoPIVA, NoLuogoNascita, NoSedeLegale, NoSpecieGiuridica, NoCodiceCCIA, Writer)
        Loop Until FileReader.EndOfStream = True
        Writer.WriteEndDocument()
        Writer.Close()
        FileReader.Close()

        Return NomeFileSalvataggio
    End Function

    Function Correggi_Anagist(ByVal File_XML_DatiMancanti As String) As Boolean

        Dim Anagist_Corretta As Boolean = True  ' Se non ci sono errori o mancanze la correzione sarà eseguita

        Dim FileReader As System.IO.StreamReader
        Dim FileWriter As System.IO.StreamWriter

        Dim stringReader As String = ""
        Dim CFoPIVA As String = ""
        Dim TipoSoggetto As String = ""
        Dim ContaRecord As Long = 0
        Dim PercorsoFileNuovo As String = Txt_Percorso_Anagist.Text.Substring(0, Txt_Percorso_Anagist.Text.IndexOf(".")) & "_Corretto.txt"
        Txt_Percorso_Anagist_Corretto.Text = PercorsoFileNuovo
        Me.Refresh()

        If My.Computer.FileSystem.FileExists(PercorsoFileNuovo) Then
            My.Computer.FileSystem.DeleteFile(PercorsoFileNuovo)
        End If
        FileReader = My.Computer.FileSystem.OpenTextFileReader(Txt_Percorso_Anagist.Text)
        FileWriter = My.Computer.FileSystem.OpenTextFileWriter(PercorsoFileNuovo, True)
        Lbl_Elaborazioni.Text = "Inizio creazione nuovo archivio Anagist corretto."
        Me.Refresh()

        Dim LuogoNascita As String = ""
        Dim SedeLegale As String = ""
        Dim SpecieGiuridica As String = ""
        Dim CCIA As String = ""

        Dim doc As New Xml.XmlDocument
        doc.Load(File_XML_DatiMancanti)

        Dim nodes As XmlNodeList = doc.DocumentElement.SelectNodes("/Soggetti/Soggetto")
        Dim CF_Trovato As Boolean = False
        Do
            stringReader = FileReader.ReadLine()

            TipoSoggetto = stringReader.Substring(28, 2)
            If TipoSoggetto = "PG" Or TipoSoggetto = "PF" Then
                CFoPIVA = stringReader.Substring(30, 16)                'Codice fiscale o Partita IVA del File Anagist Da correggere.
                Lbl_CFPIVA_Elaborato.Text = CFoPIVA
                System.Windows.Forms.Application.DoEvents()

                'Cerco il CFoPIVA nel File XML
                CF_Trovato = False
                For Each node As XmlNode In nodes

                    If node.SelectSingleNode("CFoPIVA").InnerText = CFoPIVA Then    'Cerco il CF/PIVA del Record di Anagist

                        LuogoNascita = (node.SelectSingleNode("NoLuogoNascita").InnerText & "000000").Substring(0, 6)
                        SedeLegale = (node.SelectSingleNode("NoSedeLegale").InnerText.Trim & "000000").Substring(0, 6)
                        SpecieGiuridica = (node.SelectSingleNode("NoSpecieGiuridica").InnerText & Space(4)).Substring(0, 4)
                        CCIA = (node.SelectSingleNode("NoCCIA").InnerText & "0000000").Substring(0, 7)

                        CF_Trovato = True
                        Exit For
                    End If
                Next

                If CF_Trovato = False Then
                    Anagist_Corretta = False
                    DialogResult = MessageBox.Show("Errore di elaborazione: il CF/PIVA " & CFoPIVA & " non è stato trovato", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Do
                End If

                Select Case TipoSoggetto
                    Case "PG"                                                           '*---   Persona Giuridica
                        'Sostituzione della Sede Legale tramite ricerca in file XML
                        stringReader = stringReader.Substring(0, 309) & SedeLegale & stringReader.Substring(315, stringReader.Length - 315)
                        'Sostituzione della Specie Giuridica tramite ricerca in file XML
                        stringReader = stringReader.Substring(0, 350) & SpecieGiuridica & stringReader.Substring(354, stringReader.Length - 354)
                        'Sostituzione del CCIA tramite ricerca in file XML
                        stringReader = stringReader.Substring(0, 335) & CCIA & stringReader.Substring(342, stringReader.Length - 342)
                    Case "PF"                                                           '*---   Persona Fisica
                        'Sostituzione del LuogoNascita tramite ricerca in file XML
                        stringReader = stringReader.Substring(0, 294) & LuogoNascita & stringReader.Substring(300, stringReader.Length - 300)
                        'Sostituzione della Sede Legale tramite ricerca in file XML
                        stringReader = stringReader.Substring(0, 309) & SedeLegale & stringReader.Substring(315, stringReader.Length - 315)     'In questo caso è il luogo residenza
                End Select

            End If

            'Scrivo la riga letta sul nuovo File di Anagist
            FileWriter.WriteLine(stringReader)
            ContaRecord += 1

        Loop Until FileReader.EndOfStream = True

        FileReader.Close()
        FileWriter.Close()

        Return Anagist_Corretta
    End Function

    Private Sub SalvaDatiMancanti(ByVal CFoPIVA As String, ByVal NoLuogoNascita As String, ByVal NoSedeLegale As String, ByVal NoSpecieGiuridica As String, ByVal NoCodiceCCIA As String, ByVal writer As XmlTextWriter)

        writer.WriteStartElement("Soggetto")
        writer.WriteStartElement("CFoPIVA")
        writer.WriteString(CFoPIVA)
        writer.WriteEndElement()
        writer.WriteStartElement("NoLuogoNascita")
        writer.WriteString(NoLuogoNascita)
        writer.WriteEndElement()
        writer.WriteStartElement("NoSedeLegale")
        writer.WriteString(NoSedeLegale)
        writer.WriteEndElement()
        writer.WriteStartElement("NoSpecieGiuridica")
        writer.WriteString(NoSpecieGiuridica)
        writer.WriteEndElement()
        writer.WriteStartElement("NoCCIA")
        writer.WriteString(NoCodiceCCIA)
        writer.WriteEndElement()
        writer.WriteEndElement()

    End Sub

End Class
