/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *  Copyright:   (c) 2023, Cojocaru Georgiana, Lupu Andra, Martin Maria,  *
			   Stefanel Petrescu Miron                        *
 *  E-mail:      georgiana-vasilica.cojocaru@student.tuiasi.ro            *
 *  E-mail:      andra-maria.lupu@student.tuiasi.ro                       *
 *  E-mail:      maria.martin@student.tuiasi.ro                           *
 *  E-mail:      stefanel.petrescu-miron@student.tuiasi.ro                *
 *  Description: Buttons                                                  *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/
using Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Model;
using System.IO;
using static Commons.Users;
using System.Net.Mail;

namespace Biblioteca
{
    public partial class Form1 : Form, IView
    {
        private Users _user;
        private Administrator _admin;
        private IPresenter _presenter;
        private IModel _model;
        private Book InputBook()
        {
            
            string titluCarte = textBoxTitluCarteDeAdaugat.Text;
            string autorCarte = textBoxAutorCarteDeAdaugat.Text;
            string ISBNCarte = textBoxISBNCarteDeAdaugat.Text;
            
            int d = 0;
            string dateImprumut=d.ToString()+"."+ d.ToString() + "."+d.ToString();
            
            return (new Book(titluCarte, autorCarte, ISBNCarte, false,dateImprumut));
            
        }

        private Users.User InputUser()
        {
            string username = textBoxUsernamedeAdaugat.Text;
            string parola = textBoxParolaDeAdaugat.Text;
            string passHash = Criptography.Criptography.HashString(parola);

            return (new Users.User(username, passHash));
        }

        public void Display(string text, string color)
        {

        }
        public void SetPresenter(IPresenter presenter)
        {
            _presenter = presenter;
            _presenter.Init();
        }
        public Form1(IModel model)
        {
            _model = model;
            this.BackgroundImage = Properties.Resources.back;
            InitializeComponent();
            tabControlPagini.TabPages[0].BackgroundImage = Properties.Resources.back;
            tabControlPagini.TabPages[1].BackgroundImage = Properties.Resources.back;
            _user = new Users();
            _admin = new Administrator();

        }

        private void buttonMeniuPrincipalAdministrator_Click(object sender, EventArgs e)
        {
            //tabControl1.Visible = false;
            tabControlPagini.TabPages.Clear();
            tabControlPagini.TabPages.Add(tabAdministrator);
            textBoxPassAdministrator.Text = "";
            textBoxUsernameAdministrator.Text = "";

            //tabControl1.Visible = true;

        }

        private void buttonMeniuPrincipalUtilizator_Click(object sender, EventArgs e)
        {
            _user = new Users();
            //MessageBox.Show("Meniu principal user");
            //tabControl1.Visible = false;
            tabControlPagini.TabPages.Clear();
            tabControlPagini.TabPages.Add(tabUtilizator);
            textBoxPassUtilizator.Text = "";
            textBoxUsernameUtilizator.Text = "";
            //tabControl1.TabPages.Remove(tab_Administrator);
            //tabControl1.Visible = true;

        }

        private void buttonBackToMenuUtilizator_Click(object sender, EventArgs e)
        {
            //tabControl1.Visible = false;
            tabControlPagini.TabPages.Clear();
            tabControlPagini.TabPages.Add(tabMenu);
            //tabControl1.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControlPagini.TabPages.Clear();
            tabControlPagini.TabPages.Add(tabMenu);

            //actualizareCartiInMeniuUtilizator();
            ActualizareComboStergereCarte();
            ActualizareComboStergereUser();
            ActualizareComboBoxListaUtilizatoriAvertizare();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tProiect Ingineria Programarii\n\n\n\n\n" +
                "\tRealizat de:\n\n" +
                "\t\tCojocaru Georgiana-Vasilica\t\t\n" +
                "\t\tLupu Andra-Maria\t\t\n" +
                "\t\tMartin Maria\t\t\n" +
                "\t\tPetrescu-Miron Stefanel\t\t\n\n\n\n\n" +
                "\tGrupa: 1309A");
        }

        private void buttonBackToMenuAdministrator_Click(object sender, EventArgs e)
        {
            //tabControl1.Visible = false;
            tabControlPagini.TabPages.Clear();
            tabControlPagini.TabPages.Add(tabMenu);
            textBoxUsernamedeAdaugat.Text = "";
            textBoxParolaDeAdaugat.Text = "";
            //tabControl1.Visible = true;
        }

