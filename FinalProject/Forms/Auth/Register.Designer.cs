namespace FinalProject.Forms.Auth
{
    partial class Register
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
            btnRegistrar = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.CornflowerBlue;
            btnRegistrar.Location = new Point(252, 367);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(122, 44);
            btnRegistrar.TabIndex = 13;
            btnRegistrar.Text = "Registrase";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Bisque;
            btnLogin.Location = new Point(117, 367);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(76, 35);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Ir al login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(173, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(139, 23);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Location = new Point(173, 249);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 10;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.BackColor = Color.CornflowerBlue;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(531, 93);
            label2.TabIndex = 9;
            label2.Text = "Registro";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(173, 209);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(139, 23);
            txtEmail.TabIndex = 8;
            // 
            // label1
            // 
            label1.Location = new Point(173, 183);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 7;
            label1.Text = "Correo electronico";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(173, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(139, 23);
            txtName.TabIndex = 7;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.Location = new Point(173, 120);
            label4.Name = "label4";
            label4.Size = new Size(139, 23);
            label4.TabIndex = 14;
            label4.Text = "Nombre completo";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 450);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            KeyDown += Register_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label label3;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtName;
        private Label label4;
    }
}