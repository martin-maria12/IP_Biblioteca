/**************************************************************************
 *                                                                        *
 *  File:        Presenter.cs                                             *
 *  Copyright:   (c) 2023, Cojocaru Georgiana                             *
 *  E-mail:      georgiana-vasilica.cojocaru@student.tuiasi.ro            *
 *  Description: Application with MVC architecture Presenter Class        *
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
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Commons;
namespace Presenter
{
    public class Presenter :IPresenter
    {
        private IModel _model;

        public Presenter(IModel model)
        {
            _model = model;
        }

        /// <summary>
        /// Adding a new book
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            if (_model.Add(book))
                Console.WriteLine("Cartea " + book.Name + " a fost adaugata.");
            else
                Console.WriteLine("Cartea " + book.Name + " a fost suprascrisa!");
        }

        /// <summary>
        /// Adding a new user
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(Users.User user)
        {
            if (_model.AddUser(user))
                Console.WriteLine("Userul " + user._name + " a fost adaugata.");
            else
                Console.WriteLine("Userul " + user._name + " a fost suprascris!");

        }

        /// <summary>
        /// Checking if a certain book exists
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns true if a books exists, otherwise returns false</returns>
        public bool BookExists(string name)
        {
            return _model.Exists(name); ;
        }

        /// <summary>
        /// Getting a book if it exists
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Returns the book if it exists, otherwise returns an unitialized object</returns>
        public Book GetBook(string name)
        {
            if (BookExists(name))
                return _model.Search(name);
            return new Book();
        }

        /// <summary>
        /// Initialization of the Model
        /// </summary>
        public void Init()
        {
            if (!_model.DataExists())
            {
                Console.WriteLine("Fisierul cu carti nu exista." + Environment.NewLine);
            }
            else
            {
                _model.InitializeData();
                Console.WriteLine("Fisier incarcat: " + _model.BookCount + " carti." + Environment.NewLine);
            }
        }

        /// <summary>
        /// Deleting a book
        /// </summary>
        /// <param name="book"></param>
        public void RemoveBook(string book)
        {
            if (_model.Delete(book))
                Console.WriteLine("Cartea " + book + " a fost stersa.");
            else
                Console.WriteLine("Cartea " + book + " nu exista!");
        }

        /// <summary>
        /// Exit the program
        /// </summary>
        public void Exit()
        {
            if (_model.SaveData())
                Console.WriteLine("Fisierul books a fost salvat." + Environment.NewLine);
            if (_model.SaveDataUser())
                Console.WriteLine("Fisierul users a fost salvat." + Environment.NewLine);
            // Application.DoEvents(); // numai pentru Windows Forms
            Thread.Sleep(1000);
            Environment.Exit(0);
        }

        /// <summary>
        /// Deleting an user
        /// </summary>
        /// <param name="user"></param>
        public void RemoveUser(string user)
        {
            if (_model.DeleteUser(user))
                Console.WriteLine("Userul " + user + " a fost sters.");
            else
                Console.WriteLine("Userul " + user + " nu exista!");
        }

    }
}
