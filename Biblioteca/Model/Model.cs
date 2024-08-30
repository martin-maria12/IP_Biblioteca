/**************************************************************************
 *                                                                        *
 *  File:        Model.cs                                                 *
 *  Copyright:   (c) 2023, Cojocaru Georgiana, Lupu Andra, Martin Maria   *
 *  E-mail:      georgiana-vasilica.cojocaru@student.tuiasi.ro            *
 *  E-mail:      andra-maria.lupu@student.tuiasi.ro                       *
 *  E-mail:      maria.martin@student.tuiasi.ro                           *
 *  Description: Application with MVC architecture Model Class            *
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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Commons;
using static Commons.Users;

namespace Model
{
    public class Model : IModel
    {
        private const string _BookFileName = "books.txt";
        private List<Book> _bookList;
        private bool _wasModified;
        private bool _wasModifiedUsers;
        private bool _wasModifiedIsbn;
        private Users u;
        List<Users.User> _userList;


        /// <summary>
        /// Constructor Model
        /// </summary>
        public Model()
        {
            _bookList = new List<Book>();
            _wasModified = false;
            _wasModifiedUsers = false;
            _wasModifiedIsbn = false;
            u = new Users();
            _userList = u._users;
        }

        /// <summary>
        /// Getting the name of the file name which holds the books
        /// </summary>
        /// <returns>Returns a string containing the name of a file</returns>
        public string getBookFileName()
        {
            return _BookFileName;
        }

        /// <summary>
        /// Adds a book to the book list
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Returns true or false depending if the operation was successful or not</returns>
        public bool Add(Book book)
        {
            // daca o carte cu acelasi nume exista deja va fi stearsa
            bool overwrite = false;

            for (int i = 0; i < _bookList.Count; i++)
            {
                if (_bookList[i].Name.Trim().ToUpper() == book.Name.Trim().ToUpper())
                {
                    _bookList.RemoveAt(i--);
                    overwrite = true;
                }
            }

            // adaugarea noii carti
            _bookList.Add(book);
            _wasModified = true;
            return !overwrite;
        }

        /// <summary>
        /// Getting the number of existing books in the file
        /// </summary>
        /// <returns>Returns an int containing the number of books</returns>
        public int BookCount { get { return _bookList.Count; } }

        /// <summary>
        /// Checks whether the file with the books exists
        /// </summary>
        /// <returns>Returns true if the file exists, otherwise returns false</returns>
        public bool DataExists()
        {
            if (!File.Exists(_BookFileName))
            {
                _wasModified = true;
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Reads the books from the file
        /// </summary>
        public void InitializeData()
        {
            StreamReader sr = new StreamReader(_BookFileName);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                _bookList.Add(ParseBookLine(line));

            }
            sr.Close();
        }

        /// <summary>
        /// Check if a book can be deleted
        /// </summary>
        /// /// <param name="book"></param>
        /// <returns>Returns true if a book can be deleted, otherwise the function returns false</returns>
        public bool canDeleteBook(Book book)
        {
            if (book.isImprumutat() == 1)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Deletes a book identified by name from the book list
        /// /// <param name="bookName"></param>
        /// </summary>
        /// <returns>Returns true if a book was deleted, otherwise the function returns false</returns>
        public bool Delete(string bookName)
        {
            for (int i = 0; i < _bookList.Count; i++)
            {
                if (_bookList[i].Name == bookName)
                {
                    if (canDeleteBook(_bookList[i]))
                    {
                        _bookList.RemoveAt(i);
                        _wasModified = true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;

        }

        /// <summary>
        /// Checks whether a book identified by name exists
        /// </summary>
        /// /// <param name="bookName"></param>
        /// <returns>Returns true if the book exists, otherwise returns false</returns>
        public bool Exists(string bookName)
        {
            for (int i = 0; i < _bookList.Count; i++)
            {
                if (_bookList[i].Name == bookName)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Getting a Book object whose name is the string bookName
        /// </summary>
        /// <param name="bookName"></param>
        /// <returns>Returns a Book object or it creates a new one</returns>
        public Book Search(string bookName)
        {
            // cauta o carte dupa nume si returneaza obiectul corespunzator
            for (int i = 0; i < _bookList.Count; i++)
            {
                if (_bookList[i].Name == bookName)
                    return _bookList[i];
            }

            return new Book();
        }

        /// <summary>
        /// Creating a string with all the names of the books
        /// </summary>
        /// <returns>Returns a string containing all the names of the books</returns>
        public string ListAllBooks()
        {
            if (_bookList.Count == 0)
                return "buba";

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _bookList.Count; i++)
            {
                sb.Append(_bookList[i].Name);
                if (_bookList[i].Imprumutat == false)
                    sb.Append(" Disponibila!\n");
                else
                    sb.Append(" Indisponibila!\n");

            }

            return sb.ToString();
        }

        /// <summary>
        /// Read the information of a book from a line in the file
        /// </summary>
        /// <param name="line"></param>
        /// <returns>Returns a Book object</returns>
        private static Book ParseBookLine(string line)
        {
            // citeste informatiile unei carti de pe o linie din fisier


            string[] toks = line.Split('\t');

            CultureInfo ci = (CultureInfo)(CultureInfo.CurrentCulture.Clone());
            ci.NumberFormat.NumberDecimalSeparator = ".";
            bool ok = false;
            if (Convert.ToInt32(toks[3]) == 1)
                ok = true;

            Book book = new Book(toks[0], toks[1], toks[2], ok,toks[4]);

            return book;
        }

        /// <summary>
        /// Saves the data only if the book list was modified
        /// </summary>
        /// <returns>Returns true if the new data was saved</returns>
        public bool SaveData()
        {
            if (_wasModified)
            {
                StreamWriter sw = new StreamWriter(_BookFileName);

                for (int i = 0; i < _bookList.Count; i++)
                {
                    Book b = _bookList[i];
                    sw.WriteLine(b.Name + "\t" + b.Author + "\t" + b.ISBN + "\t" + b.isImprumutat() + "\t" + b.getDataImprumut());
                }
                sw.Close();
                _wasModified = false;
                return true;
            }
            else
                return false;
        }



        /// <summary>
        /// Getting the list of books
        /// </summary>
        /// <returns>Returns a List of Book objects</returns>
        public List<Book> GetBooks()
        {
            return _bookList;
        }

        /// <summary>
        ///Gets the name of a book given by a position
        /// </summary>
        /// <param name="poz"></param>
        /// <returns>Returns a string with the name of a book</returns>
        public string getBookName(int poz)
        {
            return _bookList[poz].Name;
        }

        /// <summary>
        /// Checking if a book at a specified position is avaible
        /// </summary>
        /// <param name="poz"></param>
        /// <returns>Return true or false depending on the availability of the book</returns>
        public bool getBookDisp(int poz)
        {
            return _bookList[poz].Imprumutat;
        }

        /// <summary>
        /// Setting a book to unavailable(borrowed)
        /// </summary>
        /// <param name="name"></param>
        public void setImprumut(string name)
        {
            _wasModified = true;
            _wasModifiedIsbn = true;
            if (Exists(name))
            {
                int poz = getPozByBookName(name);
                Book b = _bookList[poz];
                b.SetImprumutat();
                b.setDataImprumut();
                _bookList[poz] = b;
            }
            SaveData();
        }

        /// <summary>
        /// Setting a book to available
        /// </summary>
        /// <param name="name"></param>
        public void setReturn(string name)
        {
            _wasModified = true;
            _wasModifiedIsbn = true;
            if (Exists(name))
            {
                int poz = getPozByBookName(name);
                Book b = _bookList[poz];
                b.SetReturnat();
                b.setDataReturn();
                _bookList[poz] = b;
            }
            SaveData();
        }

        /// <summary>
        /// Getting a user's books
        /// </summary>
        /// <param name="u"></param>
        /// <returns>Returns a List of string containing the isbns of a user </returns>
        public List<string> getUserBooks(Users.User u)
        {
            return u._isbn;
        }

        /// <summary>
        /// Getting a book name by ISBN
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Returns a string with the name of a book</returns>
        public string getBookNameByISBN(string isbn)
        {
            foreach (Book b in _bookList)
            {
                if (b.ISBN == isbn)
                {
                    return b.Name;
                }
            }
            return "";
        }

        /// <summary>
        /// Getting ISBN book by name
        /// </summary>
        /// <param name="bookName"></param>
        /// <returns>Returns a string with the ISBN of a book</returns>
        public string getISBNbyBookName(string bookName)
        {
            foreach (Book b in _bookList)
            {
                if (b.Name == bookName)
                {
                    return b.ISBN;
                }
            }
            return "";
        }

        /// <summary>
        /// Getting the position of a book given by name
        /// </summary>
        /// <param name="bookName"></param>
        /// <returns>Returns an int with the position of a book</returns>
        public int getPozByBookName(string bookName)
        {
            for (int i = 0; i < _bookList.Count; ++i)
            {
                if (_bookList[i].Name == bookName)
                {
                    return i;
                }
            }
            return -1;
        }

       
        //PARTE DE USERI

        /// <summary>
        /// Getting the list of users
        /// </summary>
        /// <returns>Returns a List of an Users.User Object</returns>
        public List<Users.User> GetUsers()
        {
            return _userList;
        }

        /// <summary>
        /// Getting all the names of the users
        /// </summary>
        /// <returns>Returns a string with all the names of the users</returns>
        public string ListAllUsers()
        {
            if (_userList.Count == 0)
                return "buba";

            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < _userList.Count; i++)
            {
                sb.Append(_userList[i]._name);
                sb.Append(" ");

            }

            return sb.ToString();
        }

        /// <summary>
        /// Gets the name of a user of a specified position
        /// </summary>
        /// <param name="poz"></param>
        /// <returns>Returns a string with the name of a user</returns>
        public string getUserName(int poz)
        {
            return _userList[poz]._name;
        }

        /// <summary>
        /// Gets the number of users
        /// </summary>
        /// <returns>Returns an int containing the number of users</returns>
        public int UserCount { get { return _userList.Count; } }


        /// <summary>
        /// Check if a user can be deleted
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns true if a user can be deleted, otherwise returns false</returns>

       public bool CanDeleteUser(User user)
        {
            // Verificăm dimensiunea listei de cărți împrumutate a utilizatorului
            if (user._isbn.Count > 0)
            {
                return false; // Utilizatorul are cărți împrumutate, deci nu poate fi șters
            }

            return true; // Utilizatorul nu are cărți împrumutate, poate fi șters
        }

        /// <summary>
        /// Delete a user given by name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>Return true if the operation was successful, otherwise returns false</returns>
        public bool DeleteUser(string userName)
        {
            bool userFound = false;
            int userIndex = -1;

            for (int i = 0; i < _userList.Count; i++)
            {
                if (_userList[i]._name == userName)
                {
                    userFound = true;
                    userIndex = i;
                    break;
                }
            }

            if (userFound)
            {
                User userToDelete = _userList[userIndex];

                if (CanDeleteUser(userToDelete))
                {
                    _userList.RemoveAt(userIndex);
                    //_wasModifiedUsers = true;
                    
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }

            return false; // Utilizatorul nu a fost gasit în lista

        }

        /// <summary>
        /// Saves the data only if the user list was modified
        /// </summary>
        /// <returns>Returns true if the new data was saved, otherwise returns false</returns>
        public bool SaveDataUser()
        {
            if (_wasModifiedUsers)
            {
                StreamWriter sw = new StreamWriter(u.getFileName);

                for (int i = 0; i < _userList.Count; i++)
                {
                    Users.User b = _userList[i];
                    sw.WriteLine(b._name + "\t" + b._passHash);
                }

                sw.Close();
                return true;
            }
            else
                return false;
        }





        /// <summary>
        /// Adding a new user to the list of users
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Returns true if the operation was succesfully done, otherwise return false</returns>
        public bool AddUser(Users.User user)
        {
            // daca un user cu acelasi nume exista deja va fi sters
            bool overwrite = false;

            for (int i = 0; i < _userList.Count; i++)
            {
                if (_userList[i]._name.Trim().ToUpper() == user._name.Trim().ToUpper())
                {
                    _userList.RemoveAt(i--);
                    overwrite = true;
                }
            }

            // adaugarea noului user
            _userList.Add(user);
            _wasModifiedUsers = true;
            
            return !overwrite;
        }

    }
}
