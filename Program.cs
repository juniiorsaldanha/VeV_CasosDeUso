using System;
using CasosDeUso;

class TestCase 
{
    static void Main(string[] args)
    {
        List<string> emails = new List<string>();

        emails.Add("gsaldanhajunior@hotmail.com");

        Console.WriteLine("Preencha o email para cadastro: ");
        var email = Console.ReadLine();

        if (ValidateEmail(emails, email))
        {
            emails.Add(email);
            Console.WriteLine("Preencha as informações adicionais: ");
        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

    ////////////////////////////////////////////////////////////////////////////////////

        List<Paciente> ListaDePacientes = new List<Paciente>(); 
        Paciente paciente = new Paciente("Junior", "60898075327", "88999999878");
        ListaDePacientes.Add(paciente); 

        Console.WriteLine("Digite o Cpf do cliente que deseja encontrar: "); 
        var cpf = Console.ReadLine();  

        BuscarPaciente(ListaDePacientes, cpf); 


    }
    static bool ValidateEmail(List<string> emails, string email)
    {
        try
        {
            for(int i = 0; i < emails.Count; i++)
            {
                if(email == emails[i]){
                    throw new Exception();                   
                }
            }
            return true; 
        }
        catch(Exception e)
        {
            throw new Exception("Não foi possível criar o cadastro. Email já cadastrado", e); 
        }
    }

    static void BuscarPaciente(List<Paciente> pacientes, string cpf)
    {
        try
        {
            for(int i = 0; i < pacientes.Count; i++)
            {
                if(cpf == pacientes[i].Cpf)
                    Console.WriteLine(pacientes[i]);
                else
                    throw new Exception(); 
            }
        }catch(Exception e)
        {
            throw new Exception("Paciente não encontrado na lista de cadastros", e); 
        }

            
    }
}

