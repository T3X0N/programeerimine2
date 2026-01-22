using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.logikanded;
using KooliProjekt.Application.Features.maitsmislogikanded;
using KooliProjekt.Application.Features.ToDoLists;
using Xunit;

namespace KooliProjekt.Application.UnitTests.Features
{
    public class LogikandedTests : ServiceTestBase
    {
        [Fact]
        public void Get_throws_if_dbcontext_is_null()
        {
            Assert.Throws<ArgumentNullException>(() => 
            {
                new GetlogikandedQueryHandler(null);
            });
        }

        [Fact]
        public async Task Get_should_return_object_if_object_exists()
        {
            // Arrange
            var query = new GetlogikandedQuery { Id = 0 };
            var todoList = new logikande { kuupäev = "veb", kirjeldus= "super", kasutajanimi="proov1" };
            var handler = new GetlogikandedQueryHandler(DbContext);
            await DbContext.ToLogiKande.AddAsync(todoList);  
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
            var query = new GetlogikandedQuery { Id = 101 };
            var todoList = new logikande { kuupäev = "veb", kirjeldus = "super", kasutajanimi = "proov1" };
            var handler = new GetlogikandedQueryHandler(DbContext);
            await DbContext.ToLogiKande.AddAsync(todoList);
            await DbContext.SaveChangesAsync();

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.False(result.HasErrors);
            Assert.Null(result.Value);
        }
    }
}
