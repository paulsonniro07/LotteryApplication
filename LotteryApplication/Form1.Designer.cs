namespace LotteryApplication
{
    partial class mainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_select_winner = new System.Windows.Forms.Button();
            this.txt_employee_no = new System.Windows.Forms.TextBox();
            this.txt_employee_name = new System.Windows.Forms.TextBox();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Department:";
            // 
            // btn_select_winner
            // 
            this.btn_select_winner.Enabled = false;
            this.btn_select_winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_winner.Location = new System.Drawing.Point(393, 264);
            this.btn_select_winner.Name = "btn_select_winner";
            this.btn_select_winner.Size = new System.Drawing.Size(248, 101);
            this.btn_select_winner.TabIndex = 1;
            this.btn_select_winner.Text = "Select Winner";
            this.btn_select_winner.UseVisualStyleBackColor = true;
            this.btn_select_winner.Click += new System.EventHandler(this.btn_select_winner_Click);
            // 
            // txt_employee_no
            // 
            this.txt_employee_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_employee_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employee_no.Location = new System.Drawing.Point(421, 63);
            this.txt_employee_no.Multiline = true;
            this.txt_employee_no.Name = "txt_employee_no";
            this.txt_employee_no.ReadOnly = true;
            this.txt_employee_no.Size = new System.Drawing.Size(220, 46);
            this.txt_employee_no.TabIndex = 2;
            // 
            // txt_employee_name
            // 
            this.txt_employee_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_employee_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employee_name.Location = new System.Drawing.Point(421, 127);
            this.txt_employee_name.Multiline = true;
            this.txt_employee_name.Name = "txt_employee_name";
            this.txt_employee_name.ReadOnly = true;
            this.txt_employee_name.Size = new System.Drawing.Size(497, 46);
            this.txt_employee_name.TabIndex = 2;
            // 
            // txt_department
            // 
            this.txt_department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.Location = new System.Drawing.Point(421, 190);
            this.txt_department.Multiline = true;
            this.txt_department.Name = "txt_department";
            this.txt_department.ReadOnly = true;
            this.txt_department.Size = new System.Drawing.Size(261, 46);
            this.txt_department.TabIndex = 2;
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(131, 264);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(248, 101);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(661, 264);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(144, 101);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 419);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.txt_employee_name);
            this.Controls.Add(this.txt_employee_no);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_select_winner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Lottery Application";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_select_winner;
        private System.Windows.Forms.TextBox txt_employee_no;
        private System.Windows.Forms.TextBox txt_employee_name;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_exit;
    }
}

