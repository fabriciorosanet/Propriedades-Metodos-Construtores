
 ![image](https://github.com/user-attachments/assets/6472fb56-5bb1-4453-8e7f-6da4f86e7926)

 # Propriedades-Metodos-Construtores

Este projeto em C# demonstra o uso de propriedades, construtores e métodos para manipulação de objetos em uma aplicação simples. O objetivo é explorar a implementação de classes com **propriedades flexíveis**, **validações de dados** e **métodos para manipulação de listas**.

## Funcionalidades

### Classes Principais

#### Pessoa

A classe `Pessoa` define um indivíduo com as seguintes propriedades:

- **Name** e **Lastname**: Validadas para não serem vazias.
- **Fullname**: Uma propriedade derivada que combina `Name` e `Lastname`.
- **Age**: Validação para garantir que o valor seja maior que 18 anos.

Métodos:

- `apresentar()`: Exibe o nome completo e a idade da pessoa.

#### Curso

A classe `Curso` representa um curso e contém:

- **Name**: O nome do curso.
- **Student**: Uma lista de objetos do tipo `Pessoa`.

Métodos:

- `AddStudent()`: Adiciona um aluno ao curso.
- `GetQuantityOfStudentsEnrolled()`: Retorna o número de alunos matriculados.
- `RemoveStudent()`: Remove um aluno da lista de estudantes.
- `ListStudent()`: Lista os alunos matriculados no curso.
