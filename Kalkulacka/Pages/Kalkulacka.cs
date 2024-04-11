class Calculator
{
    public double AktualniVysledek;

    public Calculator()
    {
        AktualniVysledek = 0;
    }

    public bool JePlatnyOperator(string operace)
    {
        return operace == "+" || operace == "-" || operace == "/" || operace == "*" || operace == "^";
    }

    public void Secti(double cislo)
    {
        AktualniVysledek += cislo;
    }

    public void Odecti(double cislo)
    {
        AktualniVysledek -= cislo;
    }

    public void Nasob(double cislo)
    {
        AktualniVysledek *= cislo;
    }

    public void Vydel(double cislo)
    {
        if (cislo != 0)
            AktualniVysledek /= cislo;
        else
            Console.WriteLine("Nelze dělit nulou.");
    }

    public void Umocni(double cislo)
    {
        for (int i = 0; i < cislo; i++)
        {
            AktualniVysledek *= cislo;
        }
    }

    public double VratAktualniVysledek()
    {
        return AktualniVysledek;
    }
}