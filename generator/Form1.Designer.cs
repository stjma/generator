namespace generator
{
    partial class Form1
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
            this.Utilisateur = new System.Windows.Forms.Button();
            this.Role_User = new System.Windows.Forms.Button();
            this.Donneur = new System.Windows.Forms.Button();
            this.Patient = new System.Windows.Forms.Button();
            this.Tests = new System.Windows.Forms.Button();
            this.TestsPatient = new System.Windows.Forms.Button();
            this.Transplantation = new System.Windows.Forms.Button();
            this.Categorie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Utilisateur
            // 
            this.Utilisateur.Location = new System.Drawing.Point(122, 77);
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Size = new System.Drawing.Size(75, 23);
            this.Utilisateur.TabIndex = 0;
            this.Utilisateur.Text = "Utilisateur";
            this.Utilisateur.UseVisualStyleBackColor = true;
            this.Utilisateur.Click += new System.EventHandler(this.Utilisateur_Click);
            // 
            // Role_User
            // 
            this.Role_User.Location = new System.Drawing.Point(203, 77);
            this.Role_User.Name = "Role_User";
            this.Role_User.Size = new System.Drawing.Size(75, 23);
            this.Role_User.TabIndex = 1;
            this.Role_User.Text = "Role_User";
            this.Role_User.UseVisualStyleBackColor = true;
            this.Role_User.Click += new System.EventHandler(this.Role_User_Click);
            // 
            // Donneur
            // 
            this.Donneur.Location = new System.Drawing.Point(122, 164);
            this.Donneur.Name = "Donneur";
            this.Donneur.Size = new System.Drawing.Size(75, 23);
            this.Donneur.TabIndex = 3;
            this.Donneur.Text = "Donneur";
            this.Donneur.UseVisualStyleBackColor = true;
            this.Donneur.Click += new System.EventHandler(this.Donneur_Click);
            // 
            // Patient
            // 
            this.Patient.Location = new System.Drawing.Point(122, 106);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(75, 23);
            this.Patient.TabIndex = 2;
            this.Patient.Text = "Patient";
            this.Patient.UseVisualStyleBackColor = true;
            this.Patient.Click += new System.EventHandler(this.Patient_Click);
            // 
            // Tests
            // 
            this.Tests.Location = new System.Drawing.Point(122, 135);
            this.Tests.Name = "Tests";
            this.Tests.Size = new System.Drawing.Size(75, 23);
            this.Tests.TabIndex = 5;
            this.Tests.Text = "Tests";
            this.Tests.UseVisualStyleBackColor = true;
            this.Tests.Click += new System.EventHandler(this.Tests_Click);
            // 
            // TestsPatient
            // 
            this.TestsPatient.Location = new System.Drawing.Point(203, 106);
            this.TestsPatient.Name = "TestsPatient";
            this.TestsPatient.Size = new System.Drawing.Size(75, 23);
            this.TestsPatient.TabIndex = 4;
            this.TestsPatient.Text = "TestsPatient";
            this.TestsPatient.UseVisualStyleBackColor = true;
            this.TestsPatient.Click += new System.EventHandler(this.TestsPatient_Click);
            // 
            // Transplantation
            // 
            this.Transplantation.Location = new System.Drawing.Point(203, 164);
            this.Transplantation.Name = "Transplantation";
            this.Transplantation.Size = new System.Drawing.Size(75, 23);
            this.Transplantation.TabIndex = 7;
            this.Transplantation.Text = "Transplantation";
            this.Transplantation.UseVisualStyleBackColor = true;
            this.Transplantation.Click += new System.EventHandler(this.Transplantation_Click);
            // 
            // Categorie
            // 
            this.Categorie.Location = new System.Drawing.Point(203, 135);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(75, 23);
            this.Categorie.TabIndex = 6;
            this.Categorie.Text = "Categorie";
            this.Categorie.UseVisualStyleBackColor = true;
            this.Categorie.Click += new System.EventHandler(this.Categorie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 283);
            this.Controls.Add(this.Transplantation);
            this.Controls.Add(this.Categorie);
            this.Controls.Add(this.Tests);
            this.Controls.Add(this.TestsPatient);
            this.Controls.Add(this.Donneur);
            this.Controls.Add(this.Patient);
            this.Controls.Add(this.Role_User);
            this.Controls.Add(this.Utilisateur);
            this.Name = "Form1";
            this.Text = "Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Utilisateur;
        private System.Windows.Forms.Button Role_User;
        private System.Windows.Forms.Button Donneur;
        private System.Windows.Forms.Button Patient;
        private System.Windows.Forms.Button Tests;
        private System.Windows.Forms.Button TestsPatient;
        private System.Windows.Forms.Button Transplantation;
        private System.Windows.Forms.Button Categorie;
    }
}

