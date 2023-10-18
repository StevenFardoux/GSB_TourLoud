namespace client_lourd
{
    partial class pageAutre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvVisiteur = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSupprVisiteur = new System.Windows.Forms.Button();
            this.btnModifVisiteur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddVisiteur = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnAddMedecin = new System.Windows.Forms.Button();
            this.dtpObtention = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRpps = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrenomMed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomMed = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvMedecin = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnDelMedecin = new System.Windows.Forms.Button();
            this.btnModifMedecin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rpps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDiplome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecin)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.dgvVisiteur);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 583);
            this.panel1.TabIndex = 0;
            // 
            // dgvVisiteur
            // 
            this.dgvVisiteur.AllowDrop = true;
            this.dgvVisiteur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisiteur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisiteur.ColumnHeadersHeight = 29;
            this.dgvVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVisiteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.Prenom});
            this.dgvVisiteur.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvVisiteur.Location = new System.Drawing.Point(0, 54);
            this.dgvVisiteur.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVisiteur.Name = "dgvVisiteur";
            this.dgvVisiteur.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisiteur.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVisiteur.RowHeadersVisible = false;
            this.dgvVisiteur.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvVisiteur.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVisiteur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisiteur.Size = new System.Drawing.Size(960, 529);
            this.dgvVisiteur.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "prenom";
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.btnSupprVisiteur);
            this.panel4.Controls.Add(this.btnModifVisiteur);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1058, 58);
            this.panel4.TabIndex = 1;
            // 
            // btnSupprVisiteur
            // 
            this.btnSupprVisiteur.Location = new System.Drawing.Point(29, 9);
            this.btnSupprVisiteur.Name = "btnSupprVisiteur";
            this.btnSupprVisiteur.Size = new System.Drawing.Size(123, 38);
            this.btnSupprVisiteur.TabIndex = 2;
            this.btnSupprVisiteur.Text = "Supprimer";
            this.btnSupprVisiteur.UseVisualStyleBackColor = true;
            // 
            // btnModifVisiteur
            // 
            this.btnModifVisiteur.Location = new System.Drawing.Point(804, 9);
            this.btnModifVisiteur.Name = "btnModifVisiteur";
            this.btnModifVisiteur.Size = new System.Drawing.Size(123, 38);
            this.btnModifVisiteur.TabIndex = 1;
            this.btnModifVisiteur.Text = "Modifier";
            this.btnModifVisiteur.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tous les Visiteurs";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnAddVisiteur);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtPrenom);
            this.panel2.Controls.Add(this.txtNom);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 649);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 344);
            this.panel2.TabIndex = 1;
            // 
            // btnAddVisiteur
            // 
            this.btnAddVisiteur.Location = new System.Drawing.Point(473, 147);
            this.btnAddVisiteur.Name = "btnAddVisiteur";
            this.btnAddVisiteur.Size = new System.Drawing.Size(110, 36);
            this.btnAddVisiteur.TabIndex = 6;
            this.btnAddVisiteur.Text = "Ajouter";
            this.btnAddVisiteur.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(171, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Prenom :";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(300, 189);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(130, 22);
            this.txtPrenom.TabIndex = 4;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(300, 118);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(130, 22);
            this.txtNom.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(194, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nom :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 58);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un Visiteur :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txtMdp);
            this.panel6.Controls.Add(this.btnAddMedecin);
            this.panel6.Controls.Add(this.dtpObtention);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.txtRpps);
            this.panel6.Controls.Add(this.txtMail);
            this.panel6.Controls.Add(this.txtPrenomMed);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtNomMed);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(1038, 649);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(960, 344);
            this.panel6.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(107, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Mot de passe :";
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(254, 209);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(188, 27);
            this.txtMdp.TabIndex = 13;
            // 
            // btnAddMedecin
            // 
            this.btnAddMedecin.Location = new System.Drawing.Point(451, 270);
            this.btnAddMedecin.Name = "btnAddMedecin";
            this.btnAddMedecin.Size = new System.Drawing.Size(110, 36);
            this.btnAddMedecin.TabIndex = 7;
            this.btnAddMedecin.Text = "Ajouter";
            this.btnAddMedecin.UseVisualStyleBackColor = true;
            // 
            // dtpObtention
            // 
            this.dtpObtention.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpObtention.Location = new System.Drawing.Point(679, 154);
            this.dtpObtention.Name = "dtpObtention";
            this.dtpObtention.Size = new System.Drawing.Size(239, 27);
            this.dtpObtention.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(428, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(227, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Date d\'obtention du diplome :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Rpps :";
            // 
            // txtRpps
            // 
            this.txtRpps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRpps.Location = new System.Drawing.Point(583, 115);
            this.txtRpps.Name = "txtRpps";
            this.txtRpps.Size = new System.Drawing.Size(287, 27);
            this.txtRpps.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(583, 205);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(301, 27);
            this.txtMail.TabIndex = 6;
            // 
            // txtPrenomMed
            // 
            this.txtPrenomMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomMed.Location = new System.Drawing.Point(254, 157);
            this.txtPrenomMed.Name = "txtPrenomMed";
            this.txtPrenomMed.Size = new System.Drawing.Size(139, 27);
            this.txtPrenomMed.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(511, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mail :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(157, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Prenom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nom :";
            // 
            // txtNomMed
            // 
            this.txtNomMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMed.Location = new System.Drawing.Point(254, 115);
            this.txtNomMed.Name = "txtNomMed";
            this.txtNomMed.Size = new System.Drawing.Size(139, 27);
            this.txtNomMed.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(353, 58);
            this.panel7.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ajouter un medecin :";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightGray;
            this.panel8.Controls.Add(this.dgvMedecin);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(1038, 25);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(960, 583);
            this.panel8.TabIndex = 3;
            // 
            // dgvMedecin
            // 
            this.dgvMedecin.AllowDrop = true;
            this.dgvMedecin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedecin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMedecin.ColumnHeadersHeight = 29;
            this.dgvMedecin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMedecin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mail,
            this.DateCreation,
            this.Rpps,
            this.DateDiplome});
            this.dgvMedecin.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvMedecin.Location = new System.Drawing.Point(0, 54);
            this.dgvMedecin.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMedecin.Name = "dgvMedecin";
            this.dgvMedecin.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedecin.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMedecin.RowHeadersVisible = false;
            this.dgvMedecin.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvMedecin.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMedecin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedecin.Size = new System.Drawing.Size(960, 529);
            this.dgvMedecin.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Silver;
            this.panel10.Controls.Add(this.btnDelMedecin);
            this.panel10.Controls.Add(this.btnModifMedecin);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1058, 58);
            this.panel10.TabIndex = 1;
            // 
            // btnDelMedecin
            // 
            this.btnDelMedecin.Location = new System.Drawing.Point(20, 9);
            this.btnDelMedecin.Name = "btnDelMedecin";
            this.btnDelMedecin.Size = new System.Drawing.Size(123, 38);
            this.btnDelMedecin.TabIndex = 4;
            this.btnDelMedecin.Text = "Supprimer";
            this.btnDelMedecin.UseVisualStyleBackColor = true;
            // 
            // btnModifMedecin
            // 
            this.btnModifMedecin.Location = new System.Drawing.Point(751, 9);
            this.btnModifMedecin.Name = "btnModifMedecin";
            this.btnModifMedecin.Size = new System.Drawing.Size(123, 38);
            this.btnModifMedecin.TabIndex = 3;
            this.btnModifMedecin.Text = "Modifier";
            this.btnModifMedecin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tous les medecins";
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "mail";
            this.Mail.HeaderText = "Mail";
            this.Mail.MinimumWidth = 6;
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // DateCreation
            // 
            this.DateCreation.DataPropertyName = "dateCreation";
            this.DateCreation.HeaderText = "Date de création";
            this.DateCreation.MinimumWidth = 6;
            this.DateCreation.Name = "DateCreation";
            this.DateCreation.ReadOnly = true;
            // 
            // Rpps
            // 
            this.Rpps.DataPropertyName = "rpps";
            this.Rpps.HeaderText = "Rpps";
            this.Rpps.MinimumWidth = 6;
            this.Rpps.Name = "Rpps";
            this.Rpps.ReadOnly = true;
            // 
            // DateDiplome
            // 
            this.DateDiplome.DataPropertyName = "dateDiplome";
            this.DateDiplome.HeaderText = "Date de diplome";
            this.DateDiplome.MinimumWidth = 6;
            this.DateDiplome.Name = "DateDiplome";
            this.DateDiplome.ReadOnly = true;
            // 
            // pageAutre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "pageAutre";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteur)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedecin)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddVisiteur;
        private System.Windows.Forms.Button btnModifVisiteur;
        private System.Windows.Forms.DataGridView dgvVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.Button btnSupprVisiteur;
        private System.Windows.Forms.DataGridView dgvMedecin;
        private System.Windows.Forms.Button btnDelMedecin;
        private System.Windows.Forms.Button btnModifMedecin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomMed;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPrenomMed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpObtention;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRpps;
        private System.Windows.Forms.Button btnAddMedecin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rpps;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDiplome;
    }
}