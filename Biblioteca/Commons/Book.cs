/**************************************************************************
 *                                                                        *
 *  File:        Book.cs                                                  *
 *  Copyright:   (c) 2023, Cojocaru Georgiana                             *
 *  E-mail:      georgiana-vasilica.cojocaru@student.tuiasi.ro            *
 *  Description: Book structure                				  *
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
using System.Windows.Forms;

namespace Commons
{
    public struct Book
    {
        public readonly string Name;
        public readonly string Author;
        public readonly string ISBN;
        public bool Imprumutat;
        public string dataImprumut;

        /// <summary>
        /// Initialization of a book object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        /// <param name="id"></param>
        /// <param name="imp"></param>
        /// <param name="dateImpumut></param>
        public Book(string name, string author, string id, bool imp,string dateImpumut)
        {
            Name = name;
            Author = author;
            ISBN = id;
            Imprumutat = imp;
            dataImprumut = dateImpumut;
        }

        /// <summary>
        /// Setting the book as unavailable(borrowed)
        /// </summary>
        /// <returns></returns>
        public void SetImprumutat()
        {
            this.Imprumutat = true;
        }

        /// <summary>
        /// Setting the the book as available(at the library)
        /// </summary>
        /// <returns></returns>
        public void SetReturnat()
        {
            this.Imprumutat = false;
        }

        /// <summary>
        /// Checking if a book is avaible or not
        /// </summary>
        /// <returns>Returns an int(1 or 0) depending on the availability of a book</returns>
        public int isImprumutat()
        {
            if (Imprumutat == false)
                return 0;
            return 1;
        }

        /// <summary>
        /// Getting the name of a book
        /// </summary>
        /// <returns>Returns a string containing the name of a book</returns>
        public string getBookName()
        {
            return Name;
        }

        /// <summary>
        /// Getting the date on which the book was borrowed
        /// </summary>
        /// <returns>Returns a string containing the date of the book</returns>
        public string getDataImprumut()
        {
            return this.dataImprumut;
        }

        /// <summary>
        /// Resetting the date of a book when it is returned
        /// </summary>
        public void setDataReturn()
        {
            int d = 0;
            string dateImprumut = d.ToString() + "." + d.ToString() + "." + d.ToString();
            this.dataImprumut = dateImprumut;
        }

        /// <summary>
        /// Setting the date of a book to the day it is borrowed
        /// </summary>
        public void setDataImprumut()
        {
            DateTime now = DateTime.Now;
            int year = now.Year;
            int month = now.Month;
            int day = now.Day;
            string d = day.ToString();
            string m = month.ToString();
            string y = year.ToString();
            string dateImprumut = d + "." + m + "." + y;
            this.dataImprumut = dateImprumut;
        }

    }
}
