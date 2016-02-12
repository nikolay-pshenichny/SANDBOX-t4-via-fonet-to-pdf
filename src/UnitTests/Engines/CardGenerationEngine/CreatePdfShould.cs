using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FluentAssertions;
using ApprovalTests.BetterPdfVerification;

namespace UnitTests.Engines.CardGenerationEngine
{
    //[DeploymentItem("gsdll32.dll")]
    [TestClass]
    public class CreatePdfShould
    {
        private t4_via_fonet_to_pdf.Models.Card _testCard;

        private t4_via_fonet_to_pdf.Engines.CardGenerationEngine _engine;

        public CreatePdfShould()
        {
            _testCard = new t4_via_fonet_to_pdf.Models.Card
            {
                FirstName = "First",
                LastName = "Last",
                Birthdate = new DateTime(2000, 01, 01),
                Phones = new List<t4_via_fonet_to_pdf.Models.Phone>
                {
                    new t4_via_fonet_to_pdf.Models.Phone {Type = t4_via_fonet_to_pdf.Models.PhoneType.Cell, Number = "555-555-5555" },
                    new t4_via_fonet_to_pdf.Models.Phone {Type = t4_via_fonet_to_pdf.Models.PhoneType.Home, Number = "666-666-6666" }
                },
                Emails = new List<t4_via_fonet_to_pdf.Models.Email>
                {
                    new t4_via_fonet_to_pdf.Models.Email {Type = t4_via_fonet_to_pdf.Models.EmailType.Work, Address = "mr.smith@some.work.com" },
                    new t4_via_fonet_to_pdf.Models.Email {Type = t4_via_fonet_to_pdf.Models.EmailType.Home, Address = "mr.smith@home.sweet.home.com" }
                },
            };

            _engine = new t4_via_fonet_to_pdf.Engines.CardGenerationEngine();
        }

        [TestMethod]
        public void WorkWithoutPhoneNumbers()
        {
            // Arrange
            _testCard.Phones = null;
            var nullStream = System.IO.Stream.Null;

            // Act
            Action action = () => _engine.CreatePdf(_testCard, nullStream);

            // Assert
            action.ShouldNotThrow();
        }

        [TestMethod]
        public void GeneratePdfWithoutPhoneNumbersIfTheyWereNotProvided()
        {
            // Arrange
            _testCard.Phones = null;
            var memoryStream = new System.IO.MemoryStream();

            // Act
            _engine.CreatePdf(_testCard, memoryStream);
            
            // Assert
            memoryStream.Position = 0;
            PdfApprovals.VerifyVisually(memoryStream);
        }

        [TestMethod]
        public void WorkWithoutEmailAddresses()
        {
            // Arrange
            _testCard.Emails = null;
            var nullStream = System.IO.Stream.Null;

            // Act
            Action action = () => _engine.CreatePdf(_testCard, nullStream);

            // Assert
            action.ShouldNotThrow();
        }

        [TestMethod]
        public void GeneratePdfWithoutEmailAddressesIfTheyWereNotProvided()
        {
            // Arrange
            _testCard.Emails = null;
            var memoryStream = new System.IO.MemoryStream();

            // Act
            _engine.CreatePdf(_testCard, memoryStream);

            // Assert
            memoryStream.Position = 0;
            PdfApprovals.VerifyVisually(memoryStream);
        }

        [TestMethod]
        public void GeneratePdfWithEmailsAndPhones()
        {
            // Arrange
            var memoryStream = new System.IO.MemoryStream();

            // Act
            _engine.CreatePdf(_testCard, memoryStream);

            // Assert
            memoryStream.Position = 0;
            PdfApprovals.VerifyVisually(memoryStream);
        }
    }
}
