
using System;
using System.Collections.Generic;
using System.Text;

namespace Modulo02.Lista01
{
    class Program
    {
        static void Main()
        {

            int opt = 0;

            do
            {

                Console.WriteLine("\n## ESCOLHA UMA OPÇÃO DE AUTENTICAÇÃO ##");
                Console.WriteLine("## 1 - Gmail ##");
                Console.WriteLine("## 2 - Instagram ##");
                Console.WriteLine("## 3 - Facebook ##");
                Console.WriteLine("## 4 - Sair ##");
                opt = int.Parse(Console.ReadLine());

                if (opt == (int)TipoLogin.Gmail)
                {
                    Console.WriteLine("Digite seu usuário: ");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("Digite sua senha: ");
                    string senha = Console.ReadLine();

                    LoginGmail objLogin = new LoginGmail();
                    objLogin.Login(usuario, senha);
                    objLogin.Logout();
                }
                else if (opt == (int)TipoLogin.Facebook)
                {
                    Console.WriteLine("Digite seu usuário: ");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("Digite sua senha: ");
                    string senha = Console.ReadLine();

                    LoginFacebook objLogin = new LoginFacebook();
                    objLogin.Login(usuario, senha);
                    objLogin.Logout();
                }
                else if (opt == (int)TipoLogin.Instagram)
                {
                    Console.WriteLine("Digite seu usuário: ");
                    string usuario = Console.ReadLine();
                    Console.WriteLine("Digite sua senha: ");
                    string senha = Console.ReadLine();

                    LoginInstagram objLogin = new LoginInstagram();
                    objLogin.Login(usuario, senha);
                    objLogin.Logout();
                }
                else if (opt == 4)
                    break;
            } while (opt != 4);


        }
    }

    enum TipoLogin
    {
        Gmail = 1,
        Facebook = 2,
        Instagram = 3,
    }

    public abstract class SuperLogin
    {
        public abstract void Login(string usuario, dynamic senha);
        protected virtual bool Autentica(string usuario, dynamic senha)
        {
            if (senha == "123456")
                return true;
            else
                return false;
        }
        public abstract void Logout();
    }

    public class LoginGmail : SuperLogin
    {
        public override void Login(string usuario, dynamic senha)
        {
            bool resultValidacao = Autentica(usuario, senha);
            if (resultValidacao)
                Console.WriteLine("Login do Gmail realizado com sucesso.");
            else
                Console.WriteLine("Login do Gmail falhou.");
        }
        protected override bool Autentica(string usuario, dynamic senha)
        {
            if (senha == "gmail12345")
                return true;
            else
                return false;
        }
        public override void Logout()
        {
            Console.WriteLine("Logout Gmail realizado.");

        }

    }

    public class LoginFacebook : SuperLogin
    {
        public override void Login(string usuario, dynamic senha)
        {
            bool resultValidacao = Autentica(usuario, senha);
            if (resultValidacao)
                Console.WriteLine("Login do Facebook realizado com sucesso.");
            else
                Console.WriteLine("Login do Facebook falhou.");
        }
        protected override bool Autentica(string usuario, dynamic senha)
        {
            if (senha == "facebook12345")
                return true;
            else
                return false;
        }
        public override void Logout()
        {
            Console.WriteLine("Logout Facebook realizado.");

        }

    }

    public class LoginInstagram : SuperLogin
    {
        public override void Login(string usuario, dynamic senha)
        {
            bool resultValidacao = Autentica(usuario, senha);
            if (resultValidacao)
                Console.WriteLine("Login do Instagram realizado com sucesso.");
            else
                Console.WriteLine("Login do Instagram falhou.");
        }
        protected override bool Autentica(string usuario, dynamic senha)
        {
            if (senha == "instagram12345")
                return true;
            else
                return false;
        }
        public override void Logout()
        {
            Console.WriteLine("Logout Instagram realizado.");

        }

    }
}