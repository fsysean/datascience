using System;
using System.Collections.Generic;
using System.Text;

namespace Sean.DataScience.Storage.SFTP
{
    public class SshOptions
    {
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DefaultPath { get; set; }
    }
}
