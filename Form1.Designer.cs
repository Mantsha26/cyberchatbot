using System;
using System.Windows.Forms;
using System.Drawing;

namespace CyberGuard
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls used by the form (minimal set required by code)
        private System.Windows.Forms.RichTextBox txtConversation;
        private System.Windows.Forms.ListBox lstTopics;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblMood;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblFavourite;
        private System.Windows.Forms.Label lblLastTopic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSetName;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// This implementation creates the minimal controls used by the logic in Form1.cs.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtConversation = new System.Windows.Forms.RichTextBox();
            this.lstTopics = new System.Windows.Forms.ListBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblMood = new System.Windows.Forms.Label();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblFavourite = new System.Windows.Forms.Label();
            this.lblLastTopic = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSetName = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtConversation
            // 
            this.txtConversation.BackColor = System.Drawing.Color.White;
            this.txtConversation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConversation.Location = new System.Drawing.Point(20, 40);
            this.txtConversation.Name = "txtConversation";
            this.txtConversation.ReadOnly = true;
            this.txtConversation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtConversation.Size = new System.Drawing.Size(500, 260);
            this.txtConversation.TabIndex = 1;
            this.txtConversation.Text = "";
            // 
            // lstTopics
            // 
            this.lstTopics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstTopics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstTopics.ItemHeight = 20;
            this.lstTopics.Location = new System.Drawing.Point(540, 40);
            this.lstTopics.Name = "lstTopics";
            this.lstTopics.Size = new System.Drawing.Size(249, 264);
            this.lstTopics.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMessage.Location = new System.Drawing.Point(20, 320);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(400, 30);
            this.txtMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(430, 320);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 35);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblMood
            // 
            this.lblMood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMood.Location = new System.Drawing.Point(20, 430);
            this.lblMood.Name = "lblMood";
            this.lblMood.Size = new System.Drawing.Size(250, 25);
            this.lblMood.TabIndex = 7;
            // 
            // lblQuestions
            // 
            this.lblQuestions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuestions.Location = new System.Drawing.Point(20, 460);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(250, 25);
            this.lblQuestions.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUser.Location = new System.Drawing.Point(20, 490);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(250, 25);
            this.lblUser.TabIndex = 9;
            // 
            // lblFavourite
            // 
            this.lblFavourite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFavourite.Location = new System.Drawing.Point(280, 430);
            this.lblFavourite.Name = "lblFavourite";
            this.lblFavourite.Size = new System.Drawing.Size(400, 25);
            this.lblFavourite.TabIndex = 10;
            // 
            // lblLastTopic
            // 
            this.lblLastTopic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastTopic.Location = new System.Drawing.Point(280, 460);
            this.lblLastTopic.Name = "lblLastTopic";
            this.lblLastTopic.Size = new System.Drawing.Size(400, 25);
            this.lblLastTopic.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(20, 370);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 22);
            this.txtName.TabIndex = 5;
            // 
            // btnSetName
            // 
            this.btnSetName.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSetName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetName.ForeColor = System.Drawing.Color.White;
            this.btnSetName.Location = new System.Drawing.Point(250, 370);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(100, 35);
            this.btnSetName.TabIndex = 6;
            this.btnSetName.Text = "Set Name";
            this.btnSetName.UseVisualStyleBackColor = false;
            this.btnSetName.Click += new System.EventHandler(this.btnSetName_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(822, 550);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtConversation);
            this.Controls.Add(this.lstTopics);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSetName);
            this.Controls.Add(this.lblMood);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblFavourite);
            this.Controls.Add(this.lblLastTopic);
            this.Name = "MainForm";
            this.Text = "CyberGuard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
