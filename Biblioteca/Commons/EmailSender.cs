/**************************************************************************
 *                                                                        *
 *  File:        EmailSender.cs                                           *
 *  Copyright:   (c) 2023, Martin Maria                                   *
 *  E-mail:      maria.martin@student.tuiasi.ro                           *
 *  Description: Functions for sending an email                           *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/
using System.Net.Mail;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace Commons
{
    public static class EmailSender
    {
        /// <summary>
        /// Setting up email sending details and sending email over the secure connection using MailKit 
        /// </summary>
        /// <param name="adresaDestinatar"></param>
        /// <param name="mesaj"></param>
        public static void SendEmail(string adresaDestinatar, string mesaj)
        {
            // Configurarea detaliilor de trimitere a emailului
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Virtual Library", "virtual.library.ip@gmail.com"));
            message.To.Add(new MailboxAddress("", adresaDestinatar));
            message.Subject = "Avertisment intarziere";
            message.Body = new TextPart("plain")
            {
                Text = mesaj
            };

            // Trimiterea emailului prin conexiunea securizata folosind MailKit
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                client.Authenticate("virtual.library.ip@gmail.com", "geimdttwnfumywcb");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}