<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateReminderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSelectedReminderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedReminderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveReminderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.current_reminders = New System.Windows.Forms.TabPage()
        Me.reminders_scroll_down = New System.Windows.Forms.Button()
        Me.reminders_scroll_up = New System.Windows.Forms.Button()
        Me.reminder_button_6 = New System.Windows.Forms.RadioButton()
        Me.reminder_button_5 = New System.Windows.Forms.RadioButton()
        Me.reminder_button_4 = New System.Windows.Forms.RadioButton()
        Me.reminder_button_3 = New System.Windows.Forms.RadioButton()
        Me.reminder_button_2 = New System.Windows.Forms.RadioButton()
        Me.reminder_button_1 = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.reminder_recurrence_6 = New System.Windows.Forms.Label()
        Me.reminder_recurrence_5 = New System.Windows.Forms.Label()
        Me.reminder_recurrence_4 = New System.Windows.Forms.Label()
        Me.reminder_recurrence_3 = New System.Windows.Forms.Label()
        Me.reminder_recurrence_2 = New System.Windows.Forms.Label()
        Me.reminder_recurrence_1 = New System.Windows.Forms.Label()
        Me.reminder_time_6 = New System.Windows.Forms.Label()
        Me.reminder_time_5 = New System.Windows.Forms.Label()
        Me.reminder_time_4 = New System.Windows.Forms.Label()
        Me.reminder_time_3 = New System.Windows.Forms.Label()
        Me.reminder_time_2 = New System.Windows.Forms.Label()
        Me.reminder_time_1 = New System.Windows.Forms.Label()
        Me.reminder_date_6 = New System.Windows.Forms.Label()
        Me.reminder_date_5 = New System.Windows.Forms.Label()
        Me.reminder_date_4 = New System.Windows.Forms.Label()
        Me.reminder_date_3 = New System.Windows.Forms.Label()
        Me.reminder_date_2 = New System.Windows.Forms.Label()
        Me.reminder_date_1 = New System.Windows.Forms.Label()
        Me.reminder_text_6 = New System.Windows.Forms.Label()
        Me.reminder_text_5 = New System.Windows.Forms.Label()
        Me.reminder_text_4 = New System.Windows.Forms.Label()
        Me.reminder_text_3 = New System.Windows.Forms.Label()
        Me.reminder_text_2 = New System.Windows.Forms.Label()
        Me.reminder_text_1 = New System.Windows.Forms.Label()
        Me.edit_reminder = New System.Windows.Forms.TabPage()
        Me.CheckBox_saturday = New System.Windows.Forms.CheckBox()
        Me.CheckBox_friday = New System.Windows.Forms.CheckBox()
        Me.CheckBox_thursday = New System.Windows.Forms.CheckBox()
        Me.CheckBox_wednesday = New System.Windows.Forms.CheckBox()
        Me.CheckBox_tuesday = New System.Windows.Forms.CheckBox()
        Me.CheckBox_monday = New System.Windows.Forms.CheckBox()
        Me.CheckBox_sunday = New System.Windows.Forms.CheckBox()
        Me.monthly_on_day_selector = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.option_monthly_on_day = New System.Windows.Forms.RadioButton()
        Me.option_monthly_variable = New System.Windows.Forms.RadioButton()
        Me.option_monday_to_friday = New System.Windows.Forms.RadioButton()
        Me.option_weekly_on = New System.Windows.Forms.RadioButton()
        Me.option_every_day = New System.Windows.Forms.RadioButton()
        Me.option_once_only = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reminder_textbox = New System.Windows.Forms.TextBox()
        Me.reminder_pop_up = New System.Windows.Forms.TabPage()
        Me.snooze_choice = New System.Windows.Forms.ComboBox()
        Me.snooze_button = New System.Windows.Forms.Button()
        Me.dismiss_button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.reminder_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.reminder_window = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.reminder_check_timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.current_reminders.SuspendLayout()
        Me.edit_reminder.SuspendLayout()
        Me.reminder_pop_up.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.CreateReminderToolStripMenuItem, Me.EditSelectedReminderToolStripMenuItem, Me.DeleteSelectedReminderToolStripMenuItem, Me.SaveReminderToolStripMenuItem, Me.CancelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimizeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CreateReminderToolStripMenuItem
        '
        Me.CreateReminderToolStripMenuItem.Name = "CreateReminderToolStripMenuItem"
        Me.CreateReminderToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.CreateReminderToolStripMenuItem.Text = "Create New Reminder"
        '
        'EditSelectedReminderToolStripMenuItem
        '
        Me.EditSelectedReminderToolStripMenuItem.Name = "EditSelectedReminderToolStripMenuItem"
        Me.EditSelectedReminderToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.EditSelectedReminderToolStripMenuItem.Text = "Edit Selected Reminder"
        '
        'DeleteSelectedReminderToolStripMenuItem
        '
        Me.DeleteSelectedReminderToolStripMenuItem.Name = "DeleteSelectedReminderToolStripMenuItem"
        Me.DeleteSelectedReminderToolStripMenuItem.Size = New System.Drawing.Size(142, 20)
        Me.DeleteSelectedReminderToolStripMenuItem.Text = "Delete Selected Reminder"
        '
        'SaveReminderToolStripMenuItem
        '
        Me.SaveReminderToolStripMenuItem.Name = "SaveReminderToolStripMenuItem"
        Me.SaveReminderToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.SaveReminderToolStripMenuItem.Text = "Save Reminder"
        '
        'CancelToolStripMenuItem
        '
        Me.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem"
        Me.CancelToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.CancelToolStripMenuItem.Text = "Cancel"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.current_reminders)
        Me.TabControl1.Controls.Add(Me.edit_reminder)
        Me.TabControl1.Controls.Add(Me.reminder_pop_up)
        Me.TabControl1.Location = New System.Drawing.Point(0, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(661, 179)
        Me.TabControl1.TabIndex = 1
        '
        'current_reminders
        '
        Me.current_reminders.Controls.Add(Me.reminders_scroll_down)
        Me.current_reminders.Controls.Add(Me.reminders_scroll_up)
        Me.current_reminders.Controls.Add(Me.reminder_button_6)
        Me.current_reminders.Controls.Add(Me.reminder_button_5)
        Me.current_reminders.Controls.Add(Me.reminder_button_4)
        Me.current_reminders.Controls.Add(Me.reminder_button_3)
        Me.current_reminders.Controls.Add(Me.reminder_button_2)
        Me.current_reminders.Controls.Add(Me.reminder_button_1)
        Me.current_reminders.Controls.Add(Me.Label28)
        Me.current_reminders.Controls.Add(Me.Label29)
        Me.current_reminders.Controls.Add(Me.Label30)
        Me.current_reminders.Controls.Add(Me.Label31)
        Me.current_reminders.Controls.Add(Me.reminder_recurrence_6)
        Me.current_reminders.Controls.Add(Me.reminder_recurrence_5)
        Me.current_reminders.Controls.Add(Me.reminder_recurrence_4)
        Me.current_reminders.Controls.Add(Me.reminder_recurrence_3)
        Me.current_reminders.Controls.Add(Me.reminder_recurrence_2)
        Me.current_reminders.Controls.Add(Me.reminder_recurrence_1)
        Me.current_reminders.Controls.Add(Me.reminder_time_6)
        Me.current_reminders.Controls.Add(Me.reminder_time_5)
        Me.current_reminders.Controls.Add(Me.reminder_time_4)
        Me.current_reminders.Controls.Add(Me.reminder_time_3)
        Me.current_reminders.Controls.Add(Me.reminder_time_2)
        Me.current_reminders.Controls.Add(Me.reminder_time_1)
        Me.current_reminders.Controls.Add(Me.reminder_date_6)
        Me.current_reminders.Controls.Add(Me.reminder_date_5)
        Me.current_reminders.Controls.Add(Me.reminder_date_4)
        Me.current_reminders.Controls.Add(Me.reminder_date_3)
        Me.current_reminders.Controls.Add(Me.reminder_date_2)
        Me.current_reminders.Controls.Add(Me.reminder_date_1)
        Me.current_reminders.Controls.Add(Me.reminder_text_6)
        Me.current_reminders.Controls.Add(Me.reminder_text_5)
        Me.current_reminders.Controls.Add(Me.reminder_text_4)
        Me.current_reminders.Controls.Add(Me.reminder_text_3)
        Me.current_reminders.Controls.Add(Me.reminder_text_2)
        Me.current_reminders.Controls.Add(Me.reminder_text_1)
        Me.current_reminders.Location = New System.Drawing.Point(4, 22)
        Me.current_reminders.Name = "current_reminders"
        Me.current_reminders.Padding = New System.Windows.Forms.Padding(3)
        Me.current_reminders.Size = New System.Drawing.Size(653, 153)
        Me.current_reminders.TabIndex = 0
        Me.current_reminders.Text = "Current Reminders"
        Me.current_reminders.UseVisualStyleBackColor = True
        '
        'reminders_scroll_down
        '
        Me.reminders_scroll_down.Location = New System.Drawing.Point(606, 97)
        Me.reminders_scroll_down.Margin = New System.Windows.Forms.Padding(1)
        Me.reminders_scroll_down.Name = "reminders_scroll_down"
        Me.reminders_scroll_down.Size = New System.Drawing.Size(43, 40)
        Me.reminders_scroll_down.TabIndex = 35
        Me.reminders_scroll_down.Text = "Scroll Down"
        Me.reminders_scroll_down.UseVisualStyleBackColor = True
        '
        'reminders_scroll_up
        '
        Me.reminders_scroll_up.Location = New System.Drawing.Point(606, 37)
        Me.reminders_scroll_up.Margin = New System.Windows.Forms.Padding(1)
        Me.reminders_scroll_up.Name = "reminders_scroll_up"
        Me.reminders_scroll_up.Size = New System.Drawing.Size(43, 40)
        Me.reminders_scroll_up.TabIndex = 34
        Me.reminders_scroll_up.Text = "Scroll Up"
        Me.reminders_scroll_up.UseVisualStyleBackColor = True
        '
        'reminder_button_6
        '
        Me.reminder_button_6.AutoSize = True
        Me.reminder_button_6.Location = New System.Drawing.Point(4, 130)
        Me.reminder_button_6.Name = "reminder_button_6"
        Me.reminder_button_6.Size = New System.Drawing.Size(14, 13)
        Me.reminder_button_6.TabIndex = 33
        Me.reminder_button_6.UseVisualStyleBackColor = True
        '
        'reminder_button_5
        '
        Me.reminder_button_5.AutoSize = True
        Me.reminder_button_5.Location = New System.Drawing.Point(4, 111)
        Me.reminder_button_5.Name = "reminder_button_5"
        Me.reminder_button_5.Size = New System.Drawing.Size(14, 13)
        Me.reminder_button_5.TabIndex = 32
        Me.reminder_button_5.UseVisualStyleBackColor = True
        '
        'reminder_button_4
        '
        Me.reminder_button_4.AutoSize = True
        Me.reminder_button_4.Location = New System.Drawing.Point(4, 91)
        Me.reminder_button_4.Name = "reminder_button_4"
        Me.reminder_button_4.Size = New System.Drawing.Size(14, 13)
        Me.reminder_button_4.TabIndex = 31
        Me.reminder_button_4.UseVisualStyleBackColor = True
        '
        'reminder_button_3
        '
        Me.reminder_button_3.AutoSize = True
        Me.reminder_button_3.Location = New System.Drawing.Point(4, 71)
        Me.reminder_button_3.Name = "reminder_button_3"
        Me.reminder_button_3.Size = New System.Drawing.Size(14, 13)
        Me.reminder_button_3.TabIndex = 30
        Me.reminder_button_3.UseVisualStyleBackColor = True
        '
        'reminder_button_2
        '
        Me.reminder_button_2.AutoSize = True
        Me.reminder_button_2.Location = New System.Drawing.Point(4, 51)
        Me.reminder_button_2.Name = "reminder_button_2"
        Me.reminder_button_2.Size = New System.Drawing.Size(14, 13)
        Me.reminder_button_2.TabIndex = 29
        Me.reminder_button_2.UseVisualStyleBackColor = True
        '
        'reminder_button_1
        '
        Me.reminder_button_1.AutoSize = True
        Me.reminder_button_1.Checked = True
        Me.reminder_button_1.Location = New System.Drawing.Point(4, 32)
        Me.reminder_button_1.Name = "reminder_button_1"
        Me.reminder_button_1.Size = New System.Drawing.Size(14, 13)
        Me.reminder_button_1.TabIndex = 28
        Me.reminder_button_1.TabStop = True
        Me.reminder_button_1.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(486, 7)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(117, 20)
        Me.Label28.TabIndex = 27
        Me.Label28.Text = "Recurrence:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(425, 7)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 20)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "Time:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(353, 7)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 20)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "Date:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(8, 7)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(345, 20)
        Me.Label31.TabIndex = 24
        Me.Label31.Text = "Reminder Text:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'reminder_recurrence_6
        '
        Me.reminder_recurrence_6.BackColor = System.Drawing.Color.White
        Me.reminder_recurrence_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_recurrence_6.Location = New System.Drawing.Point(486, 127)
        Me.reminder_recurrence_6.Name = "reminder_recurrence_6"
        Me.reminder_recurrence_6.Size = New System.Drawing.Size(117, 20)
        Me.reminder_recurrence_6.TabIndex = 23
        Me.reminder_recurrence_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_recurrence_5
        '
        Me.reminder_recurrence_5.BackColor = System.Drawing.Color.White
        Me.reminder_recurrence_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_recurrence_5.Location = New System.Drawing.Point(486, 107)
        Me.reminder_recurrence_5.Name = "reminder_recurrence_5"
        Me.reminder_recurrence_5.Size = New System.Drawing.Size(117, 20)
        Me.reminder_recurrence_5.TabIndex = 22
        Me.reminder_recurrence_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_recurrence_4
        '
        Me.reminder_recurrence_4.BackColor = System.Drawing.Color.White
        Me.reminder_recurrence_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_recurrence_4.Location = New System.Drawing.Point(486, 87)
        Me.reminder_recurrence_4.Name = "reminder_recurrence_4"
        Me.reminder_recurrence_4.Size = New System.Drawing.Size(117, 20)
        Me.reminder_recurrence_4.TabIndex = 21
        Me.reminder_recurrence_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_recurrence_3
        '
        Me.reminder_recurrence_3.BackColor = System.Drawing.Color.White
        Me.reminder_recurrence_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_recurrence_3.Location = New System.Drawing.Point(486, 67)
        Me.reminder_recurrence_3.Name = "reminder_recurrence_3"
        Me.reminder_recurrence_3.Size = New System.Drawing.Size(117, 20)
        Me.reminder_recurrence_3.TabIndex = 20
        Me.reminder_recurrence_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_recurrence_2
        '
        Me.reminder_recurrence_2.BackColor = System.Drawing.Color.White
        Me.reminder_recurrence_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_recurrence_2.Location = New System.Drawing.Point(486, 47)
        Me.reminder_recurrence_2.Name = "reminder_recurrence_2"
        Me.reminder_recurrence_2.Size = New System.Drawing.Size(117, 20)
        Me.reminder_recurrence_2.TabIndex = 19
        Me.reminder_recurrence_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_recurrence_1
        '
        Me.reminder_recurrence_1.BackColor = System.Drawing.Color.White
        Me.reminder_recurrence_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_recurrence_1.Location = New System.Drawing.Point(486, 27)
        Me.reminder_recurrence_1.Name = "reminder_recurrence_1"
        Me.reminder_recurrence_1.Size = New System.Drawing.Size(117, 20)
        Me.reminder_recurrence_1.TabIndex = 18
        Me.reminder_recurrence_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_time_6
        '
        Me.reminder_time_6.BackColor = System.Drawing.Color.White
        Me.reminder_time_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_time_6.Location = New System.Drawing.Point(425, 127)
        Me.reminder_time_6.Name = "reminder_time_6"
        Me.reminder_time_6.Size = New System.Drawing.Size(61, 20)
        Me.reminder_time_6.TabIndex = 17
        Me.reminder_time_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_time_5
        '
        Me.reminder_time_5.BackColor = System.Drawing.Color.White
        Me.reminder_time_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_time_5.Location = New System.Drawing.Point(425, 107)
        Me.reminder_time_5.Name = "reminder_time_5"
        Me.reminder_time_5.Size = New System.Drawing.Size(61, 20)
        Me.reminder_time_5.TabIndex = 16
        Me.reminder_time_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_time_4
        '
        Me.reminder_time_4.BackColor = System.Drawing.Color.White
        Me.reminder_time_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_time_4.Location = New System.Drawing.Point(425, 87)
        Me.reminder_time_4.Name = "reminder_time_4"
        Me.reminder_time_4.Size = New System.Drawing.Size(61, 20)
        Me.reminder_time_4.TabIndex = 15
        Me.reminder_time_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_time_3
        '
        Me.reminder_time_3.BackColor = System.Drawing.Color.White
        Me.reminder_time_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_time_3.Location = New System.Drawing.Point(425, 67)
        Me.reminder_time_3.Name = "reminder_time_3"
        Me.reminder_time_3.Size = New System.Drawing.Size(61, 20)
        Me.reminder_time_3.TabIndex = 14
        Me.reminder_time_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_time_2
        '
        Me.reminder_time_2.BackColor = System.Drawing.Color.White
        Me.reminder_time_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_time_2.Location = New System.Drawing.Point(425, 47)
        Me.reminder_time_2.Name = "reminder_time_2"
        Me.reminder_time_2.Size = New System.Drawing.Size(61, 20)
        Me.reminder_time_2.TabIndex = 13
        Me.reminder_time_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_time_1
        '
        Me.reminder_time_1.BackColor = System.Drawing.Color.White
        Me.reminder_time_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_time_1.Location = New System.Drawing.Point(425, 27)
        Me.reminder_time_1.Name = "reminder_time_1"
        Me.reminder_time_1.Size = New System.Drawing.Size(61, 20)
        Me.reminder_time_1.TabIndex = 12
        Me.reminder_time_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_date_6
        '
        Me.reminder_date_6.BackColor = System.Drawing.Color.White
        Me.reminder_date_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_date_6.Location = New System.Drawing.Point(353, 127)
        Me.reminder_date_6.Name = "reminder_date_6"
        Me.reminder_date_6.Size = New System.Drawing.Size(72, 20)
        Me.reminder_date_6.TabIndex = 11
        Me.reminder_date_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_date_5
        '
        Me.reminder_date_5.BackColor = System.Drawing.Color.White
        Me.reminder_date_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_date_5.Location = New System.Drawing.Point(353, 107)
        Me.reminder_date_5.Name = "reminder_date_5"
        Me.reminder_date_5.Size = New System.Drawing.Size(72, 20)
        Me.reminder_date_5.TabIndex = 10
        Me.reminder_date_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_date_4
        '
        Me.reminder_date_4.BackColor = System.Drawing.Color.White
        Me.reminder_date_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_date_4.Location = New System.Drawing.Point(353, 87)
        Me.reminder_date_4.Name = "reminder_date_4"
        Me.reminder_date_4.Size = New System.Drawing.Size(72, 20)
        Me.reminder_date_4.TabIndex = 9
        Me.reminder_date_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_date_3
        '
        Me.reminder_date_3.BackColor = System.Drawing.Color.White
        Me.reminder_date_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_date_3.Location = New System.Drawing.Point(353, 67)
        Me.reminder_date_3.Name = "reminder_date_3"
        Me.reminder_date_3.Size = New System.Drawing.Size(72, 20)
        Me.reminder_date_3.TabIndex = 8
        Me.reminder_date_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_date_2
        '
        Me.reminder_date_2.BackColor = System.Drawing.Color.White
        Me.reminder_date_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_date_2.Location = New System.Drawing.Point(353, 47)
        Me.reminder_date_2.Name = "reminder_date_2"
        Me.reminder_date_2.Size = New System.Drawing.Size(72, 20)
        Me.reminder_date_2.TabIndex = 7
        Me.reminder_date_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_date_1
        '
        Me.reminder_date_1.BackColor = System.Drawing.Color.White
        Me.reminder_date_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_date_1.Location = New System.Drawing.Point(353, 27)
        Me.reminder_date_1.Name = "reminder_date_1"
        Me.reminder_date_1.Size = New System.Drawing.Size(72, 20)
        Me.reminder_date_1.TabIndex = 6
        Me.reminder_date_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_text_6
        '
        Me.reminder_text_6.BackColor = System.Drawing.Color.White
        Me.reminder_text_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_text_6.Location = New System.Drawing.Point(22, 127)
        Me.reminder_text_6.Name = "reminder_text_6"
        Me.reminder_text_6.Size = New System.Drawing.Size(331, 20)
        Me.reminder_text_6.TabIndex = 5
        Me.reminder_text_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_text_5
        '
        Me.reminder_text_5.BackColor = System.Drawing.Color.White
        Me.reminder_text_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_text_5.Location = New System.Drawing.Point(22, 107)
        Me.reminder_text_5.Name = "reminder_text_5"
        Me.reminder_text_5.Size = New System.Drawing.Size(331, 20)
        Me.reminder_text_5.TabIndex = 4
        Me.reminder_text_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_text_4
        '
        Me.reminder_text_4.BackColor = System.Drawing.Color.White
        Me.reminder_text_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_text_4.Location = New System.Drawing.Point(22, 87)
        Me.reminder_text_4.Name = "reminder_text_4"
        Me.reminder_text_4.Size = New System.Drawing.Size(331, 20)
        Me.reminder_text_4.TabIndex = 3
        Me.reminder_text_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_text_3
        '
        Me.reminder_text_3.BackColor = System.Drawing.Color.White
        Me.reminder_text_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_text_3.Location = New System.Drawing.Point(22, 67)
        Me.reminder_text_3.Name = "reminder_text_3"
        Me.reminder_text_3.Size = New System.Drawing.Size(331, 20)
        Me.reminder_text_3.TabIndex = 2
        Me.reminder_text_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_text_2
        '
        Me.reminder_text_2.BackColor = System.Drawing.Color.White
        Me.reminder_text_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_text_2.Location = New System.Drawing.Point(22, 47)
        Me.reminder_text_2.Name = "reminder_text_2"
        Me.reminder_text_2.Size = New System.Drawing.Size(331, 20)
        Me.reminder_text_2.TabIndex = 1
        Me.reminder_text_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'reminder_text_1
        '
        Me.reminder_text_1.BackColor = System.Drawing.Color.White
        Me.reminder_text_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_text_1.Location = New System.Drawing.Point(22, 27)
        Me.reminder_text_1.Name = "reminder_text_1"
        Me.reminder_text_1.Size = New System.Drawing.Size(331, 20)
        Me.reminder_text_1.TabIndex = 0
        Me.reminder_text_1.Text = "TEST"
        Me.reminder_text_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'edit_reminder
        '
        Me.edit_reminder.Controls.Add(Me.CheckBox_saturday)
        Me.edit_reminder.Controls.Add(Me.CheckBox_friday)
        Me.edit_reminder.Controls.Add(Me.CheckBox_thursday)
        Me.edit_reminder.Controls.Add(Me.CheckBox_wednesday)
        Me.edit_reminder.Controls.Add(Me.CheckBox_tuesday)
        Me.edit_reminder.Controls.Add(Me.CheckBox_monday)
        Me.edit_reminder.Controls.Add(Me.CheckBox_sunday)
        Me.edit_reminder.Controls.Add(Me.monthly_on_day_selector)
        Me.edit_reminder.Controls.Add(Me.Label2)
        Me.edit_reminder.Controls.Add(Me.option_monthly_on_day)
        Me.edit_reminder.Controls.Add(Me.option_monthly_variable)
        Me.edit_reminder.Controls.Add(Me.option_monday_to_friday)
        Me.edit_reminder.Controls.Add(Me.option_weekly_on)
        Me.edit_reminder.Controls.Add(Me.option_every_day)
        Me.edit_reminder.Controls.Add(Me.option_once_only)
        Me.edit_reminder.Controls.Add(Me.DateTimePicker1)
        Me.edit_reminder.Controls.Add(Me.Label4)
        Me.edit_reminder.Controls.Add(Me.Label1)
        Me.edit_reminder.Controls.Add(Me.reminder_textbox)
        Me.edit_reminder.Location = New System.Drawing.Point(4, 22)
        Me.edit_reminder.Name = "edit_reminder"
        Me.edit_reminder.Padding = New System.Windows.Forms.Padding(3)
        Me.edit_reminder.Size = New System.Drawing.Size(653, 153)
        Me.edit_reminder.TabIndex = 1
        Me.edit_reminder.Text = "Reminder Editing"
        Me.edit_reminder.UseVisualStyleBackColor = True
        '
        'CheckBox_saturday
        '
        Me.CheckBox_saturday.AutoSize = True
        Me.CheckBox_saturday.Location = New System.Drawing.Point(557, 123)
        Me.CheckBox_saturday.Name = "CheckBox_saturday"
        Me.CheckBox_saturday.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox_saturday.TabIndex = 24
        Me.CheckBox_saturday.Text = "Saturday"
        Me.CheckBox_saturday.UseVisualStyleBackColor = True
        '
        'CheckBox_friday
        '
        Me.CheckBox_friday.AutoSize = True
        Me.CheckBox_friday.Location = New System.Drawing.Point(497, 123)
        Me.CheckBox_friday.Name = "CheckBox_friday"
        Me.CheckBox_friday.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox_friday.TabIndex = 23
        Me.CheckBox_friday.Text = "Friday"
        Me.CheckBox_friday.UseVisualStyleBackColor = True
        '
        'CheckBox_thursday
        '
        Me.CheckBox_thursday.AutoSize = True
        Me.CheckBox_thursday.Location = New System.Drawing.Point(421, 123)
        Me.CheckBox_thursday.Name = "CheckBox_thursday"
        Me.CheckBox_thursday.Size = New System.Drawing.Size(70, 17)
        Me.CheckBox_thursday.TabIndex = 22
        Me.CheckBox_thursday.Text = "Thursday"
        Me.CheckBox_thursday.UseVisualStyleBackColor = True
        '
        'CheckBox_wednesday
        '
        Me.CheckBox_wednesday.AutoSize = True
        Me.CheckBox_wednesday.Location = New System.Drawing.Point(332, 123)
        Me.CheckBox_wednesday.Name = "CheckBox_wednesday"
        Me.CheckBox_wednesday.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox_wednesday.TabIndex = 21
        Me.CheckBox_wednesday.Text = "Wednesday"
        Me.CheckBox_wednesday.UseVisualStyleBackColor = True
        '
        'CheckBox_tuesday
        '
        Me.CheckBox_tuesday.AutoSize = True
        Me.CheckBox_tuesday.Location = New System.Drawing.Point(259, 123)
        Me.CheckBox_tuesday.Name = "CheckBox_tuesday"
        Me.CheckBox_tuesday.Size = New System.Drawing.Size(67, 17)
        Me.CheckBox_tuesday.TabIndex = 20
        Me.CheckBox_tuesday.Text = "Tuesday"
        Me.CheckBox_tuesday.UseVisualStyleBackColor = True
        '
        'CheckBox_monday
        '
        Me.CheckBox_monday.AutoSize = True
        Me.CheckBox_monday.Location = New System.Drawing.Point(189, 123)
        Me.CheckBox_monday.Name = "CheckBox_monday"
        Me.CheckBox_monday.Size = New System.Drawing.Size(64, 17)
        Me.CheckBox_monday.TabIndex = 19
        Me.CheckBox_monday.Text = "Monday"
        Me.CheckBox_monday.UseVisualStyleBackColor = True
        '
        'CheckBox_sunday
        '
        Me.CheckBox_sunday.AutoSize = True
        Me.CheckBox_sunday.Location = New System.Drawing.Point(121, 123)
        Me.CheckBox_sunday.Name = "CheckBox_sunday"
        Me.CheckBox_sunday.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox_sunday.TabIndex = 18
        Me.CheckBox_sunday.Text = "Sunday"
        Me.CheckBox_sunday.UseVisualStyleBackColor = True
        '
        'monthly_on_day_selector
        '
        Me.monthly_on_day_selector.FormattingEnabled = True
        Me.monthly_on_day_selector.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "End"})
        Me.monthly_on_day_selector.Location = New System.Drawing.Point(608, 93)
        Me.monthly_on_day_selector.Name = "monthly_on_day_selector"
        Me.monthly_on_day_selector.Size = New System.Drawing.Size(42, 21)
        Me.monthly_on_day_selector.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(634, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Recurrence:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'option_monthly_on_day
        '
        Me.option_monthly_on_day.AutoSize = True
        Me.option_monthly_on_day.Location = New System.Drawing.Point(498, 95)
        Me.option_monthly_on_day.Name = "option_monthly_on_day"
        Me.option_monthly_on_day.Size = New System.Drawing.Size(104, 17)
        Me.option_monthly_on_day.TabIndex = 15
        Me.option_monthly_on_day.TabStop = True
        Me.option_monthly_on_day.Text = "Monthly On Day:"
        Me.option_monthly_on_day.UseVisualStyleBackColor = True
        '
        'option_monthly_variable
        '
        Me.option_monthly_variable.AutoSize = True
        Me.option_monthly_variable.Location = New System.Drawing.Point(282, 95)
        Me.option_monthly_variable.Name = "option_monthly_variable"
        Me.option_monthly_variable.Size = New System.Drawing.Size(209, 17)
        Me.option_monthly_variable.TabIndex = 14
        Me.option_monthly_variable.TabStop = True
        Me.option_monthly_variable.Text = "Monthly / Variable Day (Set Start Date)"
        Me.option_monthly_variable.UseVisualStyleBackColor = True
        '
        'option_monday_to_friday
        '
        Me.option_monday_to_friday.AutoSize = True
        Me.option_monday_to_friday.Location = New System.Drawing.Point(169, 95)
        Me.option_monday_to_friday.Name = "option_monday_to_friday"
        Me.option_monday_to_friday.Size = New System.Drawing.Size(110, 17)
        Me.option_monday_to_friday.TabIndex = 13
        Me.option_monday_to_friday.TabStop = True
        Me.option_monday_to_friday.Text = "Monday To Friday"
        Me.option_monday_to_friday.UseVisualStyleBackColor = True
        '
        'option_weekly_on
        '
        Me.option_weekly_on.AutoSize = True
        Me.option_weekly_on.Location = New System.Drawing.Point(8, 122)
        Me.option_weekly_on.Name = "option_weekly_on"
        Me.option_weekly_on.Size = New System.Drawing.Size(81, 17)
        Me.option_weekly_on.TabIndex = 12
        Me.option_weekly_on.TabStop = True
        Me.option_weekly_on.Text = "Weekly On:"
        Me.option_weekly_on.UseVisualStyleBackColor = True
        '
        'option_every_day
        '
        Me.option_every_day.AutoSize = True
        Me.option_every_day.Location = New System.Drawing.Point(89, 95)
        Me.option_every_day.Name = "option_every_day"
        Me.option_every_day.Size = New System.Drawing.Size(74, 17)
        Me.option_every_day.TabIndex = 11
        Me.option_every_day.TabStop = True
        Me.option_every_day.Text = "Every Day"
        Me.option_every_day.UseVisualStyleBackColor = True
        '
        'option_once_only
        '
        Me.option_once_only.AutoSize = True
        Me.option_once_only.Location = New System.Drawing.Point(8, 95)
        Me.option_once_only.Name = "option_once_only"
        Me.option_once_only.Size = New System.Drawing.Size(75, 17)
        Me.option_once_only.TabIndex = 10
        Me.option_once_only.TabStop = True
        Me.option_once_only.Text = "Once Only"
        Me.option_once_only.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "'Date:   ' dddd, MMMM dd, yyyy                   'Time:   'hh:mm tt "
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(189, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(458, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Set Start Date and Time:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Reminder Text (50 characters max):"
        '
        'reminder_textbox
        '
        Me.reminder_textbox.Location = New System.Drawing.Point(189, 13)
        Me.reminder_textbox.MaxLength = 75
        Me.reminder_textbox.Name = "reminder_textbox"
        Me.reminder_textbox.Size = New System.Drawing.Size(456, 20)
        Me.reminder_textbox.TabIndex = 0
        '
        'reminder_pop_up
        '
        Me.reminder_pop_up.Controls.Add(Me.snooze_choice)
        Me.reminder_pop_up.Controls.Add(Me.snooze_button)
        Me.reminder_pop_up.Controls.Add(Me.dismiss_button)
        Me.reminder_pop_up.Controls.Add(Me.GroupBox1)
        Me.reminder_pop_up.Controls.Add(Me.reminder_window)
        Me.reminder_pop_up.Location = New System.Drawing.Point(4, 22)
        Me.reminder_pop_up.Name = "reminder_pop_up"
        Me.reminder_pop_up.Padding = New System.Windows.Forms.Padding(3)
        Me.reminder_pop_up.Size = New System.Drawing.Size(653, 153)
        Me.reminder_pop_up.TabIndex = 2
        Me.reminder_pop_up.Text = "Reminder!"
        Me.reminder_pop_up.UseVisualStyleBackColor = True
        '
        'snooze_choice
        '
        Me.snooze_choice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.snooze_choice.FormattingEnabled = True
        Me.snooze_choice.Items.AddRange(New Object() {"5 minutes", "10 minutes", "15 minutes", "30 minutes", "1 hour", "2 hours", "4 hours"})
        Me.snooze_choice.Location = New System.Drawing.Point(504, 72)
        Me.snooze_choice.Name = "snooze_choice"
        Me.snooze_choice.Size = New System.Drawing.Size(141, 21)
        Me.snooze_choice.TabIndex = 17
        '
        'snooze_button
        '
        Me.snooze_button.Location = New System.Drawing.Point(269, 70)
        Me.snooze_button.Name = "snooze_button"
        Me.snooze_button.Size = New System.Drawing.Size(229, 23)
        Me.snooze_button.TabIndex = 16
        Me.snooze_button.Text = "Snooze Reminder For:"
        Me.snooze_button.UseVisualStyleBackColor = True
        '
        'dismiss_button
        '
        Me.dismiss_button.Location = New System.Drawing.Point(6, 70)
        Me.dismiss_button.Name = "dismiss_button"
        Me.dismiss_button.Size = New System.Drawing.Size(229, 23)
        Me.dismiss_button.TabIndex = 15
        Me.dismiss_button.Text = "Dismiss Reminder"
        Me.dismiss_button.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.reminder_DateTimePicker)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 48)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "For variable day reminders, please choose the next date and time:"
        '
        'reminder_DateTimePicker
        '
        Me.reminder_DateTimePicker.CustomFormat = "'Date:   ' dddd, MMMM dd, yyyy                   'Time:   'hh:mm tt "
        Me.reminder_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.reminder_DateTimePicker.Location = New System.Drawing.Point(170, 19)
        Me.reminder_DateTimePicker.Name = "reminder_DateTimePicker"
        Me.reminder_DateTimePicker.Size = New System.Drawing.Size(463, 20)
        Me.reminder_DateTimePicker.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Next Reminder Date and Time:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'reminder_window
        '
        Me.reminder_window.BackColor = System.Drawing.Color.White
        Me.reminder_window.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.reminder_window.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reminder_window.Location = New System.Drawing.Point(6, 9)
        Me.reminder_window.Name = "reminder_window"
        Me.reminder_window.Size = New System.Drawing.Size(641, 55)
        Me.reminder_window.TabIndex = 13
        Me.reminder_window.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Reminder Program"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(101, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(100, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'reminder_check_timer
        '
        Me.reminder_check_timer.Interval = 60000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(669, 234)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(669, 234)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reminder Program"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.current_reminders.ResumeLayout(False)
        Me.current_reminders.PerformLayout()
        Me.edit_reminder.ResumeLayout(False)
        Me.edit_reminder.PerformLayout()
        Me.reminder_pop_up.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateReminderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents current_reminders As System.Windows.Forms.TabPage
    Friend WithEvents edit_reminder As System.Windows.Forms.TabPage
    Friend WithEvents EditSelectedReminderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelectedReminderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reminder_textbox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SaveReminderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents monthly_on_day_selector As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents option_monthly_on_day As System.Windows.Forms.RadioButton
    Friend WithEvents option_monthly_variable As System.Windows.Forms.RadioButton
    Friend WithEvents option_monday_to_friday As System.Windows.Forms.RadioButton
    Friend WithEvents option_weekly_on As System.Windows.Forms.RadioButton
    Friend WithEvents option_every_day As System.Windows.Forms.RadioButton
    Friend WithEvents option_once_only As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox_saturday As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_friday As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_thursday As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_wednesday As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_tuesday As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_monday As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_sunday As System.Windows.Forms.CheckBox
    Friend WithEvents MinimizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents reminder_recurrence_6 As System.Windows.Forms.Label
    Friend WithEvents reminder_recurrence_5 As System.Windows.Forms.Label
    Friend WithEvents reminder_recurrence_4 As System.Windows.Forms.Label
    Friend WithEvents reminder_recurrence_3 As System.Windows.Forms.Label
    Friend WithEvents reminder_recurrence_2 As System.Windows.Forms.Label
    Friend WithEvents reminder_recurrence_1 As System.Windows.Forms.Label
    Friend WithEvents reminder_time_6 As System.Windows.Forms.Label
    Friend WithEvents reminder_time_5 As System.Windows.Forms.Label
    Friend WithEvents reminder_time_4 As System.Windows.Forms.Label
    Friend WithEvents reminder_time_3 As System.Windows.Forms.Label
    Friend WithEvents reminder_time_2 As System.Windows.Forms.Label
    Friend WithEvents reminder_time_1 As System.Windows.Forms.Label
    Friend WithEvents reminder_date_6 As System.Windows.Forms.Label
    Friend WithEvents reminder_date_5 As System.Windows.Forms.Label
    Friend WithEvents reminder_date_4 As System.Windows.Forms.Label
    Friend WithEvents reminder_date_3 As System.Windows.Forms.Label
    Friend WithEvents reminder_date_2 As System.Windows.Forms.Label
    Friend WithEvents reminder_date_1 As System.Windows.Forms.Label
    Friend WithEvents reminder_text_6 As System.Windows.Forms.Label
    Friend WithEvents reminder_text_5 As System.Windows.Forms.Label
    Friend WithEvents reminder_text_4 As System.Windows.Forms.Label
    Friend WithEvents reminder_text_3 As System.Windows.Forms.Label
    Friend WithEvents reminder_text_2 As System.Windows.Forms.Label
    Friend WithEvents reminder_text_1 As System.Windows.Forms.Label
    Friend WithEvents reminder_button_6 As System.Windows.Forms.RadioButton
    Friend WithEvents reminder_button_5 As System.Windows.Forms.RadioButton
    Friend WithEvents reminder_button_4 As System.Windows.Forms.RadioButton
    Friend WithEvents reminder_button_3 As System.Windows.Forms.RadioButton
    Friend WithEvents reminder_button_2 As System.Windows.Forms.RadioButton
    Friend WithEvents reminder_button_1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents reminders_scroll_down As System.Windows.Forms.Button
    Friend WithEvents reminders_scroll_up As System.Windows.Forms.Button
    Friend WithEvents reminder_pop_up As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents reminder_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents reminder_window As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents snooze_choice As System.Windows.Forms.ComboBox
    Friend WithEvents snooze_button As System.Windows.Forms.Button
    Friend WithEvents dismiss_button As System.Windows.Forms.Button
    Friend WithEvents reminder_check_timer As System.Windows.Forms.Timer

End Class
