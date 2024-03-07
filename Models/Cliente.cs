namespace LHPet.Models;

public class Cliente
{
    public int id {get; set;}
    public String? Nome { get; set; }
    public String? Cpf { get; set; }
    public String? Email { get; set; }
    public String?  Paciente { get; set; }

    public Cliente(int id, String Nome, String Cpf, String Email, String Paciente)
    {
        this.id = id;
        this.Nome = Nome;
        this.Cpf = Cpf;
        this.Email = Email;
        this.Paciente = Paciente;
    }

}