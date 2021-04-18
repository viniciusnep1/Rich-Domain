using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Commands.PersonCommand;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.Commands
{
    [TestClass]
    public class PersonCommandTests
    {
        [TestMethod]
        public void ReturnErrorWhenPersonNameIsInvalid()
        {
            var personCommand = new PersonCommand();
            personCommand.Name = "";
            personCommand.LastName = "Oliveira";
            personCommand.DocumentType = Domain.enums.DocumentType.CPF;
            personCommand.DocumentNumber = "11111111111";
            personCommand.Validate();
            Assert.AreEqual(false, personCommand.IsValid);
        }

        [TestMethod]
        public void ReturnErrorWhenPersonNameIsValid()
        {
            var personCommand = new PersonCommand();
            personCommand.Name = "Juarez";
            personCommand.LastName = "Oliveira";
            personCommand.DocumentType = Domain.enums.DocumentType.CPF;
            personCommand.DocumentNumber = "11111111111";
            personCommand.Validate();
            Assert.AreEqual(true, personCommand.IsValid);
        }

        [TestMethod]
        public void ReturnErrorWhenDocumentIsValid()
        {
            var personCommand = new PersonCommand();
            personCommand.Name = "Juarez";
            personCommand.LastName = "Oliveira";
            personCommand.DocumentType = Domain.enums.DocumentType.CPF;
            personCommand.DocumentNumber = "11111111111";
            personCommand.Validate();
            Assert.AreEqual(true, personCommand.IsValid);
        }

        [TestMethod]
        public void ReturnErrorWhenDocumentIsInvalid()
        {
            var personCommand = new PersonCommand();
            personCommand.Name = "Juarez";
            personCommand.LastName = "Oliveira";
            personCommand.DocumentType = Domain.enums.DocumentType.CNPJ;
            personCommand.DocumentNumber = "";
            personCommand.Validate();
            Assert.AreEqual(false, personCommand.IsValid);
        }

    }
}
