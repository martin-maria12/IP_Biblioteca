/**************************************************************************
 *                                                                        *
 *  File:        User.cs                                                  *
 *  Copyright:   (c) 2023, Lupu Andra                                     *
 *  E-mail:      andra-maria.lupu@student.tuiasi.ro                       *
 *  Description: User structure                                           *
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
using Criptography;
namespace Commons
{
    public class Users
    {
        public List<User> _users;
        private string _userFile= "users.txt";
        public User currentUsername;

        public struct User
        {
            public readonly string _name;
            public readonly string _passHash;
            public  List<string> _isbn;

            /// <summary>
            /// Initialization of a User object
            /// </summary>
            /// <param name="name"></param>
            /// <param name="passHash"></param>
            public User(string name,string passHash)
            {
                _name = name;
                _passHash = passHash;
                _isbn = new List<string>();
               
            }
        }

        /// <summary>
        /// Getting the name of the file name which holds the users
        /// </summary>
        /// <returns>Returns a string containing the name of a file</returns>
        public string getFileName { get { return _userFile; } }

        /// <summary>
        /// Initialization of a Users object
        /// </summary>
        public Users()
        {
            try
            {
                _users = new List<User>();
                using (StreamReader sr = new StreamReader(_userFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                     
                        string[] toks = line.Split('\t');
                        int lengthToks = toks.Length ;
                        int index = 2;
                        try
                        {
                            if (toks.Length > 1)
                            {
                                User user = new User(toks[0], toks[1]);

                                while (lengthToks > 2)
                                {
                                 
                                    user._isbn.Add(toks[index]);
                                    index++;
                                    lengthToks--;
                                }

                                _users.Add(user);
                            }
                        }catch(Exception exc)
                        {
                            MessageBox.Show(exc.Message);
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
        /// User Login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Return true or false depending if the login was successful</returns>
        public bool Login(string username,string password)
        {
            foreach (User user in _users)
            {
                if (user._name == username && user._passHash == Criptography.Criptography.HashString(password))
                {

                    currentUsername = new User(username, Criptography.Criptography.HashString(password));
                    if (user._isbn.Count > 0)
                    {
                        for(int i = 0; i < user._isbn.Count; i++)
                        {
                            currentUsername._isbn.Add(user._isbn[i]);
                        }
                    }
                  
                    return true;
                }
            }
            return false;
        }

       
    }
}
