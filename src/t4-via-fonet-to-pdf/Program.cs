using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fonet;

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


            var template = new Templates.ContactTemplate();
            template.Session = new Dictionary<string, object>();
            template.Session["Data"] = data;
            template.Initialize();

            var s = template.TransformText();

            var outputStream = new System.IO.MemoryStream();
            FonetDriver driver = FonetDriver.Make();
            driver.CloseOnExit = false;
            driver.Options = new Fonet.Render.Pdf.PdfRendererOptions
            {
                Author = "Mr. Smith",
                Title = "How to create a PDF file using C#, T4 templates and Fo.Net.",
                Subject = "Crazy stuff",
                EnableModify = false,
                EnableAdd = false,
                EnableCopy = false,
                EnablePrinting = true,
                OwnerPassword = "password",
            };

            using (var reader = new System.IO.StringReader(s))
            {
                driver.Render(reader, outputStream);
            }

            outputStream.Position = 0;
            using (var fileStream = System.IO.File.Create("c:/temp/test.pdf"))
            {
                outputStream.CopyTo(fileStream);
            }
                

            Console.WriteLine(s);
        }
    }
}
