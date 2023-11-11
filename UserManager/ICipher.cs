using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManager;

public interface ICipher
{
    string Encrypt(string plaintext);
    string Decrypt(string ciphertext);
}
