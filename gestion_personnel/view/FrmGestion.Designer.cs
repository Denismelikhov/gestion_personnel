namespace gestion_personnel.view
{
    partial class FrmGestion
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
            groupBoxAffichage = new GroupBox();
            dgvTableau = new DataGridView();
            groupBoxPersonnel = new GroupBox();
            comboBoxService = new ComboBox();
            buttonAnnulerP = new Button();
            buttonEnregistrerP = new Button();
            textBoxMail = new TextBox();
            textBoxTel = new TextBox();
            textBoxPrenom = new TextBox();
            textBoxNom = new TextBox();
            labelService = new Label();
            labelMail = new Label();
            labelTel = new Label();
            labelPrenom = new Label();
            labelNom = new Label();
            buttonModifierP = new Button();
            buttonSupprimerP = new Button();
            buttonAjouterP = new Button();
            buttonAfficherP = new Button();
            groupBoxAbsences = new GroupBox();
            comboBoxMotif = new ComboBox();
            labelMotif = new Label();
            labelDateFin = new Label();
            labelDateDebut = new Label();
            textBoxDateDebut = new TextBox();
            textBoxDateFin = new TextBox();
            buttonAnnulerA = new Button();
            buttonEnregistrerA = new Button();
            buttonAfficherA = new Button();
            buttonModifierA = new Button();
            buttonSupprimerA = new Button();
            buttonAjouterA = new Button();
            groupBoxAffichage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTableau).BeginInit();
            groupBoxPersonnel.SuspendLayout();
            groupBoxAbsences.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAffichage
            // 
            groupBoxAffichage.Controls.Add(dgvTableau);
            groupBoxAffichage.Location = new Point(12, 12);
            groupBoxAffichage.Name = "groupBoxAffichage";
            groupBoxAffichage.Size = new Size(1322, 482);
            groupBoxAffichage.TabIndex = 0;
            groupBoxAffichage.TabStop = false;
            groupBoxAffichage.Text = "Personnel";
            // 
            // dgvTableau
            // 
            dgvTableau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTableau.Location = new Point(6, 34);
            dgvTableau.Name = "dgvTableau";
            dgvTableau.RowHeadersWidth = 72;
            dgvTableau.Size = new Size(1310, 442);
            dgvTableau.TabIndex = 0;
            // 
            // groupBoxPersonnel
            // 
            groupBoxPersonnel.Controls.Add(comboBoxService);
            groupBoxPersonnel.Controls.Add(buttonAnnulerP);
            groupBoxPersonnel.Controls.Add(buttonEnregistrerP);
            groupBoxPersonnel.Controls.Add(textBoxMail);
            groupBoxPersonnel.Controls.Add(textBoxTel);
            groupBoxPersonnel.Controls.Add(textBoxPrenom);
            groupBoxPersonnel.Controls.Add(textBoxNom);
            groupBoxPersonnel.Controls.Add(labelService);
            groupBoxPersonnel.Controls.Add(labelMail);
            groupBoxPersonnel.Controls.Add(labelTel);
            groupBoxPersonnel.Controls.Add(labelPrenom);
            groupBoxPersonnel.Controls.Add(labelNom);
            groupBoxPersonnel.Controls.Add(buttonModifierP);
            groupBoxPersonnel.Controls.Add(buttonSupprimerP);
            groupBoxPersonnel.Controls.Add(buttonAjouterP);
            groupBoxPersonnel.Location = new Point(18, 500);
            groupBoxPersonnel.Name = "groupBoxPersonnel";
            groupBoxPersonnel.Size = new Size(655, 511);
            groupBoxPersonnel.TabIndex = 1;
            groupBoxPersonnel.TabStop = false;
            groupBoxPersonnel.Text = "Personnel";
            // 
            // comboBoxService
            // 
            comboBoxService.FormattingEnabled = true;
            comboBoxService.Location = new Point(223, 327);
            comboBoxService.Name = "comboBoxService";
            comboBoxService.Size = new Size(426, 38);
            comboBoxService.TabIndex = 14;
            // 
            // buttonAnnulerP
            // 
            buttonAnnulerP.Location = new Point(439, 465);
            buttonAnnulerP.Name = "buttonAnnulerP";
            buttonAnnulerP.Size = new Size(210, 40);
            buttonAnnulerP.TabIndex = 13;
            buttonAnnulerP.Text = "Annuler";
            buttonAnnulerP.UseVisualStyleBackColor = true;
            buttonAnnulerP.Click += buttonAnnulerP_Click;
            // 
            // buttonEnregistrerP
            // 
            buttonEnregistrerP.Location = new Point(223, 465);
            buttonEnregistrerP.Name = "buttonEnregistrerP";
            buttonEnregistrerP.Size = new Size(210, 40);
            buttonEnregistrerP.TabIndex = 12;
            buttonEnregistrerP.Text = "Enregistrer";
            buttonEnregistrerP.UseVisualStyleBackColor = true;
            buttonEnregistrerP.Click += buttonEnregistrerP_Click;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(223, 276);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(426, 35);
            textBoxMail.TabIndex = 11;
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(223, 226);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(426, 35);
            textBoxTel.TabIndex = 10;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Location = new Point(223, 174);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(426, 35);
            textBoxPrenom.TabIndex = 9;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(223, 126);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(426, 35);
            textBoxNom.TabIndex = 8;
            // 
            // labelService
            // 
            labelService.AutoSize = true;
            labelService.Location = new Point(10, 327);
            labelService.Name = "labelService";
            labelService.Size = new Size(76, 30);
            labelService.TabIndex = 7;
            labelService.Text = "service";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Location = new Point(10, 276);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(52, 30);
            labelMail.TabIndex = 6;
            labelMail.Text = "mail";
            // 
            // labelTel
            // 
            labelTel.AutoSize = true;
            labelTel.Location = new Point(10, 226);
            labelTel.Name = "labelTel";
            labelTel.Size = new Size(36, 30);
            labelTel.TabIndex = 5;
            labelTel.Text = "tel";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Location = new Point(10, 174);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(85, 30);
            labelPrenom.TabIndex = 4;
            labelPrenom.Text = "prenom";
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Location = new Point(10, 126);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(55, 30);
            labelNom.TabIndex = 3;
            labelNom.Text = "nom";
            // 
            // buttonModifierP
            // 
            buttonModifierP.Location = new Point(439, 67);
            buttonModifierP.Name = "buttonModifierP";
            buttonModifierP.Size = new Size(210, 40);
            buttonModifierP.TabIndex = 2;
            buttonModifierP.Text = "Modifier";
            buttonModifierP.UseVisualStyleBackColor = true;
            buttonModifierP.Click += buttonModifierP_Click;
            // 
            // buttonSupprimerP
            // 
            buttonSupprimerP.Location = new Point(223, 67);
            buttonSupprimerP.Name = "buttonSupprimerP";
            buttonSupprimerP.Size = new Size(210, 40);
            buttonSupprimerP.TabIndex = 1;
            buttonSupprimerP.Text = "Supprimer";
            buttonSupprimerP.UseVisualStyleBackColor = true;
            buttonSupprimerP.Click += buttonSupprimerP_Click;
            // 
            // buttonAjouterP
            // 
            buttonAjouterP.Location = new Point(7, 67);
            buttonAjouterP.Name = "buttonAjouterP";
            buttonAjouterP.Size = new Size(210, 40);
            buttonAjouterP.TabIndex = 0;
            buttonAjouterP.Text = "Ajouter";
            buttonAjouterP.UseVisualStyleBackColor = true;
            buttonAjouterP.Click += buttonAjouterP_Click;
            // 
            // buttonAfficherP
            // 
            buttonAfficherP.Location = new Point(225, 21);
            buttonAfficherP.Name = "buttonAfficherP";
            buttonAfficherP.Size = new Size(210, 40);
            buttonAfficherP.TabIndex = 18;
            buttonAfficherP.Text = "Retour";
            buttonAfficherP.UseVisualStyleBackColor = true;
            buttonAfficherP.Click += buttonAfficherP_Click;
            // 
            // groupBoxAbsences
            // 
            groupBoxAbsences.Controls.Add(buttonAfficherP);
            groupBoxAbsences.Controls.Add(comboBoxMotif);
            groupBoxAbsences.Controls.Add(labelMotif);
            groupBoxAbsences.Controls.Add(labelDateFin);
            groupBoxAbsences.Controls.Add(labelDateDebut);
            groupBoxAbsences.Controls.Add(textBoxDateDebut);
            groupBoxAbsences.Controls.Add(textBoxDateFin);
            groupBoxAbsences.Controls.Add(buttonAnnulerA);
            groupBoxAbsences.Controls.Add(buttonEnregistrerA);
            groupBoxAbsences.Controls.Add(buttonAfficherA);
            groupBoxAbsences.Controls.Add(buttonModifierA);
            groupBoxAbsences.Controls.Add(buttonSupprimerA);
            groupBoxAbsences.Controls.Add(buttonAjouterA);
            groupBoxAbsences.Location = new Point(680, 500);
            groupBoxAbsences.Name = "groupBoxAbsences";
            groupBoxAbsences.Size = new Size(655, 511);
            groupBoxAbsences.TabIndex = 2;
            groupBoxAbsences.TabStop = false;
            groupBoxAbsences.Text = "Absences";
            // 
            // comboBoxMotif
            // 
            comboBoxMotif.FormattingEnabled = true;
            comboBoxMotif.Location = new Point(222, 223);
            comboBoxMotif.Name = "comboBoxMotif";
            comboBoxMotif.Size = new Size(426, 38);
            comboBoxMotif.TabIndex = 15;
            // 
            // labelMotif
            // 
            labelMotif.AutoSize = true;
            labelMotif.Location = new Point(6, 226);
            labelMotif.Name = "labelMotif";
            labelMotif.Size = new Size(62, 30);
            labelMotif.TabIndex = 17;
            labelMotif.Text = "motif";
            // 
            // labelDateFin
            // 
            labelDateFin.AutoSize = true;
            labelDateFin.Location = new Point(6, 174);
            labelDateFin.Name = "labelDateFin";
            labelDateFin.Size = new Size(84, 30);
            labelDateFin.TabIndex = 16;
            labelDateFin.Text = "date fin";
            // 
            // labelDateDebut
            // 
            labelDateDebut.AutoSize = true;
            labelDateDebut.Location = new Point(6, 126);
            labelDateDebut.Name = "labelDateDebut";
            labelDateDebut.Size = new Size(114, 30);
            labelDateDebut.TabIndex = 15;
            labelDateDebut.Text = "date debut";
            // 
            // textBoxDateDebut
            // 
            textBoxDateDebut.Location = new Point(222, 126);
            textBoxDateDebut.Name = "textBoxDateDebut";
            textBoxDateDebut.Size = new Size(426, 35);
            textBoxDateDebut.TabIndex = 15;
            // 
            // textBoxDateFin
            // 
            textBoxDateFin.Location = new Point(222, 174);
            textBoxDateFin.Name = "textBoxDateFin";
            textBoxDateFin.Size = new Size(426, 35);
            textBoxDateFin.TabIndex = 15;
            // 
            // buttonAnnulerA
            // 
            buttonAnnulerA.Location = new Point(438, 465);
            buttonAnnulerA.Name = "buttonAnnulerA";
            buttonAnnulerA.Size = new Size(210, 40);
            buttonAnnulerA.TabIndex = 8;
            buttonAnnulerA.Text = "Annuler";
            buttonAnnulerA.UseVisualStyleBackColor = true;
            buttonAnnulerA.Click += buttonAnnulerA_Click;
            // 
            // buttonEnregistrerA
            // 
            buttonEnregistrerA.Location = new Point(222, 465);
            buttonEnregistrerA.Name = "buttonEnregistrerA";
            buttonEnregistrerA.Size = new Size(210, 40);
            buttonEnregistrerA.TabIndex = 7;
            buttonEnregistrerA.Text = "Enregistrer";
            buttonEnregistrerA.UseVisualStyleBackColor = true;
            buttonEnregistrerA.Click += buttonEnregistrerA_Click;
            // 
            // buttonAfficherA
            // 
            buttonAfficherA.Location = new Point(438, 21);
            buttonAfficherA.Name = "buttonAfficherA";
            buttonAfficherA.Size = new Size(210, 40);
            buttonAfficherA.TabIndex = 6;
            buttonAfficherA.Text = "Afficher";
            buttonAfficherA.UseVisualStyleBackColor = true;
            buttonAfficherA.Click += buttonAfficherA_Click;
            // 
            // buttonModifierA
            // 
            buttonModifierA.Location = new Point(438, 67);
            buttonModifierA.Name = "buttonModifierA";
            buttonModifierA.Size = new Size(210, 40);
            buttonModifierA.TabIndex = 5;
            buttonModifierA.Text = "Modifier";
            buttonModifierA.UseVisualStyleBackColor = true;
            buttonModifierA.Click += buttonModifierA_Click;
            // 
            // buttonSupprimerA
            // 
            buttonSupprimerA.Location = new Point(222, 67);
            buttonSupprimerA.Name = "buttonSupprimerA";
            buttonSupprimerA.Size = new Size(210, 40);
            buttonSupprimerA.TabIndex = 4;
            buttonSupprimerA.Text = "Supprimer";
            buttonSupprimerA.UseVisualStyleBackColor = true;
            buttonSupprimerA.Click += buttonSupprimerA_Click;
            // 
            // buttonAjouterA
            // 
            buttonAjouterA.Location = new Point(6, 67);
            buttonAjouterA.Name = "buttonAjouterA";
            buttonAjouterA.Size = new Size(210, 40);
            buttonAjouterA.TabIndex = 3;
            buttonAjouterA.Text = "Ajouter";
            buttonAjouterA.UseVisualStyleBackColor = true;
            buttonAjouterA.Click += buttonAjouterA_Click;
            // 
            // FrmGestion
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 1023);
            Controls.Add(groupBoxAbsences);
            Controls.Add(groupBoxPersonnel);
            Controls.Add(groupBoxAffichage);
            Name = "FrmGestion";
            Text = "Gestion du personnel";
            Load += FrmGestion_Load;
            groupBoxAffichage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTableau).EndInit();
            groupBoxPersonnel.ResumeLayout(false);
            groupBoxPersonnel.PerformLayout();
            groupBoxAbsences.ResumeLayout(false);
            groupBoxAbsences.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAffichage;
        private DataGridView dgvTableau;
        private GroupBox groupBoxPersonnel;
        private GroupBox groupBoxAbsences;
        private Button buttonModifierP;
        private Button buttonSupprimerP;
        private Button buttonAjouterP;
        private Button buttonModifierA;
        private Button buttonSupprimerA;
        private Button buttonAjouterA;
        private Button buttonAfficherA;
        private TextBox textBoxMail;
        private TextBox textBoxTel;
        private TextBox textBoxPrenom;
        private TextBox textBoxNom;
        private Label labelService;
        private Label labelMail;
        private Label labelTel;
        private Label labelPrenom;
        private Label labelNom;
        private Button buttonAnnulerP;
        private Button buttonEnregistrerP;
        private Button buttonAnnulerA;
        private Button buttonEnregistrerA;
        private ComboBox comboBoxService;
        private Label labelMotif;
        private Label labelDateFin;
        private Label labelDateDebut;
        private TextBox textBoxDateDebut;
        private TextBox textBoxDateFin;
        private ComboBox comboBoxMotif;
        private Button buttonAfficherP;
    }
}
