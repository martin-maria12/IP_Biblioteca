/**************************************************************************
 *                                                                        *
 *  File:        IPresenter.cs                                            *
 *  Copyright:   (c) 2023, Cojocaru Georgiana                             *
 *  E-mail:      georgiana-vasilica.cojocaru@student.tuiasi.ro            *
 *  Description: Application with MVC architecture IPresenter interface   *
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
    public interface IPresenter
    {

        void AddBook(Book book);
        void AddUser(Users.User user);
        bool BookExists(string name);
        Book GetBook(string name);
        void Init();
        void RemoveBook(string book);
        void RemoveUser(string user);
    }
}
