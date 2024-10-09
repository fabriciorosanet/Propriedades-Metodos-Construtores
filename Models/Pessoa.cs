using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoPropriedades.Models
{
    public class Pessoa
    {

        //criando um CONSTRUTOR -> precisa ter o mesmo nome da classe <-
        //o construtor pode ser vazio ou podemos passar valores para dentro dele
        // exemplo: public Pessoa(passar as propriedades existentes com o seu tipo)
        //podemos ter quantos varios construtores da mesma classe

        public Pessoa(string name, string lastname) 
        {

            Name = name;            //Propriedade -> Começa em maiusculo e tem o get e set abaixo 
            Lastname = lastname;    //Parametors estão em minusculo

        }
        
        
        private string _name;
        private int _age;
        private string _lastname;



        //criando PROPRIEDADES -> prop ->
        //toda propriedade tem get e set - uma maneira de identificar

        public string Name
        {
            get =>  _name.ToUpper();  //body expressions  //flexibilizando o get 



            set
            {
                if (value == "") 
                {
                    throw new ArgumentException("O nome não pode ser vazio"); //flexibilizando o set 
                }

                _name = value;
            }
        }

        public string Lastname
        {

            get => _lastname.ToUpper();

            set
            {
                if (value == "")
                {

                    throw new ArgumentException("Por favor digite o sobrenome.");
                }

                _lastname = value;
            }
        }

        public string Fullname => $"{Name} {Lastname}".ToUpper(); //body expressions

        public int Age 
        {   
            
            get => _age;

            set 
            {
                if (value < 18)
                {
                    throw new ArgumentException("A idade não pode ser menor que dezoito");
                }

                _age = value;
                
            } 
        }

        // get -> pegando um valor
        // set -> atribuindo um valor

        // criando METODO ->ACAO <- PEDAÇO DE ACAO

        public void apresentar() 
        {
            Console.WriteLine($"Nome: {Fullname}, Idade: {Age}");
        }
        
    }
}
