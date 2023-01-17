'Author: Steven Metcalf
'Date: 5/15/2019
'Project: Final Project - Web Service Client
'Description: A web Service Client that connects to an external Program and reads back input

'Class Description: The persistence layer responsible for logging interactions and events
Imports System.IO
Public Class Persistence

    Dim logfile As String
    Private myClient As MyWebService.WebService1SoapClient

    Public Sub New(filename As String)
        logfile = filename
        myClient = New MyWebService.WebService1SoapClient()
    End Sub

    Public Sub LogSelect(searchedCustomer As MyWebService.Customer)
        Dim fileExists As Boolean = File.Exists(logfile)

        Using writer As New StreamWriter(logfile, True)
            If Not fileExists Then
                writer.WriteLine("------------------Web Service Log File------------------")
            End If

            writer.Write("Select Statement: Critera: ")
            If (Not searchedCustomer.customer_id.Equals("")) Then
                writer.Write(" Customer ID: ")
                writer.Write(searchedCustomer.customer_id)
            End If
            If (Not searchedCustomer.name.Equals("")) Then
                writer.Write(" Customer Name: ")
                writer.Write(searchedCustomer.name)
            End If
            If (Not searchedCustomer.address1.Equals("")) Then
                writer.Write(" Address 1: ")
                writer.Write(searchedCustomer.address1)
            End If
            If (Not searchedCustomer.address2.Equals("")) Then
                writer.Write(" Address 2: ")
                writer.Write(searchedCustomer.address2)
            End If
            If (Not searchedCustomer.city.Equals("")) Then
                writer.Write(" City: ")
                writer.Write(searchedCustomer.city)
            End If
            If (Not searchedCustomer.state.Equals("")) Then
                writer.Write(" State: ")
                writer.Write(searchedCustomer.state)
            End If
            writer.WriteLine("")
        End Using

    End Sub

    Public Sub LogInsert(newCustomer As MyWebService.Customer)
        Dim fileExists As Boolean = File.Exists(logfile)

        Using writer As New StreamWriter(logfile, True)
            If Not fileExists Then
                writer.WriteLine("------------------Web Service Log File------------------")
            End If

            writer.Write("Insert Statement: Critera: ")
            If (Not newCustomer.name.Equals("")) Then
                writer.Write(" Customer Name: ")
                writer.Write(newCustomer.name)
            End If
            If (Not newCustomer.address1.Equals("")) Then
                writer.Write(" Address 1: ")
                writer.Write(newCustomer.address1)
            End If
            If (Not newCustomer.address2.Equals("")) Then
                writer.Write(" Address 2: ")
                writer.Write(newCustomer.address2)
            End If
            If (Not newCustomer.city.Equals("")) Then
                writer.Write(" City: ")
                writer.Write(newCustomer.city)
            End If
            If (Not newCustomer.state.Equals("")) Then
                writer.Write(" State: ")
                writer.Write(newCustomer.state)
            End If
            writer.WriteLine("")
        End Using

    End Sub

    Public Sub LogUpdate(updatedCustomer As MyWebService.Customer)
        Dim fileExists As Boolean = File.Exists(logfile)

        Using writer As New StreamWriter(logfile, True)
            If Not fileExists Then
                writer.WriteLine("------------------Web Service Log File------------------")
            End If

            writer.Write("Update Statement: Critera: ")
            If (Not updatedCustomer.customer_id.Equals("")) Then
                writer.Write(" Customer ID: ")
                writer.Write(updatedCustomer.customer_id)
            End If
            If (Not updatedCustomer.name.Equals("")) Then
                writer.Write(" Customer Name: ")
                writer.Write(updatedCustomer.name)
            End If
            If (Not updatedCustomer.address1.Equals("")) Then
                writer.Write(" Address 1: ")
                writer.Write(updatedCustomer.address1)
            End If
            If (Not updatedCustomer.address2.Equals("")) Then
                writer.Write(" Address 2: ")
                writer.Write(updatedCustomer.address2)
            End If
            If (Not updatedCustomer.city.Equals("")) Then
                writer.Write(" City: ")
                writer.Write(updatedCustomer.city)
            End If
            If (Not updatedCustomer.state.Equals("")) Then
                writer.Write(" State: ")
                writer.Write(updatedCustomer.state)
            End If
            writer.WriteLine("")
        End Using

    End Sub

    Public Sub LogDelete(customerID As Integer)
        Dim fileExists As Boolean = File.Exists(logfile)

        Using writer As New StreamWriter(logfile, True)
            If Not fileExists Then
                writer.WriteLine("------------------Web Service Log File------------------")
            End If
            writer.Write("Delete Statement: customerID: ")
            writer.WriteLine(customerID)
        End Using
    End Sub

    Public Sub LogHelloWorld()
        Dim fileExists As Boolean = File.Exists(logfile)

        Using writer As New StreamWriter(logfile, True)
            If Not fileExists Then
                writer.WriteLine("------------------Web Service Log File------------------")
            End If
            writer.Write("Hello World Statement: ")
            writer.WriteLine("successful")
        End Using
    End Sub

End Class
