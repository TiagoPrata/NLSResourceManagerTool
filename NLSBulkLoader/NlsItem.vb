Public Class NlsItem
    Private pName As String
    Private pID As String
    Private pLanguagesDictionary As Dictionary(Of String, String)

    Public Sub New()
        pLanguagesDictionary = New Dictionary(Of String, String)
    End Sub

    Property Name As String
        Get
            Return pName
        End Get
        Set(value As String)
            pName = value
        End Set
    End Property

    Property ID As String
        Get
            Return pID
        End Get
        Set(value As String)
            pID = value
        End Set
    End Property

    Property LanguagesDictionary As Dictionary(Of String, String)
        Get
            Return pLanguagesDictionary
        End Get
        Set(value As Dictionary(Of String, String))
            pLanguagesDictionary = value
        End Set
    End Property
End Class
