using System;
using System.Collections.Generic;
using System.Text;

namespace Sean.DataScience.Storage.AzureBlobStorage
{
    public class AzureBlobStorageOptions
    {
        public string ConnectionString { get; set; }
        public string Container { get; set; }
    }
}
