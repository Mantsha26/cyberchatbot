using System.Drawing;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CyberGuard
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private System.Windows.Forms.GroupBox grpQuiz;
        private System.Windows.Forms.Label lblQuizQuestion;
        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionC;
        private System.Windows.Forms.RadioButton rbOptionD;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnEndQuiz;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFeedback;



        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtConversation = new System.Windows.Forms.RichTextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lstTopics = new System.Windows.Forms.ListBox();
            this.grpUserProfile = new System.Windows.Forms.GroupBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.lblFavourite = new System.Windows.Forms.Label();
            this.lblLastTopic = new System.Windows.Forms.Label();
            this.lblMood = new System.Windows.Forms.Label();
            this.grpTaskAssistant = new System.Windows.Forms.GroupBox();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.txtTaskDesc = new System.Windows.Forms.TextBox();
            this.chkReminder = new System.Windows.Forms.CheckBox();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.lblIn5Days = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblYourTasks = new System.Windows.Forms.Label();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.grpActivityLog = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChat = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSetName = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuizQuestion = new System.Windows.Forms.Label();
            this.grpQuiz = new System.Windows.Forms.GroupBox();
            this.rbOptionA = new System.Windows.Forms.RadioButton();
            this.rbOptionB = new System.Windows.Forms.RadioButton();
            this.rbOptionC = new System.Windows.Forms.RadioButton();
            this.rbOptionD = new System.Windows.Forms.RadioButton();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnEndQuiz = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.grpUserProfile.SuspendLayout();
            this.grpTaskAssistant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpActivityLog)).BeginInit();
            this.grpChat.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConversation
            // 
            this.txtConversation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.txtConversation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConversation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConversation.ForeColor = System.Drawing.Color.White;
            this.txtConversation.Location = new System.Drawing.Point(10, 25);
            this.txtConversation.Name = "txtConversation";
            this.txtConversation.ReadOnly = true;
            this.txtConversation.Size = new System.Drawing.Size(530, 340);
            this.txtConversation.TabIndex = 0;
            this.txtConversation.Text = "";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.ForeColor = System.Drawing.Color.White;
            this.txtMessage.Location = new System.Drawing.Point(10, 375);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(430, 30);
            this.txtMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(450, 373);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 30);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lstTopics
            // 
            this.lstTopics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.lstTopics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTopics.Font = new System.Drawing.Font("Consolas", 10F);
            this.lstTopics.ForeColor = System.Drawing.Color.Cyan;
            this.lstTopics.ItemHeight = 20;
            this.lstTopics.Location = new System.Drawing.Point(12, 30);
            this.lstTopics.Name = "lstTopics";
            this.lstTopics.Size = new System.Drawing.Size(220, 342);
            this.lstTopics.TabIndex = 0;
            // 
            // grpUserProfile
            // 
            this.grpUserProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.grpUserProfile.Controls.Add(this.lblUser);
            this.grpUserProfile.Controls.Add(this.lblQuestions);
            this.grpUserProfile.Controls.Add(this.lblFavourite);
            this.grpUserProfile.Controls.Add(this.lblLastTopic);
            this.grpUserProfile.Controls.Add(this.lblMood);
            this.grpUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpUserProfile.ForeColor = System.Drawing.Color.White;
            this.grpUserProfile.Location = new System.Drawing.Point(12, 390);
            this.grpUserProfile.Name = "grpUserProfile";
            this.grpUserProfile.Size = new System.Drawing.Size(220, 180);
            this.grpUserProfile.TabIndex = 1;
            this.grpUserProfile.TabStop = false;
            this.grpUserProfile.Text = "USER PROFILE";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.LightGray;
            this.lblUser.Location = new System.Drawing.Point(10, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(97, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Name: Alex";
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.ForeColor = System.Drawing.Color.LightGray;
            this.lblQuestions.Location = new System.Drawing.Point(10, 55);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(163, 23);
            this.lblQuestions.TabIndex = 1;
            this.lblQuestions.Text = "Questions Asked: 12";
            // 
            // lblFavourite
            // 
            this.lblFavourite.AutoSize = true;
            this.lblFavourite.ForeColor = System.Drawing.Color.LightGray;
            this.lblFavourite.Location = new System.Drawing.Point(10, 85);
            this.lblFavourite.Name = "lblFavourite";
            this.lblFavourite.Size = new System.Drawing.Size(185, 23);
            this.lblFavourite.TabIndex = 2;
            this.lblFavourite.Text = "Favourite Topic: Privacy";
            // 
            // lblLastTopic
            // 
            this.lblLastTopic.AutoSize = true;
            this.lblLastTopic.ForeColor = System.Drawing.Color.LightGray;
            this.lblLastTopic.Location = new System.Drawing.Point(10, 115);
            this.lblLastTopic.Name = "lblLastTopic";
            this.lblLastTopic.Size = new System.Drawing.Size(214, 23);
            this.lblLastTopic.TabIndex = 3;
            this.lblLastTopic.Text = "Last Topic: Password Safety";
            // 
            // lblMood
            // 
            this.lblMood.AutoSize = true;
            this.lblMood.ForeColor = System.Drawing.Color.Gold;
            this.lblMood.Location = new System.Drawing.Point(10, 145);
            this.lblMood.Name = "lblMood";
            this.lblMood.Size = new System.Drawing.Size(185, 23);
            this.lblMood.TabIndex = 4;
            this.lblMood.Text = "Current Mood: Curious";
            // 
            // grpTaskAssistant
            // 
            this.grpTaskAssistant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.grpTaskAssistant.Controls.Add(this.lblAddNew);
            this.grpTaskAssistant.Controls.Add(this.txtTaskTitle);
            this.grpTaskAssistant.Controls.Add(this.txtTaskDesc);
            this.grpTaskAssistant.Controls.Add(this.chkReminder);
            this.grpTaskAssistant.Controls.Add(this.dtpReminder);
            this.grpTaskAssistant.Controls.Add(this.lblIn5Days);
            this.grpTaskAssistant.Controls.Add(this.btnAddTask);
            this.grpTaskAssistant.Controls.Add(this.lblYourTasks);
            this.grpTaskAssistant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTaskAssistant.ForeColor = System.Drawing.Color.White;
            this.grpTaskAssistant.Location = new System.Drawing.Point(810, 30);
            this.grpTaskAssistant.Name = "grpTaskAssistant";
            this.grpTaskAssistant.Size = new System.Drawing.Size(360, 240);
            this.grpTaskAssistant.TabIndex = 3;
            this.grpTaskAssistant.TabStop = false;
            this.grpTaskAssistant.Text = "TASK ASSISTANT";
            // 
            // lblAddNew
            // 
            this.lblAddNew.ForeColor = System.Drawing.Color.Cyan;
            this.lblAddNew.Location = new System.Drawing.Point(10, 20);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(150, 20);
            this.lblAddNew.TabIndex = 0;
            this.lblAddNew.Text = "Add New Task";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtTaskTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskTitle.ForeColor = System.Drawing.Color.White;
            this.txtTaskTitle.Location = new System.Drawing.Point(10, 45);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(340, 30);
            this.txtTaskTitle.TabIndex = 1;
            // 
            // txtTaskDesc
            // 
            this.txtTaskDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtTaskDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskDesc.ForeColor = System.Drawing.Color.Gray;
            this.txtTaskDesc.Location = new System.Drawing.Point(10, 80);
            this.txtTaskDesc.Name = "txtTaskDesc";
            this.txtTaskDesc.Size = new System.Drawing.Size(340, 30);
            this.txtTaskDesc.TabIndex = 2;
            this.txtTaskDesc.Text = "Enter task description...";
            // 
            // chkReminder
            // 
            this.chkReminder.ForeColor = System.Drawing.Color.White;
            this.chkReminder.Location = new System.Drawing.Point(10, 115);
            this.chkReminder.Name = "chkReminder";
            this.chkReminder.Size = new System.Drawing.Size(140, 25);
            this.chkReminder.TabIndex = 3;
            this.chkReminder.Text = "Reminder (Optional):";
            // 
            // dtpReminder
            // 
            this.dtpReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.dtpReminder.ForeColor = System.Drawing.Color.White;
            this.dtpReminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReminder.Location = new System.Drawing.Point(160, 115);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(120, 30);
            this.dtpReminder.TabIndex = 4;
            this.dtpReminder.Value = new System.DateTime(2025, 5, 18, 0, 0, 0, 0);
            // 
            // lblIn5Days
            // 
            this.lblIn5Days.ForeColor = System.Drawing.Color.LightGray;
            this.lblIn5Days.Location = new System.Drawing.Point(290, 118);
            this.lblIn5Days.Name = "lblIn5Days";
            this.lblIn5Days.Size = new System.Drawing.Size(70, 20);
            this.lblIn5Days.TabIndex = 5;
            this.lblIn5Days.Text = "In 5 days";
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(100)))));
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(10, 155);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(340, 30);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblYourTasks
            // 
            this.lblYourTasks.ForeColor = System.Drawing.Color.Cyan;
            this.lblYourTasks.Location = new System.Drawing.Point(10, 195);
            this.lblYourTasks.Name = "lblYourTasks";
            this.lblYourTasks.Size = new System.Drawing.Size(150, 20);
            this.lblYourTasks.TabIndex = 7;
            this.lblYourTasks.Text = "YOUR TASKS";
            // 
            // lstTasks
            // 
            this.lstTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.lstTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstTasks.ForeColor = System.Drawing.Color.LightGray;
            this.lstTasks.ItemHeight = 20;
            this.lstTasks.Items.AddRange(new object[] {
            "",
            "",
            ""});
            this.lstTasks.Location = new System.Drawing.Point(810, 280);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(360, 82);
            this.lstTasks.TabIndex = 4;
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnCompleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteTask.ForeColor = System.Drawing.Color.White;
            this.btnCompleteTask.Location = new System.Drawing.Point(810, 390);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(360, 30);
            this.btnCompleteTask.TabIndex = 5;
            this.btnCompleteTask.Text = "Mark Selected as Complete";
            this.btnCompleteTask.UseVisualStyleBackColor = false;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // grpActivityLog
            // 
            this.grpActivityLog.AllowUserToAddRows = false;
            this.grpActivityLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grpActivityLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grpActivityLog.ColumnHeadersHeight = 29;
            this.grpActivityLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grpActivityLog.DefaultCellStyle = dataGridViewCellStyle2;
            this.grpActivityLog.EnableHeadersVisualStyles = false;
            this.grpActivityLog.Location = new System.Drawing.Point(810, 441);
            this.grpActivityLog.Name = "grpActivityLog";
            this.grpActivityLog.ReadOnly = true;
            this.grpActivityLog.RowHeadersVisible = false;
            this.grpActivityLog.RowHeadersWidth = 51;
            this.grpActivityLog.Size = new System.Drawing.Size(360, 200);
            this.grpActivityLog.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // grpChat
            // 
            this.grpChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.grpChat.Controls.Add(this.txtConversation);
            this.grpChat.Controls.Add(this.txtMessage);
            this.grpChat.Controls.Add(this.btnSend);
            this.grpChat.Controls.Add(this.txtName);
            this.grpChat.Controls.Add(this.btnSetName);
            this.grpChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpChat.ForeColor = System.Drawing.Color.White;
            this.grpChat.Location = new System.Drawing.Point(245, 30);
            this.grpChat.Name = "grpChat";
            this.grpChat.Size = new System.Drawing.Size(550, 450);
            this.grpChat.TabIndex = 2;
            this.grpChat.TabStop = false;
            this.grpChat.Text = "CHAT CONVERSATION";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(10, 410);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 30);
            this.txtName.TabIndex = 3;
            // 
            // btnSetName
            // 
            this.btnSetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnSetName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetName.ForeColor = System.Drawing.Color.White;
            this.btnSetName.Location = new System.Drawing.Point(360, 408);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(180, 30);
            this.btnSetName.TabIndex = 4;
            this.btnSetName.Text = "Set Name";
            this.btnSetName.UseVisualStyleBackColor = false;
            this.btnSetName.Click += new System.EventHandler(this.btnSetName_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 10;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // lblQuizQuestion
            // 
            this.lblQuizQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuizQuestion.Location = new System.Drawing.Point(20, 67);
            this.lblQuizQuestion.Name = "lblQuizQuestion";
            this.lblQuizQuestion.Size = new System.Drawing.Size(500, 40);
            this.lblQuizQuestion.TabIndex = 0;
            this.lblQuizQuestion.Text = "What should you do if you receive an email asking for your password?";
            // 
            // grpQuiz
            // 
            this.grpQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.grpQuiz.Controls.Add(this.lblQuizQuestion);
            this.grpQuiz.Controls.Add(this.rbOptionA);
            this.grpQuiz.Controls.Add(this.rbOptionB);
            this.grpQuiz.Controls.Add(this.rbOptionC);
            this.grpQuiz.Controls.Add(this.rbOptionD);
            this.grpQuiz.Controls.Add(this.lblScore);
            this.grpQuiz.Controls.Add(this.btnNextQuestion);
            this.grpQuiz.Controls.Add(this.btnEndQuiz);
            this.grpQuiz.ForeColor = System.Drawing.Color.White;
            this.grpQuiz.Location = new System.Drawing.Point(245, 490);
            this.grpQuiz.Name = "grpQuiz";
            this.grpQuiz.Size = new System.Drawing.Size(550, 170);
            this.grpQuiz.TabIndex = 0;
            this.grpQuiz.TabStop = false;
            this.grpQuiz.Text = "CYBERSECURITY QUIZ";
            // 
            // rbOptionA
            // 
            this.rbOptionA.Location = new System.Drawing.Point(24, 40);
            this.rbOptionA.Name = "rbOptionA";
            this.rbOptionA.Size = new System.Drawing.Size(104, 24);
            this.rbOptionA.TabIndex = 1;
            // 
            // rbOptionB
            // 
            this.rbOptionB.Location = new System.Drawing.Point(134, 44);
            this.rbOptionB.Name = "rbOptionB";
            this.rbOptionB.Size = new System.Drawing.Size(104, 24);
            this.rbOptionB.TabIndex = 2;
            // 
            // rbOptionC
            // 
            this.rbOptionC.Location = new System.Drawing.Point(244, 44);
            this.rbOptionC.Name = "rbOptionC";
            this.rbOptionC.Size = new System.Drawing.Size(104, 24);
            this.rbOptionC.TabIndex = 3;
            // 
            // rbOptionD
            // 
            this.rbOptionD.Location = new System.Drawing.Point(360, 45);
            this.rbOptionD.Name = "rbOptionD";
            this.rbOptionD.Size = new System.Drawing.Size(104, 24);
            this.rbOptionD.TabIndex = 4;
            // 
            // lblScore
            // 
            this.lblScore.ForeColor = System.Drawing.Color.Gold;
            this.lblScore.Location = new System.Drawing.Point(424, 15);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(120, 30);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: 0/10";
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Location = new System.Drawing.Point(350, 120);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnNextQuestion.TabIndex = 6;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnEndQuiz
            // 
            this.btnEndQuiz.Location = new System.Drawing.Point(72, 127);
            this.btnEndQuiz.Name = "btnEndQuiz";
            this.btnEndQuiz.Size = new System.Drawing.Size(75, 23);
            this.btnEndQuiz.TabIndex = 7;
            this.btnEndQuiz.Text = "End Quiz";
            this.btnEndQuiz.Click += new System.EventHandler(this.btnEndQuiz_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.Location = new System.Drawing.Point(0, 0);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(100, 23);
            this.lblFeedback.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.ForeColor = System.Drawing.Color.Gray;
            this.lblVersion.Location = new System.Drawing.Point(12, 640);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(150, 20);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "CyberGuard v1.0";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.grpQuiz);
            this.Controls.Add(this.lstTopics);
            this.Controls.Add(this.grpUserProfile);
            this.Controls.Add(this.grpChat);
            this.Controls.Add(this.grpTaskAssistant);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.btnCompleteTask);
            this.Controls.Add(this.grpActivityLog);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblVersion);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CyberGuard - Cybersecurity Awareness Chatbot";
            this.grpUserProfile.ResumeLayout(false);
            this.grpUserProfile.PerformLayout();
            this.grpTaskAssistant.ResumeLayout(false);
            this.grpTaskAssistant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpActivityLog)).EndInit();
            this.grpChat.ResumeLayout(false);
            this.grpChat.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpQuiz.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Control declarations
        private System.Windows.Forms.RichTextBox txtConversation;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstTopics;
        private System.Windows.Forms.GroupBox grpUserProfile;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Label lblFavourite;
        private System.Windows.Forms.Label lblLastTopic;
        private System.Windows.Forms.Label lblMood;
        private System.Windows.Forms.GroupBox grpTaskAssistant;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtTaskDesc;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.CheckBox chkReminder;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.DataGridView grpActivityLog;
        private System.Windows.Forms.GroupBox grpChat;
        private System.Windows.Forms.Button btnSetName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Label lblAddNew;
        private Label lblIn5Days;
        private Label lblYourTasks;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label lblVersion;
    }
}