namespace gestion_personnel.view
{
    partial class FrmAuthentification
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
            groupBox1 = new GroupBox();
            buttonConnect = new Button();
            textPwd = new TextBox();
            textLogin = new TextBox();
            labelPwd = new Label();
            labelLogin = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonConnect);
            groupBox1.Controls.Add(textPwd);
            groupBox1.Controls.Add(textLogin);
            groupBox1.Controls.Add(labelPwd);
            groupBox1.Controls.Add(labelLogin);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(346, 134);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(169, 40);
            buttonConnect.TabIndex = 4;
            buttonConnect.Text = "se connecter";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // textPwd
            // 
            textPwd.Location = new Point(200, 69);
            textPwd.Name = "textPwd";
            textPwd.Size = new Size(315, 35);
            textPwd.TabIndex = 3;
            textPwd.UseSystemPasswordChar = true;
            // 
            // textLogin
            // 
            textLogin.Location = new Point(200, 22);
            textLogin.Name = "textLogin";
            textLogin.Size = new Size(315, 35);
            textLogin.TabIndex = 2;
            // 
            // labelPwd
            // 
            labelPwd.AutoSize = true;
            labelPwd.Location = new Point(22, 69);
            labelPwd.Name = "labelPwd";
            labelPwd.Size = new Size(137, 30);
            labelPwd.TabIndex = 1;
            labelPwd.Text = "mot de passe";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(22, 22);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(59, 30);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "login";
            // 
            // FrmAuthentification
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 232);
            Controls.Add(groupBox1);
            Name = "FrmAuthentification";
            Text = "Authentification";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonConnect;
        private TextBox textPwd;
        private TextBox textLogin;
        private Label labelPwd;
        private Label labelLogin;
    }
}