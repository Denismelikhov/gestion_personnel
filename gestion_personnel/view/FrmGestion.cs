using gestion_personnel.controller;
using gestion_personnel.model;
using System.Data;

namespace gestion_personnel.view
{
    public partial class FrmGestion : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionController controller;

        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        private readonly BindingSource bdgPersonnel = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des services concernant le personnel
        /// </summary>
        private readonly BindingSource bdgServices = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des motifs concernant les absneces
        /// </summary>
        private readonly BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Information";

        /// <summary>
        /// Booléen pour savoir si une modification est demandée sur un personnel
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;

        /// <summary>
        /// Booléen pour savoir si une modification est demandée sur une absence
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;

        /// <summary>
        /// DateTime pour stocker l'ancienne date de début
        /// </summary>
        private DateTime ancienneDateDebut;

        /// <summary>
        /// DateTime pour stocker l'ancienne date de fin
        /// </summary>
        private DateTime ancienneDateFin;

        /// <summary>
        /// int pour stocker l'ancien id de motif
        /// </summary>
        private int ancienIdMotif;

        /// <summary>
        /// Objet pour stocker le personnel sélectionné
        /// </summary>
        private Personnel personnelSelectionne = null;

        /// <summary>
        /// Conrtuction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmGestion()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmGestionController();
            RemplirListePersonnel();
            RemplirServices();
            RemplirMotifs();

