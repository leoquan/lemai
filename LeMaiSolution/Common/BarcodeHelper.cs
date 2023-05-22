
using System;
using System.Collections.Generic;
using System.Text;
namespace Common
{
    public class BarcodeHelper
    {
        public static string Encode(string chaineDola)
        {
            bool iPhanTram = false, tableB;
            int miniPhanTram, checksumVa = 0, dummyPhanTram;

            string code128Dola = "";
            if (chaineDola.Length > 0)
            {
                //'Vérifier si caractères valides
                //'Check for valid characters
                for (int i = 1; i <= chaineDola.Length; i++)
                {
                    char item = chaineDola[i - 1];
                    if (item >= 32 && item <= 126 || item == 203)
                    {
                        iPhanTram = true;
                    }
                    else
                    {
                        iPhanTram = false;
                        break;
                    }
                }

                //'Calculer la chaine de code en optimisant l'usage des tables B et C
                //'Calculation of the code string with optimized use of tables B and C
                code128Dola = "";
                tableB = true;
                if (iPhanTram)
                {
                    int index = 1; //'i% devient l'index sur la chaine / i% become the string index
                    while (index <= chaineDola.Length)
                    {
                        if (tableB)
                        {
                            //'Voir si intéressant de passer en table C / See if interesting to switch to table C
                            //'Oui pour 4 chiffres au début ou à la fin, sinon pour 6 chiffres / yes for 4 digits at start or end, else if 6 digits
                            if (index == 1 || index + 3 == chaineDola.Length)
                            {
                                miniPhanTram = 4;
                            }
                            else
                            {
                                miniPhanTram = 6;
                            }
                            miniPhanTram = TestNum(miniPhanTram, index, chaineDola);
                            if (miniPhanTram < 0) //'Choix table C / Choice of table C
                            {
                                if (index == 1)//'Débuter sur table C / Starting with table C
                                {
                                    code128Dola = Convert.ToChar(210).ToString();
                                }
                                else//'Commuter sur table C / Switch to table C
                                {
                                    code128Dola = code128Dola + Convert.ToChar(204).ToString();
                                }
                                tableB = false;
                            }
                            else
                            {
                                if (index == 1)//'Débuter sur table B / Starting with table B
                                {
                                    code128Dola = Convert.ToChar(209).ToString();
                                }
                            }
                        }

                        if (!tableB)
                        {
                            //'On est sur la table C, essayer de traiter 2 chiffres / We are on table C, try to process 2 digits
                            miniPhanTram = 2;
                            miniPhanTram = TestNum(miniPhanTram, index, chaineDola);
                            if (miniPhanTram < 0) //'OK pour 2 chiffres, les traiter / OK for 2 digits, process it
                            {
                                dummyPhanTram = int.Parse(chaineDola.Substring(index - 1, 2));
                                if (dummyPhanTram < 95)
                                {
                                    dummyPhanTram += 32;
                                }
                                else
                                {
                                    dummyPhanTram += 105;
                                }
                                code128Dola = code128Dola + Convert.ToChar(dummyPhanTram);
                                index = index + 2;
                            }
                            else//'On n'a pas 2 chiffres, repasser en table B / We haven't 2 digits, switch to table B
                            {
                                code128Dola = code128Dola + Convert.ToChar(205).ToString();
                                tableB = true;
                            }
                        }
                        if (tableB)
                        {
                            //'Traiter 1 caractère en table B / Process 1 digit with table B
                            code128Dola = code128Dola + chaineDola.Substring(index - 1, 1);
                            index = index + 1;
                        }
                    }
                }
            }

            //'Calcul de la clé de contrôle / Calculation of the checksum
            for (int i = 1; i <= code128Dola.Length; i++)
            {
                dummyPhanTram = code128Dola[i - 1];
                if (dummyPhanTram < 127)
                {
                    dummyPhanTram -= 32;
                }
                else
                {
                    dummyPhanTram -= 105;
                }
                if (i == 1)
                {
                    checksumVa = dummyPhanTram;
                }
                checksumVa = (checksumVa + (i - 1) * dummyPhanTram) % 103;
            }

            //'Calcul du code ASCII de la clé / Calculation of the checksum ASCII code
            if (checksumVa < 95)
            {
                checksumVa += 32;
            }
            else
            {
                checksumVa += 105;
            }
            //'Ajout de la clé et du STOP / Add the checksum and the STOP
            code128Dola = code128Dola + Convert.ToChar(checksumVa).ToString() + Convert.ToChar(211).ToString();
            return code128Dola;
        }

        private static int TestNum(int miniPhanTram, int index, string chaineDola)
        {
            miniPhanTram = miniPhanTram - 1;
            if (index + miniPhanTram <= chaineDola.Length)
            {
                while (miniPhanTram >= 0)
                {
                    if (chaineDola[(index + miniPhanTram) - 1] < 48 || chaineDola[(index + miniPhanTram) - 1] > 57)
                    {
                        break;
                    }

                    miniPhanTram = miniPhanTram - 1;
                }
            }

            return miniPhanTram;
        }
    }
}