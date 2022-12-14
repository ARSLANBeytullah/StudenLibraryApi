using StudentLibrary.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.Services
{
    public interface IOperationService
    {
        Task<OperationDto> GetByIdAsync(int id);
        Task<IList<OperationDto>> GetAllAsync();
        Task AddAsync(OperationAddDto entity);
        Task UpdateAsync(OperationUpdateDto entity);
        Task DeleteAsync(int id);
        Task<int> CountAsync(Expression<Func<OperationDto, bool>> predicate = null);
        //  Task<bool> AnyAsnc(Expression<Func<OperationDto, bool>> predicate);
    }
}
