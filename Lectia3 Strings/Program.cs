using System;

using static Lectia3_Strings.Exercitii;
namespace Lectia3_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(NumarereLitereText("Are mere", 'e'));
            //Console.WriteLine(isVocala('e'));
            //Console.WriteLine(NumarareVocaleText("Ana are mere!"));
            //6



            //string x = "Ana";
            //string t = "Anb";
            //Console.WriteLine(t.CompareTo(x));




            // string text = "Doremi re";




            // Console.WriteLine(text.IndexOf("re"));

            //Console.WriteLine(text.Substring(4));
            // Console.WriteLine(contorSilaba(text, "re"));





            //string text = "Ana are mere";//=["ANA",ARE,"MERE"]


            //Console.WriteLine(cuvinte[2]);

            //Console.WriteLine(Char.IsDigit('1'));

            //Console.WriteLine(Char.IsUpper('a'));
            //Console.WriteLine(eraseChar("text", 't'));
            //Console.WriteLine(eraseFirstLetter("Tet"));
            //EliminareSuccesiva("Deosebit");
            string[,] matrix = new string[3, 2] { { "Unu", "Una" },
                                                { "Doi", "Doua" },
                                                { "Patru", "Trei" } };

            //SirLungCaractere(matrix);
            //Console.WriteLine(Mioritic("mIoRiTiC"));
            // Console.WriteLine(Mioritic2("MiOrItIc"));
            //Console.WriteLine(maxConcatenat("Mama arc conduce"));


            string[] cuvinte = minLexicografic("Mama arc conduce paine vine");
            //Console.WriteLine(cuvinte[0]+cuvinte[1]);
            //Console.WriteLine(lowerUpperCase("ciubar"));
            //Console.WriteLine(lowerUpperCaseText("lower text"));
            //propoziteUpperCase("Fie A un punct fix. Presupunem! b punct mobil!");
            string[] prenume = { "Ana", "Alice", "a", "Mihai" };

            //prenumeFete(prenume);
            //Rimeaza("armat", "verificat");

            //tring text=  SirEliminare("   Ana   are   Mere ");//=>{"Ana","are","","","Mere"
            //Console.WriteLine(text);

            //string text1 = upperAndLast("Ana are mere");
            //Console.Write(text1);

            //Console.WriteLine(isVocalaLowerCase('e'));

            //string text3 = duplicateUpperCase("Ana Are MERE");
            //Console.Write(text3);


            //string text4 = DuplicateUpperRemoveLower("Ana are mere");
            //Console.Write(text4);

            //int sumaCifreText = SumDigits("1.Ana are 2 sau 5 mere sau 2?");
            //Console.Write(sumaCifreText);

            //double AverageASCII = AvgASCII("Media avg");//https://www.alpharithms.com/ascii-table-512119/
            //Console.Write(AverageASCII);

            //Console.Write(NrAparitii("cel  cel cel cel mai cel cel"));
            //Console.Write(OglindaSir("ABC DEFZ"));
            //SirulOglinda("abc def");//afbecd

            // int textCount = CountLowerCase("A un doi treipPO");
            // Console.Write(textCount);

            // bool sol = isToateConsoane("AdasD");


            //Console.WriteLine(sol);


            //Console.WriteLine(isPalindrom("ana"));

            //AfisareCuvVocale("ae aei aeiou");
            //CuvintelePalindrome("opo rar mam dus 121");

            //CuvintePeste4Caractere("unu doi zece unsprezece");

            //AlTreileCuvantCitit("Primul Doilea Treilea");

            //Console.WriteLine(DeleteReplace("mamam fraif tarif tartele telet"));
            //Console.Write(DeleteReplace2("12341; 12345 1234? 0222222220"));
            //Console.Write(Duplicate3Letters("1112  2223  3334"));
            //Console.Write(replaceLastLowercase("Ultima doua treia"));
            //numar numarat
            Prefixe("nu numarat abs nr numalua");
        }


    }
}
