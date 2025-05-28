namespace gestion_personnel.view
{
    partial class FrmConfirmation
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
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(250, 30);
            label1.TabIndex = 0;
            label1.Text = "Autoriser la suppression ?";
            // 
            // button1
            // 
            button1.Location = new Point(6, 91);
            button1.Name = "button1";
            button1.Size = new Size(122, 40);
            button1.TabIndex = 1;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(145, 91);
            button2.Name = "button2";
            button2.Size = new Size(122, 40);
            button2.TabIndex = 2;
            button2.Text = "Annuler";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmConfirmation
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 163);
            Controls.Add(groupBox1);
            Name = "FrmConfirmation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
        private Button button1;
    }
}