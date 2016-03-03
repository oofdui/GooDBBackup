namespace GooDBBackup
{
    partial class Default
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Default));
            this.tbDefault = new System.Windows.Forms.TableLayoutPanel();
            this.lblConnectionShow = new System.Windows.Forms.Label();
            this.lblCommand = new System.Windows.Forms.Label();
            this.lblResultShow = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.btBackup = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblExportPathShow = new System.Windows.Forms.Label();
            this.lblExportPath = new System.Windows.Forms.Label();
            this.tbDefault.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDefault
            // 
            this.tbDefault.ColumnCount = 2;
            this.tbDefault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbDefault.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbDefault.Controls.Add(this.lblConnectionShow, 0, 0);
            this.tbDefault.Controls.Add(this.lblConnection, 1, 0);
            this.tbDefault.Controls.Add(this.lblResultShow, 0, 3);
            this.tbDefault.Controls.Add(this.lblCommand, 0, 2);
            this.tbDefault.Controls.Add(this.lblResult, 1, 3);
            this.tbDefault.Controls.Add(this.lblExportPathShow, 0, 1);
            this.tbDefault.Controls.Add(this.btBackup, 1, 2);
            this.tbDefault.Controls.Add(this.lblExportPath, 1, 1);
            this.tbDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDefault.Location = new System.Drawing.Point(0, 0);
            this.tbDefault.Name = "tbDefault";
            this.tbDefault.RowCount = 4;
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbDefault.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbDefault.Size = new System.Drawing.Size(470, 105);
            this.tbDefault.TabIndex = 0;
            // 
            // lblConnectionShow
            // 
            this.lblConnectionShow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConnectionShow.AutoSize = true;
            this.lblConnectionShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblConnectionShow.Location = new System.Drawing.Point(3, 0);
            this.lblConnectionShow.Name = "lblConnectionShow";
            this.lblConnectionShow.Padding = new System.Windows.Forms.Padding(5);
            this.lblConnectionShow.Size = new System.Drawing.Size(81, 23);
            this.lblConnectionShow.TabIndex = 0;
            this.lblConnectionShow.Text = "Connection";
            // 
            // lblCommand
            // 
            this.lblCommand.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCommand.AutoSize = true;
            this.lblCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblCommand.Location = new System.Drawing.Point(3, 49);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Padding = new System.Windows.Forms.Padding(5);
            this.lblCommand.Size = new System.Drawing.Size(71, 23);
            this.lblCommand.TabIndex = 0;
            this.lblCommand.Text = "Command";
            // 
            // lblResultShow
            // 
            this.lblResultShow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResultShow.AutoSize = true;
            this.lblResultShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblResultShow.Location = new System.Drawing.Point(3, 78);
            this.lblResultShow.Name = "lblResultShow";
            this.lblResultShow.Padding = new System.Windows.Forms.Padding(5);
            this.lblResultShow.Size = new System.Drawing.Size(53, 23);
            this.lblResultShow.TabIndex = 0;
            this.lblResultShow.Text = "Result";
            // 
            // lblConnection
            // 
            this.lblConnection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConnection.AutoSize = true;
            this.lblConnection.Location = new System.Drawing.Point(90, 0);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Padding = new System.Windows.Forms.Padding(5);
            this.lblConnection.Size = new System.Drawing.Size(20, 23);
            this.lblConnection.TabIndex = 1;
            this.lblConnection.Text = "-";
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(90, 49);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(75, 23);
            this.btBackup.TabIndex = 2;
            this.btBackup.Text = "Backup";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(90, 78);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(5);
            this.lblResult.Size = new System.Drawing.Size(20, 23);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "-";
            // 
            // lblExportPathShow
            // 
            this.lblExportPathShow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExportPathShow.AutoSize = true;
            this.lblExportPathShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblExportPathShow.Location = new System.Drawing.Point(3, 23);
            this.lblExportPathShow.Name = "lblExportPathShow";
            this.lblExportPathShow.Padding = new System.Windows.Forms.Padding(5);
            this.lblExportPathShow.Size = new System.Drawing.Size(79, 23);
            this.lblExportPathShow.TabIndex = 0;
            this.lblExportPathShow.Text = "ExportPath";
            // 
            // lblExportPath
            // 
            this.lblExportPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblExportPath.AutoSize = true;
            this.lblExportPath.Location = new System.Drawing.Point(90, 23);
            this.lblExportPath.Name = "lblExportPath";
            this.lblExportPath.Padding = new System.Windows.Forms.Padding(5);
            this.lblExportPath.Size = new System.Drawing.Size(20, 23);
            this.lblExportPath.TabIndex = 1;
            this.lblExportPath.Text = "-";
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 105);
            this.Controls.Add(this.tbDefault);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Default";
            this.Text = "Default";
            this.Load += new System.EventHandler(this.Default_Load);
            this.tbDefault.ResumeLayout(false);
            this.tbDefault.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbDefault;
        private System.Windows.Forms.Label lblConnectionShow;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.Label lblResultShow;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblExportPathShow;
        private System.Windows.Forms.Label lblExportPath;
    }
}