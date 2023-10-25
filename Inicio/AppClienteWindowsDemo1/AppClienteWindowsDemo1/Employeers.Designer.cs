namespace AppClienteWindowsDemo1
{
    partial class Employeers
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
            txtCode = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtSalary = new TextBox();
            label4 = new Label();
            txtDepartment = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(352, 86);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(220, 23);
            txtCode.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 94);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 145);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(352, 145);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 23);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 195);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Salario";
            label3.Click += label3_Click;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(352, 195);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(220, 23);
            txtSalary.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 236);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 7;
            label4.Text = "Departamento";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(352, 228);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(220, 23);
            txtDepartment.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(373, 295);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(488, 295);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Employeers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtDepartment);
            Controls.Add(label3);
            Controls.Add(txtSalary);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(txtCode);
            Name = "Employeers";
            Text = "Employeers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtSalary;
        private Label label4;
        private TextBox txtDepartment;
        private Button button1;
        private Button button2;
    }
}