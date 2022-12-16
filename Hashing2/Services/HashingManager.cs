using Hashing2.Models;
using System;
using System.Drawing;

namespace Hashing2.Services
{
    public class HashingManager
    {
        public void coz(HashingManager passwordHash)
        {

        }

        public static void hashle(string password, out byte[] sifreli)
        {
            List<byte> hash = new List<byte>();
            for (int i = 0; i < password.Length; i++)
            {
                var hashCode = DisplayHashCode(password[i]);
                var x = hashCode / 10;
                hash.Add((byte)x);
            }
            sifreli = hash.ToArray();
        }

        public static int DisplayHashCode(int Operand)
        {
            int HashCode = Operand.GetHashCode();
            return HashCode;
        }

        //public static void hashle2(string[] password)
        //{
        //    List<string> hash = new List<string>();
        //    var sonuc = stringDegistir(password);

        //    hash.Add(sonuc);

        //}

        public static void VerifyPassword(string gelenPassword, string esitPassword)
        {
            string kontrolHash;
            stringDegistir(gelenPassword, out kontrolHash);
            for (int i = 0; i < kontrolHash.Length; i++)
            {
                if (kontrolHash[i] != esitPassword[i])
                {
                    throw new Exception("sifre hatalı");
                }
            }
            throw new Exception("giriş başarılı");
        }

        public static void stringDegistir(string Operand, out string passwordhash)
        {
            string toplam = null;
            List<string> param = new List<string>();
            for (int i = 0; i < Operand.Length; i++)
            {
                if (Operand[i] == 'a' || Operand[i] == 'A')
                {
                    var c = Operand[i];
                    c = 'z';
                    toplam += c;
                    int k = 1;
                    toplam += k;
                    c = 'a';

                }
                if (Operand[i] == 'b' || Operand[i] == 'B')
                {
                    var c = Operand[i];
                    c = 'y';
                    toplam += c;
                    int k = 2;
                    toplam += k;
                    c = 'b';
                }
                if (Operand[i] == 'c' || Operand[i] == 'C')
                {
                    var c = Operand[i];
                    c = 'x';
                    toplam += c;
                    int k = 3;
                    toplam += k;
                    c = 'c';
                }
                if (Operand[i] == 'd' || Operand[i] == 'D')
                {
                    var c = Operand[i];
                    c = 'v';
                    toplam += c;
                    int k = 4;
                    toplam += k;
                    c = 'd';
                }
                if (Operand[i] == 'e' || Operand[i] == 'E')
                {
                    var c = Operand[i];
                    c = 'u';
                    toplam += c;
                    int k = 5;
                    toplam += k;
                    c = 'e';
                }
                if (Operand[i] == 'f' || Operand[i] == 'F')
                {
                    var c = Operand[i];
                    c = 't';
                    toplam += c;
                    int k = 6;
                    toplam += k;
                    c = 'f';
                }
                if (Operand[i] == 'g' || Operand[i] == 'G')
                {
                    var c = Operand[i];
                    c = 's';
                    toplam += c;
                    int k = 7;
                    toplam += k;
                    c = 'g';
                }
                if (Operand[i] == 'h' || Operand[i] == 'H')
                {
                    var c = Operand[i];
                    c = 'r';
                    toplam += c;
                    int k = 8;
                    toplam += k;
                    c = 'h';
                }
                if (Operand[i] == 'ı' || Operand[i] == 'I')
                {
                    var c = Operand[i];
                    c = 'q';
                    toplam += c;
                    int k = 9;
                    toplam += k;
                    c = 'ı';
                }
                if (Operand[i] == 'i' || Operand[i] == 'İ')
                {
                    var c = Operand[i];
                    c = 'p';
                    toplam += c;
                    int k = 10;
                    toplam += k;
                    c = 'i';
                }
                if (Operand[i] == 'j' || Operand[i] == 'J')
                {
                    var c = Operand[i];
                    c = 'o';
                    toplam += c;
                    int k = 11;
                    toplam += k;
                    c = 'j';
                }
                if (Operand[i] == 'k' || Operand[i] == 'K')
                {
                    var c = Operand[i];
                    c = 'n';
                    toplam += c;
                    int k = 12;
                    toplam += k;
                    c = 'k';
                }
                if (Operand[i] == 'l' || Operand[i] == 'L')
                {
                    var c = Operand[i];
                    c = 'm';
                    toplam += c;
                    int k = 13;
                    toplam += k;
                    c = 'l';
                }
                if (Operand[i] == 'm' || Operand[i] == 'M')
                {
                    var c = Operand[i];
                    c = 'l';
                    toplam += c;
                    int k = 14;
                    toplam += k;
                    c = 'm';
                }
                if (Operand[i] == 'n' || Operand[i] == 'N')
                {
                    var c = Operand[i];
                    c = 'k';
                    toplam += c;
                    int k = 15;
                    toplam += k;
                    c = 'n';
                }
                if (Operand[i] == 'o' || Operand[i] == 'O')
                {
                    var c = Operand[i];
                    c = 'j';
                    toplam += c;
                    int k = 16;
                    toplam += k;
                    c = 'o';
                }
                if (Operand[i] == 'p' || Operand[i] == 'P')
                {
                    var c = Operand[i];
                    c = 'ı';
                    toplam += c;
                    int k = 17;
                    toplam += k;
                    c = 'p';
                }
                if (Operand[i] == 'q' || Operand[i] == 'Q')
                {
                    var c = Operand[i];
                    c = 'i';
                    toplam += c;
                    int k = 18;
                    toplam += k;
                    c = 'q';
                }
                if (Operand[i] == 'r' || Operand[i] == 'R')
                {
                    var c = Operand[i];
                    c = 'h';
                    toplam += c;
                    int k = 19;
                    toplam += k;
                    c = 'r';
                }
                if (Operand[i] == 's' || Operand[i] == 'S')
                {
                    var c = Operand[i];
                    c = 'g';
                    toplam += c;
                    int k = 20;
                    toplam += k;
                    c = 's';
                }
                if (Operand[i] == 't' || Operand[i] == 'T')
                {
                    var c = Operand[i];
                    c = 'f';
                    toplam += c;
                    int k = 21;
                    toplam += k;
                    c = 't';
                }
                if (Operand[i] == 'u' || Operand[i] == 'U')
                {
                    var c = Operand[i];
                    c = 'e';
                    toplam += c;
                    int k = 22;
                    toplam += k;
                    c = 'u';
                }
                if (Operand[i] == 'v' || Operand[i] == 'V')
                {
                    var c = Operand[i];
                    c = 'd';
                    toplam += c;
                    int k = 23;
                    toplam += k;
                    c = 'v';
                }
                if (Operand[i] == 'x' || Operand[i] == 'X')
                {
                    var c = Operand[i];
                    c = 'c';
                    toplam += c;
                    int k = 24;
                    toplam += k;
                    c = 'x';
                }
                if (Operand[i] == 'y' || Operand[i] == 'Y')
                {
                    var c = Operand[i];
                    c = 'b';
                    toplam += c;
                    int k = 25;
                    toplam += k;
                    c = 'y';
                }
                if (Operand[i] == 'z' || Operand[i] == 'Z')
                {
                    var c = Operand[i];
                    c = 'a';
                    toplam += c;
                    int k = 26;
                    toplam += k;
                    c = 'z';
                }
            }

            string[] sifreli;

            param.Add(toplam);
            sifreli = param.ToArray();
            passwordhash = sifreli[0];
        }
    }
}
