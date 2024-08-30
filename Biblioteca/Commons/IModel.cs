/**************************************************************************
 *                                                                        *
 *  File:        IModel.cs                                                *
 *  Copyright:   (c) 2023, Cojocaru Georgiana                             *
 *  E-mail:      georgiana-vasilica.cojocaru@student.tuiasi.ro            *
 *  Description: Application with MVC architecture IModel interface       *
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons
{
    public interface IModel
    {
        //  PARTE DE BOOKS

        bool Add(Book book);
        int BookCount { get; }
        bool DataExists();
        bool Delete(string bookName);
        bool Exists(string bookName);
        bool SaveData();
        string getBookName(int poz);
        bool getBookDisp(int poz);
        Book Search(string bookName);
        string ListAllBooks();
        void InitializeData();
        int getPozByBookName(string bookName);
        List<Book> GetBooks();
        void setImprumut(string name);
        void setReturn(string name);
        List<string> getUserBooks(Users.User u);
        string getBookNameByISBN(string isbn);
        string getBookFileName();
        string getISBNbyBookName(string bookName);

        //  PARTE DE USERI

        List<Users.User> GetUsers();
        string ListAllUsers();
        string getUserName(int poz);
        int UserCount { get; }
        bool DeleteUser(string userName);
        bool SaveDataUser();
        bool AddUser(Users.User user);
        bool CanDeleteUser(Users.User user);
    }
}