        private void buttonAutentificareAdministrator_Click(object sender, EventArgs e)
        {
            string password = textBoxPassAdministrator.Text;
            string username = textBoxUsernameAdministrator.Text;
            try
            {
                bool ok = _admin.Login(username, password);
                if (ok == false)
                {
                    MessageBox.Show("Datele introduse sunt gresite!");
                }
                else
                {
                    tabControlPagini.TabPages.Clear();
                    tabControlPagini.TabPages.Add(tabPageAdministratorLogat);
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAutentificareUtilizator_Click(object sender, EventArgs e)
        {
            // textBoxPassUtilizator.Clear();
            //textBoxUsernameUtilizator.Clear();
            string password = textBoxPassUtilizator.Text;
            string username = textBoxUsernameUtilizator.Text;
            try
            {
                bool ok = _user.Login(username, password);
                if (ok == false)
                {
                    MessageBox.Show("Datele introduse sunt gresite!");
                }
                else
                {
                    tabControlPagini.TabPages.Clear();
                    tabControlPagini.TabPages.Add(tabPageUtilizatorLogat);
                    listBoxCartiReturnat.Visible = false;
                    listBoxCartiImprumutat.Visible = false;
                    buttonUtilizatorImprumutare.Visible = false;
                    buttonUtilizatorReturnare.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBackToMenuWelcAdministrator_Click(object sender, EventArgs e)
        {
            //tabControl1.Visible = false;
            

            tabControlPagini.TabPages.Clear();
            tabControlPagini.TabPages.Add(tabMenu);
            listBoxCartiReturnat.Items.Clear();
            richTextBoxListaUtilizatoriWelcAdministrator.Clear();

            //tabControl1.Visible = true;
        }

        private void buttonBackToMenuWelcUtilizator_Click(object sender, EventArgs e)
        {
            //tabControl1.Visible = false;
            tabControlPagini.TabPages.Clear();
            tabControlPagini.TabPages.Add(tabMenu);
            //tabControl1.Visible = true;
        }

        private void buttonUtilizatorImprumut_Click(object sender, EventArgs e)
        {
            listBoxCartiReturnat.Visible = false;
            buttonUtilizatorReturnare.Visible = false;
            listBoxCartiImprumutat.Visible = true;
            buttonUtilizatorImprumutare.Visible = true;

            ActualizareCartiInMeniuUtilizator();
        }

        private void buttonUtilizatorReturn_Click(object sender, EventArgs e)
        {
            listBoxCartiImprumutat.Visible = false;
            buttonUtilizatorImprumutare.Visible = false;
            listBoxCartiReturnat.Visible = true;
            buttonUtilizatorReturnare.Visible = true;

            ActualizareCartiInMeniuUtilizator();
            
        }

        private void buttonCartiWelcAdministrator_Click(object sender, EventArgs e)
        {
            groupBoxUtilizatoriWelcAdministrator.Visible = false;
            groupBoxCartiWelcAdministrator.Visible = true;
        }

        private void buttonUtilizatoriWelcAdministrator_Click(object sender, EventArgs e)
        {
            groupBoxCartiWelcAdministrator.Visible = false;
            groupBoxUtilizatoriWelcAdministrator.Visible = true;
        }

        private void buttonAfisareListaCarti_Click(object sender, EventArgs e)
        {
            richTextBoxListaCartiWelcAdministrator.Clear();
            richTextBoxListaCartiWelcAdministrator.Text = _model.ListAllBooks();
        }

        private void buttonAdaugaCarte_Click(object sender, EventArgs e)
        {
            try
            {
               
                Book b = InputBook();
               
                _presenter.AddBook(b);
               
                if (_model.SaveData())
                    richTextBoxListaCartiWelcAdministrator.Text = "Carte adaugata!";
                
                ActualizareComboStergereCarte();
               
                //actualizareCartiInMeniuUtilizator();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void ActualizareComboStergereCarte()
        {
            comboBoxListaCartiStergere.Items.Clear();

            for (int i = 0; i < _model.BookCount; i++)
            {
                comboBoxListaCartiStergere.Items.Add(_model.getBookName(i));
            }
        }



        private void ActualizareCartiInMeniuUtilizator()
        {
            listBoxCartiImprumutat.Items.Clear();
            listBoxCartiReturnat.Items.Clear();

            for (int i = 0; i < _model.BookCount; i++)
            {
                if (_model.getBookDisp(i) == false)
                {
                    listBoxCartiImprumutat.Items.Add(_model.getBookName(i));
                }

            }

            if (!_user.currentUsername.Equals(null))
            {

                List<string> isbn = (_model.getUserBooks(_user.currentUsername));

                for (int j = 0; j < isbn.Count; j++)
                {

                    listBoxCartiReturnat.Items.Add(_model.getBookNameByISBN(isbn[j]));

                }

            }
        }

        private void buttonStergeCarte_Click(object sender, EventArgs e)
        {
            
                string bookName = comboBoxListaCartiStergere.Text;
                _presenter.RemoveBook(bookName);
                if (_model.SaveData())
                {
                    richTextBoxListaCartiWelcAdministrator.Text = "Carte stearsa!";

                    ActualizareComboStergereCarte();
                }
                else
                {
                    MessageBox.Show("Cartea este imprumutata de un utilizator!");

                }
           
        }

        private void buttonAfisareListaUtilizatori_Click(object sender, EventArgs e)
        {
            richTextBoxListaUtilizatoriWelcAdministrator.Text = _model.ListAllUsers();
        }

        private void buttonStergeUtilizator_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = comboBoxListaUtilizatoriStergere.Text;

                //_presenter.RemoveUser(userName);
                //if (_model.SaveDataUser())


                for(int i=0; i< _user._users.Count; i++)
                {
                    if(_user._users[i]._name == userName)
                    {
                        if (_model.CanDeleteUser(_user._users[i]))
                        {
                            _user._users.RemoveAt(i);
                            SaveDataUserAfterDelete(userName);
                            richTextBoxListaUtilizatoriWelcAdministrator.Text = "User sters!";
                        }
                        else
                        {
                            MessageBox.Show("Userul are carti imprumutate");
                        }
                    }
                }


               


                ActualizareComboStergereUser();
                ActualizareComboBoxListaUtilizatoriAvertizare();
            }
            catch
            {
                // Tratarea excepției
                MessageBox.Show("Userul are carti imprumutate!");
            }

        }
        private void SaveDataUserAfterDelete(string name)
        {
            Users idk = new Users();
            
            StreamWriter sw = new StreamWriter(_user.getFileName);
            for (int i = 0; i < idk._users.Count; i++)
            {
                Users.User b = idk._users[i];
                if (b._name != name)
                {
                    sw.Write(b._name + "\t" + b._passHash);

                    
                    
                    for (int j = 0; j < b._isbn.Count; j++)
                    {
                        sw.Write("\t" + b._isbn[j]);
                    }
                    sw.WriteLine();
                }
                else
                {
                    _user._users.Remove(b);
                }
                
            }
            sw.Close();

        }

        private void SaveDataUserAfterAdd(Users.User u)
        {
            Users idk = new Users();
            idk._users.Add(u);
            StreamWriter sw = new StreamWriter(_user.getFileName);
            for (int i = 0; i < idk._users.Count; i++)
            {
                Users.User b = idk._users[i];
                
                sw.Write(b._name + "\t" + b._passHash);
                for (int j = 0; j < b._isbn.Count; j++)
                {
                    sw.Write("\t" + b._isbn[j]);
                }
                sw.WriteLine();
            }
            



            sw.Close();


        }



        private void buttonAdaugaUtilizator_Click(object sender, EventArgs e)
        {
            Users.User u = InputUser();
            //_presenter.AddUser(u);

            //if (_model.SaveDataUser())
            SaveDataUserAfterAdd(u);

            richTextBoxListaUtilizatoriWelcAdministrator.Text = "User adaugat!";
            _user._users.Add(u);

            ActualizareComboStergereUser();
            ActualizareComboBoxListaUtilizatoriAvertizare();
            

        }





        private void ActualizareComboStergereUser()
        {
            comboBoxListaUtilizatoriStergere.Items.Clear();
            for (int i = 0; i < _user._users.Count; i++)
            {
                comboBoxListaUtilizatoriStergere.Items.Add(_user._users[i]._name);
            }
        }
        private void ActualizareComboBoxListaUtilizatoriAvertizare()
        {
            comboBoxListaUtilizatoriAvertizare.Items.Clear();
            try
            {
                for(int i = 0; i < _user._users.Count; i++)
                {
                    comboBoxListaUtilizatoriAvertizare.Items.Add(_user._users[i]._name);
                }
         
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonAvertizareIntarziere_Click(object sender, EventArgs e)
        {
            if (comboBoxListaUtilizatoriAvertizare.SelectedItem != null)
            {
                string username = comboBoxListaUtilizatoriAvertizare.SelectedItem.ToString();

                Model.Model model = new Model.Model();
                List<User> users = model.GetUsers();
                User utilizator = users.FirstOrDefault(u => u._name == username);
                
                try
                {
                    if (object.ReferenceEquals(utilizator, null))
                    {
                        // Utilizatorul nu a fost gasit în lista de utilizatori
                    }
                    else
                    {
                        if (utilizator._isbn.Count == 0)
                        {
                            throw new Exception("Utilizatorul nu are cărți de returnat.");
                        }

                        string adresaEmail = $"{utilizator._name}@gmail.com";
                        string isbn = utilizator._isbn.FirstOrDefault();

                        string mesaj = $"Avertisment intarziere: nu ati returnat cartea '({utilizator._isbn[0]})' la timp!";
                        EmailSender.SendEmail(adresaEmail, mesaj);
                        MessageBox.Show("Mail trimis către " + adresaEmail);
                       
                    }
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show("Utilizatorul " + utilizator._name + " nu are carti de returnat!", ex.Message);
                }
                
            }
        }
        private void buttonUtilizatorImprumutare_Click(object sender, EventArgs e)
        {
            try
            {
                string _bookName = listBoxCartiImprumutat.Items[listBoxCartiImprumutat.SelectedIndex].ToString();
                _model.setImprumut(_bookName);
                string isbn = _model.getISBNbyBookName(_bookName);
                _user.currentUsername._isbn.Add(isbn);
                
                BorBookSaveIsbnList(isbn);
                

                ActualizareCartiInMeniuUtilizator();
                MessageBox.Show("Carte imprumutata : " + _bookName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUtilizatorReturnare_Click(object sender, EventArgs e)
        {
            try
            {
                string _bookName = listBoxCartiReturnat.Items[listBoxCartiReturnat.SelectedIndex].ToString();
                _model.setReturn(_bookName);
                
                string isbn = _model.getISBNbyBookName(_bookName);
                
                _user.currentUsername._isbn.Remove(isbn);

                RetBookSaveIsbnList(isbn);
               
                ActualizareCartiInMeniuUtilizator();
                MessageBox.Show("Carte returnata : " + _bookName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// For when an user returns a book. We get rid of it in the users file
        /// </summary>
        /// <param name="isbn"></param>
        private void RetBookSaveIsbnList(string isbn)
        {
            
            StreamWriter sw = new StreamWriter(_user.getFileName);
            for (int i = 0; i < _user._users.Count; i++)
            {
                Users.User b = _user._users[i];
                sw.Write(b._name + "\t" + b._passHash);
                //if its not the current user, we dont modify his line
                if (b._name!=_user.currentUsername._name)  
                    for (int j = 0; j < b._isbn.Count; j++)
                    {
                            sw.Write("\t" + b._isbn[j]);
                    }
                else
                {
                    for (int j = 0; j < _user.currentUsername._isbn.Count; j++)
                    {
                        // we skip writing the returned book
                        if (_user.currentUsername._isbn[j] != isbn)
                            sw.Write("\t" + _user.currentUsername._isbn[j]);
                    }
                }
                sw.WriteLine();
            }
            sw.Close();
                
        }

        /// <summary>
        /// For when an user borrows a book. We write it in the users file
        /// </summary>
        /// <param name="isbn"></param>
        private void BorBookSaveIsbnList(string isbn)
        {

            StreamWriter sw = new StreamWriter(_user.getFileName);
            for (int i = 0; i < _user._users.Count; i++)
            {
                Users.User b = _user._users[i];
                sw.Write(b._name + "\t" + b._passHash);
                //if its not the current user, we dont modify his line
                if (b._name != _user.currentUsername._name) 
                    for (int j = 0; j < b._isbn.Count; j++)
                    {
                        sw.Write("\t" + b._isbn[j]);
                    }
                else
                {
                    // if we find the current user, we add the new book in the file
                    for (int j = 0; j < _user.currentUsername._isbn.Count; j++)
                    {
                       
                        sw.Write("\t" + _user.currentUsername._isbn[j]);

                    }
                   
                }
                sw.WriteLine();

            }
            sw.Close();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Biblioteca.chm");

        }
    }
}
