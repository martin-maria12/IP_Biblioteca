/**************************************************************************
 *                                                                        *
 *  File:        Admin.cs                                                 *
 *  Copyright:   (c) 2023, Martin Maria                                   *
 *  E-mail:      maria.martin@student.tuiasi.ro                           *
 *  Description: Admin structure                                          *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commons
{
    public class Administrator
    {
        private List<Admin> _admin;
        private string _adminFile = "admin.txt";
        public Admin currentUsername;
        public struct Admin
        {
            public readonly string _nameAdm;
            public readonly string _passhHashAdm;

            /// <summary>
            /// Initialization of a Admin object
            /// </summary>
            /// <param name="name"></param>
            /// <param name="passHashAdm"></param>
            public Admin(string name,string passHashAdm)
            {
                _nameAdm = name;
                _passhHashAdm = passHashAdm;
            }
        }

        /// <summary>
        /// Initialization of a Administrator object
        /// </summary>
        public Administrator()
        {
            try
            {
                _admin = new List<Admin>();
                using (StreamReader sr = new StreamReader(_adminFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] toks = line.Split('\t');
                        if (toks.Length >= 2)
                        {
                            Admin admin = new Admin(toks[0], toks[1]);
                            _admin.Add(admin);
                        }
                        else
                        {
                            MessageBox.Show("too few");
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        /// <summary>
        /// Login admin
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Return true or false depending if the login was successful</returns>
        public bool Login(string username,string password)
        {

            foreach (Admin admin in _admin)
            {
                if (admin._nameAdm == username && admin._passhHashAdm == Criptography.Criptography.HashString(password))
                {
                    currentUsername = new Admin(username, Criptography.Criptography.HashString(password));
                   
                    return true;
                }
            }
            return false;
        }
    }
}