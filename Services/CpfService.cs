public class CpfService
{
    public CpfService(int seed)
    {
        this.rand = new Random(seed);
    }
    Random rand;

    public bool Validate(string cpf)
    {
        string cpf9dgt = "";
        string last2numbers;
        bool result = false;
        for(int i = 0; i<=10; i++)
        {
            if(i >= 9)
            {
                break;
            }
            cpf9dgt += cpf.Substring(i, 1);
        }
        last2numbers = getValidationDigits(cpf9dgt);
        if(last2numbers == cpf.Substring(9))
        {
            return result = true;
        }
        else
        {
            return result = false;
        }
    }

    public string Generate()
    {
        int cpf;
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
        strfirstcpfnumber = strfirstcpfnumber.Substring(strfirstcpfnumber.Length - 1);

        int secondcpfnumber = 0;
        for (int i = 0; i <= 8; i++)
        {
            int cpfmultiplicado = 0;
            cpfmultiplicado = int.Parse(cpf9digits.Substring(i, 1));
            cpfmultiplicado *= i;
            secondcpfnumber += cpfmultiplicado;
        }
        secondcpfnumber += firstcpfnumber * 9;
        secondcpfnumber %= 11;
        string strsecondcpfnumber = secondcpfnumber.ToString();
        strsecondcpfnumber = strsecondcpfnumber.Substring(strsecondcpfnumber.Length - 1);

        return strfirstcpfnumber + strsecondcpfnumber;
    }
}