/**************************************************************************
 *                                                                        *
 *  File:        Criptography.cs                                          *
 *  Copyright:   (c) 2023, Lupu Andra                                     *
 *  E-mail:      andra-maria.lupu@student.tuiasi.ro                       *
 *  Description: Contains a function for hashing                          *
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
using System.IO;
using System.Security.Cryptography;

namespace Criptography
{
    public class Criptography
    {
       
        /// <summary>
        /// Creates a hash for a string
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Returns string containing the hash</returns>
        public static string HashString(string str)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            byte[] buf = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
                buf[i] = (byte)str[i];
            byte[] result = sha.ComputeHash(buf);
            return Convert.ToBase64String(result);
        }
    }
}