            InitialiserEtatInterface();
        }

        /// <summary>
        /// Initialisation de l'interface (Boutons/saisies actifs/non actifs lors du lancement)
        /// </summary>
        private void InitialiserEtatInterface()
        {
            ActiverBoutonsPersonnel(true);
            ActiverSaisiePersonnel(false);

            ActiverBoutonsAbsence(false);
            ActiverSaisieAbsence(false);

            buttonAfficherP.Enabled = false;
            buttonAfficherA.Enabled = true;

            comboBoxService.SelectedIndex = -1;
            comboBoxService.Text = "";

            comboBoxMotif.SelectedIndex = -1;
            comboBoxMotif.Text = "";
        }

        /// <summary>
        /// Remplir les services
        /// </summary>
        private void RemplirServices()
        {
            bdgServices.DataSource = controller.GetLesServices();
            comboBoxService.DataSource = bdgServices;
            comboBoxService.DisplayMember = "nom";
            comboBoxService.ValueMember = "idservice";
        }

        /// <summary>
        /// Remplir les motifs
        /// </summary>
        private void RemplirMotifs()
        {
            bdgMotifs.DataSource = controller.GetLesMotifs();
            comboBoxMotif.DataSource = bdgMotifs;
            comboBoxMotif.DisplayMember = "libelle";
            comboBoxMotif.ValueMember = "idmotif";
        }

        /// <summary>
        /// Gestion de l'interface au lancement
        /// </summary>
        private void FrmGestion_Load(object sender, EventArgs e)
        {
            dgvTableau.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTableau.MultiSelect = false;

            InitialiserEtatInterface();

            dgvTableau.SelectionChanged += dgvTableau_SelectionChanged;
        }

        /// <summary>
        /// Permettre au bouton d'affichage des absences d'etre actif si on a une ligne personnel selectionné
        /// </summary>
        private void dgvTableau_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTableau.DataSource == bdgPersonnel && dgvTableau.SelectedRows.Count > 0)
            {
                buttonAfficherA.Enabled = true;
            }
            else
            {
                buttonAfficherA.Enabled = false;
            }
        }

        /// <summary>
        /// PARTIE PERSONNEL
        /// </summary>

        /// <summary>
        /// Gestion d'activation des boutons du personnel
        /// </summary>
        private void ActiverBoutonsPersonnel(bool activer)
        {
            buttonAjouterP.Enabled = activer;
            buttonModifierP.Enabled = activer;
            buttonSupprimerP.Enabled = activer;
        }

        /// <summary>
        /// Gestion d'activation des saisies du personnel
        /// </summary>
        private void ActiverSaisiePersonnel(bool activer)
        {
            buttonEnregistrerP.Enabled = activer;
            buttonAnnulerP.Enabled = activer;
            textBoxNom.Enabled = activer;
            textBoxPrenom.Enabled = activer;
            textBoxTel.Enabled = activer;
            textBoxMail.Enabled = activer;
            comboBoxService.Enabled = activer;
        }

        /// <summary>
        /// Remplissage de la liste du personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lesPersonnels = controller.GetLesPersonnels();
            bdgPersonnel.DataSource = lesPersonnels;
            dgvTableau.DataSource = bdgPersonnel;
            dgvTableau.Columns["idpersonnel"].Visible = false;
            dgvTableau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Gestion du bonton enregistrer pour le personnel
        /// </summary>
        private void buttonEnregistrerP_Click(object sender, EventArgs e)
        {
            if (!textBoxNom.Text.Equals("") && !textBoxPrenom.Text.Equals("") && !textBoxTel.Text.Equals("") && !textBoxMail.Text.Equals("") && comboBoxService.SelectedIndex != -1)
            {
                Service service = (Service)comboBoxService.SelectedItem;

                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.nom = textBoxNom.Text;
                    personnel.prenom = textBoxPrenom.Text;
                    personnel.tel = textBoxTel.Text;
                    personnel.mail = textBoxMail.Text;
                    personnel.service = service;

                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(textBoxNom.Text, textBoxPrenom.Text, textBoxTel.Text, textBoxMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                EnCoursDeModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifPersonnel(bool modif)
        {
            enCoursDeModifPersonnel = modif;
            ActiverBoutonsPersonnel(!modif);
            ActiverSaisiePersonnel(modif);

            groupBoxPersonnel.Text = modif ? "Modifier un personnel" : "Ajouter un personnel";

            if (!modif)
            {
                textBoxNom.Text = "";
                textBoxPrenom.Text = "";
                textBoxTel.Text = "";
                textBoxMail.Text = "";
                comboBoxService.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Gestion du bouton annuler pour le personnel
        /// </summary>
        private void buttonAnnulerP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifPersonnel(false);
                groupBoxPersonnel.Text = "Personnel";
            }
        }

        /// <summary>
        /// Gestion du bouton supprimer pour le personnel
        /// </summary>
        private void buttonSupprimerP_Click(object sender, EventArgs e)
        {
            if (dgvTableau.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.nom + " " + personnel.prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Gestion du bouton modifier pour le personnel
        /// </summary>
        private void buttonModifierP_Click(object sender, EventArgs e)
        {
            if (dgvTableau.SelectedRows.Count > 0)
            {
                EnCoursDeModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                textBoxNom.Text = personnel.nom;
                textBoxPrenom.Text = personnel.prenom;
                textBoxTel.Text = personnel.tel;
                textBoxMail.Text = personnel.mail;
                comboBoxService.SelectedIndex = comboBoxService.FindStringExact(personnel.service.nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Gestion du bouton ajouter pour le personnel
        /// </summary>
        private void buttonAjouterP_Click(object sender, EventArgs e)
        {
            EnCoursDeModifPersonnel(false);
            ActiverSaisiePersonnel(true);
        }

        /// <summary>
        /// Gestion du bouton afficher pour le personnel
        /// </summary>
        private void buttonAfficherP_Click(object sender, EventArgs e)
        {
            personnelSelectionne = null;

            RemplirListePersonnel();
            buttonAfficherP.Enabled = false;
            buttonAfficherA.Enabled = true;

            ActiverBoutonsPersonnel(true);
            ActiverSaisiePersonnel(false);

            ActiverBoutonsAbsence(false);
            ActiverSaisieAbsence(false);

            groupBoxAffichage.Text = "Personnel";
        }

        /// <summary>
        /// PARTIE ABSENCE
        /// </summary>

        /// <summary>
        /// Gestion d'activation des boutons des absences
        /// </summary>
        private void ActiverBoutonsAbsence(bool activer)
        {
            buttonAjouterA.Enabled = activer;
            buttonModifierA.Enabled = activer;
            buttonSupprimerA.Enabled = activer;
        }

        /// <summary>
        /// Gestion d'activation des saisies des absences
        /// </summary>
        private void ActiverSaisieAbsence(bool activer)
        {
            buttonEnregistrerA.Enabled = activer;
            buttonAnnulerA.Enabled = activer;
            textBoxDateDebut.Enabled = activer;
            textBoxDateFin.Enabled = activer;
            comboBoxMotif.Enabled = activer;
        }

        /// <summary>
        /// Remplissage de la liste des absences
        /// </summary>
        private void RemplirListeAbsences()
        {
            if (personnelSelectionne != null)
            {
                int idPersonnel = personnelSelectionne.idpersonnel;
                List<Absence> lesAbsences = controller.GetAbsencesPourPersonnel(idPersonnel);
                bdgAbsences.DataSource = lesAbsences;
                dgvTableau.DataSource = bdgAbsences;
                dgvTableau.Columns["idpersonnel"].Visible = false;
                dgvTableau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifAbsence(bool modif)
        {
            enCoursDeModifAbsence = modif;
            ActiverBoutonsAbsence(!modif);
            ActiverSaisieAbsence(modif);

            groupBoxAbsences.Text = modif ? "Modifier une absence" : "Ajouter une absence";

            if (!modif)
            {
                textBoxDateDebut.Text = "";
                textBoxDateFin.Text = "";
                comboBoxMotif.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Gestion du bouton afficher pour les absences
        /// </summary>
        private void buttonAfficherA_Click(object sender, EventArgs e)
        {
            if (dgvTableau.CurrentRow != null && dgvTableau.CurrentRow.DataBoundItem is Personnel selectedPersonnel)
            {
                personnelSelectionne = selectedPersonnel;
                
                RemplirListeAbsences();

                buttonAfficherA.Enabled = false;
                buttonAfficherP.Enabled = true;

                ActiverBoutonsAbsence(true);
                ActiverSaisieAbsence(false);
                ActiverBoutonsPersonnel(false);
                ActiverSaisiePersonnel(false);

                groupBoxAffichage.Text = "Absences";
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un personnel avant d'afficher ses absences.", "Information");
            }
        }

        /// <summary>
        /// Gestion du bouton ajouter pour les absences
        /// </summary>
        private void buttonAjouterA_Click(object sender, EventArgs e)
        {
            EnCoursDeModifAbsence(false);
            ActiverSaisieAbsence(true);

            groupBoxAbsences.Text = "Ajouter une absence";

            textBoxDateDebut.Text = "";
            textBoxDateFin.Text = "";
            comboBoxMotif.SelectedIndex = -1;
        }

        /// <summary>
        /// Gestion du bouton supprimer pour les absences
        /// </summary>
        private void buttonSupprimerA_Click(object sender, EventArgs e)
        {
            if (dgvTableau.CurrentRow != null && dgvTableau.CurrentRow.DataBoundItem is Absence absence)
            {
                string message = $"Voulez-vous vraiment supprimer l'absence du {absence.datedebut:dd/MM/yyyy} au {absence.datefin:dd/MM/yyyy} ?";
                if (MessageBox.Show(message, "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une absence à supprimer.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Gestion du bouton modifier pour les absences
        /// </summary>
        private void buttonModifierA_Click(object sender, EventArgs e)
        {
            if (dgvTableau.SelectedRows.Count > 0 && bdgAbsences.Current is Absence absence)
            {
                ancienneDateDebut = absence.datedebut;
                ancienneDateFin = absence.datefin;
                ancienIdMotif = absence.motif.idmotif;

                EnCoursDeModifAbsence(true);
                textBoxDateDebut.Text = absence.datedebut.ToString("dd/MM/yyyy");
                textBoxDateFin.Text = absence.datefin.ToString("dd/MM/yyyy");
                comboBoxMotif.SelectedItem = bdgMotifs.List
                    .Cast<Motif>()
                    .FirstOrDefault(m => m.idmotif == absence.motif.idmotif);
            }
            else
            {
                MessageBox.Show("Une absence doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Gestion du bouton annuler pour les absences
        /// </summary>
        private void buttonAnnulerA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifAbsence(false);
                groupBoxAbsences.Text = "Absences";
            }
        }

        /// <summary>
        /// Gestion du bouton enregistrer pour les absences
        /// </summary>
        private void buttonEnregistrerA_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(textBoxDateDebut.Text, out DateTime dateDebut) ||
                !DateTime.TryParse(textBoxDateFin.Text, out DateTime dateFin))
            {
                MessageBox.Show("Dates invalides.", "Erreur");
                return;
            }

            if (dateFin < dateDebut)
            {
                MessageBox.Show("La date de fin doit être supérieure ou égale à la date de début.", "Erreur");
                return;
            }

            if (comboBoxMotif.SelectedItem is not Motif motif)
            {
                MessageBox.Show("Veuillez sélectionner un motif.", "Erreur");
                return;
            }

            if (enCoursDeModifAbsence)
            {
                System.Diagnostics.Debug.WriteLine("Mode modification détecté");
                if (bdgAbsences.Current is Absence absence)
                {
                    absence.datedebut = dateDebut;
                    absence.datefin = dateFin;
                    absence.motif = motif;

                    controller.UpdateAbsence(absence, ancienneDateDebut, ancienneDateFin, ancienIdMotif);
                }
                else
                {
                    MessageBox.Show("Erreur : impossible de récupérer l'absence à modifier.", "Erreur");
                    return;
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Mode ajout détecté");
                if (personnelSelectionne != null)
                {
                    Absence nouvelleAbsence = new Absence(personnelSelectionne.idpersonnel, dateDebut, dateFin, motif);
                    controller.AddAbsence(nouvelleAbsence);
                }
                else
                {
                    MessageBox.Show("Erreur : aucun personnel sélectionné.", "Erreur");
                    return;
                }
            }

            RemplirListeAbsences();
            EnCoursDeModifAbsence(false);
        }
    }
}
