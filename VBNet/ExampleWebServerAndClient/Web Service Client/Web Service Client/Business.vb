'Author: Steven Metcalf
'Date: 5/15/2019
'Project: Final Project - Web Service Client
'Description: A web Service Client that connects to an external Program and reads back input

'Class Description: The business layer responsible for interacting with the external web service
Public Class Business

    Private myClient As MyWebService.WebService1SoapClient
    Private log As Persistence = New Persistence("log.txt")

    Public Function HelloWorld()
        myClient = New MyWebService.WebService1SoapClient()
        Dim result = myClient.HelloWorld.ToString
        log.LogHelloWorld()
        Return result

    End Function

    Public Function CustomerSelect(customerID As Integer, name As String, address1 As String, address2 As String, city As String, state As String, zip As String)
        myClient = New MyWebService.WebService1SoapClient()

        Dim selectCustomer As New MyWebService.Customer
        selectCustomer.name = name
        selectCustomer.customer_id = customerID
        selectCustomer.name = name
        selectCustomer.address1 = address1
        selectCustomer.address2 = address2
        selectCustomer.city = city
        selectCustomer.state = state
        selectCustomer.zip = zip

        Dim result() = myClient.CustomerSelect(selectCustomer)

        Dim formattedResults As ArrayList = New ArrayList()

        For Each item As MyWebService.Customer In result
            Dim nextResult = New Tuple(Of Integer, String, String, String, String, String, String)(item.customer_id, item.name, item.address1, item.address2, item.city, item.state, item.zip)
            formattedResults.Add(nextResult)
        Next
        log.LogSelect(selectCustomer)
        Return formattedResults

    End Function

    Public Function CustomerUpdate(customerID As Integer, name As String, address1 As String, address2 As String, city As String, state As String, zip As String)
        myClient = New MyWebService.WebService1SoapClient()

        Dim updateCustomer As New MyWebService.Customer
        updateCustomer.customer_id = customerID
        updateCustomer.name = name
        updateCustomer.address1 = address1
        updateCustomer.address2 = address2
        updateCustomer.city = city
        updateCustomer.state = state
        updateCustomer.zip = zip
        log.LogUpdate(updateCustomer)
        Return myClient.CustomerWrite(updateCustomer)
    End Function

    Public Function CustomerInsert(name As String, address1 As String, address2 As String, city As String, state As String, zip As Integer)
        myClient = New MyWebService.WebService1SoapClient()

        Dim newCustomer As New MyWebService.Customer()
        newCustomer.name = name
        newCustomer.address1 = address1
        newCustomer.address2 = address2
        newCustomer.city = city
        newCustomer.state = state
        newCustomer.zip = zip
        log.LogInsert(newCustomer)
        Return myClient.CustomerInsert(newCustomer)
    End Function

    Public Function CustomerDelete(customerID As Integer)
        myClient = New MyWebService.WebService1SoapClient()
        Dim result = myClient.CustomerDelete(customerID)
        log.LogDelete(customerID)
        Return result
    End Function


End Class
