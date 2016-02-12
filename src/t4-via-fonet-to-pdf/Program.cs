using System;
using System.Collections.Generic;
using t4_via_fonet_to_pdf.Engines;

namespace t4_via_fonet_to_pdf
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new t4_via_fonet_to_pdf.Models.Card
            {
                FirstName = "First",
                LastName = "Last",
                Birthdate = new DateTime(2000, 01, 01),
                Phones = new List<Models.Phone>
                {
                    new Models.Phone {Type = Models.PhoneType.Cell, Number = "555-555-5555" },
                    new Models.Phone {Type = Models.PhoneType.Home, Number = "666-666-6666" }
                },
                Emails = new List<Models.Email>
                {
                    new Models.Email {Type = Models.EmailType.Work, Address = "mr.smith@some.work.com" },
                    new Models.Email {Type = Models.EmailType.Home, Address = "mr.smith@home.sweet.home.com" }
                },
            };


            using (var fileStream = System.IO.File.Create("c:/temp/test.pdf"))
            {
                new CardGenerationEngine().CreatePdf(data, fileStream);
            }

        }
    }
}
