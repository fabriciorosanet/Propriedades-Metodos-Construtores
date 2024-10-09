using ExplorandoPropriedades.Models;


Pessoa pessoa1 = new Pessoa(name: "Fabricio",lastname: "Rosa"); 
Pessoa pessoa2 = new Pessoa(name: "Bianca",lastname: "Silva");


Curso cursoOfIngles = new Curso();
cursoOfIngles.Name = "Ingles";
cursoOfIngles.Student = new List<Pessoa>();

cursoOfIngles.AddStudent(pessoa1);
cursoOfIngles.AddStudent(pessoa2);
cursoOfIngles.ListStudent();


//Pessoa pessoa1 = new Pessoa(); //instanciando a classe Pessoa -> lá do pacote Models
//                              //variavel pessoa1 criando no momento de instanciar a classe Pessoa
//pessoa1.Name = "fabricio";
//pessoa1.Lastname = "rosa";
//pessoa1.Age = 20; // coloquei o sinal de = estou chamando o SET
//                  // (atribuindo um valor na propriedade)
//pessoa1.apresentar();




