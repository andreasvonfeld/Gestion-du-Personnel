﻿namespace Atelier2
{
    partial class ajouter_personnel
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
            this.grp_AjouterUnNouveauPersonnel = new System.Windows.Forms.GroupBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_service = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.cb_service = new System.Windows.Forms.ComboBox();
            this.grp_AjouterUnNouveauPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_AjouterUnNouveauPersonnel
            // 
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.cb_service);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.txt_mail);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.txt_tel);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.txt_prenom);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.txt_nom);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.lbl_service);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.lbl_mail);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.lbl_tel);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.lbl_prenom);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.lbl_nom);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.btn_annuler);
            this.grp_AjouterUnNouveauPersonnel.Controls.Add(this.btn_valider);
            this.grp_AjouterUnNouveauPersonnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_AjouterUnNouveauPersonnel.Location = new System.Drawing.Point(12, 12);
            this.grp_AjouterUnNouveauPersonnel.Name = "grp_AjouterUnNouveauPersonnel";
            this.grp_AjouterUnNouveauPersonnel.Size = new System.Drawing.Size(280, 206);
            this.grp_AjouterUnNouveauPersonnel.TabIndex = 3;
            this.grp_AjouterUnNouveauPersonnel.TabStop = false;
            this.grp_AjouterUnNouveauPersonnel.Text = "Ajouter un nouveau personnel";
            this.grp_AjouterUnNouveauPersonnel.Enter += new System.EventHandler(this.grp_seConnecter_Enter);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(152, 156);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(53, 23);
            this.btn_annuler.TabIndex = 2;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.Location = new System.Drawing.Point(84, 156);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(62, 23);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(25, 37);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_nom.TabIndex = 3;
            this.lbl_nom.Text = "Nom";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prenom.Location = new System.Drawing.Point(25, 60);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(43, 13);
            this.lbl_prenom.TabIndex = 4;
            this.lbl_prenom.Text = "Prénom";
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tel.Location = new System.Drawing.Point(25, 83);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(25, 13);
            this.lbl_tel.TabIndex = 5;
            this.lbl_tel.Text = "Tél.";
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(25, 106);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(26, 13);
            this.lbl_mail.TabIndex = 6;
            this.lbl_mail.Text = "Mail";
            // 
            // lbl_service
            // 
            this.lbl_service.AutoSize = true;
            this.lbl_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service.Location = new System.Drawing.Point(25, 134);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(43, 13);
            this.lbl_service.TabIndex = 7;
            this.lbl_service.Text = "Service";
            // 
            // txt_nom
            // 
            this.txt_nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(84, 34);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(121, 20);
            this.txt_nom.TabIndex = 8;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prenom.Location = new System.Drawing.Point(84, 57);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(121, 20);
            this.txt_prenom.TabIndex = 9;
            // 
            // txt_tel
            // 
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tel.Location = new System.Drawing.Point(84, 80);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(121, 20);
            this.txt_tel.TabIndex = 10;
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mail.Location = new System.Drawing.Point(84, 103);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(121, 20);
            this.txt_mail.TabIndex = 11;
            // 
            // cb_service
            // 
            this.cb_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_service.FormattingEnabled = true;
            this.cb_service.Location = new System.Drawing.Point(84, 129);
            this.cb_service.Name = "cb_service";
            this.cb_service.Size = new System.Drawing.Size(121, 21);
            this.cb_service.TabIndex = 12;
            // 
            // ajouter_personnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 223);
            this.Controls.Add(this.grp_AjouterUnNouveauPersonnel);
            this.Name = "ajouter_personnel";
            this.Text = "ajouter_personnel";
            this.grp_AjouterUnNouveauPersonnel.ResumeLayout(false);
            this.grp_AjouterUnNouveauPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_AjouterUnNouveauPersonnel;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.ComboBox cb_service;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label lbl_service;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_nom;
    }
}