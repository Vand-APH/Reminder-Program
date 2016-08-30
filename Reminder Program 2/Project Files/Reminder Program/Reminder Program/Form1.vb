Imports System.IO
Imports Microsoft.Win32

Public Class Form1

    Public close_program_switch As Boolean
    Public program_path As String
    Public reminder_array() As String
    Public temp_reminder_array() As String
    Public char_counter As Integer
    Public reminder_counter As Integer
    Public array_counter As Integer
    Public temp_array_counter As Integer
    Public test_string As String
    Public date_time_string As String
    Public recurrence_string As String
    Public skip_switch As Boolean
    Public list_selected_index As Integer
    Public new_reminder_string As String
    Public date_time_picker_temp_string As String
    Public write_string As String
    Public create_edit_switch As String
    Public reminder_list_counter As Integer
    Public display_array_start As Integer
    Public display_counter As Integer
    Public button_selected As Integer
    Public selected_array_item As Integer
    Public selected_array_delete_item As Integer
    Public reminder_name As String
    Public yes_no_choice As Integer
    Public reminder_type As String
    Public new_date_time_string As System.DateTime
    Public add_time As System.TimeSpan
    Public day_counter As Integer
    Public check_reminder_counter As Integer
    Public stop_check_reminder_loop As Boolean
    Public set_day_string As String
    Public month_number_string As String
    Public exit_choice As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AddHandler SystemEvents.SessionEnding, AddressOf OnShuttingdown
        AddHandler SystemEvents.SessionEnded, AddressOf OnShutdown

        reminder_type = ""
        create_edit_switch = ""
        close_program_switch = False
        button_selected = 0
        stop_check_reminder_loop = False
        check_reminder_counter = 0

        Call reset_recurrence_options()

        TabControl1.TabPages(1).Enabled = False
        TabControl1.TabPages(2).Enabled = False

        program_path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        If Microsoft.VisualBasic.Left(program_path, 6) = "file:\" Then
            program_path = Microsoft.VisualBasic.Right(program_path, Len(program_path) - 6)
        End If
        If Microsoft.VisualBasic.Right(program_path, 1) <> "\" Then
            program_path = program_path & "\"
        End If

        If Dir(program_path & "reminder_program_config.txt") = "" Then
            Dim fs As FileStream = Nothing
            fs = File.Create(program_path & "reminder_program_config.txt")
            Using fs
            End Using
            Using sw As StreamWriter = New StreamWriter(program_path & "reminder_program_config.txt")
                sw.Write("No reminders, , , " & Chr(13) & Chr(10))
            End Using
        End If

        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(program_path & "reminder_program_config.txt")
        Dim reminder_string As String
        reminder_string = fileReader.ReadToEnd
        fileReader.Close()

        For Me.char_counter = Len(reminder_string) To 1 Step -1
            Select Case Val(Asc(Mid(reminder_string, char_counter, 1)))
                Case 10, 13
                Case Else
                    Exit For
            End Select
        Next char_counter
        reminder_string = Microsoft.VisualBasic.Left(reminder_string, char_counter)

        reminder_counter = 1
        For Me.char_counter = 1 To Len(reminder_string) - 1
            If Mid(reminder_string, char_counter, 2) = Chr(13) & Chr(10) Then reminder_counter = reminder_counter + 1
        Next char_counter
        ReDim reminder_array(reminder_counter - 1)
        For Me.array_counter = 0 To reminder_counter - 1
            reminder_array(array_counter) = reminder_string.Split(Chr(13) & Chr(10))(array_counter)
            reminder_array(array_counter) = Replace(reminder_array(array_counter), Chr(13), "")
            reminder_array(array_counter) = Replace(reminder_array(array_counter), Chr(10), "")
        Next array_counter

        display_array_start = 0
        reminders_scroll_up.Enabled = False

        Call refresh_reminder_list()

        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False

        Call check_reminders()
        reminder_check_timer.Start()

    End Sub

    Sub refresh_data_file()

        write_string = ""
        For Me.array_counter = 0 To UBound(reminder_array)
            write_string = write_string & reminder_array(array_counter) & Chr(13) & Chr(10)
        Next array_counter

        Using sw As StreamWriter = New StreamWriter(program_path & "reminder_program_config.txt")
            sw.Write(write_string)
            sw.Close()
        End Using

    End Sub

    Sub refresh_reminder_list()

        button_selected = 0

        reminder_button_1.Checked = False
        reminder_button_1.Enabled = True
        reminder_button_2.Checked = False
        reminder_button_2.Enabled = True
        reminder_button_3.Checked = False
        reminder_button_3.Enabled = True
        reminder_button_4.Checked = False
        reminder_button_4.Enabled = True
        reminder_button_5.Checked = False
        reminder_button_5.Enabled = True
        reminder_button_6.Checked = False
        reminder_button_6.Enabled = True

        For Me.reminder_list_counter = 1 To 6
            current_reminders.Controls("reminder_text_" & reminder_list_counter).Text = ""
            current_reminders.Controls("reminder_date_" & reminder_list_counter).Text = ""
            current_reminders.Controls("reminder_time_" & reminder_list_counter).Text = ""
            current_reminders.Controls("reminder_recurrence_" & reminder_list_counter).Text = ""
            current_reminders.Controls("reminder_text_" & reminder_list_counter).ForeColor = Color.Black
            current_reminders.Controls("reminder_text_" & reminder_list_counter).BackColor = Color.White
            current_reminders.Controls("reminder_date_" & reminder_list_counter).ForeColor = Color.Black
            current_reminders.Controls("reminder_date_" & reminder_list_counter).BackColor = Color.White
            current_reminders.Controls("reminder_time_" & reminder_list_counter).ForeColor = Color.Black
            current_reminders.Controls("reminder_time_" & reminder_list_counter).BackColor = Color.White
            current_reminders.Controls("reminder_recurrence_" & reminder_list_counter).ForeColor = Color.Black
            current_reminders.Controls("reminder_recurrence_" & reminder_list_counter).BackColor = Color.White
        Next reminder_list_counter
        display_counter = 1
        For Me.array_counter = display_array_start To UBound(reminder_array)
            If display_counter = 7 Then Exit For
            current_reminders.Controls("reminder_text_" & display_counter).Text = Split(reminder_array(array_counter), ",")(0)
            current_reminders.Controls("reminder_date_" & display_counter).Text = Split(reminder_array(array_counter), ",")(1)
            current_reminders.Controls("reminder_time_" & display_counter).Text = Split(reminder_array(array_counter), ",")(2)
            current_reminders.Controls("reminder_recurrence_" & display_counter).Text = Split(reminder_array(array_counter), ",")(3)
            display_counter = display_counter + 1
        Next array_counter

        If reminder_text_1.Text = "" Or reminder_text_1.Text = "No reminders" Then reminder_button_1.Enabled = False
        If reminder_text_2.Text = "" Then reminder_button_2.Enabled = False
        If reminder_text_3.Text = "" Then reminder_button_3.Enabled = False
        If reminder_text_4.Text = "" Then reminder_button_4.Enabled = False
        If reminder_text_5.Text = "" Then reminder_button_5.Enabled = False
        If reminder_text_6.Text = "" Then reminder_button_6.Enabled = False

        If display_array_start - 6 >= 0 Then reminders_scroll_up.Enabled = True Else reminders_scroll_up.Enabled = False
        If display_array_start + 6 > UBound(reminder_array) Then reminders_scroll_down.Enabled = False Else reminders_scroll_down.Enabled = True

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        exit_choice = MsgBox("Are you sure you wish to exit the program?",vbYesNo)
        If exit_choice = 7 Then Exit Sub
        close_program_switch = True
        Me.Close()

    End Sub

    Private Sub CancelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelToolStripMenuItem.Click

        button_selected = 0
        Call reset_reminder_buttons()

        reminder_textbox.Text = ""
        DateTimePicker1.Value = DateTime.Now
        TabControl1.TabPages(1).Enabled = False
        Call reset_recurrence_options()

        TabControl1.SelectedTab = current_reminders
        create_edit_switch = ""

        reminder_check_timer.Start()

    End Sub

    Private Sub option_weekly_on_CheckedChanged(sender As Object, e As EventArgs) Handles option_weekly_on.CheckedChanged

        If option_weekly_on.Checked = True Then
            CheckBox_sunday.Checked = False
            CheckBox_sunday.Enabled = True
            CheckBox_monday.Checked = False
            CheckBox_monday.Enabled = True
            CheckBox_tuesday.Checked = False
            CheckBox_tuesday.Enabled = True
            CheckBox_wednesday.Checked = False
            CheckBox_wednesday.Enabled = True
            CheckBox_thursday.Checked = False
            CheckBox_thursday.Enabled = True
            CheckBox_friday.Checked = False
            CheckBox_friday.Enabled = True
            CheckBox_saturday.Checked = False
            CheckBox_saturday.Enabled = True
        Else
            CheckBox_sunday.Checked = False
            CheckBox_sunday.Enabled = False
            CheckBox_monday.Checked = False
            CheckBox_monday.Enabled = False
            CheckBox_tuesday.Checked = False
            CheckBox_tuesday.Enabled = False
            CheckBox_wednesday.Checked = False
            CheckBox_wednesday.Enabled = False
            CheckBox_thursday.Checked = False
            CheckBox_thursday.Enabled = False
            CheckBox_friday.Checked = False
            CheckBox_friday.Enabled = False
            CheckBox_saturday.Checked = False
            CheckBox_saturday.Enabled = False
        End If

    End Sub

    Sub reset_recurrence_options()

        reminder_textbox.Text = ""
        option_once_only.Checked = False
        option_every_day.Checked = False
        option_monday_to_friday.Checked = False
        option_monthly_variable.Checked = False
        option_monthly_on_day.Checked = False
        monthly_on_day_selector.Text = ""
        monthly_on_day_selector.Enabled = False
        option_weekly_on.Checked = False
        CheckBox_sunday.Checked = False
        CheckBox_sunday.Enabled = False
        CheckBox_monday.Checked = False
        CheckBox_monday.Enabled = False
        CheckBox_tuesday.Checked = False
        CheckBox_tuesday.Enabled = False
        CheckBox_wednesday.Checked = False
        CheckBox_wednesday.Enabled = False
        CheckBox_thursday.Checked = False
        CheckBox_thursday.Enabled = False
        CheckBox_friday.Checked = False
        CheckBox_friday.Enabled = False
        CheckBox_saturday.Checked = False
        CheckBox_saturday.Enabled = False
        create_edit_switch = ""

    End Sub

    Private Sub CreateReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateReminderToolStripMenuItem.Click

        reminder_check_timer.Stop()

        TabControl1.TabPages(1).Enabled = True
        TabControl1.SelectedTab = edit_reminder
        create_edit_switch = "create"

    End Sub

    Private Sub EditSelectedReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditSelectedReminderToolStripMenuItem.Click

        If button_selected = 0 Then
            MsgBox("No reminders selected.", vbExclamation)
            Exit Sub
        End If

        reminder_check_timer.Stop()

        create_edit_switch = "edit"

        TabControl1.TabPages(1).Enabled = True
        TabControl1.SelectedTab = edit_reminder

        reminder_textbox.Text = current_reminders.Controls("reminder_text_" & button_selected).Text
        DateTimePicker1.Value = New DateTime(Year(current_reminders.Controls("reminder_date_" & button_selected).Text), Month(current_reminders.Controls("reminder_date_" & button_selected).Text), Microsoft.VisualBasic.DateAndTime.Day(current_reminders.Controls("reminder_date_" & button_selected).Text), Hour(current_reminders.Controls("reminder_time_" & button_selected).Text), Minute(current_reminders.Controls("reminder_time_" & button_selected).Text), 0)
        recurrence_string = current_reminders.Controls("reminder_recurrence_" & button_selected).Text

        If InStr(recurrence_string, "Monthly", vbTextCompare) = 0 Then

            skip_switch = False
            If recurrence_string = "Once Only" Then
                option_once_only.Checked = True
                skip_switch = True
            End If
            If skip_switch = False And recurrence_string = "Mon Tue Wed Thu Fri" Then
                option_monday_to_friday.Checked = True
                skip_switch = True
            End If
            If skip_switch = False And recurrence_string = "Every Day" Then
                option_every_day.Checked = True
                skip_switch = True
            End If
            If skip_switch = False Then
                option_weekly_on.Checked = True
                If InStr(recurrence_string, "Sun", vbTextCompare) <> 0 Then CheckBox_sunday.Checked = True
                If InStr(recurrence_string, "Mon", vbTextCompare) <> 0 Then CheckBox_monday.Checked = True
                If InStr(recurrence_string, "Tue", vbTextCompare) <> 0 Then CheckBox_tuesday.Checked = True
                If InStr(recurrence_string, "Wed", vbTextCompare) <> 0 Then CheckBox_wednesday.Checked = True
                If InStr(recurrence_string, "Thu", vbTextCompare) <> 0 Then CheckBox_thursday.Checked = True
                If InStr(recurrence_string, "Fri", vbTextCompare) <> 0 Then CheckBox_friday.Checked = True
                If InStr(recurrence_string, "Sat", vbTextCompare) <> 0 Then CheckBox_saturday.Checked = True
            End If

        Else 'Monthly is in the recurrence_string

            If recurrence_string = "Monthly / Variable Day" Then option_monthly_variable.Checked = True
            If InStr(recurrence_string, "Monthly / Day", vbTextCompare) <> 0 Then
                option_monthly_on_day.Checked = True
                monthly_on_day_selector.Text = Microsoft.VisualBasic.Right(recurrence_string, 2)
            End If

        End If

        For Me.array_counter = 0 To UBound(reminder_array)
            If reminder_textbox.Text = Split(reminder_array(array_counter), ",")(0) Then
                selected_array_item = array_counter
                Exit For
            End If
        Next array_counter

    End Sub

    Private Sub DeleteSelectedReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSelectedReminderToolStripMenuItem.Click

        If button_selected = 0 Then
            MsgBox("No reminders selected.", vbExclamation)
            Exit Sub
        End If

        reminder_check_timer.Stop()

        For Me.array_counter = 0 To UBound(reminder_array)
            If current_reminders.Controls("reminder_text_" & button_selected).Text = Split(reminder_array(array_counter), ",")(0) Then
                selected_array_item = array_counter
                reminder_name = current_reminders.Controls("reminder_text_" & button_selected).Text
                Exit For
            End If
        Next array_counter

        yes_no_choice = MsgBox("Are you sure you want to delete:" & Chr(13) & """" & reminder_name & """?", vbYesNo)

        If yes_no_choice = 7 Then
            Call refresh_reminder_list()
            reminder_check_timer.Start()
            Exit Sub
        End If

        If UBound(reminder_array) > 0 Then

            ReDim temp_reminder_array(UBound(reminder_array) - 1)

            Me.temp_array_counter = 0
            For Me.array_counter = 0 To UBound(reminder_array)
                If array_counter <> selected_array_item Then
                    temp_reminder_array(temp_array_counter) = reminder_array(array_counter)
                    temp_array_counter = temp_array_counter + 1
                End If
            Next array_counter

            ReDim reminder_array(UBound(temp_reminder_array))

            For Me.array_counter = 0 To UBound(temp_reminder_array)
                reminder_array(array_counter) = temp_reminder_array(array_counter)
            Next array_counter

        Else

            ReDim reminder_array(0)
            reminder_array(0) = "No reminders, , , "

        End If

        display_array_start = 0
        Call refresh_data_file()
        Call refresh_reminder_list()

        reminder_check_timer.Start()

    End Sub

    Private Sub SaveReminderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveReminderToolStripMenuItem.Click

        If reminder_textbox.Text = "" Then
            MsgBox("Please make sure you have entered text" & Chr(13) & "in the ""Reminder Text"" field.", vbExclamation)
            Exit Sub
        End If

        If option_once_only.Checked = False And _
            option_every_day.Checked = False And _
                option_monday_to_friday.Checked = False And _
                    option_monthly_variable.Checked = False And _
                        option_monthly_on_day.Checked = False And _
                            option_weekly_on.Checked = False Then
            MsgBox("Please make sure you have a recurrence option selected.", vbExclamation)
            Exit Sub
        End If

        If option_monthly_on_day.Checked = True And monthly_on_day_selector.Text = "" Then
            MsgBox("Please make sure you have a day of the month selected.", vbExclamation)
            Exit Sub
        End If

        If option_weekly_on.Checked = True Then
            If CheckBox_sunday.Checked = False And _
                CheckBox_monday.Checked = False And _
                    CheckBox_tuesday.Checked = False And _
                        CheckBox_wednesday.Checked = False And _
                            CheckBox_thursday.Checked = False And _
                                CheckBox_friday.Checked = False And _
                                    CheckBox_saturday.Checked = False Then
                MsgBox("Please make sure you have at least one day of the week selected.", vbExclamation)
                Exit Sub
            End If
        End If

        Select Case create_edit_switch
            Case "edit"
                For Me.array_counter = 0 To UBound(reminder_array)
                    If reminder_textbox.Text = Split(reminder_array(array_counter), ",")(0) And array_counter <> selected_array_item Then
                        MsgBox("Please make sure the reminder text is unique.", vbExclamation)
                        Exit Sub
                        Exit For
                    End If
                Next array_counter
            Case "create"
                For Me.array_counter = 0 To UBound(reminder_array)
                    If reminder_textbox.Text = Split(reminder_array(array_counter), ",")(0) Then
                        MsgBox("Please make sure the reminder text is unique.", vbExclamation)
                        Exit Sub
                        Exit For
                    End If
                Next array_counter
        End Select

        new_reminder_string = ""
        new_reminder_string = reminder_textbox.Text & ","
        date_time_picker_temp_string = DateTimePicker1.Text
        date_time_picker_temp_string = Microsoft.VisualBasic.Left(date_time_picker_temp_string, InStr(date_time_picker_temp_string, "Time", vbTextCompare) - 1)
        date_time_picker_temp_string = Replace(date_time_picker_temp_string, "Date:", "")
        date_time_picker_temp_string = Trim(date_time_picker_temp_string)
        new_reminder_string = new_reminder_string & Format(CDate(date_time_picker_temp_string), "MM/dd/yyyy") & ","
        date_time_picker_temp_string = DateTimePicker1.Text
        date_time_picker_temp_string = Microsoft.VisualBasic.Right(date_time_picker_temp_string, 1 + Len(date_time_picker_temp_string) - InStrRev(date_time_picker_temp_string, "Time", -1, vbTextCompare))
        date_time_picker_temp_string = Replace(date_time_picker_temp_string, "Time:", "")
        date_time_picker_temp_string = Trim(date_time_picker_temp_string)
        new_reminder_string = new_reminder_string & date_time_picker_temp_string & ","

        recurrence_string = ""
        If option_once_only.Checked = True Then
            recurrence_string = "Once Only"
        End If
        If recurrence_string = "" And option_every_day.Checked = True Then
            recurrence_string = "Every Day"
        End If
        If recurrence_string = "" And option_monday_to_friday.Checked = True Then
            recurrence_string = "Mon Tue Wed Thu Fri"
        End If
        If recurrence_string = "" And option_monthly_variable.Checked = True Then
            recurrence_string = "Monthly / Variable Day"
        End If
        If recurrence_string = "" And option_monthly_on_day.Checked = True Then
            recurrence_string = "Monthly / Day " & monthly_on_day_selector.Text
        End If
        If recurrence_string = "" And option_weekly_on.Checked = True Then
            If CheckBox_sunday.Checked = True Then recurrence_string = "Sun "
            If CheckBox_monday.Checked = True Then recurrence_string = recurrence_string & "Mon "
            If CheckBox_tuesday.Checked = True Then recurrence_string = recurrence_string & "Tue "
            If CheckBox_wednesday.Checked = True Then recurrence_string = recurrence_string & "Wed "
            If CheckBox_thursday.Checked = True Then recurrence_string = recurrence_string & "Thu "
            If CheckBox_friday.Checked = True Then recurrence_string = recurrence_string & "Fri "
            If CheckBox_saturday.Checked = True Then recurrence_string = recurrence_string & "Sat"
        End If
        new_reminder_string = new_reminder_string & Trim(recurrence_string)

        Select Case create_edit_switch
            Case "edit"
                reminder_array(selected_array_item) = new_reminder_string
            Case "create"
                If InStr(reminder_array(0), "No reminders", vbTextCompare) = 0 Then ReDim Preserve reminder_array(UBound(reminder_array) + 1)
                reminder_array(UBound(reminder_array)) = new_reminder_string
        End Select

        button_selected = 0
        display_array_start = 0

        Call refresh_reminder_list()
        Call refresh_data_file()

        TabControl1.TabPages(1).Enabled = False
        Call reset_recurrence_options()
        TabControl1.SelectedTab = current_reminders

        reminder_check_timer.Start()

    End Sub

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click

        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False

    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click

        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click

        exit_choice = MsgBox("Are you sure you wish to exit the program?", vbYesNo)
        If exit_choice = 7 Then Exit Sub
        close_program_switch = True
        Me.Close()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        '       If close_program_switch = False Then
        ' e.Cancel = True
        ' Me.WindowState = FormWindowState.Minimized
        ' Me.ShowInTaskbar = False
        'Else
        NotifyIcon1.Visible = False
        'End If

    End Sub

    Private Sub option_monthly_on_day_CheckedChanged(sender As Object, e As EventArgs) Handles option_monthly_on_day.CheckedChanged

        If option_monthly_on_day.Checked = True Then
            monthly_on_day_selector.Enabled = True
        Else
            monthly_on_day_selector.Text = ""
            monthly_on_day_selector.Enabled = False
        End If
    End Sub

    Private Sub reminder_textbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles reminder_textbox.KeyPress

        Select Case e.KeyChar
            Case ","
                e.Handled = True
            Case Else
                Return
        End Select

    End Sub

    Private Sub reminders_scroll_up_Click(sender As Object, e As EventArgs) Handles reminders_scroll_up.Click

        display_array_start = display_array_start - 6
        Call refresh_reminder_list()

    End Sub

    Private Sub reminders_scroll_down_Click(sender As Object, e As EventArgs) Handles reminders_scroll_down.Click

        display_array_start = display_array_start + 6
        Call refresh_reminder_list()

    End Sub

    Private Sub reminder_button_1_CheckedChanged(sender As Object, e As EventArgs) Handles reminder_button_1.CheckedChanged

        If reminder_button_1.Checked = True Then
            button_selected = 1
            Call reset_reminder_buttons()
            reminder_text_1.BackColor = Color.Black
            reminder_text_1.ForeColor = Color.White
            reminder_date_1.BackColor = Color.Black
            reminder_date_1.ForeColor = Color.White
            reminder_time_1.BackColor = Color.Black
            reminder_time_1.ForeColor = Color.White
            reminder_recurrence_1.BackColor = Color.Black
            reminder_recurrence_1.ForeColor = Color.White
        End If

    End Sub

    Private Sub reminder_button_2_CheckedChanged(sender As Object, e As EventArgs) Handles reminder_button_2.CheckedChanged

        If reminder_button_2.Checked = True Then
            button_selected = 2
            Call reset_reminder_buttons()
            reminder_text_2.BackColor = Color.Black
            reminder_text_2.ForeColor = Color.White
            reminder_date_2.BackColor = Color.Black
            reminder_date_2.ForeColor = Color.White
            reminder_time_2.BackColor = Color.Black
            reminder_time_2.ForeColor = Color.White
            reminder_recurrence_2.BackColor = Color.Black
            reminder_recurrence_2.ForeColor = Color.White
        End If

    End Sub

    Private Sub reminder_button_3_CheckedChanged(sender As Object, e As EventArgs) Handles reminder_button_3.CheckedChanged

        If reminder_button_3.Checked = True Then
            button_selected = 3
            Call reset_reminder_buttons()
            reminder_text_3.BackColor = Color.Black
            reminder_text_3.ForeColor = Color.White
            reminder_date_3.BackColor = Color.Black
            reminder_date_3.ForeColor = Color.White
            reminder_time_3.BackColor = Color.Black
            reminder_time_3.ForeColor = Color.White
            reminder_recurrence_3.BackColor = Color.Black
            reminder_recurrence_3.ForeColor = Color.White
        End If

    End Sub

    Private Sub reminder_button_4_CheckedChanged(sender As Object, e As EventArgs) Handles reminder_button_4.CheckedChanged

        If reminder_button_4.Checked = True Then
            button_selected = 4
            Call reset_reminder_buttons()
            reminder_text_4.BackColor = Color.Black
            reminder_text_4.ForeColor = Color.White
            reminder_date_4.BackColor = Color.Black
            reminder_date_4.ForeColor = Color.White
            reminder_time_4.BackColor = Color.Black
            reminder_time_4.ForeColor = Color.White
            reminder_recurrence_4.BackColor = Color.Black
            reminder_recurrence_4.ForeColor = Color.White
        End If

    End Sub

    Private Sub reminder_button_5_CheckedChanged(sender As Object, e As EventArgs) Handles reminder_button_5.CheckedChanged

        If reminder_button_5.Checked = True Then
            button_selected = 5
            Call reset_reminder_buttons()
            reminder_text_5.BackColor = Color.Black
            reminder_text_5.ForeColor = Color.White
            reminder_date_5.BackColor = Color.Black
            reminder_date_5.ForeColor = Color.White
            reminder_time_5.BackColor = Color.Black
            reminder_time_5.ForeColor = Color.White
            reminder_recurrence_5.BackColor = Color.Black
            reminder_recurrence_5.ForeColor = Color.White
        End If

    End Sub

    Private Sub reminder_button_6_CheckedChanged(sender As Object, e As EventArgs) Handles reminder_button_6.CheckedChanged

        If reminder_button_6.Checked = True Then
            button_selected = 6
            Call reset_reminder_buttons()
            reminder_text_6.BackColor = Color.Black
            reminder_text_6.ForeColor = Color.White
            reminder_date_6.BackColor = Color.Black
            reminder_date_6.ForeColor = Color.White
            reminder_time_6.BackColor = Color.Black
            reminder_time_6.ForeColor = Color.White
            reminder_recurrence_6.BackColor = Color.Black
            reminder_recurrence_6.ForeColor = Color.White
        End If

    End Sub

    Sub reset_reminder_buttons()

        If button_selected = 0 Then
            reminder_button_1.Checked = False
            reminder_button_2.Checked = False
            reminder_button_3.Checked = False
            reminder_button_4.Checked = False
            reminder_button_5.Checked = False
            reminder_button_6.Checked = False
        End If

        If button_selected <> 1 Then
            reminder_text_1.ForeColor = Color.Black
            reminder_text_1.BackColor = Color.White
            reminder_date_1.ForeColor = Color.Black
            reminder_date_1.BackColor = Color.White
            reminder_time_1.ForeColor = Color.Black
            reminder_time_1.BackColor = Color.White
            reminder_recurrence_1.ForeColor = Color.Black
            reminder_recurrence_1.BackColor = Color.White
        End If

        If button_selected <> 2 Then
            reminder_text_2.ForeColor = Color.Black
            reminder_text_2.BackColor = Color.White
            reminder_date_2.ForeColor = Color.Black
            reminder_date_2.BackColor = Color.White
            reminder_time_2.ForeColor = Color.Black
            reminder_time_2.BackColor = Color.White
            reminder_recurrence_2.ForeColor = Color.Black
            reminder_recurrence_2.BackColor = Color.White
        End If

        If button_selected <> 3 Then
            reminder_text_3.ForeColor = Color.Black
            reminder_text_3.BackColor = Color.White
            reminder_date_3.ForeColor = Color.Black
            reminder_date_3.BackColor = Color.White
            reminder_time_3.ForeColor = Color.Black
            reminder_time_3.BackColor = Color.White
            reminder_recurrence_3.ForeColor = Color.Black
            reminder_recurrence_3.BackColor = Color.White
        End If

        If button_selected <> 4 Then
            reminder_text_4.ForeColor = Color.Black
            reminder_text_4.BackColor = Color.White
            reminder_date_4.ForeColor = Color.Black
            reminder_date_4.BackColor = Color.White
            reminder_time_4.ForeColor = Color.Black
            reminder_time_4.BackColor = Color.White
            reminder_recurrence_4.ForeColor = Color.Black
            reminder_recurrence_4.BackColor = Color.White
        End If

        If button_selected <> 5 Then
            reminder_text_5.ForeColor = Color.Black
            reminder_text_5.BackColor = Color.White
            reminder_date_5.ForeColor = Color.Black
            reminder_date_5.BackColor = Color.White
            reminder_time_5.ForeColor = Color.Black
            reminder_time_5.BackColor = Color.White
            reminder_recurrence_5.ForeColor = Color.Black
            reminder_recurrence_5.BackColor = Color.White
        End If

        If button_selected <> 6 Then
            reminder_text_6.ForeColor = Color.Black
            reminder_text_6.BackColor = Color.White
            reminder_date_6.ForeColor = Color.Black
            reminder_date_6.BackColor = Color.White
            reminder_time_6.ForeColor = Color.Black
            reminder_time_6.BackColor = Color.White
            reminder_recurrence_6.ForeColor = Color.Black
            reminder_recurrence_6.BackColor = Color.White
        End If

    End Sub

    Private Sub reminder_check_timer_Tick(sender As Object, e As EventArgs) Handles reminder_check_timer.Tick

        'MsgBox("")  'troubleshooting msgbox

        Call check_reminders()

    End Sub

    Sub check_reminders()

        If InStr(reminder_array(0), "No reminders", vbTextCompare) = 0 Then

            reminder_check_timer.Stop()

            stop_check_reminder_loop = False

            For Me.array_counter = 0 To UBound(reminder_array)

                If InStr(Split(reminder_array(array_counter), ",")(3), "Monthly", vbTextCompare) = 0 Then

                    skip_switch = False

                    If Split(reminder_array(array_counter), ",")(3) = "Once Only" Then
                        If DateTime.Parse(Now) >= DateTime.Parse(Split(reminder_array(array_counter), ",")(1) & " " & Split(reminder_array(array_counter), ",")(2)) Then
                            TabControl1.TabPages(2).Enabled = True
                            reminder_window.Text = Split(reminder_array(array_counter), ",")(0)
                            snooze_choice.Enabled = True
                            reminder_DateTimePicker.Enabled = False
                            TabControl1.SelectedTab = reminder_pop_up
                            reminder_type = "Once Only"
                            selected_array_delete_item = array_counter
                            stop_check_reminder_loop = True
                            Me.WindowState = FormWindowState.Normal
                            Me.ShowInTaskbar = True
                            Exit For
                        End If
                        skip_switch = True
                    End If

                    If Split(reminder_array(array_counter), ",")(3) = "Every Day" Then
                        If DateTime.Parse(Now) >= DateTime.Parse(Split(reminder_array(array_counter), ",")(1) & " " & Split(reminder_array(array_counter), ",")(2)) Then
                            TabControl1.TabPages(2).Enabled = True
                            reminder_window.Text = Split(reminder_array(array_counter), ",")(0)
                            snooze_choice.Enabled = True
                            reminder_DateTimePicker.Enabled = False
                            TabControl1.SelectedTab = reminder_pop_up
                            reminder_type = "Every Day"
                            selected_array_item = array_counter
                            stop_check_reminder_loop = True
                            Me.WindowState = FormWindowState.Normal
                            Me.ShowInTaskbar = True
                            Exit For
                        End If
                        skip_switch = True
                    End If

                    If skip_switch = False Then 'catches Mon, Tue, Wed, etc...
                        If DateTime.Parse(Now) >= DateTime.Parse(Split(reminder_array(array_counter), ",")(1) & " " & Split(reminder_array(array_counter), ",")(2)) Then
                            TabControl1.TabPages(2).Enabled = True
                            reminder_window.Text = Split(reminder_array(array_counter), ",")(0)
                            snooze_choice.Enabled = True
                            reminder_DateTimePicker.Enabled = False
                            TabControl1.SelectedTab = reminder_pop_up
                            reminder_type = "Days of the Week"
                            selected_array_item = array_counter
                            stop_check_reminder_loop = True
                            Me.WindowState = FormWindowState.Normal
                            Me.ShowInTaskbar = True
                            Exit For
                        End If
                    End If

                Else

                    If InStr(Split(reminder_array(array_counter), ",")(3), "Variable Day", vbTextCompare) <> 0 Then
                        If DateTime.Parse(Now) >= DateTime.Parse(Split(reminder_array(array_counter), ",")(1) & " " & Split(reminder_array(array_counter), ",")(2)) Then
                            TabControl1.TabPages(2).Enabled = True
                            reminder_window.Text = Split(reminder_array(array_counter), ",")(0)
                            snooze_choice.Enabled = True
                            reminder_DateTimePicker.Enabled = True
                            reminder_DateTimePicker.Value = New DateTime(Year(Split(reminder_array(array_counter), ",")(1)), Month(Split(reminder_array(array_counter), ",")(1)), Microsoft.VisualBasic.DateAndTime.Day(Split(reminder_array(array_counter), ",")(1)), Hour(Split(reminder_array(array_counter), ",")(2)), Minute(Split(reminder_array(array_counter), ",")(2)), 0)
                            TabControl1.SelectedTab = reminder_pop_up
                            reminder_type = "Monthly Variable Day"
                            selected_array_item = array_counter
                            stop_check_reminder_loop = True
                            Me.WindowState = FormWindowState.Normal
                            Me.ShowInTaskbar = True
                            Exit For
                        End If
                    Else
                        If DateTime.Parse(Now) >= DateTime.Parse(Split(reminder_array(array_counter), ",")(1) & " " & Split(reminder_array(array_counter), ",")(2)) Then
                            TabControl1.TabPages(2).Enabled = True
                            reminder_window.Text = Split(reminder_array(array_counter), ",")(0)
                            snooze_choice.Enabled = True
                            reminder_DateTimePicker.Enabled = False
                            TabControl1.SelectedTab = reminder_pop_up
                            reminder_type = "Monthly Set Day"
                            selected_array_item = array_counter
                            stop_check_reminder_loop = True
                            Me.WindowState = FormWindowState.Normal
                            Me.ShowInTaskbar = True
                            Exit For
                        End If
                    End If

                End If

            Next array_counter

            If stop_check_reminder_loop = False Then reminder_check_timer.Start()

        End If

    End Sub

    Private Sub dismiss_button_Click(sender As Object, e As EventArgs) Handles dismiss_button.Click

        Select Case reminder_type

            Case "Once Only"

                If UBound(reminder_array) > 0 Then

                    ReDim temp_reminder_array(UBound(reminder_array) - 1)

                    Me.temp_array_counter = 0
                    For Me.array_counter = 0 To UBound(reminder_array)
                        If array_counter <> selected_array_delete_item Then
                            temp_reminder_array(temp_array_counter) = reminder_array(array_counter)
                            temp_array_counter = temp_array_counter + 1
                        End If
                    Next array_counter

                    ReDim reminder_array(UBound(temp_reminder_array))

                    For Me.array_counter = 0 To UBound(temp_reminder_array)
                        reminder_array(array_counter) = temp_reminder_array(array_counter)
                    Next array_counter

                Else

                    ReDim reminder_array(0)
                    reminder_array(0) = "No reminders, , , "

                End If

                display_array_start = 0
                Call refresh_data_file()
                Call refresh_reminder_list()

            Case "Every Day"

                If DateTime.Parse(Format(DateTime.Now, "MM/dd/yyyy") & " " & Split(reminder_array(selected_array_item), ",")(2)) >= DateTime.Now Then
                    new_date_time_string = DateTime.Parse(Format(DateTime.Now, "MM/dd/yyyy") & " " & Split(reminder_array(selected_array_item), ",")(2))
                Else
                    new_date_time_string = DateTime.Now
                    add_time = New System.TimeSpan(1, 0, 0, 0)
                    new_date_time_string = new_date_time_string.Add(add_time)
                End If

                new_reminder_string = ""
                new_reminder_string = Split(reminder_array(selected_array_item), ",")(0)
                new_reminder_string = new_reminder_string & "," & Format(new_date_time_string, "MM/dd/yyyy")
                new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(2)
                new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(3)

                reminder_array(selected_array_item) = new_reminder_string

                display_array_start = 0
                Call refresh_data_file()
                Call refresh_reminder_list()

            Case "Days of the Week"

                If DateTime.Parse(Format(DateTime.Now, "MM/dd/yyyy") & " " & Split(reminder_array(selected_array_item), ",")(2)) >= DateTime.Now And InStr(Split(reminder_array(selected_array_item), ",")(3), Microsoft.VisualBasic.Left(Format(DateTime.Now, "dddd"), 3), vbTextCompare) <> 0 Then
                    new_date_time_string = DateTime.Parse(Format(DateTime.Now, "MM/dd/yyyy") & " " & Split(reminder_array(selected_array_item), ",")(2))
                Else
                    For Me.day_counter = 1 To 7
                        new_date_time_string = DateTime.Now
                        add_time = New System.TimeSpan(day_counter, 0, 0, 0)
                        new_date_time_string = new_date_time_string.Add(add_time)
                        If InStr(reminder_array(selected_array_item), Microsoft.VisualBasic.Left(Format(new_date_time_string, "dddd"), 3), vbTextCompare) <> 0 Then
                            Exit For
                        End If
                    Next day_counter
                End If

                new_reminder_string = ""
                new_reminder_string = Split(reminder_array(selected_array_item), ",")(0)
                new_reminder_string = new_reminder_string & "," & Format(new_date_time_string, "MM/dd/yyyy")
                new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(2)
                new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(3)

                reminder_array(selected_array_item) = new_reminder_string

                display_array_start = 0
                Call refresh_data_file()
                Call refresh_reminder_list()

            Case "Monthly Variable Day"

                If DateTime.Parse(reminder_DateTimePicker.Value) < DateTime.Now Then
                    MsgBox("Please make sure you have the next date set before proceeding.", vbExclamation)
                    Exit Sub
                End If

                new_reminder_string = ""
                new_reminder_string = Split(reminder_array(selected_array_item), ",")(0)
                new_reminder_string = new_reminder_string & "," & Format(DateTime.Parse(reminder_DateTimePicker.Value), "MM/dd/yyyy")
                new_reminder_string = new_reminder_string & "," & Format(DateTime.Parse(reminder_DateTimePicker.Value), "hh:mm tt")
                new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(3)

                reminder_array(selected_array_item) = new_reminder_string

                display_array_start = 0
                Call refresh_data_file()
                Call refresh_reminder_list()

            Case "Monthly Set Day"

                test_string = Split(reminder_array(selected_array_item), ",")(3)
                set_day_string = Trim(Microsoft.VisualBasic.Right(test_string, Len(test_string) - InStrRev(test_string, " ", -1, vbTextCompare)))

                If IsNumeric(set_day_string) Then

                    date_time_string = DateTime.Parse(Split(reminder_array(selected_array_item), ",")(1) & " " & Split(reminder_array(selected_array_item), ",")(2))

                    Do Until date_time_string > DateTime.Now
                        Dim dat As Date
                        dat = DateTime.Parse(date_time_string)
                        date_time_string = dat.AddMonths(1).ToString("MM/dd/yyyy")
                    Loop

                    new_reminder_string = ""
                    new_reminder_string = Split(reminder_array(selected_array_item), ",")(0)
                    new_reminder_string = new_reminder_string & "," & date_time_string
                    new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(2)
                    new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(3)

                    reminder_array(selected_array_item) = new_reminder_string

                    display_array_start = 0
                    Call refresh_data_file()
                    Call refresh_reminder_list()

                Else

                    date_time_string = DateTime.Parse(Split(reminder_array(selected_array_item), ",")(1) & " " & Split(reminder_array(selected_array_item), ",")(2))

                    Do Until date_time_string > DateTime.Now

                        Dim dat As Date
                        dat = DateTime.Parse(date_time_string)
                        date_time_string = dat.AddMonths(1).ToString("MM/dd/yyyy")

                        For Me.day_counter = 1 To 4
                            new_date_time_string = DateTime.Parse(date_time_string)
                            add_time = New System.TimeSpan(day_counter, 0, 0, 0)
                            new_date_time_string = new_date_time_string.Add(add_time)
                            If Month(date_time_string) = Month(new_date_time_string) Then
                                date_time_string = new_date_time_string
                            Else
                                Exit For
                            End If
                        Next day_counter

                    Loop

                    new_reminder_string = ""
                    new_reminder_string = Split(reminder_array(selected_array_item), ",")(0)
                    new_reminder_string = new_reminder_string & "," & date_time_string
                    new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(2)
                    new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(3)

                    reminder_array(selected_array_item) = new_reminder_string

                    display_array_start = 0
                    Call refresh_data_file()
                    Call refresh_reminder_list()

                End If

        End Select

        reminder_type = ""

        TabControl1.TabPages(2).Enabled = False
        TabControl1.SelectedTab = current_reminders

        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False

        Call clear_reminder_tab()
        Call check_reminders()

        reminder_check_timer.Start()

    End Sub

    Private Sub snooze_button_Click(sender As Object, e As EventArgs) Handles snooze_button.Click

        If snooze_choice.Text = "" Then
            MsgBox("Please make sure you have a length of time" & Chr(13) & "selected before hitting the snooze button.", vbExclamation)
            Exit Sub
        End If

        Select Case reminder_type

            Case "Once Only"

                selected_array_item = selected_array_delete_item

                Call create_snooze_item()

                ReDim temp_reminder_array(UBound(reminder_array) - 1)

                Me.temp_array_counter = 0
                For Me.array_counter = 0 To UBound(reminder_array)
                    If array_counter <> selected_array_delete_item Then
                        temp_reminder_array(temp_array_counter) = reminder_array(array_counter)
                        temp_array_counter = temp_array_counter + 1
                    End If
                Next array_counter

                ReDim reminder_array(UBound(temp_reminder_array))

                For Me.array_counter = 0 To UBound(temp_reminder_array)
                    reminder_array(array_counter) = temp_reminder_array(array_counter)
                Next array_counter

                display_array_start = 0
                Call refresh_data_file()
                Call refresh_reminder_list()

            Case "Every Day"

                If DateTime.Parse(Format(DateTime.Now, "MM/dd/yyyy") & " " & Split(reminder_array(selected_array_item), ",")(2)) >= DateTime.Now Then
                    new_date_time_string = DateTime.Parse(Format(DateTime.Now, "MM/dd/yyyy") & " " & Split(reminder_array(selected_array_item), ",")(2))
                Else
                    new_date_time_string = DateTime.Now
                    add_time = New System.TimeSpan(1, 0, 0, 0)
                    new_date_time_string = new_date_time_string.Add(add_time)
                End If

                new_reminder_string = ""
                new_reminder_string = Split(reminder_array(selected_array_item), ",")(0)
                new_reminder_string = new_reminder_string & "," & Format(new_date_time_string, "MM/dd/yyyy")
                new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(2)
                new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(3)

                reminder_array(selected_array_item) = new_reminder_string

                Call create_snooze_item()

                display_array_start = 0
                Call refresh_data_file()
                Call refresh_reminder_list()

            Case "Days of the Week"

                If DateTime.Parse(Format(DateTime.Now, "MM/dd/yyyy") & " " & Split(reminder_array(selected_array_item), ",")(2)) >= DateTime.Now And InStr(Split(reminder_array(selected_array_item), ",")(3), Microsoft.VisualBasic.Left(Format(DateTime.Now, "dddd"), 3), vbTextCompare) <> 0 Then
                    new_date_time_string = DateTime.Parse(Format(DateTime.Now, "MM/dd/yyyy") & " " & Split(reminder_array(selected_array_item), ",")(2))
                Else
                    For Me.day_counter = 1 To 7
                        new_date_time_string = DateTime.Now
                        add_time = New System.TimeSpan(day_counter, 0, 0, 0)
                        new_date_time_string = new_date_time_string.Add(add_time)
                        If InStr(reminder_array(selected_array_item), Microsoft.VisualBasic.Left(Format(new_date_time_string, "dddd"), 3), vbTextCompare) <> 0 Then
                            Exit For
                        End If
                    Next day_counter
                End If

                new_reminder_string = ""
                new_reminder_string = Split(reminder_array(selected_array_item), ",")(0)
                new_reminder_string = new_reminder_string & "," & Format(new_date_time_string, "MM/dd/yyyy")
                new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(2)
                new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(3)

                reminder_array(selected_array_item) = new_reminder_string

                Call create_snooze_item()

                display_array_start = 0
                Call refresh_data_file()
                Call refresh_reminder_list()

            Case "Monthly Variable Day"

                If DateTime.Parse(reminder_DateTimePicker.Value) < DateTime.Now Then
                    MsgBox("Please make sure you have the next date set before proceeding.", vbExclamation)
                    Exit Sub
                End If

                new_reminder_string = ""
                new_reminder_string = Split(reminder_array(selected_array_item), ",")(0)
                new_reminder_string = new_reminder_string & "," & Format(DateTime.Parse(reminder_DateTimePicker.Value), "MM/dd/yyyy")
                new_reminder_string = new_reminder_string & "," & Format(DateTime.Parse(reminder_DateTimePicker.Value), "hh:mm tt")
                new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(3)

                reminder_array(selected_array_item) = new_reminder_string

                Call create_snooze_item()

                display_array_start = 0
                Call refresh_data_file()
                Call refresh_reminder_list()

            Case "Monthly Set Day"

                test_string = Split(reminder_array(selected_array_item), ",")(3)
                set_day_string = Trim(Microsoft.VisualBasic.Right(test_string, Len(test_string) - InStrRev(test_string, " ", -1, vbTextCompare)))

                If IsNumeric(set_day_string) Then

                    date_time_string = DateTime.Parse(Split(reminder_array(selected_array_item), ",")(1) & " " & Split(reminder_array(selected_array_item), ",")(2))

                    Do Until date_time_string > DateTime.Now
                        Dim dat As Date
                        dat = DateTime.Parse(date_time_string)
                        date_time_string = dat.AddMonths(1).ToString("MM/dd/yyyy")
                    Loop

                    new_reminder_string = ""
                    new_reminder_string = Split(reminder_array(selected_array_item), ",")(0)
                    new_reminder_string = new_reminder_string & "," & date_time_string
                    new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(2)
                    new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(3)

                    reminder_array(selected_array_item) = new_reminder_string

                    Call create_snooze_item()

                    display_array_start = 0
                    Call refresh_data_file()
                    Call refresh_reminder_list()

                Else

                    date_time_string = DateTime.Parse(Split(reminder_array(selected_array_item), ",")(1) & " " & Split(reminder_array(selected_array_item), ",")(2))

                    Do Until date_time_string > DateTime.Now

                        Dim dat As Date
                        dat = DateTime.Parse(date_time_string)
                        date_time_string = dat.AddMonths(1).ToString("MM/dd/yyyy")

                        For Me.day_counter = 1 To 4
                            new_date_time_string = DateTime.Parse(date_time_string)
                            add_time = New System.TimeSpan(day_counter, 0, 0, 0)
                            new_date_time_string = new_date_time_string.Add(add_time)
                            If Month(date_time_string) = Month(new_date_time_string) Then
                                date_time_string = new_date_time_string
                            Else
                                Exit For
                            End If
                        Next day_counter

                    Loop

                    new_reminder_string = ""
                    new_reminder_string = Split(reminder_array(selected_array_item), ",")(0)
                    new_reminder_string = new_reminder_string & "," & date_time_string
                    new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(2)
                    new_reminder_string = new_reminder_string & "," & Split(reminder_array(selected_array_item), ",")(3)

                    reminder_array(selected_array_item) = new_reminder_string

                    Call create_snooze_item()

                    display_array_start = 0
                    Call refresh_data_file()
                    Call refresh_reminder_list()

                End If

        End Select

        reminder_type = ""

        TabControl1.TabPages(2).Enabled = False
        TabControl1.SelectedTab = current_reminders

        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False

        Call clear_reminder_tab()
        Call check_reminders()

        reminder_check_timer.Start()

    End Sub

    Sub create_snooze_item()

        ReDim Preserve reminder_array(UBound(reminder_array) + 1)

        new_reminder_string = "SNOOZED: "
        new_reminder_string = new_reminder_string & Split(reminder_array(selected_array_item), ",")(0)

        new_date_time_string = DateTime.Now

        Select Case snooze_choice.Text
            Case "5 minutes"
                add_time = New System.TimeSpan(0, 0, 5, 0)
            Case "10 minutes"
                add_time = New System.TimeSpan(0, 0, 10, 0)
            Case "15 minutes"
                add_time = New System.TimeSpan(0, 0, 15, 0)
            Case "30 minutes"
                add_time = New System.TimeSpan(0, 0, 30, 0)
            Case "1 hour"
                add_time = New System.TimeSpan(0, 1, 0, 0)
            Case "2 hours"
                add_time = New System.TimeSpan(0, 2, 0, 0)
            Case "4 hours"
                add_time = New System.TimeSpan(0, 4, 0, 0)
        End Select
        new_date_time_string = new_date_time_string.Add(add_time)

        new_reminder_string = new_reminder_string & "," & Format(new_date_time_string, "MM/dd/yyyy") & "," & Format(new_date_time_string, "hh:mm tt")
        new_reminder_string = new_reminder_string & ",Once Only"

        reminder_array(UBound(reminder_array)) = new_reminder_string


    End Sub

    Sub clear_reminder_tab()

        reminder_window.Text = ""
        snooze_choice.SelectedIndex = -1

    End Sub

    Sub OnShuttingdown(sender As Object, e As SessionEndingEventArgs)
        close_program_switch = True
        Me.Close()
    End Sub

    Sub OnShutdown(sender As Object, e As SessionEndedEventArgs)
        close_program_switch = True
        Me.Close()
    End Sub

End Class