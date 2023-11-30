class Pessoa {

    public string Nome {get;set;}
    public DateTime DataDeNascismento {get;set;}
    public int CPF {get;set;}
}
class Advogado : Pessoa {
    public int CNA{get;set;}

}


class Cliente : Pessoa {
    public string EstadoCivil{get;set;}
}




class Escritorio {
    List<Advogado> advogados = new List<Advogado>();
    List<Cliente> clientes= new List<Cliente>();

    public bool AdicionarAdvogado(Advogado advogado)
{
    if (!advogados.Exists(a => a.CPF == advogado.CPF) && !advogados.Exists(a => a.CNA == advogado.CNA))
    {
        advogados.Add(advogado);
        return true;
    }
    return false;
}


    public void MostrarAdvogados()
        {
            Console.WriteLine("Advogados no escritório:");
            foreach (var advogado in advogados)
            {
                Console.WriteLine($"Nome: {advogado.Nome}, CPF: {advogado.CPF}, CNA: {advogado.CNA}");
            }
        }
}







static void Main() 
{

 Escritorio escritorio = new Escritorio();

        Advogado advogado1 = new Advogado { Nome = "João", DataDeNascimento = new DateTimeTryParse(1985, 5, 15), CPF = 123456789, CNA = 98765 };
        escritorio.AdicionarAdvogado(advogado1);

        escritorio.MostrarAdvogados();



}
