namespace EducationProject.View
{
    partial class AddNewTask
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPoint = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTaskCat = new System.Windows.Forms.TextBox();
            this.TxbTaskUrl = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txbTaskName = new System.Windows.Forms.TextBox();
            this.txbDetail = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Task Url";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Task Details";
            // 
            // txbPoint
            // 
            this.txbPoint.AutoSize = true;
            this.txbPoint.Location = new System.Drawing.Point(22, 165);
            this.txbPoint.Name = "txbPoint";
            this.txbPoint.Size = new System.Drawing.Size(58, 13);
            this.txbPoint.TabIndex = 1;
            this.txbPoint.Text = "Task Point";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Task Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Task Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddTask);
            this.groupBox1.Controls.Add(this.txbDetail);
            this.groupBox1.Controls.Add(this.txbTaskName);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.TxbTaskUrl);
            this.groupBox1.Controls.Add(this.txbTaskCat);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbPoint);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(130, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 381);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Task";
            // 
            // txbTaskCat
            // 
            this.txbTaskCat.Location = new System.Drawing.Point(136, 26);
            this.txbTaskCat.Name = "txbTaskCat";
            this.txbTaskCat.Size = new System.Drawing.Size(219, 20);
            this.txbTaskCat.TabIndex = 5;
            // 
            // TxbTaskUrl
            // 
            this.TxbTaskUrl.Location = new System.Drawing.Point(136, 118);
            this.TxbTaskUrl.Name = "TxbTaskUrl";
            this.TxbTaskUrl.Size = new System.Drawing.Size(219, 20);
            this.TxbTaskUrl.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 162);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 20);
            this.textBox3.TabIndex = 7;
            // 
            // txbTaskName
            // 
            this.txbTaskName.Location = new System.Drawing.Point(136, 74);
            this.txbTaskName.Name = "txbTaskName";
            this.txbTaskName.Size = new System.Drawing.Size(219, 20);
            this.txbTaskName.TabIndex = 8;
            // 
            // txbDetail
            // 
            this.txbDetail.Location = new System.Drawing.Point(136, 206);
            this.txbDetail.Multiline = true;
            this.txbDetail.Name = "txbDetail";
            this.txbDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbDetail.Size = new System.Drawing.Size(219, 85);
            this.txbDetail.TabIndex = 9;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(280, 330);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 10;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // AddNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddNewTask";
            this.Text = "Add New Task";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txbPoint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txbDetail;
        private System.Windows.Forms.TextBox txbTaskName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox TxbTaskUrl;
        private System.Windows.Forms.TextBox txbTaskCat;
    }
}