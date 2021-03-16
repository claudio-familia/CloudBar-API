using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBar.Common.Services.Contracts
{
    public interface ICryptographyService
    {
        public string Decrypt(string text, string hash);
        public string Encrypt(string text, string hash);
    }
}
