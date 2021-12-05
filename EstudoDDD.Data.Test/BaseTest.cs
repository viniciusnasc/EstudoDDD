using EstudoDDD.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace EstudoDDD.Data.Test
{
    public abstract class BaseTest
    {
        public BaseTest()
        {

        }
    }

    // Conex�o com banco de dados momentaneo
    public class DbTeste : IDisposable
    {
        private string _dataBaseName = $"dbApiTest_{Guid.NewGuid().ToString().Replace("-", String.Empty)}";
        public ServiceProvider ServiceProvider { get; private set; }

        public DbTeste()
        {
            // Configura��o da cria��o do DB
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<MyContext>(o => 
                            o.UseSqlServer($"Integrated Security = SSPI;Persist Security Info=False;" +
                                           $"Initial Catalog={_dataBaseName};" +
                                           $"Data Source=DESKTOP-R9JFMSC\\SQLEXPRESS"), 
                                           ServiceLifetime.Transient); // Transiente serve parar criar o bd somente durante a execu��o do teste
            ServiceProvider = serviceCollection.BuildServiceProvider();
            
            // Cria��o do DB
            using (var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureCreated();
            }
        }

        // Esse metodo deleta o database criado
        public void Dispose()
        {
            using (var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureDeleted();
            }
        }
    }
}