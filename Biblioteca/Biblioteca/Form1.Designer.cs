/**************************************************************************
 *                                                                        *
 *  File:        Form1.Designer.cs                                        *
 *  Copyright:   (c) 2023, Cojocaru Georgiana, Lupu Andra, Martin Maria,  *
			   Stefanel Petrescu Miron                        *
 *  E-mail:      georgiana-vasilica.cojocaru@student.tuiasi.ro            *
 *  E-mail:      andra-maria.lupu@student.tuiasi.ro                       *
 *  E-mail:      maria.martin@student.tuiasi.ro                           *
 *  E-mail:      stefanel.petrescu-miron@student.tuiasi.ro                *
 *  Description: Buttons details                                          *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/
namespace Biblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabUtilizator = new System.Windows.Forms.TabPage();
            this.buttonBackToMenuUtilizator = new System.Windows.Forms.Button();
            this.labelPassUtilizator = new System.Windows.Forms.Label();
            this.labelUsernameUtilizator = new System.Windows.Forms.Label();
            this.textBoxPassUtilizator = new System.Windows.Forms.TextBox();
            this.textBoxUsernameUtilizator = new System.Windows.Forms.TextBox();
            this.buttonAutentificareUtilizator = new System.Windows.Forms.Button();
            this.tabAdministrator = new System.Windows.Forms.TabPage();
            this.buttonBackToMenuAdministrator = new System.Windows.Forms.Button();
            this.labelPassAdministrator = new System.Windows.Forms.Label();
            this.labelUsernameAdministrator = new System.Windows.Forms.Label();
            this.textBoxPassAdministrator = new System.Windows.Forms.TextBox();
            this.textBoxUsernameAdministrator = new System.Windows.Forms.TextBox();
            this.buttonAutentificareAdministrator = new System.Windows.Forms.Button();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.buttonMeniuPrincipalAdministrator = new System.Windows.Forms.Button();
            this.buttonMeniuPrincipalUtilizator = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlPagini = new System.Windows.Forms.TabControl();
            this.tabPageAdministratorLogat = new System.Windows.Forms.TabPage();
            this.groupBoxUtilizatoriWelcAdministrator = new System.Windows.Forms.GroupBox();
            this.buttonAfisareListaUtilizatori = new System.Windows.Forms.Button();
            this.groupBoxAdvertisment = new System.Windows.Forms.GroupBox();
            this.comboBoxListaUtilizatoriAvertizare = new System.Windows.Forms.ComboBox();
            this.buttonAvertizareIntarziere = new System.Windows.Forms.Button();
            this.richTextBoxListaUtilizatoriWelcAdministrator = new System.Windows.Forms.RichTextBox();
            this.labelListaUtilizatoriWelcAdministrator = new System.Windows.Forms.Label();
            this.groupBoxStergeUtilizator = new System.Windows.Forms.GroupBox();
            this.comboBoxListaUtilizatoriStergere = new System.Windows.Forms.ComboBox();
            this.buttonStergeUtilizator = new System.Windows.Forms.Button();
            this.groupBoxAdaugareUtilizator = new System.Windows.Forms.GroupBox();
            this.buttonAdaugaUtilizator = new System.Windows.Forms.Button();
            this.textBoxParolaDeAdaugat = new System.Windows.Forms.TextBox();
            this.textBoxUsernamedeAdaugat = new System.Windows.Forms.TextBox();
            this.groupBoxCartiWelcAdministrator = new System.Windows.Forms.GroupBox();
            this.buttonAfisareListaCarti = new System.Windows.Forms.Button();
            this.groupBoxAdaugaCarti = new System.Windows.Forms.GroupBox();
            this.buttonAdaugaCarte = new System.Windows.Forms.Button();
            this.textBoxTitluCarteDeAdaugat = new System.Windows.Forms.TextBox();
            this.textBoxISBNCarteDeAdaugat = new System.Windows.Forms.TextBox();
            this.textBoxAutorCarteDeAdaugat = new System.Windows.Forms.TextBox();
            this.groupBoxStergereCarte = new System.Windows.Forms.GroupBox();
            this.comboBoxListaCartiStergere = new System.Windows.Forms.ComboBox();
            this.buttonStergeCarte = new System.Windows.Forms.Button();
            this.labelListaCartiWelcAdministrator = new System.Windows.Forms.Label();
            this.richTextBoxListaCartiWelcAdministrator = new System.Windows.Forms.RichTextBox();
            this.buttonUtilizatoriWelcAdministrator = new System.Windows.Forms.Button();
            this.buttonCartiWelcAdministrator = new System.Windows.Forms.Button();
            this.buttonBackToMenuWelcAdministrator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageUtilizatorLogat = new System.Windows.Forms.TabPage();
            this.listBoxCartiReturnat = new System.Windows.Forms.ListBox();
            this.listBoxCartiImprumutat = new System.Windows.Forms.ListBox();
            this.buttonUtilizatorReturnare = new System.Windows.Forms.Button();
            this.buttonUtilizatorImprumutare = new System.Windows.Forms.Button();
            this.buttonBackToMenuWelcUtilizator = new System.Windows.Forms.Button();
            this.buttonUtilizatorReturn = new System.Windows.Forms.Button();
            this.buttonUtilizatorImprumut = new System.Windows.Forms.Button();
            this.tabUtilizator.SuspendLayout();
            this.tabAdministrator.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tabControlPagini.SuspendLayout();
            this.tabPageAdministratorLogat.SuspendLayout();
            this.groupBoxUtilizatoriWelcAdministrator.SuspendLayout();
            this.groupBoxAdvertisment.SuspendLayout();
            this.groupBoxStergeUtilizator.SuspendLayout();
            this.groupBoxAdaugareUtilizator.SuspendLayout();
            this.groupBoxCartiWelcAdministrator.SuspendLayout();
            this.groupBoxAdaugaCarti.SuspendLayout();
            this.groupBoxStergereCarte.SuspendLayout();
            this.tabPageUtilizatorLogat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabUtilizator
            // 
            this.tabUtilizator.BackgroundImage = global::Biblioteca.Properties.Resources.back;
            this.tabUtilizator.Controls.Add(this.buttonBackToMenuUtilizator);
            this.tabUtilizator.Controls.Add(this.labelPassUtilizator);
            this.tabUtilizator.Controls.Add(this.labelUsernameUtilizator);
            this.tabUtilizator.Controls.Add(this.textBoxPassUtilizator);
            this.tabUtilizator.Controls.Add(this.textBoxUsernameUtilizator);
            this.tabUtilizator.Controls.Add(this.buttonAutentificareUtilizator);
            this.tabUtilizator.Location = new System.Drawing.Point(4, 22);
            this.tabUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUtilizator.Name = "tabUtilizator";
            this.tabUtilizator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabUtilizator.Size = new System.Drawing.Size(828, 469);
            this.tabUtilizator.TabIndex = 0;
            this.tabUtilizator.Text = "Utilizator";
            this.tabUtilizator.UseVisualStyleBackColor = true;
            // 
            // buttonBackToMenuUtilizator
            // 
            this.buttonBackToMenuUtilizator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonBackToMenuUtilizator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToMenuUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMenuUtilizator.ForeColor = System.Drawing.Color.White;
            this.buttonBackToMenuUtilizator.Location = new System.Drawing.Point(753, 5);
            this.buttonBackToMenuUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBackToMenuUtilizator.Name = "buttonBackToMenuUtilizator";
            this.buttonBackToMenuUtilizator.Size = new System.Drawing.Size(72, 33);
            this.buttonBackToMenuUtilizator.TabIndex = 5;
            this.buttonBackToMenuUtilizator.Text = "Menu";
            this.buttonBackToMenuUtilizator.UseVisualStyleBackColor = false;
            this.buttonBackToMenuUtilizator.Click += new System.EventHandler(this.buttonBackToMenuUtilizator_Click);
            // 
            // labelPassUtilizator
            // 
            this.labelPassUtilizator.AutoSize = true;
            this.labelPassUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.labelPassUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelPassUtilizator.ForeColor = System.Drawing.Color.White;
            this.labelPassUtilizator.Location = new System.Drawing.Point(356, 174);
            this.labelPassUtilizator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassUtilizator.Name = "labelPassUtilizator";
            this.labelPassUtilizator.Size = new System.Drawing.Size(116, 26);
            this.labelPassUtilizator.TabIndex = 4;
            this.labelPassUtilizator.Text = "Password";
            // 
            // labelUsernameUtilizator
            // 
            this.labelUsernameUtilizator.AutoSize = true;
            this.labelUsernameUtilizator.BackColor = System.Drawing.Color.Transparent;
            this.labelUsernameUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelUsernameUtilizator.ForeColor = System.Drawing.Color.White;
            this.labelUsernameUtilizator.Location = new System.Drawing.Point(356, 60);
            this.labelUsernameUtilizator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsernameUtilizator.Name = "labelUsernameUtilizator";
            this.labelUsernameUtilizator.Size = new System.Drawing.Size(121, 26);
            this.labelUsernameUtilizator.TabIndex = 3;
            this.labelUsernameUtilizator.Text = "Username";
            // 
            // textBoxPassUtilizator
            // 
            this.textBoxPassUtilizator.Location = new System.Drawing.Point(322, 222);
            this.textBoxPassUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassUtilizator.Name = "textBoxPassUtilizator";
            this.textBoxPassUtilizator.PasswordChar = '*';
            this.textBoxPassUtilizator.Size = new System.Drawing.Size(174, 20);
            this.textBoxPassUtilizator.TabIndex = 2;
            // 
            // textBoxUsernameUtilizator
            // 
            this.textBoxUsernameUtilizator.Location = new System.Drawing.Point(324, 102);
            this.textBoxUsernameUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsernameUtilizator.Name = "textBoxUsernameUtilizator";
            this.textBoxUsernameUtilizator.Size = new System.Drawing.Size(174, 20);
            this.textBoxUsernameUtilizator.TabIndex = 1;
            // 
            // buttonAutentificareUtilizator
            // 
            this.buttonAutentificareUtilizator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAutentificareUtilizator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutentificareUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutentificareUtilizator.ForeColor = System.Drawing.Color.White;
            this.buttonAutentificareUtilizator.Location = new System.Drawing.Point(332, 301);
            this.buttonAutentificareUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAutentificareUtilizator.Name = "buttonAutentificareUtilizator";
            this.buttonAutentificareUtilizator.Size = new System.Drawing.Size(165, 61);
            this.buttonAutentificareUtilizator.TabIndex = 0;
            this.buttonAutentificareUtilizator.Text = "Autentificare";
            this.buttonAutentificareUtilizator.UseVisualStyleBackColor = false;
            this.buttonAutentificareUtilizator.Click += new System.EventHandler(this.buttonAutentificareUtilizator_Click);
            // 
            // tabAdministrator
            // 
            this.tabAdministrator.BackgroundImage = global::Biblioteca.Properties.Resources.back;
            this.tabAdministrator.Controls.Add(this.buttonBackToMenuAdministrator);
            this.tabAdministrator.Controls.Add(this.labelPassAdministrator);
            this.tabAdministrator.Controls.Add(this.labelUsernameAdministrator);
            this.tabAdministrator.Controls.Add(this.textBoxPassAdministrator);
            this.tabAdministrator.Controls.Add(this.textBoxUsernameAdministrator);
            this.tabAdministrator.Controls.Add(this.buttonAutentificareAdministrator);
            this.tabAdministrator.Location = new System.Drawing.Point(4, 22);
            this.tabAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAdministrator.Name = "tabAdministrator";
            this.tabAdministrator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabAdministrator.Size = new System.Drawing.Size(828, 469);
            this.tabAdministrator.TabIndex = 1;
            this.tabAdministrator.Text = "Administrator";
            this.tabAdministrator.UseVisualStyleBackColor = true;
            // 
            // buttonBackToMenuAdministrator
            // 
            this.buttonBackToMenuAdministrator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonBackToMenuAdministrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToMenuAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMenuAdministrator.ForeColor = System.Drawing.Color.White;
            this.buttonBackToMenuAdministrator.Location = new System.Drawing.Point(753, 5);
            this.buttonBackToMenuAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBackToMenuAdministrator.Name = "buttonBackToMenuAdministrator";
            this.buttonBackToMenuAdministrator.Size = new System.Drawing.Size(72, 33);
            this.buttonBackToMenuAdministrator.TabIndex = 11;
            this.buttonBackToMenuAdministrator.Text = "Menu";
            this.buttonBackToMenuAdministrator.UseVisualStyleBackColor = false;
            this.buttonBackToMenuAdministrator.Click += new System.EventHandler(this.buttonBackToMenuAdministrator_Click);
            // 
            // labelPassAdministrator
            // 
            this.labelPassAdministrator.AutoSize = true;
            this.labelPassAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.labelPassAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelPassAdministrator.ForeColor = System.Drawing.Color.White;
            this.labelPassAdministrator.Location = new System.Drawing.Point(344, 193);
            this.labelPassAdministrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassAdministrator.Name = "labelPassAdministrator";
            this.labelPassAdministrator.Size = new System.Drawing.Size(116, 26);
            this.labelPassAdministrator.TabIndex = 10;
            this.labelPassAdministrator.Text = "Password";
            // 
            // labelUsernameAdministrator
            // 
            this.labelUsernameAdministrator.AutoSize = true;
            this.labelUsernameAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.labelUsernameAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelUsernameAdministrator.ForeColor = System.Drawing.Color.White;
            this.labelUsernameAdministrator.Location = new System.Drawing.Point(339, 78);
            this.labelUsernameAdministrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsernameAdministrator.Name = "labelUsernameAdministrator";
            this.labelUsernameAdministrator.Size = new System.Drawing.Size(121, 26);
            this.labelUsernameAdministrator.TabIndex = 9;
            this.labelUsernameAdministrator.Text = "Username";
            // 
            // textBoxPassAdministrator
            // 
            this.textBoxPassAdministrator.Location = new System.Drawing.Point(308, 239);
            this.textBoxPassAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassAdministrator.Name = "textBoxPassAdministrator";
            this.textBoxPassAdministrator.PasswordChar = '*';
            this.textBoxPassAdministrator.Size = new System.Drawing.Size(174, 20);
            this.textBoxPassAdministrator.TabIndex = 8;
            // 
            // textBoxUsernameAdministrator
            // 
            this.textBoxUsernameAdministrator.Location = new System.Drawing.Point(310, 119);
            this.textBoxUsernameAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsernameAdministrator.Name = "textBoxUsernameAdministrator";
            this.textBoxUsernameAdministrator.Size = new System.Drawing.Size(174, 20);
            this.textBoxUsernameAdministrator.TabIndex = 7;
            // 
            // buttonAutentificareAdministrator
            // 
            this.buttonAutentificareAdministrator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAutentificareAdministrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutentificareAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutentificareAdministrator.ForeColor = System.Drawing.Color.White;
            this.buttonAutentificareAdministrator.Location = new System.Drawing.Point(317, 326);
            this.buttonAutentificareAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAutentificareAdministrator.Name = "buttonAutentificareAdministrator";
            this.buttonAutentificareAdministrator.Size = new System.Drawing.Size(165, 61);
            this.buttonAutentificareAdministrator.TabIndex = 6;
            this.buttonAutentificareAdministrator.Text = "Autentificare";
            this.buttonAutentificareAdministrator.UseVisualStyleBackColor = false;
            this.buttonAutentificareAdministrator.Click += new System.EventHandler(this.buttonAutentificareAdministrator_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.BackgroundImage = global::Biblioteca.Properties.Resources.back;
            this.tabMenu.Controls.Add(this.labelTitlu);
            this.tabMenu.Controls.Add(this.buttonMeniuPrincipalAdministrator);
            this.tabMenu.Controls.Add(this.buttonMeniuPrincipalUtilizator);
            this.tabMenu.Controls.Add(this.menuStrip);
            this.tabMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(828, 469);
            this.tabMenu.TabIndex = 2;
            this.tabMenu.Text = "Menu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.ForeColor = System.Drawing.Color.White;
            this.labelTitlu.Location = new System.Drawing.Point(162, 128);
            this.labelTitlu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(547, 73);
            this.labelTitlu.TabIndex = 3;
            this.labelTitlu.Text = "My Virtual Library";
            // 
            // buttonMeniuPrincipalAdministrator
            // 
            this.buttonMeniuPrincipalAdministrator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonMeniuPrincipalAdministrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMeniuPrincipalAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeniuPrincipalAdministrator.ForeColor = System.Drawing.Color.White;
            this.buttonMeniuPrincipalAdministrator.Location = new System.Drawing.Point(515, 372);
            this.buttonMeniuPrincipalAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMeniuPrincipalAdministrator.Name = "buttonMeniuPrincipalAdministrator";
            this.buttonMeniuPrincipalAdministrator.Size = new System.Drawing.Size(165, 61);
            this.buttonMeniuPrincipalAdministrator.TabIndex = 1;
            this.buttonMeniuPrincipalAdministrator.Text = "Administrator";
            this.buttonMeniuPrincipalAdministrator.UseVisualStyleBackColor = false;
            this.buttonMeniuPrincipalAdministrator.Click += new System.EventHandler(this.buttonMeniuPrincipalAdministrator_Click);
            // 
            // buttonMeniuPrincipalUtilizator
            // 
            this.buttonMeniuPrincipalUtilizator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonMeniuPrincipalUtilizator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMeniuPrincipalUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeniuPrincipalUtilizator.ForeColor = System.Drawing.Color.White;
            this.buttonMeniuPrincipalUtilizator.Location = new System.Drawing.Point(172, 372);
            this.buttonMeniuPrincipalUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMeniuPrincipalUtilizator.Name = "buttonMeniuPrincipalUtilizator";
            this.buttonMeniuPrincipalUtilizator.Size = new System.Drawing.Size(165, 61);
            this.buttonMeniuPrincipalUtilizator.TabIndex = 2;
            this.buttonMeniuPrincipalUtilizator.Text = "Utilizator";
            this.buttonMeniuPrincipalUtilizator.UseVisualStyleBackColor = false;
            this.buttonMeniuPrincipalUtilizator.Click += new System.EventHandler(this.buttonMeniuPrincipalUtilizator_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = global::Biblioteca.Properties.Resources.back;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 35);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(828, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemMenu
            // 
            this.ToolStripMenuItemMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemMenu.BackgroundImage")));
            this.ToolStripMenuItemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ToolStripMenuItemMenu.Name = "ToolStripMenuItemMenu";
            this.ToolStripMenuItemMenu.Size = new System.Drawing.Size(22, 20);
            this.ToolStripMenuItemMenu.Text = " ";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControlPagini
            // 
            this.tabControlPagini.Controls.Add(this.tabMenu);
            this.tabControlPagini.Controls.Add(this.tabAdministrator);
            this.tabControlPagini.Controls.Add(this.tabUtilizator);
            this.tabControlPagini.Controls.Add(this.tabPageAdministratorLogat);
            this.tabControlPagini.Controls.Add(this.tabPageUtilizatorLogat);
            this.tabControlPagini.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControlPagini.Location = new System.Drawing.Point(2, 0);
            this.tabControlPagini.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlPagini.Name = "tabControlPagini";
            this.tabControlPagini.SelectedIndex = 0;
            this.tabControlPagini.Size = new System.Drawing.Size(836, 495);
            this.tabControlPagini.TabIndex = 0;
            // 
            // tabPageAdministratorLogat
            // 
            this.tabPageAdministratorLogat.BackgroundImage = global::Biblioteca.Properties.Resources.back;
            this.tabPageAdministratorLogat.Controls.Add(this.groupBoxUtilizatoriWelcAdministrator);
            this.tabPageAdministratorLogat.Controls.Add(this.groupBoxCartiWelcAdministrator);
            this.tabPageAdministratorLogat.Controls.Add(this.buttonUtilizatoriWelcAdministrator);
            this.tabPageAdministratorLogat.Controls.Add(this.buttonCartiWelcAdministrator);
            this.tabPageAdministratorLogat.Controls.Add(this.buttonBackToMenuWelcAdministrator);
            this.tabPageAdministratorLogat.Controls.Add(this.label1);
            this.tabPageAdministratorLogat.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdministratorLogat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAdministratorLogat.Name = "tabPageAdministratorLogat";
            this.tabPageAdministratorLogat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageAdministratorLogat.Size = new System.Drawing.Size(828, 469);
            this.tabPageAdministratorLogat.TabIndex = 3;
            this.tabPageAdministratorLogat.Text = "WelcomeAdministrator";
            this.tabPageAdministratorLogat.UseVisualStyleBackColor = true;
            // 
            // groupBoxUtilizatoriWelcAdministrator
            // 
            this.groupBoxUtilizatoriWelcAdministrator.Controls.Add(this.buttonAfisareListaUtilizatori);
            this.groupBoxUtilizatoriWelcAdministrator.Controls.Add(this.groupBoxAdvertisment);
            this.groupBoxUtilizatoriWelcAdministrator.Controls.Add(this.richTextBoxListaUtilizatoriWelcAdministrator);
            this.groupBoxUtilizatoriWelcAdministrator.Controls.Add(this.labelListaUtilizatoriWelcAdministrator);
            this.groupBoxUtilizatoriWelcAdministrator.Controls.Add(this.groupBoxStergeUtilizator);
            this.groupBoxUtilizatoriWelcAdministrator.Controls.Add(this.groupBoxAdaugareUtilizator);
            this.groupBoxUtilizatoriWelcAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUtilizatoriWelcAdministrator.ForeColor = System.Drawing.Color.White;
            this.groupBoxUtilizatoriWelcAdministrator.Location = new System.Drawing.Point(428, 61);
            this.groupBoxUtilizatoriWelcAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUtilizatoriWelcAdministrator.Name = "groupBoxUtilizatoriWelcAdministrator";
            this.groupBoxUtilizatoriWelcAdministrator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxUtilizatoriWelcAdministrator.Size = new System.Drawing.Size(349, 405);
            this.groupBoxUtilizatoriWelcAdministrator.TabIndex = 17;
            this.groupBoxUtilizatoriWelcAdministrator.TabStop = false;
            this.groupBoxUtilizatoriWelcAdministrator.Text = "Utilizatori";
            this.groupBoxUtilizatoriWelcAdministrator.Visible = false;
            // 
            // buttonAfisareListaUtilizatori
            // 
            this.buttonAfisareListaUtilizatori.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAfisareListaUtilizatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisareListaUtilizatori.ForeColor = System.Drawing.Color.White;
            this.buttonAfisareListaUtilizatori.Location = new System.Drawing.Point(134, 284);
            this.buttonAfisareListaUtilizatori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAfisareListaUtilizatori.Name = "buttonAfisareListaUtilizatori";
            this.buttonAfisareListaUtilizatori.Size = new System.Drawing.Size(75, 28);
            this.buttonAfisareListaUtilizatori.TabIndex = 20;
            this.buttonAfisareListaUtilizatori.Text = "Afisare";
            this.buttonAfisareListaUtilizatori.UseVisualStyleBackColor = false;
            this.buttonAfisareListaUtilizatori.Click += new System.EventHandler(this.buttonAfisareListaUtilizatori_Click);
            // 
            // groupBoxAdvertisment
            // 
            this.groupBoxAdvertisment.Controls.Add(this.comboBoxListaUtilizatoriAvertizare);
            this.groupBoxAdvertisment.Controls.Add(this.buttonAvertizareIntarziere);
            this.groupBoxAdvertisment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdvertisment.ForeColor = System.Drawing.Color.White;
            this.groupBoxAdvertisment.Location = new System.Drawing.Point(19, 325);
            this.groupBoxAdvertisment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAdvertisment.Name = "groupBoxAdvertisment";
            this.groupBoxAdvertisment.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAdvertisment.Size = new System.Drawing.Size(321, 76);
            this.groupBoxAdvertisment.TabIndex = 19;
            this.groupBoxAdvertisment.TabStop = false;
            this.groupBoxAdvertisment.Text = "Avertizare Intarziere";
            // 
            // comboBoxListaUtilizatoriAvertizare
            // 
            this.comboBoxListaUtilizatoriAvertizare.FormattingEnabled = true;
            this.comboBoxListaUtilizatoriAvertizare.Location = new System.Drawing.Point(16, 33);
            this.comboBoxListaUtilizatoriAvertizare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxListaUtilizatoriAvertizare.Name = "comboBoxListaUtilizatoriAvertizare";
            this.comboBoxListaUtilizatoriAvertizare.Size = new System.Drawing.Size(140, 23);
            this.comboBoxListaUtilizatoriAvertizare.TabIndex = 13;
            // 
            // buttonAvertizareIntarziere
            // 
            this.buttonAvertizareIntarziere.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAvertizareIntarziere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvertizareIntarziere.ForeColor = System.Drawing.Color.White;
            this.buttonAvertizareIntarziere.Location = new System.Drawing.Point(178, 15);
            this.buttonAvertizareIntarziere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAvertizareIntarziere.Name = "buttonAvertizareIntarziere";
            this.buttonAvertizareIntarziere.Size = new System.Drawing.Size(111, 55);
            this.buttonAvertizareIntarziere.TabIndex = 14;
            this.buttonAvertizareIntarziere.Text = "Trimite Avertizare!";
            this.buttonAvertizareIntarziere.UseVisualStyleBackColor = false;
            this.buttonAvertizareIntarziere.Click += new System.EventHandler(this.buttonAvertizareIntarziere_Click);
            // 
            // richTextBoxListaUtilizatoriWelcAdministrator
            // 
            this.richTextBoxListaUtilizatoriWelcAdministrator.Location = new System.Drawing.Point(19, 184);
            this.richTextBoxListaUtilizatoriWelcAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxListaUtilizatoriWelcAdministrator.Name = "richTextBoxListaUtilizatoriWelcAdministrator";
            this.richTextBoxListaUtilizatoriWelcAdministrator.Size = new System.Drawing.Size(322, 96);
            this.richTextBoxListaUtilizatoriWelcAdministrator.TabIndex = 18;
            this.richTextBoxListaUtilizatoriWelcAdministrator.Text = "";
            // 
            // labelListaUtilizatoriWelcAdministrator
            // 
            this.labelListaUtilizatoriWelcAdministrator.AutoSize = true;
            this.labelListaUtilizatoriWelcAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.labelListaUtilizatoriWelcAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelListaUtilizatoriWelcAdministrator.ForeColor = System.Drawing.Color.White;
            this.labelListaUtilizatoriWelcAdministrator.Location = new System.Drawing.Point(14, 155);
            this.labelListaUtilizatoriWelcAdministrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListaUtilizatoriWelcAdministrator.Name = "labelListaUtilizatoriWelcAdministrator";
            this.labelListaUtilizatoriWelcAdministrator.Size = new System.Drawing.Size(171, 26);
            this.labelListaUtilizatoriWelcAdministrator.TabIndex = 17;
            this.labelListaUtilizatoriWelcAdministrator.Text = "Lista Utilizatori";
            // 
            // groupBoxStergeUtilizator
            // 
            this.groupBoxStergeUtilizator.Controls.Add(this.comboBoxListaUtilizatoriStergere);
            this.groupBoxStergeUtilizator.Controls.Add(this.buttonStergeUtilizator);
            this.groupBoxStergeUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStergeUtilizator.ForeColor = System.Drawing.Color.White;
            this.groupBoxStergeUtilizator.Location = new System.Drawing.Point(14, 101);
            this.groupBoxStergeUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxStergeUtilizator.Name = "groupBoxStergeUtilizator";
            this.groupBoxStergeUtilizator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxStergeUtilizator.Size = new System.Drawing.Size(321, 52);
            this.groupBoxStergeUtilizator.TabIndex = 16;
            this.groupBoxStergeUtilizator.TabStop = false;
            this.groupBoxStergeUtilizator.Text = "Stergere utilizator";
            // 
            // comboBoxListaUtilizatoriStergere
            // 
            this.comboBoxListaUtilizatoriStergere.FormattingEnabled = true;
            this.comboBoxListaUtilizatoriStergere.Location = new System.Drawing.Point(21, 20);
            this.comboBoxListaUtilizatoriStergere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxListaUtilizatoriStergere.Name = "comboBoxListaUtilizatoriStergere";
            this.comboBoxListaUtilizatoriStergere.Size = new System.Drawing.Size(140, 23);
            this.comboBoxListaUtilizatoriStergere.TabIndex = 13;
            // 
            // buttonStergeUtilizator
            // 
            this.buttonStergeUtilizator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonStergeUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergeUtilizator.ForeColor = System.Drawing.Color.White;
            this.buttonStergeUtilizator.Location = new System.Drawing.Point(214, 15);
            this.buttonStergeUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStergeUtilizator.Name = "buttonStergeUtilizator";
            this.buttonStergeUtilizator.Size = new System.Drawing.Size(75, 28);
            this.buttonStergeUtilizator.TabIndex = 14;
            this.buttonStergeUtilizator.Text = "Sterge";
            this.buttonStergeUtilizator.UseVisualStyleBackColor = false;
            this.buttonStergeUtilizator.Click += new System.EventHandler(this.buttonStergeUtilizator_Click);
            // 
            // groupBoxAdaugareUtilizator
            // 
            this.groupBoxAdaugareUtilizator.Controls.Add(this.buttonAdaugaUtilizator);
            this.groupBoxAdaugareUtilizator.Controls.Add(this.textBoxParolaDeAdaugat);
            this.groupBoxAdaugareUtilizator.Controls.Add(this.textBoxUsernamedeAdaugat);
            this.groupBoxAdaugareUtilizator.ForeColor = System.Drawing.Color.White;
            this.groupBoxAdaugareUtilizator.Location = new System.Drawing.Point(14, 26);
            this.groupBoxAdaugareUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAdaugareUtilizator.Name = "groupBoxAdaugareUtilizator";
            this.groupBoxAdaugareUtilizator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAdaugareUtilizator.Size = new System.Drawing.Size(322, 62);
            this.groupBoxAdaugareUtilizator.TabIndex = 0;
            this.groupBoxAdaugareUtilizator.TabStop = false;
            this.groupBoxAdaugareUtilizator.Text = "Adaugare Utilizator";
            // 
            // buttonAdaugaUtilizator
            // 
            this.buttonAdaugaUtilizator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAdaugaUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaUtilizator.ForeColor = System.Drawing.Color.White;
            this.buttonAdaugaUtilizator.Location = new System.Drawing.Point(235, 17);
            this.buttonAdaugaUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdaugaUtilizator.Name = "buttonAdaugaUtilizator";
            this.buttonAdaugaUtilizator.Size = new System.Drawing.Size(75, 36);
            this.buttonAdaugaUtilizator.TabIndex = 13;
            this.buttonAdaugaUtilizator.Text = "Adauga";
            this.buttonAdaugaUtilizator.UseVisualStyleBackColor = false;
            this.buttonAdaugaUtilizator.Click += new System.EventHandler(this.buttonAdaugaUtilizator_Click);
            // 
            // textBoxParolaDeAdaugat
            // 
            this.textBoxParolaDeAdaugat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParolaDeAdaugat.Location = new System.Drawing.Point(120, 24);
            this.textBoxParolaDeAdaugat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxParolaDeAdaugat.Name = "textBoxParolaDeAdaugat";
            this.textBoxParolaDeAdaugat.Size = new System.Drawing.Size(100, 23);
            this.textBoxParolaDeAdaugat.TabIndex = 1;
            this.textBoxParolaDeAdaugat.Text = "Parola";
            // 
            // textBoxUsernamedeAdaugat
            // 
            this.textBoxUsernamedeAdaugat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernamedeAdaugat.Location = new System.Drawing.Point(16, 24);
            this.textBoxUsernamedeAdaugat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUsernamedeAdaugat.Name = "textBoxUsernamedeAdaugat";
            this.textBoxUsernamedeAdaugat.Size = new System.Drawing.Size(100, 23);
            this.textBoxUsernamedeAdaugat.TabIndex = 0;
            this.textBoxUsernamedeAdaugat.Text = "Username";
            // 
            // groupBoxCartiWelcAdministrator
            // 
            this.groupBoxCartiWelcAdministrator.Controls.Add(this.buttonAfisareListaCarti);
            this.groupBoxCartiWelcAdministrator.Controls.Add(this.groupBoxAdaugaCarti);
            this.groupBoxCartiWelcAdministrator.Controls.Add(this.groupBoxStergereCarte);
            this.groupBoxCartiWelcAdministrator.Controls.Add(this.labelListaCartiWelcAdministrator);
            this.groupBoxCartiWelcAdministrator.Controls.Add(this.richTextBoxListaCartiWelcAdministrator);
            this.groupBoxCartiWelcAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCartiWelcAdministrator.ForeColor = System.Drawing.Color.White;
            this.groupBoxCartiWelcAdministrator.Location = new System.Drawing.Point(31, 61);
            this.groupBoxCartiWelcAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCartiWelcAdministrator.Name = "groupBoxCartiWelcAdministrator";
            this.groupBoxCartiWelcAdministrator.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCartiWelcAdministrator.Size = new System.Drawing.Size(349, 407);
            this.groupBoxCartiWelcAdministrator.TabIndex = 16;
            this.groupBoxCartiWelcAdministrator.TabStop = false;
            this.groupBoxCartiWelcAdministrator.Text = "Carti";
            this.groupBoxCartiWelcAdministrator.Visible = false;
            // 
            // buttonAfisareListaCarti
            // 
            this.buttonAfisareListaCarti.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAfisareListaCarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisareListaCarti.ForeColor = System.Drawing.Color.White;
            this.buttonAfisareListaCarti.Location = new System.Drawing.Point(130, 366);
            this.buttonAfisareListaCarti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAfisareListaCarti.Name = "buttonAfisareListaCarti";
            this.buttonAfisareListaCarti.Size = new System.Drawing.Size(75, 28);
            this.buttonAfisareListaCarti.TabIndex = 16;
            this.buttonAfisareListaCarti.Text = "Afisare";
            this.buttonAfisareListaCarti.UseVisualStyleBackColor = false;
            this.buttonAfisareListaCarti.Click += new System.EventHandler(this.buttonAfisareListaCarti_Click);
            // 
            // groupBoxAdaugaCarti
            // 
            this.groupBoxAdaugaCarti.Controls.Add(this.buttonAdaugaCarte);
            this.groupBoxAdaugaCarti.Controls.Add(this.textBoxTitluCarteDeAdaugat);
            this.groupBoxAdaugaCarti.Controls.Add(this.textBoxISBNCarteDeAdaugat);
            this.groupBoxAdaugaCarti.Controls.Add(this.textBoxAutorCarteDeAdaugat);
            this.groupBoxAdaugaCarti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAdaugaCarti.ForeColor = System.Drawing.Color.White;
            this.groupBoxAdaugaCarti.Location = new System.Drawing.Point(13, 26);
            this.groupBoxAdaugaCarti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAdaugaCarti.Name = "groupBoxAdaugaCarti";
            this.groupBoxAdaugaCarti.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAdaugaCarti.Size = new System.Drawing.Size(321, 90);
            this.groupBoxAdaugaCarti.TabIndex = 12;
            this.groupBoxAdaugaCarti.TabStop = false;
            this.groupBoxAdaugaCarti.Text = "Adaugare Carte";
            // 
            // buttonAdaugaCarte
            // 
            this.buttonAdaugaCarte.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonAdaugaCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdaugaCarte.ForeColor = System.Drawing.Color.White;
            this.buttonAdaugaCarte.Location = new System.Drawing.Point(117, 46);
            this.buttonAdaugaCarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdaugaCarte.Name = "buttonAdaugaCarte";
            this.buttonAdaugaCarte.Size = new System.Drawing.Size(75, 36);
            this.buttonAdaugaCarte.TabIndex = 12;
            this.buttonAdaugaCarte.Text = "Adauga";
            this.buttonAdaugaCarte.UseVisualStyleBackColor = false;
            this.buttonAdaugaCarte.Click += new System.EventHandler(this.buttonAdaugaCarte_Click);
            // 
            // textBoxTitluCarteDeAdaugat
            // 
            this.textBoxTitluCarteDeAdaugat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitluCarteDeAdaugat.Location = new System.Drawing.Point(21, 17);
            this.textBoxTitluCarteDeAdaugat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTitluCarteDeAdaugat.Name = "textBoxTitluCarteDeAdaugat";
            this.textBoxTitluCarteDeAdaugat.Size = new System.Drawing.Size(76, 23);
            this.textBoxTitluCarteDeAdaugat.TabIndex = 9;
            this.textBoxTitluCarteDeAdaugat.Text = "Titlu";
            // 
            // textBoxISBNCarteDeAdaugat
            // 
            this.textBoxISBNCarteDeAdaugat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxISBNCarteDeAdaugat.Location = new System.Drawing.Point(226, 19);
            this.textBoxISBNCarteDeAdaugat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxISBNCarteDeAdaugat.Name = "textBoxISBNCarteDeAdaugat";
            this.textBoxISBNCarteDeAdaugat.Size = new System.Drawing.Size(76, 23);
            this.textBoxISBNCarteDeAdaugat.TabIndex = 11;
            this.textBoxISBNCarteDeAdaugat.Text = "ISBN";
            // 
            // textBoxAutorCarteDeAdaugat
            // 
            this.textBoxAutorCarteDeAdaugat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAutorCarteDeAdaugat.Location = new System.Drawing.Point(117, 19);
            this.textBoxAutorCarteDeAdaugat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAutorCarteDeAdaugat.Name = "textBoxAutorCarteDeAdaugat";
            this.textBoxAutorCarteDeAdaugat.Size = new System.Drawing.Size(76, 23);
            this.textBoxAutorCarteDeAdaugat.TabIndex = 10;
            this.textBoxAutorCarteDeAdaugat.Text = "Autor";
            // 
            // groupBoxStergereCarte
            // 
            this.groupBoxStergereCarte.Controls.Add(this.comboBoxListaCartiStergere);
            this.groupBoxStergereCarte.Controls.Add(this.buttonStergeCarte);
            this.groupBoxStergereCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStergereCarte.ForeColor = System.Drawing.Color.White;
            this.groupBoxStergereCarte.Location = new System.Drawing.Point(13, 136);
            this.groupBoxStergereCarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxStergereCarte.Name = "groupBoxStergereCarte";
            this.groupBoxStergereCarte.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxStergereCarte.Size = new System.Drawing.Size(321, 52);
            this.groupBoxStergereCarte.TabIndex = 15;
            this.groupBoxStergereCarte.TabStop = false;
            this.groupBoxStergereCarte.Text = "Stergere Carte";
            // 
            // comboBoxListaCartiStergere
            // 
            this.comboBoxListaCartiStergere.FormattingEnabled = true;
            this.comboBoxListaCartiStergere.Location = new System.Drawing.Point(21, 20);
            this.comboBoxListaCartiStergere.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxListaCartiStergere.Name = "comboBoxListaCartiStergere";
            this.comboBoxListaCartiStergere.Size = new System.Drawing.Size(140, 23);
            this.comboBoxListaCartiStergere.TabIndex = 13;
            // 
            // buttonStergeCarte
            // 
            this.buttonStergeCarte.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonStergeCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergeCarte.ForeColor = System.Drawing.Color.White;
            this.buttonStergeCarte.Location = new System.Drawing.Point(214, 15);
            this.buttonStergeCarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStergeCarte.Name = "buttonStergeCarte";
            this.buttonStergeCarte.Size = new System.Drawing.Size(75, 28);
            this.buttonStergeCarte.TabIndex = 14;
            this.buttonStergeCarte.Text = "Sterge";
            this.buttonStergeCarte.UseVisualStyleBackColor = false;
            this.buttonStergeCarte.Click += new System.EventHandler(this.buttonStergeCarte_Click);
            // 
            // labelListaCartiWelcAdministrator
            // 
            this.labelListaCartiWelcAdministrator.AutoSize = true;
            this.labelListaCartiWelcAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.labelListaCartiWelcAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelListaCartiWelcAdministrator.ForeColor = System.Drawing.Color.White;
            this.labelListaCartiWelcAdministrator.Location = new System.Drawing.Point(8, 190);
            this.labelListaCartiWelcAdministrator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListaCartiWelcAdministrator.Name = "labelListaCartiWelcAdministrator";
            this.labelListaCartiWelcAdministrator.Size = new System.Drawing.Size(121, 26);
            this.labelListaCartiWelcAdministrator.TabIndex = 4;
            this.labelListaCartiWelcAdministrator.Text = "Lista Carti";
            // 
            // richTextBoxListaCartiWelcAdministrator
            // 
            this.richTextBoxListaCartiWelcAdministrator.Location = new System.Drawing.Point(13, 225);
            this.richTextBoxListaCartiWelcAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxListaCartiWelcAdministrator.Name = "richTextBoxListaCartiWelcAdministrator";
            this.richTextBoxListaCartiWelcAdministrator.Size = new System.Drawing.Size(322, 134);
            this.richTextBoxListaCartiWelcAdministrator.TabIndex = 5;
            this.richTextBoxListaCartiWelcAdministrator.Text = "";
            // 
            // buttonUtilizatoriWelcAdministrator
            // 
            this.buttonUtilizatoriWelcAdministrator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUtilizatoriWelcAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilizatoriWelcAdministrator.ForeColor = System.Drawing.Color.White;
            this.buttonUtilizatoriWelcAdministrator.Location = new System.Drawing.Point(428, 20);
            this.buttonUtilizatoriWelcAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUtilizatoriWelcAdministrator.Name = "buttonUtilizatoriWelcAdministrator";
            this.buttonUtilizatoriWelcAdministrator.Size = new System.Drawing.Size(129, 36);
            this.buttonUtilizatoriWelcAdministrator.TabIndex = 8;
            this.buttonUtilizatoriWelcAdministrator.Text = "Utilizatori";
            this.buttonUtilizatoriWelcAdministrator.UseVisualStyleBackColor = false;
            this.buttonUtilizatoriWelcAdministrator.Click += new System.EventHandler(this.buttonUtilizatoriWelcAdministrator_Click);
            // 
            // buttonCartiWelcAdministrator
            // 
            this.buttonCartiWelcAdministrator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonCartiWelcAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCartiWelcAdministrator.ForeColor = System.Drawing.Color.White;
            this.buttonCartiWelcAdministrator.Location = new System.Drawing.Point(31, 20);
            this.buttonCartiWelcAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCartiWelcAdministrator.Name = "buttonCartiWelcAdministrator";
            this.buttonCartiWelcAdministrator.Size = new System.Drawing.Size(129, 36);
            this.buttonCartiWelcAdministrator.TabIndex = 7;
            this.buttonCartiWelcAdministrator.Text = "Carti";
            this.buttonCartiWelcAdministrator.UseVisualStyleBackColor = false;
            this.buttonCartiWelcAdministrator.Click += new System.EventHandler(this.buttonCartiWelcAdministrator_Click);
            // 
            // buttonBackToMenuWelcAdministrator
            // 
            this.buttonBackToMenuWelcAdministrator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonBackToMenuWelcAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMenuWelcAdministrator.ForeColor = System.Drawing.Color.White;
            this.buttonBackToMenuWelcAdministrator.Location = new System.Drawing.Point(751, 5);
            this.buttonBackToMenuWelcAdministrator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBackToMenuWelcAdministrator.Name = "buttonBackToMenuWelcAdministrator";
            this.buttonBackToMenuWelcAdministrator.Size = new System.Drawing.Size(74, 35);
            this.buttonBackToMenuWelcAdministrator.TabIndex = 6;
            this.buttonBackToMenuWelcAdministrator.Text = "Menu";
            this.buttonBackToMenuWelcAdministrator.UseVisualStyleBackColor = false;
            this.buttonBackToMenuWelcAdministrator.Click += new System.EventHandler(this.buttonBackToMenuWelcAdministrator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabPageUtilizatorLogat
            // 
            this.tabPageUtilizatorLogat.BackgroundImage = global::Biblioteca.Properties.Resources.back;
            this.tabPageUtilizatorLogat.Controls.Add(this.listBoxCartiReturnat);
            this.tabPageUtilizatorLogat.Controls.Add(this.listBoxCartiImprumutat);
            this.tabPageUtilizatorLogat.Controls.Add(this.buttonUtilizatorReturnare);
            this.tabPageUtilizatorLogat.Controls.Add(this.buttonUtilizatorImprumutare);
            this.tabPageUtilizatorLogat.Controls.Add(this.buttonBackToMenuWelcUtilizator);
            this.tabPageUtilizatorLogat.Controls.Add(this.buttonUtilizatorReturn);
            this.tabPageUtilizatorLogat.Controls.Add(this.buttonUtilizatorImprumut);
            this.tabPageUtilizatorLogat.Location = new System.Drawing.Point(4, 22);
            this.tabPageUtilizatorLogat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageUtilizatorLogat.Name = "tabPageUtilizatorLogat";
            this.tabPageUtilizatorLogat.Size = new System.Drawing.Size(828, 469);
            this.tabPageUtilizatorLogat.TabIndex = 4;
            this.tabPageUtilizatorLogat.Text = "WelcomeUtilizator";
            this.tabPageUtilizatorLogat.UseVisualStyleBackColor = true;
            // 
            // listBoxCartiReturnat
            // 
            this.listBoxCartiReturnat.FormattingEnabled = true;
            this.listBoxCartiReturnat.Location = new System.Drawing.Point(506, 189);
            this.listBoxCartiReturnat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCartiReturnat.Name = "listBoxCartiReturnat";
            this.listBoxCartiReturnat.Size = new System.Drawing.Size(248, 147);
            this.listBoxCartiReturnat.TabIndex = 8;
            this.listBoxCartiReturnat.Visible = false;
            // 
            // listBoxCartiImprumutat
            // 
            this.listBoxCartiImprumutat.FormattingEnabled = true;
            this.listBoxCartiImprumutat.Location = new System.Drawing.Point(56, 189);
            this.listBoxCartiImprumutat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCartiImprumutat.Name = "listBoxCartiImprumutat";
            this.listBoxCartiImprumutat.Size = new System.Drawing.Size(248, 147);
            this.listBoxCartiImprumutat.TabIndex = 7;
            this.listBoxCartiImprumutat.Visible = false;
            // 
            // buttonUtilizatorReturnare
            // 
            this.buttonUtilizatorReturnare.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUtilizatorReturnare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilizatorReturnare.ForeColor = System.Drawing.Color.White;
            this.buttonUtilizatorReturnare.Location = new System.Drawing.Point(548, 406);
            this.buttonUtilizatorReturnare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUtilizatorReturnare.Name = "buttonUtilizatorReturnare";
            this.buttonUtilizatorReturnare.Size = new System.Drawing.Size(146, 41);
            this.buttonUtilizatorReturnare.TabIndex = 6;
            this.buttonUtilizatorReturnare.Text = "Returnare";
            this.buttonUtilizatorReturnare.UseVisualStyleBackColor = false;
            this.buttonUtilizatorReturnare.Visible = false;
            this.buttonUtilizatorReturnare.Click += new System.EventHandler(this.buttonUtilizatorReturnare_Click);
            // 
            // buttonUtilizatorImprumutare
            // 
            this.buttonUtilizatorImprumutare.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUtilizatorImprumutare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilizatorImprumutare.ForeColor = System.Drawing.Color.White;
            this.buttonUtilizatorImprumutare.Location = new System.Drawing.Point(112, 406);
            this.buttonUtilizatorImprumutare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUtilizatorImprumutare.Name = "buttonUtilizatorImprumutare";
            this.buttonUtilizatorImprumutare.Size = new System.Drawing.Size(146, 41);
            this.buttonUtilizatorImprumutare.TabIndex = 5;
            this.buttonUtilizatorImprumutare.Text = "Imprumut";
            this.buttonUtilizatorImprumutare.UseVisualStyleBackColor = false;
            this.buttonUtilizatorImprumutare.Visible = false;
            this.buttonUtilizatorImprumutare.Click += new System.EventHandler(this.buttonUtilizatorImprumutare_Click);
            // 
            // buttonBackToMenuWelcUtilizator
            // 
            this.buttonBackToMenuWelcUtilizator.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonBackToMenuWelcUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToMenuWelcUtilizator.ForeColor = System.Drawing.Color.White;
            this.buttonBackToMenuWelcUtilizator.Location = new System.Drawing.Point(757, 10);
            this.buttonBackToMenuWelcUtilizator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBackToMenuWelcUtilizator.Name = "buttonBackToMenuWelcUtilizator";
            this.buttonBackToMenuWelcUtilizator.Size = new System.Drawing.Size(70, 31);
            this.buttonBackToMenuWelcUtilizator.TabIndex = 2;
            this.buttonBackToMenuWelcUtilizator.Text = "Menu";
            this.buttonBackToMenuWelcUtilizator.UseVisualStyleBackColor = false;
            this.buttonBackToMenuWelcUtilizator.Click += new System.EventHandler(this.buttonBackToMenuWelcUtilizator_Click);
            // 
            // buttonUtilizatorReturn
            // 
            this.buttonUtilizatorReturn.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUtilizatorReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilizatorReturn.ForeColor = System.Drawing.Color.White;
            this.buttonUtilizatorReturn.Location = new System.Drawing.Point(506, 81);
            this.buttonUtilizatorReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUtilizatorReturn.Name = "buttonUtilizatorReturn";
            this.buttonUtilizatorReturn.Size = new System.Drawing.Size(248, 76);
            this.buttonUtilizatorReturn.TabIndex = 1;
            this.buttonUtilizatorReturn.Text = "Vreau sa returnez o carte";
            this.buttonUtilizatorReturn.UseVisualStyleBackColor = false;
            this.buttonUtilizatorReturn.Click += new System.EventHandler(this.buttonUtilizatorReturn_Click);
            // 
            // buttonUtilizatorImprumut
            // 
            this.buttonUtilizatorImprumut.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonUtilizatorImprumut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUtilizatorImprumut.ForeColor = System.Drawing.Color.White;
            this.buttonUtilizatorImprumut.Location = new System.Drawing.Point(56, 81);
            this.buttonUtilizatorImprumut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUtilizatorImprumut.Name = "buttonUtilizatorImprumut";
            this.buttonUtilizatorImprumut.Size = new System.Drawing.Size(248, 76);
            this.buttonUtilizatorImprumut.TabIndex = 0;
            this.buttonUtilizatorImprumut.Text = "Vreau sa imprumut o carte";
            this.buttonUtilizatorImprumut.UseVisualStyleBackColor = false;
            this.buttonUtilizatorImprumut.Click += new System.EventHandler(this.buttonUtilizatorImprumut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 498);
            this.Controls.Add(this.tabControlPagini);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "MyVirtualLibrary";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabUtilizator.ResumeLayout(false);
            this.tabUtilizator.PerformLayout();
            this.tabAdministrator.ResumeLayout(false);
            this.tabAdministrator.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tabMenu.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlPagini.ResumeLayout(false);
            this.tabPageAdministratorLogat.ResumeLayout(false);
            this.tabPageAdministratorLogat.PerformLayout();
            this.groupBoxUtilizatoriWelcAdministrator.ResumeLayout(false);
            this.groupBoxUtilizatoriWelcAdministrator.PerformLayout();
            this.groupBoxAdvertisment.ResumeLayout(false);
            this.groupBoxStergeUtilizator.ResumeLayout(false);
            this.groupBoxAdaugareUtilizator.ResumeLayout(false);
            this.groupBoxAdaugareUtilizator.PerformLayout();
            this.groupBoxCartiWelcAdministrator.ResumeLayout(false);
            this.groupBoxCartiWelcAdministrator.PerformLayout();
            this.groupBoxAdaugaCarti.ResumeLayout(false);
            this.groupBoxAdaugaCarti.PerformLayout();
            this.groupBoxStergereCarte.ResumeLayout(false);
            this.tabPageUtilizatorLogat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabUtilizator;
        private System.Windows.Forms.Button buttonBackToMenuUtilizator;
        private System.Windows.Forms.Label labelPassUtilizator;
        private System.Windows.Forms.Label labelUsernameUtilizator;
        private System.Windows.Forms.TextBox textBoxPassUtilizator;
        private System.Windows.Forms.TextBox textBoxUsernameUtilizator;
        private System.Windows.Forms.Button buttonAutentificareUtilizator;
        private System.Windows.Forms.TabPage tabAdministrator;
        private System.Windows.Forms.Button buttonBackToMenuAdministrator;
        private System.Windows.Forms.Label labelPassAdministrator;
        private System.Windows.Forms.Label labelUsernameAdministrator;
        private System.Windows.Forms.TextBox textBoxPassAdministrator;
        private System.Windows.Forms.TextBox textBoxUsernameAdministrator;
        private System.Windows.Forms.Button buttonAutentificareAdministrator;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Button buttonMeniuPrincipalAdministrator;
        private System.Windows.Forms.Button buttonMeniuPrincipalUtilizator;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlPagini;
        private System.Windows.Forms.TabPage tabPageAdministratorLogat;
        private System.Windows.Forms.RichTextBox richTextBoxListaCartiWelcAdministrator;
        private System.Windows.Forms.Label labelListaCartiWelcAdministrator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageUtilizatorLogat;
        private System.Windows.Forms.Button buttonUtilizatorReturn;
        private System.Windows.Forms.Button buttonUtilizatorImprumut;
        private System.Windows.Forms.Button buttonBackToMenuWelcAdministrator;
        private System.Windows.Forms.Button buttonBackToMenuWelcUtilizator;
        private System.Windows.Forms.Button buttonUtilizatorImprumutare;
        private System.Windows.Forms.Button buttonUtilizatorReturnare;
        private System.Windows.Forms.ListBox listBoxCartiImprumutat;
        private System.Windows.Forms.Button buttonUtilizatoriWelcAdministrator;
        private System.Windows.Forms.Button buttonCartiWelcAdministrator;
        private System.Windows.Forms.GroupBox groupBoxCartiWelcAdministrator;
        private System.Windows.Forms.GroupBox groupBoxAdaugaCarti;
        private System.Windows.Forms.Button buttonAdaugaCarte;
        private System.Windows.Forms.TextBox textBoxTitluCarteDeAdaugat;
        private System.Windows.Forms.TextBox textBoxISBNCarteDeAdaugat;
        private System.Windows.Forms.TextBox textBoxAutorCarteDeAdaugat;
        private System.Windows.Forms.GroupBox groupBoxStergereCarte;
        private System.Windows.Forms.ComboBox comboBoxListaCartiStergere;
        private System.Windows.Forms.Button buttonStergeCarte;
        private System.Windows.Forms.GroupBox groupBoxUtilizatoriWelcAdministrator;
        private System.Windows.Forms.GroupBox groupBoxAdvertisment;
        private System.Windows.Forms.ComboBox comboBoxListaUtilizatoriAvertizare;
        private System.Windows.Forms.Button buttonAvertizareIntarziere;
        private System.Windows.Forms.RichTextBox richTextBoxListaUtilizatoriWelcAdministrator;
        private System.Windows.Forms.Label labelListaUtilizatoriWelcAdministrator;
        private System.Windows.Forms.GroupBox groupBoxStergeUtilizator;
        private System.Windows.Forms.ComboBox comboBoxListaUtilizatoriStergere;
        private System.Windows.Forms.Button buttonStergeUtilizator;
        private System.Windows.Forms.GroupBox groupBoxAdaugareUtilizator;
        private System.Windows.Forms.Button buttonAdaugaUtilizator;
        private System.Windows.Forms.TextBox textBoxParolaDeAdaugat;
        private System.Windows.Forms.TextBox textBoxUsernamedeAdaugat;
        private System.Windows.Forms.Button buttonAfisareListaUtilizatori;
        private System.Windows.Forms.Button buttonAfisareListaCarti;
        private System.Windows.Forms.ListBox listBoxCartiReturnat;
    }
}

