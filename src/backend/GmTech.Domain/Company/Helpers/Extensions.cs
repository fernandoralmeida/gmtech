using System.Text.RegularExpressions;
using GmTech.Domain.Functions;

namespace GmTech.Domain.Company.Helpers;

public static class Extensions {
    public static bool Validate(this string document) {

        if (Regex.IsMatch(document, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            return CompanyDocument(document.MaskRemove());

        else
            return false;

    }

    private static bool CompanyDocument(string document) {

        int[] digitos, soma, resultado;

        int nrDig;

        string ftmt;

        bool[] cnpjOk;

        if (document == "00000000000000")
            return false;

        ftmt = "6543298765432";

        digitos = new int[14];

        soma = new int[2];

        soma[0] = 0;

        soma[1] = 0;

        resultado = new int[2];

        resultado[0] = 0;

        resultado[1] = 0;

        cnpjOk = new bool[2];

        cnpjOk[0] = false;

        cnpjOk[1] = false;

        try {

            for (nrDig = 0; nrDig < 14; nrDig++)  {

                digitos[nrDig] = int.Parse(document.Substring(nrDig, 1));

                if (nrDig <= 11)

                    soma[0] += (digitos[nrDig] *

                    int.Parse(ftmt.Substring(nrDig + 1, 1)));

                if (nrDig <= 12)

                    soma[1] += (digitos[nrDig] *

                    int.Parse(ftmt.Substring(nrDig, 1)));

            }

            for (nrDig = 0; nrDig < 2; nrDig++)  {

                resultado[nrDig] = (soma[nrDig] % 11);

                if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))

                    cnpjOk[nrDig] = (digitos[12 + nrDig] == 0);

                else

                    cnpjOk[nrDig] = (digitos[12 + nrDig] == (

                    11 - resultado[nrDig]));

            }

            return (cnpjOk[0] && cnpjOk[1]);
        }

        catch  {
            return false;
        }

    }
}