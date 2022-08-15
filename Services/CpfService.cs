public class CpfService
{
    public CpfService(int seed)
    {
        this.rand = new Random(seed);
    }
    Random rand;

    public bool Validate(string cpf)
    {
        throw new NotImplementedException();
    }

    public string Generate()
    {
        throw new NotImplementedException();
    }

    // detalhes em: https://www.calculadorafacil.com.br/computacao/validar-cpf
    public string getValidationDigits(string cpf9digits)
    {
        int firstcpfnumber = 0;
        for (int i = 1; i <= 9; i++)
        {
            int cpfmultiplicado = 0;
            cpfmultiplicado = int.Parse(cpf9digits.Substring(i - 1, 1));
            cpfmultiplicado *= i;
            firstcpfnumber += cpfmultiplicado;
        }
        firstcpfnumber %= 11;
        string strfirstcpfnumber = firstcpfnumber.ToString();
        strfirstcpfnumber = strfirstcpfnumber.Substring(strfirstcpfnumber.Length);

        int secondcpfnumber = 0;
        for (int i = 0; i <= 8; i++)
        {
            int cpfmultiplicado = 0;
            cpfmultiplicado = int.Parse(cpf9digits.Substring(i, 1));
            Console.WriteLine(cpf9digits.Substring(i, 1));
            cpfmultiplicado *= i;
            secondcpfnumber += cpfmultiplicado;
        }
        secondcpfnumber += firstcpfnumber * 9;
        string strsecondcpfnumber = secondcpfnumber.ToString();
        strsecondcpfnumber = strsecondcpfnumber.Substring(strfirstcpfnumber.Length);

        return strfirstcpfnumber + strsecondcpfnumber;
    }
}