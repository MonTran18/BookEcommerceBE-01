using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RepositoryDLL.Entities;

namespace ClassLibrary_RepositoryDLL.Repository.Interface
{
    public interface IPublisherRepository
    {
        List<Publisher> getAllPublisher();
        void AddPublisher(Publisher newpub);
        bool UpdatePublisher(Publisher newpub);
        bool DeletePublisher(int pubId);
        Publisher getDetailPublisher(int pubId);
    }
}
