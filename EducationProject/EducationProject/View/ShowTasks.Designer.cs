namespace EducationProject.View
{
    partial class ShowTasks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTaskCat = new System.Windows.Forms.ListBox();
            this.lbTaskName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaskDelete = new System.Windows.Forms.Button();
            this.btnTaskUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnTaskUpdate);
            this.groupBox1.Controls.Add(this.btnTaskDelete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbTaskName);
            this.groupBox1.Controls.Add(this.lbTaskCat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Task";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task Category";
            // 
            // lbTaskCat
            // 
            this.lbTaskCat.FormattingEnabled = true;
            this.lbTaskCat.Location = new System.Drawing.Point(25, 55);
            this.lbTaskCat.Name = "lbTaskCat";
            this.lbTaskCat.Size = new System.Drawing.Size(120, 95);
            this.lbTaskCat.TabIndex = 1;
            // 
            // lbTaskName
            // 
            this.lbTaskName.FormattingEnabled = true;
            this.lbTaskName.Location = new System.Drawing.Point(235, 55);
            this.lbTaskName.Name = "lbTaskName";
            this.lbTaskName.Size = new System.Drawing.Size(383, 329);
            this.lbTaskName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Task Name";
            // 
            // btnTaskDelete
            // 
            this.btnTaskDelete.Location = new System.Drawing.Point(431, 407);
            this.btnTaskDelete.Name = "btnTaskDelete";
            this.btnTaskDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTaskDelete.TabIndex = 4;
            this.btnTaskDelete.Text = "Delete";
            this.btnTaskDelete.UseVisualStyleBackColor = true;
            // 
            // btnTaskUpdate
            // 
            this.btnTaskUpdate.Location = new System.Drawing.Point(543, 407);
            this.btnTaskUpdate.Name = "btnTaskUpdate";
            this.btnTaskUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnTaskUpdate.TabIndex = 5;
            this.btnTaskUpdate.Text = "Update";
            this.btnTaskUpdate.UseVisualStyleBackColor = true;
            this.btnTaskUpdate.Click += new System.EventHandler(this.btnTaskUpdate_Click);
            // 
            // ShowTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowTasks";
            this.Text = "ShowTasks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaskUpdate;
        private System.Windows.Forms.Button btnTaskDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTaskName;
        private System.Windows.Forms.ListBox lbTaskCat;
        private System.Windows.Forms.Label label1;
    }
}