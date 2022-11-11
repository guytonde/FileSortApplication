﻿
namespace FileSortApplication
{
    partial class appForm
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_editFile = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_searchBar = new System.Windows.Forms.RichTextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(42, 33);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(110, 30);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome!";
            // 
            // btn_editFile
            // 
            this.btn_editFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editFile.Location = new System.Drawing.Point(620, 388);
            this.btn_editFile.Name = "btn_editFile";
            this.btn_editFile.Size = new System.Drawing.Size(100, 40);
            this.btn_editFile.TabIndex = 1;
            this.btn_editFile.Text = "Edit File";
            this.btn_editFile.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(485, 388);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 40);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add File";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // txt_searchBar
            // 
            this.txt_searchBar.Location = new System.Drawing.Point(183, 172);
            this.txt_searchBar.Name = "txt_searchBar";
            this.txt_searchBar.Size = new System.Drawing.Size(315, 47);
            this.txt_searchBar.TabIndex = 4;
            this.txt_searchBar.Text = "Search for files...";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(528, 183);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // appForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_searchBar);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_editFile);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "appForm";
            this.Text = "File Sorter";
            this.Load += new System.EventHandler(this.appForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_editFile;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.RichTextBox txt_searchBar;
        private System.Windows.Forms.Button btn_search;
    }
}

