using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_RepositoryDLL.Entities;
using ClassLibrary_RepositoryDLL.Repository.Interface;
using ClassLibrary_RepositoryDLL.Mappings;
using ClassLibrary_RepositoryDLL.Models;
using AutoMapper;

namespace ClassLibrary_RepositoryDLL.Services
{
    public class BookBannerService : IBookBannerService
    {
        private readonly IBookRepository _repo;
        private readonly IMapper _mapper;
        public BookBannerService(IBookRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public BannerModel getDetailBook(int bookId)
        {
            //var bookmodel = ObjectMapper.Mapper.Map<Book>(_repo.getDetailBook(bookId));
            var bookmodel = _mapper.Map<BannerModel>(_repo.getDetailBook(bookId));
            return bookmodel;
        }

        BookModel IBookBannerService.getDetailBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
