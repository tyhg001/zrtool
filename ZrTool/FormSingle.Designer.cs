namespace ZrTool
{
    partial class FormSingle
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
            this.components = new System.ComponentModel.Container();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCombin = new System.Windows.Forms.Button();
            this.btnCFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPath = new System.Windows.Forms.TextBox();
            this.txtCFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCPath = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 252);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(602, 25);
            this.progressBar.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // btnCombin
            // 
            this.btnCombin.Location = new System.Drawing.Point(49, 174);
            this.btnCombin.Margin = new System.Windows.Forms.Padding(4);
            this.btnCombin.Name = "btnCombin";
            this.btnCombin.Size = new System.Drawing.Size(100, 29);
            this.btnCombin.TabIndex = 2;
            this.btnCombin.Text = "开始转换";
            this.btnCombin.UseVisualStyleBackColor = true;
            this.btnCombin.Click += new System.EventHandler(this.btnCombin_Click);
            // 
            // btnCFile
            // 
            this.btnCFile.Location = new System.Drawing.Point(397, 55);
            this.btnCFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnCFile.Name = "btnCFile";
            this.btnCFile.Size = new System.Drawing.Size(52, 29);
            this.btnCFile.TabIndex = 1;
            this.btnCFile.Text = "<<";
            this.btnCFile.UseVisualStyleBackColor = true;
            this.btnCFile.Click += new System.EventHandler(this.btnCFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "选择要转换的文件";
            // 
            // txtCPath
            // 
            this.txtCPath.Location = new System.Drawing.Point(49, 110);
            this.txtCPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPath.Name = "txtCPath";
            this.txtCPath.Size = new System.Drawing.Size(340, 25);
            this.txtCPath.TabIndex = 6;
            // 
            // txtCFile
            // 
            this.txtCFile.Location = new System.Drawing.Point(49, 55);
            this.txtCFile.Margin = new System.Windows.Forms.Padding(4);
            this.txtCFile.Name = "txtCFile";
            this.txtCFile.Size = new System.Drawing.Size(340, 25);
            this.txtCFile.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "选择转换后文件存放路径及名称";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 277);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCPath);
            this.tabPage2.Controls.Add(this.txtCFile);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnCPath);
            this.tabPage2.Controls.Add(this.btnCombin);
            this.tabPage2.Controls.Add(this.btnCFile);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(594, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "生成金蝶导入表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCPath
            // 
            this.btnCPath.Location = new System.Drawing.Point(399, 109);
            this.btnCPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnCPath.Name = "btnCPath";
            this.btnCPath.Size = new System.Drawing.Size(51, 29);
            this.btnCPath.TabIndex = 3;
            this.btnCPath.Text = "<<";
            this.btnCPath.UseVisualStyleBackColor = true;
            this.btnCPath.Click += new System.EventHandler(this.btnCPath_Click);
            // 
            // FormSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 277);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSingle";
            this.Text = "单文件转换";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnCombin;
        private System.Windows.Forms.Button btnCFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPath;
        private System.Windows.Forms.TextBox txtCFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCPath;
    }
}