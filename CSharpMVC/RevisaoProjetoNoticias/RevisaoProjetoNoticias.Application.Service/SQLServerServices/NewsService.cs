using RevisaoProjetoNoticias.Domain.DTO;
using RevisaoProjetoNoticias.Domain.Entities;
using RevisaoProjetoNoticias.Domain.IRepositories;
using RevisaoProjetoNoticias.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Application.Service.SQLServerServices
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _repository;
        public NewsService(INewsRepository repository)
        {
            _repository = repository;
        }
        public Task<int> Delete(NewsDTO entity)
        {
            return _repository.Delete(entity.mapToEntity());
        }

        public List<NewsDTO> FindAll()
        {
            return _repository.FindAll()
                              .Select(n => new NewsDTO()
                              {
                                  id = n.Id,
                                  title = n.Title,
                                  description = n.Description,
                                  categoryId = n.CategoryId,
                                  createdOn = n.CreatedOn,
                                  published = n.Published
                              }).ToList();
        }

        public async Task<NewsDTO> FindById(int id)
        {
            var dto = new NewsDTO();
            return dto.mapToDTO(await _repository.FindById(id));
        }

        public Task<int> Save(NewsDTO entity)
        {
            if (entity.id > 0)
            {
                return _repository.Update(entity.mapToEntity());
            }
            else
            {
                return _repository.Save(entity.mapToEntity());
            }
        }
    }
}
