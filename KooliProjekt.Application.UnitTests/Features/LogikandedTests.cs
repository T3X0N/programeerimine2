using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KooliProjekt.Application.Data;
using KooliProjekt.Application.Features.ToDoLists;
using Xunit;

namespace KooliProjekt.Application.UnitTests.Features
{
    public class ToDoListTests : TestBase
    {
        [Fact]
        public void Get_throws_if_dbcontext_is_null()
        {
            Assert.Throws<ArgumentNullException>(() => 
            {
                new GetToDoListQueryHandler(null);
            });
        }

        [Fact]
        public async Task Get_should_return_object_if_object_exists()
        {
            // Arrange
            var query = new GetToDoListQuery { Id = 1 };
            var todoList = new ToDoList { Title = "Test ToDo List" };
            var handler = new GetToDoListQueryHandler(DbContext);
            await DbContext.ToDoLists.AddAsync(todoList);  
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
            var query = new GetToDoListQuery { Id = 101 };
            var todoList = new ToDoList { Title = "Test ToDo List" };
            var handler = new GetToDoListQueryHandler(DbContext);
            await DbContext.ToDoLists.AddAsync(todoList);
            await DbContext.SaveChangesAsync();

            // Act
            var result = await handler.Handle(query, CancellationToken.None);

            // Assert
            Assert.False(result.HasErrors);
            Assert.Null(result.Value);
        }
    }
}
