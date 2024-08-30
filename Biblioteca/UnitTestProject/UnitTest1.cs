using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Commons;
using Criptography;
using Model;
using Presenter;
using System.IO;
using System.Collections.Generic;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdminLogin()
        {
            Administrator a = new Administrator();
            Assert.AreEqual(true, a.Login("admin", "paradmin"));
        }
        [TestMethod]
        public void UsernameLoginMirunel()
        {
            Users u = new Users();
            Assert.AreEqual(true, u.Login("mirunel.ciudatel22", "mirunel.ciudatel22"));
        }

        [TestMethod]
        public void UsernameLoginUsername()
        {
            Users u = new Users();
            Assert.AreEqual(true, u.Login("Username", "Parola"));
        }

        [TestMethod]
        public void UsernameLoginGeo()
        {
            Users u = new Users();
            Assert.AreEqual(true, u.Login("geo", "geo"));
        }

        [TestMethod]
        public void UsernameLoginAndra()
        {
            Users u = new Users();
            Assert.AreEqual(true, u.Login("andra", "marai"));
        }

        [TestMethod]
        public void UsernameLoginMaria()
        {
            Users u = new Users();
            Assert.AreEqual(true, u.Login("maria.martin", "maria.martin"));
        }

        [TestMethod]
        public void BookIsImprumutatMorometii()
        {
            Book b = new Book("Morometii", "Marin Preda", "1234", false, " 0.0.0");
            Assert.AreEqual(0, b.isImprumutat());
        }

        [TestMethod]
        public void BookGetBookNameMorometii()
        {
            Book b = new Book("Morometii", "Marin Preda", "1234", false, " 0.0.0");
            Assert.AreEqual("Morometii", b.getBookName());
        }

        [TestMethod]
        public void BookGetDataImprumutMorometii()
        {
            Book b = new Book("Morometii", "Marin Preda", "1234", false, " 0.0.0");
            Assert.AreEqual(" 0.0.0", b.getDataImprumut());
        }

        [TestMethod]
        public void BookSetImprumutMorometii()
        {
            Book b = new Book("Morometii", "Marin Preda", "1234", false, " 0.0.0");
            b.SetImprumutat();
            b.setDataImprumut();
            Assert.AreEqual(1, b.isImprumutat());
            Assert.AreEqual("21.5.2023", b.getDataImprumut());
        }

        [TestMethod]
        public void BookSetReturntMorometii()
        {
            Book b = new Book("Morometii", "Marin Preda", "1234", false, " 0.0.0");
            b.SetReturnat();
            b.setDataReturn();
            Assert.AreEqual(0, b.isImprumutat());
            Assert.AreEqual("0.0.0", b.getDataImprumut());
        }

        [TestMethod]
        public void TestHash()
        {
            Assert.AreEqual("6y0SgwaLHFtoRxQ1ekB4eRF133Y=", Criptography.Criptography.HashString("Parola"));
        }

        [TestMethod]
        public void ModelGetBookFileName()
        {
            Model.Model model = new Model.Model();

            Assert.AreEqual("books.txt",model.getBookFileName());
        }

        [TestMethod]
        public void ModelAddBook()
        {
            Model.Model model = new Model.Model();
            Book b = new Book("Mara", "Ioan Slavici", "1353", false, "0.0.0");
            Assert.AreEqual(true, model.Add(b));
        }

        [TestMethod]
        public void ModelBookCount()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Assert.AreEqual(5,model.BookCount);
        }

        [TestMethod]
        public void ModelDataExists()
        {
            Model.Model model = new Model.Model();
            
            Assert.AreEqual(true, model.DataExists());
        }

        [TestMethod]
        public void ModelCanDeleteBook()
        {
            Model.Model model = new Model.Model();
            Book b = new Book("Ion", "Liviu Rebreanu", "5678", true, "20.05.2023");
            Assert.AreEqual(false,model.canDeleteBook(b));
        }


        [TestMethod]
        public void ModelDeleteBook()
        {
            Model.Model model = new Model.Model();
            Assert.AreEqual(false, model.Delete("Ion"));
        }

        [TestMethod]
        public void ModelExistsBook()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Assert.AreEqual(true, model.Exists("Ion"));
        }
        
        [TestMethod]
        public void ModelSearchBook()
        {
            Model.Model model = new Model.Model();
            Book b = new Book("Morometii", "Marin Preda", "1234", false, " 0.0.0");
            model.InitializeData();
            Book c = model.Search("Morometii");
            c.dataImprumut = " " + c.dataImprumut;
            Assert.IsTrue(b.ISBN==c.ISBN && b.Name==c.Name && b.Author==c.Author && b.Imprumutat==c.Imprumutat && b.dataImprumut==c.dataImprumut);
           
        }
        
        [TestMethod]
        public void ModelListAllBooks()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            string lista = "Morometii Disponibila!\n" + "Moara cu Noroc Indisponibila!\n" + "Casa de langa lac Indisponibila!\n" + "Ion Disponibila!\n" + "Baltagul Indisponibila!\n";
            Assert.AreEqual(lista, model.ListAllBooks());
        }

        [TestMethod]
        public void ModelSaveData()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Assert.AreEqual(false, model.SaveData());
        }

       
        [TestMethod]
        public void ModelGetBookName()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Assert.AreEqual("Baltagul", model.getBookName(4));
        }
       
        /*
        [TestMethod]
        public void ModelSetImprumut()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            model.setImprumut("Baltagul");
            Assert.AreEqual(true, model.getBookDisp(4));
        }

        [TestMethod]
        public void ModelSetReturn()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            model.setReturn("Ion");
            Assert.AreEqual(false, model.getBookDisp(3));
        }
        */
        [TestMethod]
        public void ModelGetBooks()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            List<Book> b = model.GetBooks();
            List<Book> c = new List<Book>();
            Book b1 = new Book("Morometii", "Marin Preda", "1234", false, " 0.0.0");
            Book b2 = new Book("Moara cu Noroc", "Ioan Slavici", "2345", true, " 21.05.2023");
            Book b3 = new Book("Casa de langa lac", "Kate Morton", "3456", true, " 20.05.2023");
            Book b4 = new Book("Ion", "Liviu Rebreanu", "5678", false, " 0.0.0");
            Book b5 = new Book("Baltagul", "Mihail Sadoveanu", "6789", true, " 21.05.2023");
            c.Add(b1);
            c.Add(b2);
            c.Add(b3);
            c.Add(b4);
            c.Add(b5);
            for (int i = 0; i < b.Count; i++)
            {

                Assert.IsTrue(b[i].ISBN == c[i].ISBN && b[i].Name == c[i].Name && b[i].Author == c[i].Author && b[i].Imprumutat == c[i].Imprumutat);
            }
        }
        [TestMethod]
        public void ModelGetBookDisp()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Assert.AreEqual(true, model.getBookDisp(4));
        }

        [TestMethod]
        public void ModelGetUserBooks()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Users.User u = new Users.User("mirunel.ciudatel22", Criptography.Criptography.HashString("mirunel.ciudatel22"));
           
            List<string> isbn = model.getUserBooks(u);
            List<string> isbn2 = new List<string>();
            isbn2.Add("5678");
            isbn2.Add("3456");
            for(int i = 0; i < isbn.Count; i++)
            {
                Assert.IsTrue(isbn[i] == isbn2[i]);
            }
           
        }

        [TestMethod]
        public void ModelGetBookNameByISBN()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Assert.AreEqual("Casa de langa lac", model.getBookNameByISBN("3456"));
        }

        [TestMethod]
        public void ModelGetISBNByBookName()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Assert.AreEqual("2345", model.getISBNbyBookName("Moara cu Noroc"));
        }

        [TestMethod]
        public void ModelGetPozByBookName()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Assert.AreEqual(1, model.getPozByBookName("Moara cu Noroc"));
        }

        [TestMethod]
        public void ModelGetUsers()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            List<Users.User> users = new List<Users.User>();
            Users.User u1 = new Users.User("Username", Criptography.Criptography.HashString("Parola"));
            Users.User u2 = new Users.User("geo", Criptography.Criptography.HashString("geo"));
            Users.User u3 = new Users.User("andra", Criptography.Criptography.HashString("marai"));
            Users.User u4 = new Users.User("maria.martin", Criptography.Criptography.HashString("maria.martin"));
            Users.User u5 = new Users.User("mirunel.ciudatel22", Criptography.Criptography.HashString("mirunel.ciudatel22"));
            List<Users.User> u = model.GetUsers();
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);
            users.Add(u5);
            for (int i=0;i< u.Count; i++)
            {
                Assert.IsTrue(u[i]._name == users[i]._name && u[i]._passHash == users[i]._passHash);
            }
        }

        [TestMethod]
        public void ModelListAllUsers()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            string lista = "Username geo andra maria.martin mirunel.ciudatel22 ";
           Assert.AreEqual(lista, model.ListAllUsers());
        }

        [TestMethod]
        public void ModelGetUserName()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
           
            Assert.AreEqual("geo", model.getUserName(1));
        }

        [TestMethod]
        public void ModelUserCount()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
           
            Assert.AreEqual(5, model.UserCount);
        }

        [TestMethod]
        public void ModelCanDeleteUser()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Users.User a = new Users.User("andra", Criptography.Criptography.HashString("marai"));
            
            Assert.AreEqual(true, model.CanDeleteUser(a));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ModelDeleteUserCuCarti()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();

            model.DeleteUser("geo");
        }

        [TestMethod]
        public void ModelDeleteUserFaraCarti()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();

            Assert.AreEqual(true, model.DeleteUser("andra"));
        }

        [TestMethod]
        public void ModelDeleteUserNuExista()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            
            Assert.AreEqual(false, model.DeleteUser("dan"));
        }

        [TestMethod]
        public void ModelSaveDataUser()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();

            Assert.AreEqual(false, model.SaveDataUser());
        }

        [TestMethod]
        public void ModelAddUserNou()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Users.User u = new Users.User("bianca", Criptography.Criptography.HashString("lalala"));
            Assert.AreEqual(true, model.AddUser(u));
        }

        [TestMethod]
        public void ModelAddUserExistent()
        {
            Model.Model model = new Model.Model();
            model.InitializeData();
            Users.User a = new Users.User("andra", Criptography.Criptography.HashString("marai"));
            Assert.AreEqual(false, model.AddUser(a));
        }
    }
}
