'Author: Steven Metcalf
'Date: 5/15/2019
'Project: Final Project - Web Service Server
'Description: A web Service server that takes commands from a client, communicates with an external api and communicates back to the client
' http://localhost:51256/WebService1.asmx?WSDL

'Soap imports
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
'rest imports
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports RestSharp

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class WebService1
    Inherits System.Web.Services.WebService

    Dim myWebClient As WebClient
    Dim myStream As Stream
    Dim myReader As StreamReader
    Dim JsonString As String
    Dim myJson As JObject

    <WebMethod()>
    Public Function HelloWorld() As String
        myWebClient = New WebClient
        myWebClient.BaseAddress = "http://cit263.clearllc.com/api/"

        myStream = myWebClient.OpenRead("?method=helloWorld")
        myReader = New StreamReader(myStream)
        JsonString = myReader.ReadToEnd()
        Return JsonString
    End Function

    <WebMethod()>
    Public Function CustomerDelete(ByVal customer_id As Integer) As String
        myWebClient = New WebClient
        myWebClient.BaseAddress = "http://cit263.clearllc.com/api/"

        myStream = myWebClient.OpenRead("?method=deleteCustomer" & "&customer_id=" & customer_id)
        myReader = New StreamReader(myStream)
        JsonString = myReader.ReadToEnd()

        myJson = JObject.Parse(JsonString)
        Return myJson.SelectToken("status").ToString
    End Function

    <WebMethod()>
    Public Function CustomerInsert(ByRef newCustomer As Customer) As String
        myWebClient = New WebClient
        myWebClient.BaseAddress = "http://cit263.clearllc.com/api/"

        myStream = myWebClient.OpenRead("?method=insertCustomer" &
                                        "&name=" & newCustomer.name &
                                        "&address1=" & newCustomer.address1 &
                                        "&address2=" & newCustomer.address2 &
                                        "&city=" & newCustomer.city &
                                        "&state=" & newCustomer.state &
                                        "&zip=" & newCustomer.zip)
        myReader = New StreamReader(myStream)
        JsonString = myReader.ReadToEnd()

        myJson = JObject.Parse(JsonString)
        Return myJson.SelectToken("status").ToString + "," + myJson.SelectToken("customer_id").ToString

    End Function

    <WebMethod()>
    Public Function CustomerSelect(ByRef searchCustomer As Customer) As Customer()
        myWebClient = New WebClient
        myWebClient.BaseAddress = "http://cit263.clearllc.com/api/"

        Dim execString As String = "?method=selectCustomer"
        If (Not (searchCustomer.customer_id = -1)) Then
            execString += "&customer_id=" + searchCustomer.customer_id.ToString
        Else
            execString += "&customer_id=+"
        End If
        If (Not (searchCustomer.name.Equals(""))) Then
            execString += "&name=" + searchCustomer.name
        Else
            execString += "&name=+"
        End If
        If (Not (searchCustomer.address1.Equals(""))) Then
            execString += "&address1=" + searchCustomer.address1
        Else
            execString += "&address1=+"
        End If
        If (Not (searchCustomer.address2.Equals(""))) Then
            execString += "&address2=" + searchCustomer.address2
        Else
            execString += "&address2=+"
        End If
        If (Not (searchCustomer.city.Equals(""))) Then
            execString += "&city=" + searchCustomer.city
        Else
            execString += "&city=+"
        End If
        If (Not (searchCustomer.state.Equals(""))) Then
            execString += "&state=" + searchCustomer.state
        Else
            execString += "&state=+"
        End If
        If (Not (searchCustomer.zip.Equals(""))) Then
            execString += "&zip=" + searchCustomer.zip.ToString
        Else
            execString += "&zip=+"
        End If

        myStream = myWebClient.OpenRead(execString)
        myReader = New StreamReader(myStream)
        JsonString = myReader.ReadToEnd()

        Dim result() As Customer = JsonConvert.DeserializeObject(Of Customer())(JsonString)
        Return result 'should be contact
    End Function

    <WebMethod()>
    Public Function CustomerWrite(ByRef updateCustomer As Customer) As String
        myWebClient = New WebClient
        myWebClient.BaseAddress = "http://cit263.clearllc.com/api/"

        Dim execString As String = "?method=updateCustomer"
        If (Not (updateCustomer.customer_id = -1)) Then
            execString += "&customer_id=" + updateCustomer.customer_id.ToString
        End If
        If (Not (updateCustomer.name.Equals(""))) Then
            execString += "&name=" + updateCustomer.name
        End If
        If (Not (updateCustomer.address1.Equals(""))) Then
            execString += "&address1=" + updateCustomer.address1
        End If
        If (Not (updateCustomer.address2.Equals(""))) Then
            execString += "&address2=" + updateCustomer.address2
        Else
            execString += "&address2=+"
        End If
        If (Not (updateCustomer.city.Equals(""))) Then
            execString += "&city=" + updateCustomer.city
        End If
        If (Not (updateCustomer.state.Equals(""))) Then
            execString += "&state=" + updateCustomer.state
        End If
        If (Not (updateCustomer.zip.Equals(""))) Then
            execString += "&zip=" + updateCustomer.zip
        End If
        myStream = myWebClient.OpenRead(execString)
        myReader = New StreamReader(myStream)
        JsonString = myReader.ReadToEnd()

        myJson = JObject.Parse(JsonString)
        Return myJson.SelectToken("status").ToString
    End Function

    Public Class Customer
        Public Property name As String
        Public Property address1 As String
        Public Property address2 As String
        Public Property city As String
        Public Property state As String
        Public Property zip As String
        Public Property status As Integer
        Public Property customer_id As Integer

        Public Sub New()
            Me.name = ""
            Me.address1 = ""
            Me.address2 = ""
            Me.city = ""
            Me.state = ""
            Me.zip = ""
            Me.status = -1
            Me.customer_id = -1
        End Sub

        Public Sub New(customerID As Integer, name As String, address1 As String, address2 As String, city As String, state As String, zip As String)
            Me.customer_id = customerID
            Me.name = name
            Me.address1 = address1
            Me.address2 = address2
            Me.city = city
            Me.state = state
            Me.zip = zip
        End Sub

        Public Sub New(name As String, address1 As String, address2 As String, city As String, state As String, zip As String)
            Me.name = name
            Me.address1 = address1
            Me.address2 = address2
            Me.city = city
            Me.state = state
            Me.zip = zip
        End Sub

    End Class

End Class