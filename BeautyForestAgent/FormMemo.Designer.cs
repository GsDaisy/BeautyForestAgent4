namespace BeautyForestAgent
{
    partial class FormMemo
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
            this.Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.savaFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.tabMode = new System.Windows.Forms.TabControl();
            this.tpRead = new System.Windows.Forms.TabPage();
            this.tbWrite = new System.Windows.Forms.TabPage();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.btnLoadFileSelect = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtLoadText = new System.Windows.Forms.TextBox();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.txtSaveText = new System.Windows.Forms.TextBox();
            this.btnSaveFileSelect = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.Status.SuspendLayout();
            this.tabMode.SuspendLayout();
            this.tpRead.SuspendLayout();
            this.tbWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.Status.Location = new System.Drawing.Point(0, 319);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(485, 22);
            this.Status.SizingGrip = false;
            this.Status.TabIndex = 0;
            this.Status.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(168, 17);
            this.toolStripStatusLabel1.Text = "3509 윤수영 - 파일 읽고 쓰기";
            // 
            // loadFileDlg
            // 
            this.loadFileDlg.FileName = "openFileDialog1";
            this.loadFileDlg.Filter = "텍스트 파일(*.txt)|*.txt|모든파일 (*.*)|*.*";
            // 
            // savaFileDlg
            // 
            this.savaFileDlg.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // tabMode
            // 
            this.tabMode.Controls.Add(this.tpRead);
            this.tabMode.Controls.Add(this.tbWrite);
            this.tabMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMode.Location = new System.Drawing.Point(0, 0);
            this.tabMode.Name = "tabMode";
            this.tabMode.SelectedIndex = 0;
            this.tabMode.Size = new System.Drawing.Size(485, 319);
            this.tabMode.TabIndex = 1;
            // 
            // tpRead
            // 
            this.tpRead.Controls.Add(this.txtLoadText);
            this.tpRead.Controls.Add(this.btnLoadFile);
            this.tpRead.Controls.Add(this.btnLoadFileSelect);
            this.tpRead.Controls.Add(this.txtLoadFile);
            this.tpRead.Location = new System.Drawing.Point(4, 22);
            this.tpRead.Name = "tpRead";
            this.tpRead.Padding = new System.Windows.Forms.Padding(3);
            this.tpRead.Size = new System.Drawing.Size(477, 293);
            this.tpRead.TabIndex = 0;
            this.tpRead.Text = "파일 읽기";
            this.tpRead.UseVisualStyleBackColor = true;
            // 
            // tbWrite
            // 
            this.tbWrite.Controls.Add(this.btnSaveFile);
            this.tbWrite.Controls.Add(this.btnSaveFileSelect);
            this.tbWrite.Controls.Add(this.txtSaveText);
            this.tbWrite.Controls.Add(this.txtSaveFile);
            this.tbWrite.Location = new System.Drawing.Point(4, 22);
            this.tbWrite.Name = "tbWrite";
            this.tbWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tbWrite.Size = new System.Drawing.Size(477, 293);
            this.tbWrite.TabIndex = 1;
            this.tbWrite.Text = "파일 쓰기";
            this.tbWrite.UseVisualStyleBackColor = true;
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Location = new System.Drawing.Point(9, 7);
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.ReadOnly = true;
            this.txtLoadFile.Size = new System.Drawing.Size(295, 21);
            this.txtLoadFile.TabIndex = 0;
            // 
            // btnLoadFileSelect
            // 
            this.btnLoadFileSelect.Location = new System.Drawing.Point(310, 7);
            this.btnLoadFileSelect.Name = "btnLoadFileSelect";
            this.btnLoadFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFileSelect.TabIndex = 1;
            this.btnLoadFileSelect.Text = "파일 선택";
            this.btnLoadFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(392, 7);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "불러오기";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            // 
            // txtLoadText
            // 
            this.txtLoadText.Location = new System.Drawing.Point(9, 35);
            this.txtLoadText.Multiline = true;
            this.txtLoadText.Name = "txtLoadText";
            this.txtLoadText.ReadOnly = true;
            this.txtLoadText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLoadText.Size = new System.Drawing.Size(458, 252);
            this.txtLoadText.TabIndex = 3;
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(7, 7);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.ReadOnly = true;
            this.txtSaveFile.Size = new System.Drawing.Size(285, 21);
            this.txtSaveFile.TabIndex = 0;
            // 
            // txtSaveText
            // 
            this.txtSaveText.Location = new System.Drawing.Point(7, 35);
            this.txtSaveText.Multiline = true;
            this.txtSaveText.Name = "txtSaveText";
            this.txtSaveText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSaveText.Size = new System.Drawing.Size(449, 238);
            this.txtSaveText.TabIndex = 1;
            // 
            // btnSaveFileSelect
            // 
            this.btnSaveFileSelect.Location = new System.Drawing.Point(299, 7);
            this.btnSaveFileSelect.Name = "btnSaveFileSelect";
            this.btnSaveFileSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFileSelect.TabIndex = 2;
            this.btnSaveFileSelect.Text = "파일 선택";
            this.btnSaveFileSelect.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(381, 7);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "저장하기";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // FormMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 341);
            this.Controls.Add(this.tabMode);
            this.Controls.Add(this.Status);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMemo";
            this.Text = "3509 윤수영";
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.tabMode.ResumeLayout(false);
            this.tpRead.ResumeLayout(false);
            this.tpRead.PerformLayout();
            this.tbWrite.ResumeLayout(false);
            this.tbWrite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog loadFileDlg;
        private System.Windows.Forms.SaveFileDialog savaFileDlg;
        private System.Windows.Forms.TabControl tabMode;
        private System.Windows.Forms.TabPage tpRead;
        private System.Windows.Forms.TabPage tbWrite;
        private System.Windows.Forms.TextBox txtLoadText;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnLoadFileSelect;
        private System.Windows.Forms.TextBox txtLoadFile;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnSaveFileSelect;
        private System.Windows.Forms.TextBox txtSaveText;
        private System.Windows.Forms.TextBox txtSaveFile;
    }
}