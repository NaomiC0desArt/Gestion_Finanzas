namespace FinalProject.Forms.Auth
{
    partial class Login
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
			label1 = new Label();
			txtEmail = new TextBox();
			label2 = new Label();
			txtPassword = new TextBox();
			label3 = new Label();
			btnRegistrarse = new Button();
			btnEntrar = new Button();
			label4 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Location = new Point(200, 163);
			label1.Name = "label1";
			label1.Size = new Size(139, 23);
			label1.TabIndex = 0;
			label1.Text = "Correo electronico";
			// 
			// txtEmail
			// 
			txtEmail.BorderStyle = BorderStyle.FixedSingle;
			txtEmail.Location = new Point(200, 189);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(139, 23);
			txtEmail.TabIndex = 1;
			// 
			// label2
			// 
			label2.BackColor = Color.CornflowerBlue;
			label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
			label2.Location = new Point(1, -1);
			label2.Name = "label2";
			label2.Size = new Size(799, 93);
			label2.TabIndex = 2;
			label2.Text = "Login";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			
			// 
			// txtPassword
			// 
			txtPassword.BorderStyle = BorderStyle.FixedSingle;
			txtPassword.Location = new Point(446, 189);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(139, 23);
			txtPassword.TabIndex = 4;
			txtPassword.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			label3.Location = new Point(446, 163);
			label3.Name = "label3";
			label3.Size = new Size(139, 23);
			label3.TabIndex = 3;
			label3.Text = "Contraseña";
			label3.Click += label3_Click;
			// 
			// btnRegistrarse
			// 
			btnRegistrarse.BackColor = Color.Bisque;
			btnRegistrarse.Location = new Point(200, 255);
			btnRegistrarse.Name = "btnRegistrarse";
			btnRegistrarse.Size = new Size(139, 54);
			btnRegistrarse.TabIndex = 5;
			btnRegistrarse.Text = "Registrarse";
			btnRegistrarse.UseVisualStyleBackColor = false;
			btnRegistrarse.Click += btnRegistrarse_Click;
			// 
			// btnEntrar
			// 
			btnEntrar.BackColor = Color.CornflowerBlue;
			btnEntrar.Location = new Point(446, 255);
			btnEntrar.Name = "btnEntrar";
			btnEntrar.Size = new Size(139, 54);
			btnEntrar.TabIndex = 6;
			btnEntrar.Text = "Entrar";
			btnEntrar.UseVisualStyleBackColor = false;
			btnEntrar.Click += btnEntrar_Click;
			// 
			// label4
			// 
			label4.Location = new Point(299, 112);
			label4.Name = "label4";
			label4.Size = new Size(202, 23);
			label4.TabIndex = 7;
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 363);
			Controls.Add(label4);
			Controls.Add(btnEntrar);
			Controls.Add(btnRegistrarse);
			Controls.Add(txtPassword);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(txtEmail);
			Controls.Add(label1);
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			Load += Login_Load;
			KeyDown += Login_KeyDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private Button btnRegistrarse;
        private Button btnEntrar;
        private Label label4;
    }
}