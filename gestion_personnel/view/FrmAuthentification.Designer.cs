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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(521, 208);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(59, 30);
            label1.TabIndex = 0;
            label1.Text = "login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 69);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 1;
            label2.Text = "mot de passe";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 35);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 35);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(346, 134);
            button1.Name = "button1";
            button1.Size = new Size(169, 40);
            button1.TabIndex = 4;
            button1.Text = "se connecter";
            button1.UseVisualStyleBackColor = true;
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
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}