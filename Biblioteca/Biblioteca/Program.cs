/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
 *  Copyright:   (c) 2023, Cojocaru Georgiana, Lupu Andra, Martin Maria,  *
			   Stefanel Petrescu Miron                        *
 *  E-mail:      georgiana-vasilica.cojocaru@student.tuiasi.ro            *
 *  E-mail:      andra-maria.lupu@student.tuiasi.ro                       *
 *  E-mail:      maria.martin@student.tuiasi.ro                           *
 *  E-mail:      stefanel.petrescu-miron@student.tuiasi.ro                *
 *  Description: The main entry point for the application.                *
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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Presenter;

namespace Biblioteca
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IModel model = new Model.Model();
            IView view = new Form1(model);
            IPresenter presenter = new Presenter.Presenter(model);
            view.SetPresenter(presenter);
            Application.Run((Form1)view);
        }
    }
}
