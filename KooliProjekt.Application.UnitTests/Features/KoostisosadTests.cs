using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.koostisosad;
using KooliProjekt.Application.Features.ToDoLists;
using Xunit;

namespace KooliProjekt.Application.UnitTests.Features
{
    public class KoostisosadTests : ServiceTestBase
    {
        [Fact]
        public void Get_throws_if_dbcontext_is_null()
        {
            Assert.Throws<ArgumentNullException>(() => 
            {
                new GetkoostisosadQueryHandler(null);
            });
        }

        [Fact]
        public async Task Get_should_return_object_if_object_exists()
        {
            // Arrange
            var query = new GetkoostisosadQuery{ Id = 0 };
            var todoList = new koostisosa { Nimetus = "Test ToDo List", ühik="ml", kogus=2, ühikuhind=2, summa=2 };
            var handler = new GetkoostisosadQueryHandler(DbContext);
            await DbContext.ToKoostisosa.AddAsync(todoList);  
            await DbContext.SaveChangesAsync();

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.False(result.HasErrors);
            Assert.NotNull(result.Value);
            Assert.Equal(1, result.Value.Id);
        }

        [Fact]
        public async Task Get_should_return_null_if_object_does_not_exist()
        {
            // Arrange
            var query = new GetkoostisosadQuery { Id = 101 };
            var todoList = new koostisosa { Nimetus = "Test ToDo List", ühik = "ml", kogus = 2, ühikuhind = 2, summa = 2 };
            var handler = new GetkoostisosadQueryHandler(DbContext);
            await DbContext.ToKoostisosa.AddAsync(todoList);
            await DbContext.SaveChangesAsync();

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.False(result.HasErrors);
            Assert.Null(result.Value);
        }
    }
}
