﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Credencial
    {
        public string username { get; set; }
        public string password { get; set; }
        public string acceso { get; set; }

        public Credencial(string username, string password, string acceso)
        {
            this.username = username;
            this.password = password;
            this.acceso = acceso;
        }
    }
}
