using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Lectia3_Strings
{
    class Exercitii
        
    {
        /*Se considera un text de maximum 255 de caractere. 
         * 
         Realizati un program care afiseaza: 
        a.Numarul de aparitii al unei litere in text. Litera va fi cititia de la tastatura
        b. Cate vocale apar in textul citit
        c. Numarul de aparitii al unei silabe in text. 
        Silaba va fi cititia de la tastatura. 
        Exemplu: pentru litera 'a', silaba "re" cu textul: "Ina are multe mere"
        se va afisa: 
        a. 2; b.8; c.2*/

        public static int NumarereLitereText(String text, char c)
        {
            int contorAparitiiLitera = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == c)
                {

                    contorAparitiiLitera++;
                }
            }
            return contorAparitiiLitera;

        }


        //functie isVocala care are ca paramteru un caracter


        public static bool isVocala(char x)
        {

            string vocale = "AEIOUaeiou";

            for (int i = 0; i < vocale.Length; i++)
            {
                if (vocale[i] == x)
                {
                    return true;
                }
            }
            return false;

        }

        public static int NumarareVocaleText(String text)
        {
            int contor = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (isVocala(text[i]) == true)
                {
                    contor++;
                }
            }
            return contor;
        }


        public static int contorSilaba(string text, string silaba)
        {

            int contor = 0;

            int pozitie = text.IndexOf(silaba);

            while (pozitie >= 0)
            {

                contor++;

                text = text.Substring(pozitie + silaba.Length);

                pozitie = text.IndexOf(silaba);
            }


            return contor;
        }//                                                        012345678            re
        /*contor  |  pozitie  |  while (pozitie >= 0)|    text     Doremi re        | silaba | pozitie+silaba.length   |
         0              2               true                           01234                   (2+2(lungimea silabei)=4
         1              -                                          ----mi re  
         -              3             da(3>0)
         2              -                                                /                       3+2=5
                        -1
                                                             */

        /*Se considera un cuvnat format din litere mici si mari ale alfabetului englez. 
         Realizati un program care permite stergerea tutoror aparitilor primei litere in cadrul cuvantului respectiv. 
        Exemplu: Pt. mamamie, se va afisa aaie*/



        //functie ce sterge dintr-un text tot caracter


        /*  public static string eraseChar(string text ,char x)
          {
              string[] exemplu = text.Split(x);
              string nou = "";
              for(int i = 0; i < exemplu.Length; i++)
              {

                  nou += exemplu[i];

              }
              return nou;
          }*/

        public static string eraseFirstLetter(string cuvant)
        {
            string nouInCareSeSalveaza = "";


            for (int i = 0; i < cuvant.Length; i++)
            {
                if (cuvant[0] != cuvant[i]//daca prima litera != litera curenta(litera care e parcurs)
                             && cuvant[0] - 32 != cuvant[i]//Daca e litera mare o fac litera mica -unicode 32
                             && cuvant[i] - 32 != cuvant[0])
                {
                    nouInCareSeSalveaza += cuvant[i];
                }
            }
            return nouInCareSeSalveaza;
        }
        /*Se considera un cuvant format din litere mici si mari ale alfabetului englez. Sa se scrie un program care afiseaza cuvintele obtinute
        din cuvantul initial prin eliminarea succesiva a primului si ultimului caracter al sirului.
        ex: pt deosebit se va afisa eosebi, oseb, se.*/
        public static void EliminareSuccesiva(string cuvant)
        {
            string nouInCareSeSalveaza = "";//salvam cuvintele obtinute
            for (int i = 0; i < (cuvant.Length - 1) / 2; i++)
            //Eliminare a doua litere(prima si ultima
            //pentru ficare i am obitnut o solutie
            {
                for (int j = i + 1; j < (cuvant.Length - 1) - i; j++)
                //creare solutie
                //se pleaca de la litera 2, pana la penultima
                {
                    //copiere in noul string litera cu litera
                    nouInCareSeSalveaza += cuvant[j];

                }
                Console.WriteLine(nouInCareSeSalveaza);
                //reinitializare string empty
                nouInCareSeSalveaza = "";
            }
        }
        /*
         * i   | i < (cuvant.Length - 1) / 2 |  j  | j < (cuvant.Length - 1) - i| nouInCareSeSalveaza | Cuvant | 0  1  2  3  4  5  6  7
         *                                                                                                       D  e  o  s  e  b  i  t
         *i=0  | 0 < (8-1)=7/2=3 T              1      1<7                                                          e
                                                2      2<7                                                             o
                                                3      3<7                                                                s 
                                                4      4<7                                                                   e
                                                5      5<7                                                                      b
                                                6      6<7                                                                         i
                                                7      7<7F
        Console.write ="eosebi"                                                           nouInCareSeSalveaza=  "";
                                                                                                                0  1  2  3  4  5  6 
        i=1   | 1<3T                            2      2<6                                                     |      o
                                                3      3<6                                                               s
                                                4      4<6                                                                  e
                                                5      5<6                                                                     b
                                                6      6<6False

         Console.write="oseb"                                                               nouInCareSeSalveaza=""; 
                                                                                                               |0  1  2  3  4  5
         i=2    2<3T                            3     3<5                                                                s
                                                4     4<5                                                                   e
                                                 5   F
        Console.Write("se");                                                         nouInCareSeSalveaza=  ""; |0  1  2  3  4

        i=3      3<3F 

        */


        public static string erasePoz(string text, int poz)
        {

            if (poz == 0)
            {
                return text.Substring(poz + 1);
            }
            return text.Substring(0, poz - 1) + text.Substring(poz + 1);

        }
        /*  public static string stergereLitera(string text, int poz)
        {

            //Etapa 1 spargem in cuvonte
            string[] cuvinte = text.Split(" ");


            string rezultat = "";


            for(int i = 0; i < cuvinte.Length; i++)
            {

            }
        }*/



        /*poz ==0   |    rext poz+1   |    text.Substring(0, poz -1) + text.Substring(poz+1) | "Ana are mere"
         *                                                                                      01234567891011
         *true(0)        1                                                                       na are mere 
         * ----
         * false(3)                        3+1=4                                                Anare mere //poz 4 a fost stearsa    
         * 
        /*Se considera o matrice de dimensiune nxm cu elemente de tip sir de caractere. 
        Creati un program care afiseaza sirul 
        de caractere de lungime maxima de pe fiecare linie a matricii.
         n=3, m=2
        "Ana are mere"      "Tata are cartofi"
        "Vine vara"         "Afara e cald"
        "E cald in casa"    "Apa e buna"
         */
        public static void SirLungCaractere(string[,] matriciString)
        {
            int maxim = 0;
            int indiceN = 0;
            int indiceM = 0;
            //parcurgere linii
            for (int i = 0; i < matriciString.GetLength(0); i++)//returneaza nr. de randuri din matrice
            {
                //parcurgere coloane
                maxim = 0;
                for (int j = 0; j < matriciString.GetLength(1); j++)//imi da nr. de coloane din matrice
                {
                    if (matriciString[i, j].Length > maxim)
                    {
                        maxim = matriciString[i, j].Length;
                        indiceN = i;
                        indiceM = j;
                    }

                }
                Console.WriteLine(matriciString[indiceN, indiceM]);
            }
        }
        /*          0       1
         * 0      Unu      Una
         * 1      Doi      Doua
         * 2      Patru    Trei
        i   |   i<matriciString.GetLnegth(0)   |   maxim   |    j   |   j<matriciString.GetLenght(1)    | if (matriciString[i, j].Length > maxim) | maxim | indiceN |   indiceM |   Cw   |
        i=0              0<3                         0          0       0<2(nr coloane)                      0,0(Unu)=>lungime(3)>0                  3        0            0
                                                                1       1<2                                  0,1(Una)=>lungime(3)>3 F
                                                                2       2<2F                         
                                                               Console.WriteLine("Unu")
        i=1             1<3(nr randuri)              0          0       0<2                                 1,0(Doi)>0(maxim)=>3>0                   3       1             0     
                                                                1       1<2                                 1,1(Doua)>3(maxim)=>4>3 T                4       1             1 
                                                                2       2<2F
                                                               Print("Doua")
        i=2             2<3                         0           0       0<2                                 2,0(Patru)>0=>4>0 T                      5       2             0
                                                                1       1<2                                 2,1(Trei)>5 F     
                                                                2       2<2F
                                                                Print("Patru")
        i=3             3<3 F
        */

        /*Sa se creeze un program care transforma literele mici in litere mari si literele mari in litere mici.
         * ex: pentru cuvantul "MiorItIC" se va afisa "mIORiTic".
         */

        public static string Mioritic(string cuvantul)
        {
            string cuvantNou = "";
            for (int i = 0; i < cuvantul.Length; i++)
            {

                if (char.IsLower(cuvantul[i]))
                {
                    cuvantNou += char.ToUpper(cuvantul[i]);
                }
                else
                    cuvantNou += char.ToLower(cuvantul[i]);
            }
            return cuvantNou;
        }


        public static string Mioritic2(string cuvantul)
        {
            string cuvantNou = "";
            for (int i = 0; i < cuvantul.Length; i++)
            {
                if (cuvantul[i] >= 'a' && cuvantul[i] <= 'z')
                    cuvantNou += (char)(cuvantul[i] - 32);
                else
                    cuvantNou += (char)(cuvantul[i] + 32);
            }
            return cuvantNou;
        }
        /*Se considera un sir de n cuvinte. Sa se determine cuvantul de lungime maxima 
         * care se poate forma prin concatenarea a doua dintre cuvintele citite. 
         Ex: pentru n=5 si sirul de cuvinte 'mama', 'arc', 'conduce','paine','vine', se va afisa:'conducepaine' sau 'paineconduce'*/

        public static string maxConcatenat(string text)
        {
            string[] cuvinte = text.Split(" ");//"Ana are mere"=>["Ana","are","mere"]

            string lungime = "";

            for (int i = 0; i < cuvinte.Length - 1; i++)
            {

                for (int j = i + 1; j < cuvinte.Length; j++)
                {

                    if ((cuvinte[i] + cuvinte[j]).Length > lungime.Length)
                    {
                        lungime = cuvinte[i] + cuvinte[j];
                    }
                }

            }
            return lungime;
        }
        /*"Mama arc conduce paine vine"=>["Mama ,"arc","conduce"]
         * 
         * 
         *
         *  | i<cuvinte.length | j<cuvinte.length |cuvinte[i]+cuvinte[j]>lungime.length | lungime |   j     | i
         *     0<2                      1<3        cuvinte[0]+cuvinte[1]                            
         *                                           =>"Mamaarc"
         *                                           =>7>1 da                             "Mamaarc"     2
         
                                       2<3(NrCuvinte) cuvinte[0]+cuvinte[2]
                                                    =>"MamaConduce"
                                                    =>11>7 Da                             "MamaConduce" 3    1

              
                                  
         -   1<2                      2<3          cuvinte[1]+cuvinte[2]
                                                   =>10>11F                                             3 
                                      3<3False                                                               2
             2<2F                                                                          "MamaConduce"
         
         */
        /*Se considera un sire de n cuvinte. Sa se determine cuvantul cel mai mic in ordine lexicografica obtinut prin concatenarea a doua dintre cuvintele citite. 
         ExempluL Pentru n=5 si sirul :'mama','arc', 'conduce','paine','vine' se va afisa: 'arcconduce'*/

        public static string[] minLexicografic(string text)
        {
            string[] cuvinte = text.Split(" ");
            for (int i = 0; i < cuvinte.Length - 1; i++)
            {

                for (int j = i + 1; j < cuvinte.Length; j++)
                {

                    if (cuvinte[i].CompareTo(cuvinte[j]) > 0)
                    {

                        string aux = cuvinte[i];
                        cuvinte[i] = aux;
                        aux = cuvinte[i];

                    }
                }
            }
            return cuvinte;
        }

        /*Consideram un text de maximum 255 de caractere. 
         Propozitiile sunt delimitate prin caracterele punct(.) sau prin semnul exclamarii(!).
         Realizati un program care afiseaza fiecare propozitie pe o singura linie, 
        fiecare cuvant incepand cu o majuscula.
        Ex: Pentru textul 
        "Fie A un punct fix. Presupunem B punct mobil" se va afisa:
        Fie A un Punct Fix. 
        Presupunem B Punct Mobil.
        - 1 Propozitie 1 linie. 
        - 1 cuvant majuscula*/
        /* public static string linieNouaMajuscula(string text)
         {
             string[] cuvinte = text.Split(".!"); 
             for(int i=0; i<cuvinte.Length-1; i++)
             {
                 if(cuvinte[0] ==)
             }
         }*/
        public static string lowerUpperCase(string cuvantul)
        {

            return char.ToUpper(cuvantul[0]) + cuvantul.Substring(1);
        }


        public static string lowerUpperCaseText(string text)
        {
            string[] cuvinte = text.Split(" ");

            string nou = "";
            for (int i = 0; i < cuvinte.Length; i++)
            {
                nou += lowerUpperCase(cuvinte[i]) + " ";
            }
            return nou;
        }
        /* text lower 
         * i   | i<cuvinte.length  |   nou  |   
           0     0<2                  [text]->Text + " "            
           1     1<2                  [lower]-> Lower + " "*/

        /*  public static string propozitiiImpartite(string text)
          {
              string[] cuvinte = text.Split(" !.");//["Ana are mere"]
              string propozitieNoua = " ";
              for (int i = 0; i > cuvinte.Length; i++)
              {
                  if (cuvinte[i] == ("!. ")){
                      propozitieNoua += lowerUpperCaseText(text);
                  }
               }
              return propozitieNoua;
          }*/
        public static void propoziteUpperCase(string text)
        {
            //char[] delimitatori =  { '!', '.' };
            string[] propozitii = text.Split(".!");//textul e impartit in propozitii
            string propozitieNoua = "";
            for (int i = 0; i < propozitii.Length; i++)
            {
                propozitieNoua += lowerUpperCaseText(propozitii[i]);
                Console.WriteLine(lowerUpperCaseText(propozitii[i]) + "\n");
            }

        }
        /*Se considera o lista cu n<100 prenume ale elevilor dintr-o clasa. 
         * Prenumele unei fete este recunoscut datorita faptului ca: 
         * fie are ultima litera a(cuvant-1), fie este Carmen(if) sau (||)Alice.
         * Sa se creeze un program care afiseaza (void) nr. fetelor din clasa, 
         * si cel mai mare prenume in sens lexicografic ale carei litere
         * vor fi transformate in majuscule.
         * ex: n=5 si lista 'Ana', 'Alice', 'Mihai', 'Maria', 'Ion',
         * se va afisa:'3 MIHAI'
         */

        public static void prenumeFete(string[] prenume)
        {
            int nrFeteClasa = 0;
            char prenume1 = 'a';
            string prenume2 = "Carmen";
            string prenume3 = "Alice";
            string prenumeMaxim = "";
            for (int i = 0; i < prenume.Length; i++)
            {
                if (prenume[i][prenume[i].Length - 1] == prenume1//aflam ultima litera a uni cuvant si o comparam cu prenume1
                          || prenume[i].CompareTo(prenume2) == 0//This instance has the same position in the sort order as value. 
                          || prenume[i].CompareTo(prenume3) == 0)//https://docs.microsoft.com/en-us/dotnet/api/system.string.compareto?view=net-5.0

                    nrFeteClasa++;

                if (prenume[i].CompareTo(prenumeMaxim) > 0)
                    prenumeMaxim = prenume[i];
            }
            prenumeMaxim = prenumeMaxim.ToUpper();

            Console.WriteLine("Nr fete in clasa e " + nrFeteClasa + ", iar prenumele maxim upper case " + prenumeMaxim);
            /*Se considera doua cuvnte ce contin numai litere mici. 
             Consideram ca ultima silaba a unui cuvant este subsirul care incepe
             cu ultima lui vocala. Verificati daca aceste cuvinte rimeaza(Daca e ultima silaba identica)
             Daca un cuvant nu contine vocale, atunci ultima silaba este intregul cuvant. 
            Ex: Pt. "armat" si "verificat" se va afisa "Rimeaza"*/
        }

        public static void Rimeaza(string cuvant1, string cuvant2)
        {
            string ultimaSilabaCuv1 = "";
            string ultimaSilabaCuv2 = "";
            int i = cuvant1.Length - 1;//plecam de la final
                                       //cautam ultima vocala din primul cuvant si plecam de la final
            while (isVocala(cuvant1[i]) == false && i >= 0)
                i--;
            ultimaSilabaCuv1 = cuvant1.Substring(i);
            i = cuvant2.Length - 1;
            while (isVocala(cuvant2[i]) == false && i >= 0)
                i--;
            ultimaSilabaCuv2 = cuvant2.Substring(i);
            if (ultimaSilabaCuv1.CompareTo(ultimaSilabaCuv2) == 0)
                Console.WriteLine("Rimeaza");
            else
                Console.WriteLine("Nu rimeaza.");
        }

        /*Se citeste un sir de maxim 200 de caractere, cvinte separate prin unul sau mai multe spatii
         a. Sa se elimine spatiile multiple dintre cuvinte. 
         b. Sa se transforme prima litera din fiecare cuvant in litera mare si sa se inlocuoasca
        ultima litera din fiecare cuvant cu urmatoarea de dupa ea din alfabet.
        ana => Anb
         c. Dublati toate vocalele mari si stergeti toate vocalele mici
         d. realizati suma tutuor cifrelor din sir
        
         */
        public static string SirEliminare(string text)
        {
            string[] cuvinte = text.Split(" ");

            string nou = "";
            for (int i = 0; i < cuvinte.Length - 1; i++)
            {
                if (cuvinte[i] != "")//verifica si pentru mai mult de un spatiu le taie
                {
                    nou += cuvinte[i] + " ";
                }
            }
            return nou;
        }
        /*i   |    i<cuvinte.Length-1    |   nou   |   cuvinte  |   nou   |  Ana  are   Mere
         0         0<2                        Ana        Ana         Ana     0     1      2
         1         1<2                            */
        //b.Sa se transforme prima litera din fiecare cuvant in litera mare si sa se inlocuoasca
        //ultima litera din fiecare cuvant cu urmatoarea de dupa ea din alfabet.
        //ana => Anb
        public static string upperAndLast(string text)
        {
            string[] cuvinte = text.Split(" ");

            string nou = "";
            for (int i = 0; i < cuvinte.Length; i++)
            {

                string cuvant = cuvinte[i];//"ana"

                cuvant = Char.ToUpper(cuvant[0]) + cuvant.Substring(1);
                //'A'+"na"=> Ana

                char u = cuvant[cuvant.Length - 1];
                //u='a'
                u++;//u a devenit 'b'

                cuvant = cuvant.Substring(0, cuvant.Length - 1) + u;
                //"An"+'b'=>"Anb"

                nou += cuvant + " ";
            }

            return nou;
        }

        public static bool isVocalaUpperCase(char c)
        {
            string vocaleMari = "AEIOU";
            for (int i = 0; i < vocaleMari.Length; i++)
            {
                if (vocaleMari[i] == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool isVocalaLowerCase(char c)
        {
            string vocaleMici = "aeiou";
            for (int i = 0; i < vocaleMici.Length; i++)
            {
                if (vocaleMici[i] == c)
                {
                    return true;
                }
            }
            return false;
        }

        //functie ce dubleaza vocalele mari
        public static string duplicateUpperCase(string text)

        {
            string nou = "";

            for (int i = 0; i < text.Length; i++)
            {
                nou += text[i];
                if (isVocalaUpperCase(text[i]))
                {
                    nou += text[i];
                }
            }

            return nou;
        }
        //functie in care stergem vocalele mici

        public static string deleteLowercase(string text)
        {
            string nou = "";
            for (int i = 0; i < text.Length; i++)
            {

                if (isVocalaLowerCase(text[i]) == false)
                {
                    nou += text[i];
                }
            }


            return nou;
        }

        public static string DuplicateUpperRemoveLower(string text)
        {


            text = deleteLowercase(text);

            text = duplicateUpperCase(text);

            return text;
        }

        public static bool IsCifra(char c)
        {
            string cifre = "0123456789";

            for (int i = 0; i < cifre.Length; i++)
            {
                if (cifre[i] == c)
                {
                    return true;
                }
            }
            return false;
        }

        //suma tututor cifrelor din sir
        public static int SumDigits(string text)
        {
            int sumDigitsIs = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (IsCifra(text[i]) == true)
                {

                    int ValoareaConvertitaCharToInt = (int)Char.GetNumericValue(text[i]);
                    sumDigitsIs += ValoareaConvertitaCharToInt;

                }

            }
            return sumDigitsIs;
        }

        //realizati media aritmetica a codurilor ASCII cu litera mica

        public static bool IsLowerCase(char c)
        {
            //if(c >= 'a' && c <= 'z')
            if (c >= 97 && c <= 122)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double AvgASCII(string text)
        {
            double AvgAscii = 0;
            int SumAscii = 0;
            int contor = 0;

            for (int i = 0; i < text.Length; i++)
            {
                //if(IsLowerCase(text[i]) == true)
                if (char.IsLower(text[i]) == true)
                {
                    contor++;
                    SumAscii += text[i];

                }
            }
            AvgAscii = (double)SumAscii / contor;
            return AvgAscii;

        }
        //de cate ori apare ultimul cuvant in tot sirul
        //tbd sa compar si sa adaug in contor si lower+upper case
        public static int NrAparitii(string text)
        {
            int contor = 0;
            string[] cuvinte = text.Split(" ");

            string cuv = cuvinte[cuvinte.Length - 1];

            for (int i = 0; i < cuvinte.Length - 1; i++)
            {
                if (cuvinte[i].Equals(cuv))
                {

                    contor++;
                }

            }
            return contor;
        }

        //equals egalezi doua strinuri
        //compareTo compari doua string 
        //Interschimbati elementele sirului in oglinda fata de mijloc

        public static void SirulOglinda(string text)
        {
            string nou = "";
            for (int i = 0, j = text.Length - 1; i < j; i++, j--)
            {
                Console.Write(text[i]);
                Console.Write(text[j]);
            }
        }

        //Cate litere mici avem? Sunt toate literele consoane?
        public static bool IsConsoana(char c)
        {
            string consoane = "BCDFGHJKMNPQRSTVWXYTVWXYZbcdfghjkmnpqrstvqxyz";


            return consoane.Contains(c);

        }
        public static bool isToateConsoane(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]) && IsConsoana(text[i]) == true)
                {
                    return false;
                }
            }

            return true;
        }

        public static int CountLowerCase(string text)
        {
            int contorLowerCase = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLower(text[i]))
                {
                    contorLowerCase++;
                }
            }
            return contorLowerCase;
        }

        /*se citeste un sir de max 200 caractere, cuvinte separate prin:
         " , . ! ? : : "
        a. Realizati un nou sir cu toate cuvintele palindrome.
        b. Afisati cuvantul ce are cele mai multe vocale.
        c. Modificati sirul cititi astfel incat sa stergeti toate cuvintele e au mai putin de 4 caractere*/
        public static bool IsPalindrom(string text)
        {
            string cuvantulInversat = "";
            for (int i = text.Length - 1; i >= 0; i--)//Pleaca de la ultima litera
                                                      //i>=0 pana la prima litera
                                                      //rasturnatul cuvantului
            {
                cuvantulInversat += text[i];//adauga cate o litera de la sfarsit la inceputul cuvantului

            }
            return cuvantulInversat.Equals(text);//true sau false daca "opo" inversat = "opo" true, "abc" = false
        }

        public static void CuvintelePalindrome(string text)
        {
            string SirPalindrom = "";
            string[] cuvant = text.Split(" ");

            for(int i=0; i<cuvant.Length; i++)
            {
                if (IsPalindrom(cuvant[i]))
                {
                    SirPalindrom += cuvant[i];
                    SirPalindrom += " ";
                }
            }
            Console.Write(SirPalindrom);

        }
        //b.Afisati cuvantul ce are cele mai multe vocale.
        //NumarareVocaleText

        public static void AfisareCuvVocale(string text)
        {
            string[] cuvinte = text.Split(" ");
            string cuvantNouLung = "";

            int NrVocaleMaximCuvant = 0;
            for (int i = 0; i < cuvinte.Length; i++)
            {
                if (NumarareVocaleText(cuvinte[i]) > NrVocaleMaximCuvant)
                {
                    NrVocaleMaximCuvant = NumarareVocaleText(cuvinte[i]);
                    cuvantNouLung = cuvinte[i];
                }
            }
            Console.Write(cuvantNouLung);
        }

        //c.Modificati sirul citit astfel incat sa stergeti toate cuvintele ce au mai putin de 4 caractere
        public static void CuvintePeste4Caractere(string text)
        {
            string[] cuvinte = text.Split(" ");
            string CuvintePeste4Char = "";
            {
                for(int i = 0; i<cuvinte.Length; i++)
                //i<cuvinte.Length cate cuvinte sunt in sir
                //i<cuvinte[i].Length cate litere are cuvantul cu indexul i
                //i<text.Length cate litere are textul    
                {
                      if(cuvinte[i].Length >= 4)
                    {
                        CuvintePeste4Char += cuvinte[i];
                        CuvintePeste4Char += " ";
                    }
                }
            }
            Console.Write(CuvintePeste4Char);
        }
       //d. Care este al treilea cuvant citit.
       // Daca sirul nu are cel putin 3 cuvinte se va afisa un mesaj.

        public static void AlTreileCuvantCitit(string text)
        {
            string[] cuvant = text.Split(" ");

            if (cuvant.Length < 3)
            {
                Console.Write(" Un mesaj "); 
            }
            else
            {
                Console.Write(cuvant[2]);
            }
        }

        //2e stergeti cuvintele de exact 5 litere ce au prima si ultima litera identica

        //verificare conditie sa aiba 5 litere, prima ultima litera identica
        public static bool IsFiveFirstLastIdentical(string text)
        {
            if(text.Length == 5
              &&text[0] == text[4])
            {
                return true;
            }
            return false;
        }


        public static string DeleteReplace2(string text)
        {
            string[] cuvant = text.Split(' ','.', '?', ';', ':', '!');
            string textIntermediar = "";
            int pozitie;
            for (int i = 0; i < cuvant.Length; i++)
            {
                if (IsFiveFirstLastIdentical(cuvant[i]) == true)
                {
                    pozitie = text.IndexOf(cuvant[i]);
                    textIntermediar = text.Substring(0, pozitie);//textIntermediar = substringul aflat inainte de cuvant[i]
                    text = textIntermediar + text.Substring(pozitie + cuvant[i].Length); //concatenam textIntermediar cu substringul de dupa cuvant[i]
                 
                }
            }
            return text;
        }

        //2F Dublati grupurile de 3 litere identice
        //cuviiintele suntluuungi => cuviiiiiintele sunt luuuuuungi 

        public static string Duplicate3Letters(string text)
        {
            string TextCuLitereTriplate = "";
            TextCuLitereTriplate += text[0];
            TextCuLitereTriplate += text[1];
            for(int i = 2; i<text.Length; i++)
            {
                TextCuLitereTriplate += text[i];
                if (text[i].Equals(text[i -1]) && text[i].Equals(text[i-2]))
                {
                    TextCuLitereTriplate += text[i-2];
                    TextCuLitereTriplate += text[i-1];
                    TextCuLitereTriplate += text[i];
                }
            }
            return TextCuLitereTriplate;

        }
        //2g Transformati ultima litera din fiecare cuvant(doar daca este litera mica) in litera mare

        public static bool IsLastLowerCase(string cuvantul)
        {
            if(char.IsLower(cuvantul[cuvantul.Length-1]) == true)
            {
                return true;
            }
            return false;
        }
      
        
        public static string replaceLastLowercase(string text)
        {
            string nou = "";
            string[] cuvant = text.Split(" ");
            for (int i = 0; i < cuvant.Length; i++)
            {

                if (IsLastLowerCase(cuvant[i]) == true)
                {
                    string cuvantModificat = cuvant[i];
                    char LastLetter = cuvantModificat[cuvantModificat.Length - 1];
                    LastLetter = char.ToUpper(LastLetter);
                    cuvantModificat = cuvantModificat.Substring(0, cuvantModificat.Length - 1) + LastLetter;
                    nou += cuvantModificat;
                }
                else
                {
                    nou += cuvant[i];
                }
                nou += " ";
            }
            return nou;
        }


        //2h Verificati daca primul cuvant e prefix pt. celelalte cuvinte din text
        public static bool IsPrefix(string cuvantulInitial, string prefixulCautat)
        {
            if (cuvantulInitial.IndexOf(prefixulCautat) == 0)
                //IndexOf -> daca pozitia prefixului cautat in cuvant initial == 0
                return true;
            return false;
        }

        public static void Prefixe(string text)
        {
            string[] cuvinte = text.Split(" ");
            for(int i=1; i<cuvinte.Length; i++)
            {
                if (IsPrefix(cuvinte[i], cuvinte[0]) == true)
                    Console.Write(cuvinte[i] + " ");
            }
        }
        /*3. Se citeste un sir de max 100 cuv. separate prin spatii
         a. Sa se stearga toate spatiile multiple
         b. Se se faca prima litera din fiecare cuvant mare, 
           si sa se inlocuiasca ultima litera cu urmatoarea din alfabet
        c. Sa se inverseze toate cuvintele din sir ce NU sunt palindrome. 
        d. Realizati un nou sir  in care sa se puna toate cuvintele care au 
           frecventa singulara in sir
           (singular - care a par doar o data in sirul citit)
        e. Stergeti toate literele C si dublati toate literele D*/

        //3a Sa se stearga toate spatiile multiple
       
        public static void DeleteMultipleSpaces(string text)
        {   
            string[] cuvant = text.Split(" ");
            string CuvantNou = "";
            for (int i = 0; i < cuvant.Length; i++)
            {
                if(cuvant[i] != "")
                {
              
                    CuvantNou += cuvant[i] + " ";
                }
            }
            Console.Write("Cuvantul nou" + CuvantNou);
        }
        //3b Se se faca prima litera din fiecare cuvant mare, 
        //si sa se inlocuiasca ultima litera cu urmatoarea din alfabet
        public static bool IsFirstLowerCase(string cuvantul)
        {
            if(char.IsLower(cuvantul[0]) == true)
            {
                return true;
            }
            return false;
        }
        public static string ToUpperFirstLetter(string cuvantModificat)
        {
          
            if (IsFirstLowerCase(cuvantModificat) == true)
            {
                char FirstLetter = cuvantModificat[0];
                FirstLetter = char.ToUpper(FirstLetter);
                cuvantModificat = FirstLetter + cuvantModificat.Substring(1);//merge pana la finalul cuvantului
            }
            return cuvantModificat;
        }

        public static string NextlphabetLetterLastChar(string cuvantModificat)
        {

            char LastLetter = cuvantModificat[cuvantModificat.Length - 1];
            if (LastLetter == 'z')
            {
                LastLetter = 'a';
            }
            else if (LastLetter =='Z')
            {
                LastLetter = 'A';
            }
            else
                LastLetter++;
            cuvantModificat = cuvantModificat.Substring(0, cuvantModificat.Length - 1) + LastLetter;

            return cuvantModificat;
        }

        public static void FirstCharLowerToUpperLastLetterNextAlphabetChar(string text)
        {
            string[] cuvant = text.Split(" ");
            string cuvantNou = "";
            for(int i = 0; i<cuvant.Length; i++)
            {
                string cuvantModificat = cuvant[i];
                cuvantModificat = ToUpperFirstLetter(cuvantModificat);
                cuvantModificat = NextlphabetLetterLastChar(cuvantModificat);
                cuvantNou += cuvantModificat + " ";

            }
            Console.Write(cuvantNou);
        }
        //3.c Sa se inverseze toate cuvintele din sir ce NU sunt palindrome.
        
        public static string ReversedWord(string cuvantDeInversat)
        {
            string cuvantInversat = "";
            for (int i = cuvantDeInversat.Length - 1; i >= 0; i--)
            {
                cuvantInversat += cuvantDeInversat[i];
            }
            return cuvantInversat;
        } 

        public static void WordNotPalindrome(string text)
        {
            string[] cuvant = text.Split(" ");
            string cuvantulInversat = "";
            string textulNouCuInversateSiPalindrome= "";
            for(int i=0; i<cuvant.Length; i++)
            {
                if(IsPalindrom(cuvant[i])  == false)
                {
                    cuvantulInversat = ReversedWord(cuvant[i]);
                    textulNouCuInversateSiPalindrome += cuvantulInversat + " ";

                }
                else
                {
                    textulNouCuInversateSiPalindrome += cuvant[i] + " ";
                }

            }
            Console.Write(textulNouCuInversateSiPalindrome);
        }

        //3d. Realizati un nou sir  in care sa se puna toate cuvintele care au 
        //frecventa singulara in sir
        //(singular - care a par doar o data in sirul citit)
        public static string SingularFreq(string text)
        {
            string[] cuvant = text.Split(" ");
            string cuvintSingular = "";
            for(int i = 0; i<cuvant.Length; i++)
            {
                int contorDeCateOriIntalnesteCuvantulInPropozitie = 0;
                for(int j =0; j<cuvant.Length; j++)
                {   
                    if (cuvant[i].Equals(cuvant[j]))
                    {
                        contorDeCateOriIntalnesteCuvantulInPropozitie++;
                    }
                    
                }
                if(contorDeCateOriIntalnesteCuvantulInPropozitie == 1)
                {
                    cuvintSingular += cuvant[i] +" ";
                }
            }
            return cuvintSingular;
        }


    }
}

/*  public static string eraseChar(string text ,char x)
          {
              string[] exemplu = text.Split(x);
              string nou = "";
              for(int i = 0; i < exemplu.Length; i++)
              {

                  nou += exemplu[i];

              }
              return nou;
          }*/

/**/