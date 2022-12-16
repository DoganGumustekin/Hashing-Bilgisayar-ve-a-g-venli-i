using System;

class GetHashCode
{
    public static void Main()
    {
        //string password = "4abc6def";
        string x = "zffeeeeez";
        //stringDegistir(x);
        Hash11(x);
        //hash(password);
        //Coz(password);
        //int[] x = new int[2];
        //x[1] = 2;
        //DisplayHashCode(x[1].ToString());
        //DisplayHashCode("");
        //DisplayHashCode("a");
        //DisplayHashCode("b");
        //DisplayHashCode("c");
        //DisplayHashCode("d");
        //DisplayHashCode("e");
        //DisplayHashCode("f");
        //DisplayHashCode("g");
        //DisplayHashCode("h");
        //DisplayHashCode("i");
        //DisplayHashCode("g");
        //DisplayHashCode("h");
        //DisplayHashCode("1");

        //yeni yol bulundu girilen her karakteri veya sayıyı başka bir karaktere veya sayıya dönüştür. 
    }

    static void DisplayHashCode(string Operand)
    {
        int HashCode = Operand.GetHashCode();
        Console.WriteLine("The hash code for \"{0}\" is: 0x{1:X8}, {1}",
                          Operand, HashCode);
    }

    static void Coz(string operand)
    {
        string[] cozulen;
        List<string> liste = new List<string>();
        liste.Add(operand);
        string toplam = null;
        for (int i = 0; i < operand.Length; i++)
        {
            if (operand[i] % 2 == 0)
            {
                liste.Remove("abc");
            }
            else
            {
                liste.Remove("def");
            }
        }
        cozulen = liste.ToArray();
        Console.WriteLine(cozulen[0]);
    }
    static void hash(string operand)
    {
        string[] sifreli;
        List<string> liste = new List<string>();
        string toplam = null;
        string y = null;
        string x = null;
        for (int i = 0; i < operand.Length; i++)
        {
            if (operand[i] % 2 == 0)
            {
                y = operand[i] * 2 + "abc" /*+ operand[i].GetHashCode()*/;
                toplam += y;

            }
            //eğer kullanıcı 4444 gibi aynı şeyleri girerse farklı birşey yapsın
            else
            {
                x = operand[i] * 3 + "def" /*+ operand[i].GetHashCode()*/;
                toplam += x;

            }
        }
        liste.Add(toplam);
        sifreli = liste.ToArray();
        Console.WriteLine(sifreli[0]);
    }



    public static string stingCoz(string Operand)
    {
        //string ad;
        //Console.WriteLine("şifre gir");
        //ad = Console.ReadLine();
        //var k = stringDegistir(ad);
        //var ss = stringDegistir(Operand);

        //for (int i = 0; i < k.Length; i++)
        //{
        //    if (ss[i] != k[i])
        //    {

        //        throw new Exception("şifre hatalı");
        //    }
        //    else
        //    {
        //        throw new Exception("giriş başarılı");
        //    }
        //}




        string toplam = null;
        string[] s = null;
        List<string> param = new List<string>();
        List<string> tut = new List<string>();
        for (int i = 0; i < Operand.Length; i++)
        {
            if (Operand[i] == 'z' || Operand[i] == 'Z')
            {
                var c = Operand[i];
                c = 'a';
                toplam += c;
                Operand.Remove(Operand[i] + 1);
            }
        }
        string[] sifreli;
        param.Add(toplam);
        sifreli = param.ToArray();
        Console.WriteLine(sifreli[0]);
        return sifreli[0];
    }

    static int Hash11(string input)
    {
        int hash = 0;
        foreach (char c in input)
        {
            hash += (int)c;
        }
        Console.WriteLine(hash);
        return hash;
    }

    public static string stringDegistir(string Operand)
    {
        string toplam = null;
        List<string> param = new List<string>();
        for (int q = 0; q < Operand.Length; q++)
        {
            if (Operand[q].GetType() == typeof(string))
            {
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

            }

            else if (Operand[q].GetType() == typeof(int))
            {
                if (Operand[q] == 1)
                {
                    var c = Operand[q];
                    toplam += c*c;
                }
            }
            else
            {
                throw new Exception("dd");
            }
        }
        
        string[] sifreli;

        param.Add(toplam);
        sifreli = param.ToArray();
        Console.WriteLine(sifreli[0]);
        return sifreli[0];
    }


}
