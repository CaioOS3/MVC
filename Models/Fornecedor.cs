namespace LHPet.Models;

public class Fornecedor
{
    public int id {get; set;}
    public String? Nome { get; set; }
    public String? Cnpj { get; set; }
    public String? Email { get; set; }
   

    public Fornecedor(int id, String Nome, String Cnpj, String Email)
    {
        this.id = id;
        this.Nome = Nome;
        this.Cnpj = Cnpj;
        this.Email = Email;
       
    }

}