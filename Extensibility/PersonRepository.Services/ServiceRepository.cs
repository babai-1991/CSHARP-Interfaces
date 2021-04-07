using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using PersonRepository.Interface;

namespace PersonRepository.Services
{
    public class ServiceRepository:IPersonRepository
    {
        WebClient client = new WebClient();
        private string url = "http://localhost:9874/api/people";
        public IEnumerable<Person> GetPeople()
        {
            string response = client.DownloadString(url);
            IEnumerable<Person> persons = JsonConvert.DeserializeObject<IEnumerable<Person>>(response);
            return persons;
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }
    }
}
