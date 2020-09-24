using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Cadastro
{
    class Empresa
    {
        private String User;
        private ArrayList idEmpresa = new ArrayList();

        // empresa
        public int cont1 = 0;
        public ArrayList estados = new ArrayList();
        private ArrayList ufE = new ArrayList();
        private ArrayList nomeE = new ArrayList();
        private ArrayList identiE = new ArrayList();
        private Boolean criterioIdadePr = false;

        // fornecedor
        public int cont2 = 0;
        private String empre;
        private /*public*/ ArrayList name = new ArrayList();
        public ArrayList identi = new ArrayList();
        public ArrayList nomeFor = new ArrayList();
        public ArrayList telefone = new ArrayList();
        public ArrayList telefone2 = new ArrayList();

        // entrada do programa (regras)
        public void getRegras()
        {
            Console.WriteLine("Por favor! Leia com atenção antes de iniciar!\n");
            Console.WriteLine("- Este código tem muitas entradas que são int (inteiras), portanto não digite String nestas entradas");
            Console.WriteLine("Pois existe a possibilidade que a execução do código pare!");
            Console.WriteLine("- O código pode ser explorado a vontade...");
            Console.WriteLine("- Se ouver erro contacte-me, ajude me a melhorar!");
            Console.WriteLine("- O código não está ligado a nehum banco de Dados, nem mesmo a interface gráfica");
            Console.WriteLine("- O programa pede seu nome, apenas para uma melhor experiência com o programa, ele não fica salvo fora do programa");
            Console.WriteLine("- Desenvolvido por Jonathas");
            Console.WriteLine("\n\n");
            Console.WriteLine("Obrigado por ler até aqui!");
        }

        // entrada usuário
        public void setUser(String name_user)
        {
            this.User = name_user;
        }

        // saida menu
        public void getMenu()
        {
            Console.WriteLine(User + ", o que deseja fazer?\n");
            // cadastrar;
            Console.WriteLine("1 - Cadastrar a empresa;");
            Console.WriteLine("2 - Cadastrar os fornecedores da empresa;");
            // consutar
            Console.WriteLine("3 - Consultar os fornecedores da empresa;");
            Console.WriteLine("4 - Consultar os dados da empresa;");
            // sair
            Console.WriteLine("5 - SAIR;\n");
        }

        // id da empresa (buscador da empresa)
        public void setIdEmpresa(int idE)
        {
            idEmpresa.Add(idE);
        }

        public void getUf()
        {
            Console.WriteLine("Por favor! Qual a UF da empresa? (digite qual for sua opção) ");

            // estados
            estados.Add("AC"); // [0]
            estados.Add("AL");
            estados.Add("AP");
            estados.Add("AM");
            estados.Add("BA");
            estados.Add("CE");
            estados.Add("ES");
            estados.Add("GO");
            estados.Add("MA");
            estados.Add("MT");
            estados.Add("MS");
            estados.Add("MG");
            estados.Add("PA");
            estados.Add("PB");
            estados.Add("PR"); // [14] - Paraná, Critério de idade aqui!
            estados.Add("PE");
            estados.Add("PI");
            estados.Add("RJ");
            estados.Add("RN");
            estados.Add("RS");
            estados.Add("RO");
            estados.Add("RR");
            estados.Add("SC");
            estados.Add("SP");
            estados.Add("SE");
            estados.Add("TO");
            estados.Add("DF"); // [26] = estado 27

            for (int estadoE = 0; estadoE < 27; estadoE++)
            {
                Console.WriteLine(estadoE + " - " + estados[estadoE]);
            }
        }


        // recebe UF
        public void setSaveUfE(String nameE)
        {
            ufE.Add(nameE);
        }

        // envia o nome da UF
        public void getSaveUfE()
        {
            Console.WriteLine(ufE[0]);
        }

        public void getNomeF()
        {
            Console.WriteLine("Muito bem " + User + "!\nAgora preciso do nome fantasia da empresa\n");
            Console.WriteLine("Digite abaixo o nome fantasia da empresa:");
        }

        public void setNomeFanE(String nomeFanE)
        {
            nomeE.Add(nomeFanE);
        }

        public String getNomeFanE()
        {
            return nomeE[0].ToString();
        }

        public void getDigiteCnpj()
        {
            Console.WriteLine(User + "!\nAté aqui deu tudo certo");
            Console.WriteLine("Agora, para finalizar o cadastro da empresa digite o CNPJ da empresa (sem caracter especial): ");
        }

        public void setCnpj(String cnpj)
        {
            identiE.Add(cnpj);
        }

        public String getCnpj()
        {
            String cnpjE = identiE[0].ToString();
            return cnpjE;
        }

        public void getJa()
        {
            Console.WriteLine(User + ", já existe uma empresa cadastrada");
            Console.WriteLine("Você pode consultar a empresa!");
            Console.WriteLine("\n'APERTE QUALQUER TECLA PARA VOLTAR PARA O MENU!'\n");
        }

        // fornecedor

        public void setMenorIdade(Boolean idade = false)
        {
            this.criterioIdadePr = idade;
        }

        public void getFornecedorEmpresa()
        {
            Console.WriteLine(User + ", você vai cadastrar fornecedores para a empresa \"" + nomeE[0] + "\"\n");
        }

       public void setNomeF(String nomeF)
        {
            name.Add(nomeF);
            nomeFor.Add(nomeF);
        }

        public void setIdentF(String idF)
        {
            identi.Add(idF);
        }

        public void getNomeFor()
        {
            Console.WriteLine(name[0]);
        }

        public void setTelefone(String tel)
        {
            telefone.Add(tel);
        }

        public void setTelefone2(String tel)
        {
            telefone.Add(tel);
        }

    }
}
