using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ApiTrayCorp.Model;
using ApiTrayCorp.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace TesteUnitarioApiTrayCorp
{
    [TestClass]
    public class CreateProduto
    {
        [TestMethod]
        public void SaveProduto()
        {
            var mockSet = new Mock<DbSet<Produtos>>();
            var mockContext = new Mock<ProdutoContext>();
            mockContext.Setup(x => x.Produtos).Returns(mockSet.Object);
            
            var service = new ApiTrayCorp.Service.ProdutosService(mockContext.Object);

            service.CreateProduto(new Produtos()
            {
                Id = Guid.NewGuid(),
                Nome = "Caderno",
                Value = 20
            });
            
            mockSet.Verify(m => m.Add(It.IsAny<Produtos>()),Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}