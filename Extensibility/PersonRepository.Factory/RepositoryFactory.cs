using System;
using PersonRepository.CSV;
using PersonRepository.Interface;
using PersonRepository.Services;
using PersonRepository.SQL;

namespace PersonRepository.Factory
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository(string repositoryType)
        {
            IPersonRepository repository;
            switch (repositoryType)
            {
                case "ServiceRepository":
                    repository = new ServiceRepository();
                    break;
                case "SqlRepository":
                    repository = new SQLRepository();
                    break;
                case "CSVRepository":
                    repository = new CSVRepository();
                    break;
                default:
                    throw new ArgumentException("Invalid repository type");
            }
            return repository;
        }
    }
}
