﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace envioMasivoCorreos.Models
{
    public class ConfigurationSmtpClient
    {
        public string Host { get; set; } = "";
        public int Port { get; set; }
        public bool EnableSsl { get; set; }
        public string User { get; set; } = "";
        public string Password { get; set; } = "";

    }
}