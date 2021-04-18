using Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Entidades
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void ReturnErrorWhenCNPJIsInvalid()
        {
            var person = new Person("Antonio", "Augusto", "antonioAugusto@email.com", Domain.enums.DocumentType.CNPJ, "123");
            Assert.IsTrue(!person.IsValid);
        }

        [TestMethod]
        public void ReturnSucessWhenCNPJIsValid()
        {
            var person = new Person("Antonio", "Augusto", "antonioAugusto@email.com", Domain.enums.DocumentType.CNPJ, "22770620000142");
            Assert.IsTrue(person.IsValid);
        }

        [TestMethod]
        public void ReturnErrorWhenCPFIsInvalid()
        {
            var person = new Person("Antonio", "Augusto", "antonioAugusto@email.com", Domain.enums.DocumentType.CPF, "123");
            Assert.IsTrue(!person.IsValid);
        }

        [TestMethod]
        public void ReturnSucessWhenCPFIsValid()
        {
            var person = new Person("Antonio", "Augusto", "antonioAugusto@email.com", Domain.enums.DocumentType.CPF, "55925228006");
            Assert.IsTrue(person.IsValid);
        }
    }
}
