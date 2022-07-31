using StudentLibrary.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
         IAuthorRepository Authors { get; }
         IStudentRepository Students { get; }
         IBookRepository Books { get; }
         IOperationRepository Operations { get; }
         Task<int> SaveAsync();
    }
}
