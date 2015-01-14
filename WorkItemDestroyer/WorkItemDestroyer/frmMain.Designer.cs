namespace WorkItemDestroyer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtSourceID = new System.Windows.Forms.RichTextBox();
            this.lblSourceID = new System.Windows.Forms.Label();
            this.txtCommands = new System.Windows.Forms.RichTextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblCollectionURL = new System.Windows.Forms.Label();
            this.lblBatchSize = new System.Windows.Forms.Label();
            this.txtCollectionURL = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBatchSize = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.chkNoPrompt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(343, 548);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(120, 27);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate Commands";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtSourceID
            // 
            this.txtSourceID.Location = new System.Drawing.Point(12, 30);
            this.txtSourceID.Name = "txtSourceID";
            this.txtSourceID.Size = new System.Drawing.Size(161, 545);
            this.txtSourceID.TabIndex = 1;
            this.txtSourceID.Text = "";
            // 
            // lblSourceID
            // 
            this.lblSourceID.AutoSize = true;
            this.lblSourceID.Location = new System.Drawing.Point(12, 9);
            this.lblSourceID.Name = "lblSourceID";
            this.lblSourceID.Size = new System.Drawing.Size(70, 17);
            this.lblSourceID.TabIndex = 2;
            this.lblSourceID.Text = "Source ID";
            // 
            // txtCommands
            // 
            this.txtCommands.Location = new System.Drawing.Point(179, 114);
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.Size = new System.Drawing.Size(284, 428);
            this.txtCommands.TabIndex = 3;
            this.txtCommands.Text = "";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(179, 94);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(78, 17);
            this.lblCommand.TabIndex = 4;
            this.lblCommand.Text = "Commands";
            // 
            // lblCollectionURL
            // 
            this.lblCollectionURL.AutoSize = true;
            this.lblCollectionURL.Location = new System.Drawing.Point(179, 30);
            this.lblCollectionURL.Name = "lblCollectionURL";
            this.lblCollectionURL.Size = new System.Drawing.Size(101, 17);
            this.lblCollectionURL.TabIndex = 5;
            this.lblCollectionURL.Text = "Collection URL";
            // 
            // lblBatchSize
            // 
            this.lblBatchSize.AutoSize = true;
            this.lblBatchSize.Location = new System.Drawing.Point(179, 63);
            this.lblBatchSize.Name = "lblBatchSize";
            this.lblBatchSize.Size = new System.Drawing.Size(73, 17);
            this.lblBatchSize.TabIndex = 6;
            this.lblBatchSize.Text = "Batch size";
            // 
            // txtCollectionURL
            // 
            this.txtCollectionURL.Location = new System.Drawing.Point(276, 27);
            this.txtCollectionURL.Name = "txtCollectionURL";
            this.txtCollectionURL.Size = new System.Drawing.Size(300, 22);
            this.txtCollectionURL.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(582, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse TFS";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBatchSize
            // 
            this.txtBatchSize.Location = new System.Drawing.Point(276, 60);
            this.txtBatchSize.Name = "txtBatchSize";
            this.txtBatchSize.Size = new System.Drawing.Size(54, 22);
            this.txtBatchSize.TabIndex = 9;
            this.txtBatchSize.Text = "50";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(469, 114);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(251, 428);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // chkNoPrompt
            // 
            this.chkNoPrompt.AutoSize = true;
            this.chkNoPrompt.Location = new System.Drawing.Point(343, 59);
            this.chkNoPrompt.Name = "chkNoPrompt";
            this.chkNoPrompt.Size = new System.Drawing.Size(97, 21);
            this.chkNoPrompt.TabIndex = 11;
            this.chkNoPrompt.Text = "No Prompt";
            this.chkNoPrompt.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 587);
            this.Controls.Add(this.chkNoPrompt);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.txtBatchSize);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtCollectionURL);
            this.Controls.Add(this.lblBatchSize);
            this.Controls.Add(this.lblCollectionURL);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.txtCommands);
            this.Controls.Add(this.lblSourceID);
            this.Controls.Add(this.txtSourceID);
            this.Controls.Add(this.btnGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Work Item Destroyer - RoadToALM.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox txtSourceID;
        private System.Windows.Forms.Label lblSourceID;
        private System.Windows.Forms.RichTextBox txtCommands;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblCollectionURL;
        private System.Windows.Forms.Label lblBatchSize;
        private System.Windows.Forms.TextBox txtCollectionURL;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtBatchSize;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckBox chkNoPrompt;
    }
}

