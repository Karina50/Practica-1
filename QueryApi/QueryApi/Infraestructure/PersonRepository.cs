using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;
using System.Threading.Tasks;

namespace QueryApi.Repositories
{
    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        // retornar todos los valores
        public IEnumerable<Person> GetAll()
        {
            var query = _persons.Select(person => person);
            return query;
        }

        // retornar campos especificos

        // retornar elementos que sean iguales
        
        // Retornar elementos que sean diferentes
        
        // retornar valores que contengan
        
        // retornar valores entre un rango
        
        // retornar elementos ordenados
        
        // retorno cantidad de elementos
        
        // Evalua si un elemento existe
        
        // retornar solo un elemento
        
        // retornar solamente unos elementos
        
        // retornar elementos saltando posición
        
    }
}