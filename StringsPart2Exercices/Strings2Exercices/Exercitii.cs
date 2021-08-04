using System;
using System.Collections.Generic;
using System.Text;

namespace Strings2Exercices
{
    class Exercitii
    {
        //Se considera doua cuvinte ce contim numai litere mici. 
        //Consideram ca ultima silaba a unui cuvant este subsirul care incepe cu ultima lui vocala. 
        //-Trbuie sa gasesc pozitia ultimei vocale
        //Verificati daca aceste cuvinte rimeaza(daca au ultima silaba identica).
        //-poz ultima vocala primul cuvant si poz ultima vocala la al doilea cuvant

        //Daca un cuvant nu contine vocale atunci ultima silaba este intregul cuvant. 
        //Ex: pt. 'armat' si 'verificat' se va afisa mesajul 'Rimeaza'

        //functie ce verifica daca un caracter este vocala
        public static bool IsVocala(char c)
        {
            string vocale = "AEIOUaeiou";

            return vocale.Contains(c);
        }

        //functie ce returneaza pozitia ultimei vocale dintr-un text
        public static int PozitieUltimaVocala(string text)
        {
             for(int i = text.Length - 1; i >= 0; i--)
            {
                if (IsVocala(text[i]) == true)
                {
                    return i;
                }
            }
            return 0;
        }

        //functie ce returneaza silaba fiecarui cuvant
        public static string UltimaSilaba(string cuvantDeVerificat)
        {
            return cuvantDeVerificat.Substring(PozitieUltimaVocala(cuvantDeVerificat));
            //return la final;
            //Se apeleaza functia PozitieUltimaVocala cu parametrul cuvnat de verificat
            //Aceasta returneaza pozitia(Index) la care se afla ultima vocala
            //.Substring primeste pozita(returnat de functie pozUltimaVocala) de unde sa ia substringul
            //ex. pt substring de 2, pleaca de la m(rimeaza), si taie/extrage 'ri', si ramane 'meaza'
            //se obtine ultima silaba
            //se returneaza ultima silaba
        }

        public static void Rimeaza(string cuvantInitital, string cuvantCuCareSeCompara)
        {
            string ultimaSilabaCuvantInitial, ultimaSilabaCuvantCuCareSeCompara;

            ultimaSilabaCuvantInitial = UltimaSilaba(cuvantInitital);
            ultimaSilabaCuvantCuCareSeCompara = UltimaSilaba(cuvantCuCareSeCompara);
            if(ultimaSilabaCuvantInitial.Equals(ultimaSilabaCuvantCuCareSeCompara))
            {
                Console.Write("Rimeaza ");
            }
            else 
                Console.Write("Nu rimeaza ");
        }

        /*De la tastatura se citeste un text codificat dupa regula urmatoare:
        in fata fiecarui caracter este scirs un numar ce reprezinta numarul de aparitii
        consecutive al acestuia. Realizati un program care decodifica textul.
        Numarul ce apare in fata unui caracter va fi mai mic sau cel mult egal cu 20.
        ex: pentru "1G11o1L" se va afisa "GoooooooooooL".
         */
       
        //functie ce verifica daca textul are 1 cifra inainte de text
        //functie ce verifica daca textul are 2 cifre inainte de text
        
        public static string Inserare(char c ,int nrAparitiiCaracterInNoulString)
        {
            //formarea stringului ce trebuie adaugat
            string nou = "";
            for (int i = 1; i <= nrAparitiiCaracterInNoulString; i++)
            {
                nou += c;
            }
            return nou;
        }   
       
        public static void TextulCodificatPt1Cifra(string text)
        {
            for(int i=0; i<text.Length-1; i++)
            {
                if (char.IsDigit(text[i])&&i< text.Length-1)
                {
                    text = text.Substring(0, i) + Inserare(text[i + 1], Int32.Parse(text[i] + ""))
                         + text.Substring(i + 1);
                 
                }
            }
            Console.Write(text);
        }

        public static void TextCodificatV2(string textCodificat)
        {
            string textDecodificat = "";
            int i = 0;
            while (i < textCodificat.Length)
            {
                if (char.IsDigit(textCodificat[i + 1]))
                {
                    int cifraZeci = (int)char.GetNumericValue(textCodificat[i]);
                    int cifraUnitati = (int)char.GetNumericValue(textCodificat[i + 1]);
                    int numar = cifraZeci * 10 + cifraUnitati;
                    for (int j = 0; j < numar; j++)
                    {
                        textDecodificat += textCodificat[i + 2];
                    }
                    i += 3;
                }
                else
                {
                    int numar = (int)char.GetNumericValue(textCodificat[i]);
                    for (int j = 0; j < numar; j++)
                    {
                        textDecodificat += textCodificat[i + 1];
                    }
                    i += 2;
                }
            }
            Console.Write(textDecodificat);
        } 
    }
}
