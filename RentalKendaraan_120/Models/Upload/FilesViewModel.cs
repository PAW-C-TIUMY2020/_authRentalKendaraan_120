using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RentalKendaraan_120.Models.Upload
{
    public class FileDetails
    {
        public string Name { get; set; }
        public string Path { get; set; }
    }
    public class FileViewModel
    {
        public List<FileDetails> Files { get; set; }
        = new List<FileDetails>();
    }
}