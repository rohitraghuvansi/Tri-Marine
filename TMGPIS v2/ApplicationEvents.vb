Imports System.Net.Mail

Namespace My

    ' The following events are available for MyApplication:
    '
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private sysModule As String

        Public Sub setSySModule(ByVal location As String)
            sysModule = "TEST" 'TMGPIS.
        End Sub

        Public Function getSysModule()
            Return sysModule
        End Function

        'Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
        '    Try
        '        Dim site As String = "Tri-Marine Facility"

        '        Dim smtpServer As New SmtpClient
        '        smtpServer.Credentials = New Net.NetworkCredential("ois@trimarinegroup.com", "tmiUSA123!")
        '        smtpServer.Port = "587"
        '        smtpServer.Host = "pod51018.outlook.com"
        '        smtpServer.EnableSsl = True

        '        Dim mail As New MailMessage
        '        mail.From = New MailAddress("ois@trimarinegroup.com")
        '        mail.To.Add("oisexceptions@trimarinegroup.com")
        '        mail.Subject = site & " Unhandled Excemptions"

        '        mail.Body = site & " Excemption" & Chr(13) & _
        '            "Date/ Time: " & getServerDateTime() & Chr(13) & _
        '            "Email Subject Line: " & "OISException: " & getMachineName() & " - OISUsername: " & getUserFullName() & Chr(13) & _
        '            "Email Body: " & getProductVersion() & " Exception Message: " & e.Exception.Message & Chr(13) & _
        '            "Inner Exception: " & e.Exception.InnerException.StackTrace.ToString & Chr(13) & _
        '            "Module: " & e.Exception.TargetSite.Module.ToString   'getSysModule()

        '        ''"Module: " & Me. & Chr(13) & _
        '        smtpServer.Send(mail)

        '        smtpServer.Dispose()
        '        mail.Dispose()

        '        MsgBox("System Unhandled Excemption is successfully forwarded to OIS Team" & Chr(13) & _
        '            "We will get back to you as soon as possible", MsgBoxStyle.Information, "Information")

        '        'sendError(sender, e)
        '    Catch ex As Exception
        '        'MsgBox("Application will now terminate" & Chr(13) & _
        '        '        ex.Message)
        '        'MsgBox("Please verify that you specify the correct email account." & Chr(13) & _
        '        '        "For further details, please find below the system error" & Chr(13) & _
        '        '        ex.Message, MsgBoxStyle.Exclamation, "Warning")
        '        'MsgBox(ex.Message)

        '        'sendError(sender, e)
        '        Throw
        '    End Try
        'End Sub

        Public Sub sendError(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs)
            'Try
         

            'Catch ex As Exception
            '    'MsgBox("System experienced unhandled exception from the Global Exception Handling" & Chr(13) & _
            '    '        "Error: " & ex.Message, MsgBoxStyle.Exclamation, "Warning")
            '    Throw
            'Finally
            'End Try
        End Sub
    End Class

End Namespace