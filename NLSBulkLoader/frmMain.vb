Imports System.IO
Imports System.Xml

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateListMainHeaders()
        AdjustAfterResize()
    End Sub

    Private Sub LoadXML()
        Dim list As List(Of NlsItem)
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Select XML File"
        fd.Filter = "XML|*.xml"
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            list = XMLFileParser(fd.FileName)
            If list Is Nothing Then Exit Sub
            lstItems.Clear()
            CreateListMainHeaders()
            LoadListItems(list)
        End If
    End Sub

    Private Sub LoadXmlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadXmlToolStripMenuItem.Click
        LoadXML()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        LoadXML()
    End Sub

    Private Sub SaveCSV()
        Dim dict As List(Of NlsItem)
        dict = GetListItems(lstItems)
        ExportCSV(dict)
    End Sub

    Private Sub SaveCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveCSVToolStripMenuItem.Click
        SaveCSV()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        SaveCSV()
    End Sub

    Private Sub LoadCSV()
        Dim list As List(Of NlsItem)
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Select CSV File"
        fd.Filter = "CSV|*.csv"
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            list = CSVFileParser(fd.FileName)
            If list Is Nothing Then Exit Sub
            lstItems.Clear()
            CreateListMainHeaders()
            LoadListItems(list)
        End If
    End Sub

    Private Sub LoadCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadCSVToolStripMenuItem.Click
        LoadCSV()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        LoadCSV()
    End Sub

    Private Sub SaveXML()
        Dim dict As List(Of NlsItem)
        dict = GetListItems(lstItems)
        ExportXML(dict)
    End Sub

    Private Sub SaveXMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveXMLToolStripMenuItem.Click
        SaveXML()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        SaveXML()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        lstItems.Clear()
        CreateListMainHeaders()
    End Sub

    Private Sub CreateListMainHeaders()
        lstItems.Columns.Add("ID", 0)
        lstItems.Columns.Add("NLS ID", 300)
    End Sub

    Private Function XMLFileParser(filename As String) As List(Of NlsItem)

        Dim doc As New XmlDocument()
        Dim nlsresourcelist As XmlNodeList
        Dim NlsRows As New List(Of NlsItem)
        Dim NlsRow As NlsItem
        Dim LanguagesDict As Dictionary(Of String, String)

        Try
            doc.Load(filename)
        Catch ex As Exception
            MsgBox("Error loading " & filename & vbCrLf & vbCrLf & "Error message:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error loading file")
            Exit Function
        End Try

        nlsresourcelist = doc.GetElementsByTagName("NlsResource")

        For Each nlsresource As XmlElement In nlsresourcelist
            NlsRow = New NlsItem
            NlsRow.Name = nlsresource.GetAttribute("NlsId")
            LanguagesDict = New Dictionary(Of String, String)

            For Each nlsnodeitem As XmlNode In nlsresource
                If nlsnodeitem.NodeType = XmlNodeType.Comment And nlsnodeitem.Name = "#comment" Then
                    NlsRow.ID = nlsnodeitem.Value
                End If
                If nlsnodeitem.NodeType = XmlNodeType.Element And nlsnodeitem.Name = "NlsItem" Then
                    ' Adding to language dictionary = {LanguageID, LanguageValue}
                    ' E.g.: {"en-us", "Control List 2"}
                    LanguagesDict.Add(nlsnodeitem.Attributes("Language").Value, nlsnodeitem.FirstChild.FirstChild.Value)

                End If
            Next

            NlsRow.LanguagesDictionary = LanguagesDict
            NlsRows.Add(NlsRow)

        Next

        Return NlsRows

    End Function

    Private Function CSVFileParser(filename As String) As List(Of NlsItem)

        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(filename)
        Dim item As NlsItem
        Dim items As New List(Of NlsItem)
        Dim ItemLanguage As Dictionary(Of String, String)
        Dim Languages As New List(Of String)
        Dim TextFileTable As DataTable = Nothing
        Dim CurrentRow As String()
        Dim isHeader As Boolean = True

        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)

        While Not TextFileReader.EndOfData
            Try
                CurrentRow = TextFileReader.ReadFields()
                If Not CurrentRow Is Nothing Then

                    If isHeader Then
                        ' Reading header
                        For i = 2 To CurrentRow.GetUpperBound(0)
                            Languages.Add(CurrentRow(i))
                        Next
                        isHeader = False
                    Else
                        ' Reading rows
                        item = New NlsItem
                        ItemLanguage = New Dictionary(Of String, String)

                        item.ID = CurrentRow(0)
                        item.Name = CurrentRow(1)
                        For i = 0 To Languages.Count - 1
                            ItemLanguage.Add(Languages(i), CurrentRow(i + 2))
                        Next
                        item.LanguagesDictionary = ItemLanguage

                        items.Add(item)
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error loading " & filename & vbCrLf & vbCrLf & "Error message:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error loading file")
                Exit Function
            End Try
        End While
        TextFileReader.Dispose()

        Return items
    End Function

    Private Function GetLanguagesList(NlsItems As List(Of NlsItem)) As List(Of String)
        Dim Languages As New List(Of String)

        ' Check in all rows all the existent languages
        For Each item As NlsItem In NlsItems
            For Each language_kvp As KeyValuePair(Of String, String) In item.LanguagesDictionary
                If Not Languages.Contains(language_kvp.Key) Then Languages.Add(language_kvp.Key)
            Next
        Next

        Return Languages
    End Function

    Private Function GetLanguagesList(list As ListView) As List(Of String)
        Dim Languages As New List(Of String)

        ' Check all languages listed in the list
        For i = 2 To list.Columns.Count - 1         ' TODO Replace 2 by a constant that describes the number of fixed columns
            If Not Languages.Contains(list.Columns(i).Text) Then Languages.Add(list.Columns(i).Text)
        Next

        Return Languages
    End Function

    Private Sub LoadListItems(NlsItems As List(Of NlsItem))
        Dim Languages As New List(Of String)
        Dim LanguageIndexOnList As Integer
        Dim ListItem As ListViewItem

        ' Creating language columns
        Languages = GetLanguagesList(NlsItems)
        For Each lang In Languages
            lstItems.Columns.Add(lang, 250)
        Next

        Dim str(Languages.Count + 1) As String

        ' Loading items
        For Each item As NlsItem In NlsItems
            ' Cleaning str array
            For i = 0 To UBound(str)
                str(i) = ""
            Next

            str(0) = item.ID
            str(1) = item.Name

            For Each language_kvp As KeyValuePair(Of String, String) In item.LanguagesDictionary
                LanguageIndexOnList = GetColumnIndex(language_kvp.Key)
                str(LanguageIndexOnList) = language_kvp.Value
            Next

            ListItem = New ListViewItem(str)
            lstItems.Items.Add(ListItem)
        Next

    End Sub

    Private Function GetListItems(lst As ListView) As List(Of NlsItem)
        Dim item As NlsItem
        Dim items As New List(Of NlsItem)
        Dim itemLanguages As Dictionary(Of String, String)
        Dim Languages As List(Of String)
        Dim ColumnIndex As Integer

        Languages = GetLanguagesList(lst)

        For Each row As ListViewItem In lst.Items
            item = New NlsItem
            itemLanguages = New Dictionary(Of String, String)

            item.ID = row.SubItems(0).Text
            item.Name = row.SubItems(1).Text
            For i = 0 To Languages.Count - 1
                ColumnIndex = GetColumnIndex(Languages(i))
                itemLanguages.Add(Languages(i), row.SubItems(ColumnIndex).Text)
            Next
            item.LanguagesDictionary = itemLanguages

            items.Add(item)
        Next

        Return items

    End Function

    Private Sub ExportCSV(NlsItems As List(Of NlsItem))
        Dim fileName As String
        Dim Languages = New List(Of String)
        Dim saveFileDlg As New SaveFileDialog()

        saveFileDlg.Filter = "CSV|*.csv"
        saveFileDlg.Title = "Save an CSV File"
        saveFileDlg.ShowDialog()

        If saveFileDlg.FileName = "" Then Exit Sub

        fileName = saveFileDlg.FileName
        Dim fi As New IO.FileInfo(fileName)

        Languages = GetLanguagesList(NlsItems)

        Try
            ' Check if file already exists. If yes, delete it.
            If fi.Exists Then
                fi.Delete()
            End If

            ' Create a new file
            Using sw As StreamWriter = fi.CreateText()
                ' Creating headers
                sw.Write("""ID""")
                sw.Write(Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                sw.Write("""Name""")
                sw.Write(Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                For i = 0 To Languages.Count - 1
                    sw.Write("""" & Languages(i) & """")
                    If i <> Languages.Count - 1 Then sw.Write(Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                Next
                sw.WriteLine()

                ' Populating data
                For Each item As NlsItem In NlsItems
                    sw.Write("""" & item.ID & """")
                    sw.Write(Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                    sw.Write("""" & item.Name & """")
                    sw.Write(Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)

                    For i = 0 To Languages.Count - 1
                        If item.LanguagesDictionary.ContainsKey(Languages(i)) Then
                            sw.Write("""" & item.LanguagesDictionary(Languages(i)) & """")
                        End If
                        If i <> Languages.Count - 1 Then sw.Write(Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator)
                    Next

                    sw.WriteLine()
                Next
            End Using

        Catch Ex As Exception
            Console.WriteLine(Ex.ToString())
        End Try

    End Sub

    Private Sub ExportXML(NlsItems As List(Of NlsItem))
        Dim fileName As String
        Dim Languages = New List(Of String)
        Dim saveFileDlg As New SaveFileDialog()

        saveFileDlg.Filter = "XML|*.xml"
        saveFileDlg.Title = "Save an XML File"
        saveFileDlg.ShowDialog()

        If saveFileDlg.FileName = "" Then Exit Sub

        fileName = saveFileDlg.FileName
        Dim fi As New IO.FileInfo(fileName)

        Languages = GetLanguagesList(NlsItems)

        Try
            ' Check if file already exists. If yes, delete it.
            If fi.Exists Then
                fi.Delete()
            End If

            ' Create a new file
            'Using sw As StreamWriter = fi.CreateText()
            Using sw As StreamWriter = New StreamWriter(fileName, True, System.Text.Encoding.Unicode)
                ' Creating headers
                sw.WriteLine("<?xml version=""1.0"" encoding=""utf-16""?>")
                sw.WriteLine("<NlsBulkTranslation>")
                sw.WriteLine("<NlsPrefix>NLSID_</NlsPrefix>")
                For Each item As NlsItem In NlsItems
                    sw.WriteLine("<NlsResource NlsId=""" & item.Name & """>        <!--" & item.ID & "-->")
                    For Each lang As KeyValuePair(Of String, String) In item.LanguagesDictionary
                        If lang.Value <> "" Then
                            sw.WriteLine("<NlsItem Language=""" & lang.Key & """>")
                            sw.WriteLine("<NlsString>" & lang.Value & "</NlsString>")
                            sw.WriteLine("</NlsItem>")
                        End If
                    Next
                    sw.WriteLine("</NlsResource>")
                Next
                sw.WriteLine("</NlsBulkTranslation>")
                sw.Close()
            End Using

        Catch Ex As Exception
            Console.WriteLine(Ex.ToString())
        End Try

    End Sub

    Private Function GetColumnIndex(ColumnName As String) As Integer

        For x As Integer = 0 To lstItems.Columns.Count - 1
            If lstItems.Columns(x).Text = ColumnName Then
                Return x
            End If
        Next
        Return -1
    End Function

    ' Setting Drag and Drop
    Private Sub lstItems_DragEnter(sender As Object, e As DragEventArgs) Handles lstItems.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub lstItems_DragDrop(sender As Object, e As DragEventArgs) Handles lstItems.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Dim extension As String
        Dim items As List(Of NlsItem)

        If files.Count > 1 Then
            MsgBox("Can't drop multiple files together", MsgBoxStyle.Exclamation, "Easy boy!")
            Exit Sub
        End If
        For Each path In files
            ' Read file extension
            extension = Mid(path, path.Length - 2)

            Select Case UCase(extension)
                Case "XML"
                    items = XMLFileParser(path)
                    If items Is Nothing Then Exit Sub
                    lstItems.Clear()
                    CreateListMainHeaders()
                    LoadListItems(items)
                Case "CSV"
                    items = CSVFileParser(path)
                    If items Is Nothing Then Exit Sub
                    lstItems.Clear()
                    CreateListMainHeaders()
                    LoadListItems(items)
                Case Else
                    MsgBox("File type not supported", MsgBoxStyle.Exclamation, "File not supported")
            End Select
        Next
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        AdjustAfterResize()
    End Sub

    Private Sub AdjustAfterResize()
        Dim ListSize As New Drawing.Size

        ListSize.Width = Me.Size.Width - 27
        ListSize.Height = Me.Size.Height - 163
        lstItems.Size = ListSize

        lblTip.Location = New Point(12, ListSize.Height + lstItems.Location.Y + 3)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        About.Show()
    End Sub
End Class
