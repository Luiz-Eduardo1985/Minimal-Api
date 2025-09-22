using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades
{
    [TestClass]
    public class VeiculoTeste
    {
        [TestMethod]
        public void TestarGetSetPropriedades()
        {
            //Arrenge
            var veiculo = new Veiculo();

            //Act
            veiculo.Id = 3;
            veiculo.Nome = "Livina";
            veiculo.Marca = "Nissan";
            veiculo.Ano = 2014;

            //Assert
            Assert.AreEqual(3, veiculo.Id);
            Assert.AreEqual("Livina", veiculo.Nome);
            Assert.AreEqual("Nissan", veiculo.Marca);
            Assert.AreEqual(2014, veiculo.Ano);
        }
    }
}