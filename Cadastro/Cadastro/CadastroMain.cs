/*
 
    Desenvolvido por Jonathas Rocha

    >> Desafio lançado pela BluData, esta é a solução que desenvolvi!

    Última atualização em: 24/09/2020;

    GitHub:
    https://github.com/jonathasrochadesouza

*/

using System;
using System.Collections;

namespace Cadastro
{
    class EmpresaMain
    {
        static void Main(string[] args)
        {
            Empresa Acess = new Empresa(); // método acessor

            String cnpjE = "";
            String readGeneralString;
            ArrayList data = new ArrayList();
            ArrayList telefone = new ArrayList();
            ArrayList telefone2 = new ArrayList();
            int idade;
            int readInt;
            int i = 0;
            int idE = 0;
            int read = 0;
            int opUfE = 0;
            int opMenu = 0;
            int hereQtd = 0;
            int idFornecedores = 0;
            Boolean pararUfE = false;
            Boolean pararMenu = false;
            Boolean pedirIdade = false;
            Boolean verifiqueUf = false;
            Boolean cadastradaE = false;
            Boolean cadastradaF = false;

            Acess.getRegras();

            Console.WriteLine("\n'APERTE QUALQUER TECLA PARA CONTINUAR!'\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Para iniciarmos digite o seu nome, por favor!");

            readGeneralString = (Console.ReadLine());

            Acess.setUser(readGeneralString);

            Console.Clear(); // limpa

            // entrada no programa
            do
            {

                i++;
                if (i > 1)
                {
                    Console.WriteLine("[ERRO] Tente Novamente!\n\n(digite uma das 4 opções + Enter)\n");
                }

                Console.Clear();
                Acess.getMenu();

                opMenu = Convert.ToInt32(Console.ReadLine());

                if (opMenu == 1)
                {
                    if (cadastradaE == false)
                    {
                        Console.Clear(); // limpa
                        // Console.WriteLine("1");
                        Acess.setIdEmpresa(idE); // [0]

                        idE++; // acrescenta valor ao id, para o próximo cadastro

                        Acess.getUf(); // mostra estados

                        opUfE = Convert.ToInt32(Console.ReadLine());

                        // estados (UF)
                        switch (opUfE)
                        {
                            case 0:
                                Acess.setSaveUfE("AC");

                                verifiqueUf = true;
                                i = 0;
                                break;
                            case 1:
                                Acess.setSaveUfE("AL");

                                verifiqueUf = true;
                                break;
                            case 2:
                                Acess.setSaveUfE("AP");

                                verifiqueUf = true;
                                break;
                            case 3:
                                Acess.setSaveUfE("AM");

                                verifiqueUf = true;
                                break;
                            case 4:
                                Acess.setSaveUfE("BA");

                                verifiqueUf = true;
                                break;
                            case 5:
                                Acess.setSaveUfE("CE");

                                verifiqueUf = true;
                                break;
                            case 6:
                                Acess.setSaveUfE("ES");

                                verifiqueUf = true;
                                break;
                            case 7:
                                Acess.setSaveUfE("GO");

                                verifiqueUf = true;
                                break;
                            case 8:
                                Acess.setSaveUfE("MA");

                                verifiqueUf = true;
                                break;
                            case 9:

                                Acess.setSaveUfE("MT");

                                verifiqueUf = true;
                                break;
                            case 10:
                                Acess.setSaveUfE("MS");

                                verifiqueUf = true;
                                break;
                            case 11:

                                Acess.setSaveUfE("MG");

                                verifiqueUf = true;
                                break;
                            case 12:
                                Acess.setSaveUfE("PA");

                                verifiqueUf = true;
                                break;
                            case 13:

                                Acess.setSaveUfE("PB");

                                verifiqueUf = true;
                                break;
                            case 14:

                                Acess.setSaveUfE("PR");
                                Acess.setMenorIdade(true);
                                pedirIdade = true;

                                verifiqueUf = true;
                                break;
                            case 15:
                                Acess.setSaveUfE("PE");

                                verifiqueUf = true;
                                break;
                            case 16:
                                Acess.setSaveUfE("PI");

                                verifiqueUf = true;
                                break;
                            case 17:
                                Acess.setSaveUfE("RJ");

                                verifiqueUf = true;
                                break;
                            case 18:
                                Acess.setSaveUfE("RN");

                                verifiqueUf = true;
                                break;
                            case 19:
                                Acess.setSaveUfE("RS");

                                verifiqueUf = true;
                                break;
                            case 20:
                                Acess.setSaveUfE("RO");

                                verifiqueUf = true;
                                break;
                            case 21:
                                Acess.setSaveUfE("RR");

                                verifiqueUf = true;
                                break;
                            case 22:
                                Acess.setSaveUfE("SC");

                                verifiqueUf = true;
                                break;
                            case 23:
                                Acess.setSaveUfE("SP");

                                verifiqueUf = true;
                                break;
                            case 24:
                                Acess.setSaveUfE("SE");

                                verifiqueUf = true;
                                break;
                            case 25:
                                Acess.setSaveUfE("TO");

                                verifiqueUf = true;
                                break;
                            case 26:
                                Acess.setSaveUfE("DF");

                                verifiqueUf = true;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("[Entrada Inválida]\n");
                                continue;
                        }

                        if (verifiqueUf == true)
                        {
                            Console.Clear();

                            Console.Write("Recebemos a UF ");
                            Acess.getSaveUfE();
                            Console.Write("\n");

                            Acess.getNomeF();
                            Console.Write("\n");

                            readGeneralString = (Console.ReadLine());
                            Acess.setNomeFanE(readGeneralString);

                            Console.Clear();

                            Console.Write("Recebemos o nome \"" + Acess.getNomeFanE() + "\", como nome fantasia\n\n");

                            Acess.getDigiteCnpj();

                            do
                            {
                                readGeneralString = (Console.ReadLine());
                                if (readGeneralString.Length == 14)
                                {
                                    Acess.setCnpj(readGeneralString);
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine
                                        ("Um CNPJ possui 14 digitos " +
                                        "Você digitou ao todo " + readGeneralString.Length + "\n" +
                                        "\nTente novamente:");
                                }
                            } while (readGeneralString.Length != 14);

                            Console.Clear();
                            // Console.WriteLine("\n Recebemos \"" + Acess.getCnpj() + "\", como nome CNPJ\n");
                            cnpjE = Acess.getCnpj();

                            String cnpjE_formatado = cnpjE.Substring(0, 2) + "."
                                                    + cnpjE.Substring(2, 3) + "."
                                                    + cnpjE.Substring(5, 3) + "/"
                                                    + cnpjE.Substring(8, 4) + "-"
                                                    + cnpjE.Substring(12);

                            Console.WriteLine("Recebemos " + cnpjE_formatado + " como CNPJ\n" +
                                                "\nCadastro realizado com Sucesso! Obrigado!\n");

                            Console.WriteLine("'APERTE QUALQUER TECLA PARA CONTINUAR!'\n");
                            Console.ReadKey();

                            Console.Clear();

                            cadastradaE = true;
                            Acess.cont1++;
                        }

                        i = 0;
                    }
                    else if (cadastradaE == true)
                    {
                        Console.Clear();
                        Acess.getJa();
                        Console.ReadKey();

                        i = 0;
                    } // fim da opção 1
                }
                else if (opMenu == 2)
                {
                    if (cadastradaE)
                    {

                        Console.Clear();
                        if (pedirIdade)
                        {
                            Console.WriteLine("Esta empresa é do Paraná, temos uma regra diferente para empresas do Paraná\n" +
                            "Fornecedores menores de idade não podem se cadastrar!\n");

                            Console.WriteLine("Escolha uma opção: ");
                            Console.WriteLine("1 - Se for fornecedor físico (Pessoa)");
                            Console.WriteLine("2 - Se for fornecedor direto (empresa)\n");
                            readInt = Convert.ToInt32(Console.ReadLine());

                            Console.Clear();
                            if (readInt == 1)
                            {
                                Console.WriteLine("Por favor informe a idade do fornecedor!\n");
                                idade = Convert.ToInt32(Console.ReadLine());
                            }
                            else
                            {
                                idade = 18;
                            }

                            if (idade >= 18)
                            {
                                Console.Clear();
                                Acess.getFornecedorEmpresa();
                                // Console.Write("\n");

                                Console.WriteLine("Informe o nome do fornecedor: ");
                                readGeneralString = (Console.ReadLine());
                                Acess.setNomeF(readGeneralString);

                                // Console.Clear();

                                // Console.WriteLine("Nome do fornecedor cadastrado " + "" + "\n");
                                Console.Clear();
                                Console.Write("Fornecedor - ");
                                Acess.getNomeFor();
                                Console.WriteLine("\nDigite:");
                                if (read == 1)
                                {
                                    if (pedirIdade)
                                    {
                                        Console.WriteLine("Por favor informe a idade do fornecedor!\n");
                                        idade = Convert.ToInt32(Console.ReadLine());
                                        if (idade < 18)
                                        {
                                            break;
                                        }
                                    }

                                    Console.Clear();
                                    do
                                    {
                                        Console.WriteLine("Insira o CPF :");
                                        readGeneralString = (Console.ReadLine());
                                        if (readGeneralString.Length == 11)
                                        {
                                            Acess.setIdentF(readGeneralString);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine
                                                ("Um CPF possui 11 digitos " +
                                                "Você digitou ao todo " + readGeneralString.Length + "\n" +
                                                "\nTente novamente:");
                                        }
                                    } while (readGeneralString.Length != 11);
                                }
                                else if (read == 2)
                                {
                                    Console.Clear();

                                    do
                                    {
                                        Console.WriteLine("Insira o CNPJ :");
                                        readGeneralString = (Console.ReadLine());
                                        if (readGeneralString.Length == 14)
                                        {
                                            Acess.setIdentF(readGeneralString);
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine
                                                ("Um CNPJ possui 14 digitos " +
                                                "Você digitou ao todo " + readGeneralString.Length + "\n" +
                                                "\nTente novamente:");
                                        }
                                    } while (readGeneralString.Length != 14);
                                }


                                Console.Clear();
                                Console.WriteLine("Agora digite um telefone para contato, iniciado com o ddd e os 9 digitos \n(sem caracteres especiais e sem parênteses)\n");
                                readGeneralString = (Console.ReadLine());
                                Acess.setTelefone(readGeneralString);

                                // Outro telefone?
                                Console.Clear();
                                Console.WriteLine("Deseja acrescentar outro telefone?\n\"S\" para sim, ou \"N\" para não\n");
                                readGeneralString = (Console.ReadLine());
                                if (readGeneralString == "s" || readGeneralString == "S")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Digite o outro telefone para contato \n(sem caracteres especiais e sem parênteses):\n");
                                    readGeneralString = (Console.ReadLine());
                                    Acess.setTelefone2(readGeneralString);
                                }

                                // DATA E HORA                        
                                DateTime dataNow2 = DateTime.Now;
                                data.Add(dataNow2); // aqui a data e hora do cadastro de fornecedores são salvos!

                                Console.Clear();
                                Console.WriteLine("Cadastro realizado com sucesso!");
                                Console.WriteLine("\n'APERTE QUALQUER TECLA PARA CONTINUAR!'\n");
                                Console.ReadKey();
                                Acess.cont2++;

                                cadastradaF = true;
                                idFornecedores++;
                                i = 0;
                            }
                            else
                            {
                                continue;
                            }

                        }
                        else
                        {

                        }
                        Acess.getFornecedorEmpresa();
                        // Console.Write("\n");

                        Console.WriteLine("Informe o nome do fornecedor: ");
                        readGeneralString = (Console.ReadLine());
                        Acess.setNomeF(readGeneralString);

                        // Console.Clear();

                        // Console.WriteLine("Nome do fornecedor cadastrado " + "" + "\n");
                        int id_cc;
                        do
                        {
                            Console.Clear();
                            Console.Write("Fornecedor - ");
                            Acess.getNomeFor();
                            Console.WriteLine("\nDigite:");
                            Console.WriteLine("1 - Se for fornecedor físico (Pessoa)");
                            Console.WriteLine("2 - Se for fornecedor direto (empresa)");
                            readGeneralString = (Console.ReadLine());
                            id_cc = Convert.ToInt32(readGeneralString);
                            read = Convert.ToInt32(readGeneralString);
                            if (read == 1)
                            {
                                Console.Clear();

                                do
                                {
                                    Console.WriteLine("Insira o CPF :");
                                    readGeneralString = (Console.ReadLine());
                                    if (readGeneralString.Length == 11)
                                    {
                                        Acess.setIdentF(readGeneralString);
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine
                                            ("Um CPF possui 11 digitos " +
                                            "Você digitou ao todo " + readGeneralString.Length + "\n" +
                                            "\nTente novamente:");
                                    }
                                } while (readGeneralString.Length != 11);
                            }
                            else if (read == 2)
                            {
                                Console.Clear();

                                do
                                {
                                    Console.WriteLine("Insira o CNPJ :");
                                    readGeneralString = (Console.ReadLine());
                                    if (readGeneralString.Length == 14)
                                    {
                                        Acess.setIdentF(readGeneralString);
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine
                                            ("Um CNPJ possui 14 digitos " +
                                            "Você digitou ao todo " + readGeneralString.Length + "\n" +
                                            "\nTente novamente:");
                                    }
                                } while (readGeneralString.Length != 14);
                            }
                        } while (id_cc <= 0 || id_cc > 2);

                        Console.Clear();

                        do
                        {
                            Console.WriteLine("Insira o telefone :");
                            readGeneralString = (Console.ReadLine());
                            if (readGeneralString.Length == 10 || readGeneralString.Length == 11)
                            {
                                Acess.setTelefone(readGeneralString);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine
                                    ("Um telefone possui 10 ou 11 digitos " +
                                    "Você digitou ao todo " + readGeneralString.Length + "\n" +
                                    "Veja os exemplos: 4733334444 ou 47988887777 \n" +
                                    "\nTente novamente:");
                            }
                        } while (readGeneralString.Length < 10 || readGeneralString.Length > 11);

                        // Outro telefone?
                        Console.Clear();
                        Console.WriteLine("Deseja acrescentar outro telefone?\n\"S\" para sim, ou \"N\" para não\n");
                        readGeneralString = (Console.ReadLine());
                        if (readGeneralString == "s" || readGeneralString == "S")
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o outro telefone para contato, iniciado com o ddd e os 9 digitos \n(sem caracteres especiais e sem parênteses)");
                            readGeneralString = (Console.ReadLine());
                            Acess.setTelefone2(readGeneralString);
                        }
                        else
                        {
                            readGeneralString = "0";
                            Acess.telefone2.Add(readGeneralString);
                        }

                        // DATA E HORA                        
                        DateTime dataNow = DateTime.Now;
                        data.Add(dataNow); // aqui a data e hora do cadastro de fornecedores são salvos!

                        Console.Clear();
                        Console.WriteLine("Cadastro realizado com sucesso!");
                        Console.WriteLine("\n'APERTE QUALQUER TECLA PARA CONTINUAR!'\n");
                        Console.ReadKey();

                        cadastradaF = true;
                        idFornecedores++;
                        i = 0;
                        Acess.cont2++;
                    } // fim da opção 2 (se)
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Você ainda não cadastrou nenhuma empresa\n");
                        Console.WriteLine("Cadastre primeiro uma empresa para depois cadastrar os fornecedores\n");
                        Console.ReadKey();

                        i = 0;
                    } // fim da opção 2 (senão)
                }
                else if (opMenu == 3)
                {
                    if (Acess.cont2 > 0)
                    {
                        Console.Clear();
                        int contador = 0;
                        do
                        {
                            if (contador > 0)
                            {
                                Console.Write("\n");
                            }

                            Console.WriteLine("Fornecedor " + (contador + 1) + ":");
                            if (contador < Acess.cont2)
                            {
                                Console.WriteLine("Nome: " + Acess.nomeFor[contador]);
                                Console.WriteLine("CPF/CNPJ: " + Acess.identi[contador]);
                                Console.WriteLine("Data do Cadastro: " + data[contador]);
                                Console.WriteLine("Telefone Principal: " + Acess.telefone[contador]);
                            }

                            if (contador == Acess.cont2-1)
                            {
                                Console.WriteLine("\n'APERTE QUALQUER TECLA PARA VOLTAR PARA O MENU!'\n");
                                Console.ReadKey();
                            }
                            contador++;
                        } while (contador < Acess.cont2);

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Você aida não cadastrou nenhum Fornecedor!\n\n" +
                        "'APERTE QUALQUER TECLA PARA VOLTAR PARA O MENU!'\n");
                        Console.ReadKey();
                    }

                }
                else if (opMenu == 4)
                {
                    if (Acess.cont1 > 0)
                    {
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("Dados da empresa cadastrada:\n");
                        Console.Write("UF: ");
                        Acess.getSaveUfE();
                        Console.WriteLine("Nome Fantasia: " + Acess.getNomeFanE());

                        Console.Write("CNPJ: " + cnpjE.Substring(0, 2) + "."
                                                + cnpjE.Substring(2, 3) + "."
                                                + cnpjE.Substring(5, 3) + "/"
                                                + cnpjE.Substring(8, 4) + "-"
                                                + cnpjE.Substring(12));

                        Console.WriteLine("\n\n'APERTE QUALQUER TECLA PARA CONTINUAR!'\n");
                        Console.ReadKey();

                        i = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Você aida não cadastrou a empresa!\n\n" +
                        "'APERTE QUALQUER TECLA PARA VOLTAR PARA O MENU!'\n\n");
                        Console.ReadKey();

                        i = 0;
                    }

                    i = 0;
                }
                else if (opMenu == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Desenvolvido por Jonathas Rocha de Souza, para o desafio da BluData");
                    Console.Write("\n;)\n\n\n");
                    pararMenu = true;
                }
                else
                {
                    Console.Clear();
                }
                
            // true (parar o loop)
            } while (pararMenu == false);

        }
    }
}
