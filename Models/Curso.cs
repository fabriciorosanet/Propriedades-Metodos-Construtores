using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorandoPropriedades.Models
{
    public class Curso
    {
        public string Name { get; set; } //criando uma prop Name 
        public List<Pessoa> Student { get; set; } //criando uma prop Pessoa do tipo List 

        public void AddStudent(Pessoa student) 
        {
            Student.Add(student);
        }
                                                  //um metodo diferente de void, precisa ter um return      
        public int GetQuantityOfStudentsEnrolled()
        {
            int quantity = Student.Count;
            return quantity;
        }

        public bool RemoveStudent(Pessoa student) //todo metodo diferente de VOID precisa de um RETURN no code
        {
            Student.Remove(student);
            return true;
        }

        public void ListStudent() 
        {
            Console.WriteLine($"Abaixo segue a lista de alunos do curso de {Name}");
            foreach (Pessoa student in Student)
            {

                Console.WriteLine(student.Fullname);
                
            }
        }

    }
}
