using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12Classes
{
    internal class Personagem
    {
        //variaveis (atributos) "dentro de uma classe"
        public string nome;
        public string raça;
        public int poder;

        //funções (métodos) "dentro de uma classe"
        public void mostra()
        {
            Console.WriteLine($"Seu personagem é da(o) raça : {raça} , tem o nivel de poder :{poder} e o nome dele(a) é : {nome} ");
        }
    }
}
