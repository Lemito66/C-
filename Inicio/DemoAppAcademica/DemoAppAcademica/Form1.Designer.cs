namespace DemoAppAcademica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtScoreOne = new TextBox();
            txtScoreTwo = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(269, 284);
            button1.Name = "button1";
            button1.Size = new Size(93, 50);
            button1.TabIndex = 0;
            button1.Text = "Agregar Estudiante";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(425, 284);
            button2.Name = "button2";
            button2.Size = new Size(75, 50);
            button2.TabIndex = 1;
            button2.Text = "Mostrar Estudiante";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 46);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "Código";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 88);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 128);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Nota Uno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(243, 162);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 5;
            label4.Text = "Nota Dos";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(364, 46);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(136, 23);
            txtCode.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(366, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(134, 23);
            txtName.TabIndex = 8;
            // 
            // txtScoreOne
            // 
            txtScoreOne.Location = new Point(366, 128);
            txtScoreOne.Name = "txtScoreOne";
            txtScoreOne.Size = new Size(134, 23);
            txtScoreOne.TabIndex = 9;
            // 
            // txtScoreTwo
            // 
            txtScoreTwo.Location = new Point(366, 162);
            txtScoreTwo.Name = "txtScoreTwo";
            txtScoreTwo.Size = new Size(134, 23);
            txtScoreTwo.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtScoreTwo);
            Controls.Add(txtScoreOne);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtScoreOne;
        private TextBox txtScoreTwo;
    }
}