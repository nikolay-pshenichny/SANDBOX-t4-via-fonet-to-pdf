using System;
using System.Collections.Generic;
using System.IO;
using Fonet;

namespace t4_via_fonet_to_pdf.Engines
{
    public class CardGenerationEngine : ICardGenerationEngine
    {
        public void CreatePdf(Models.Card cardData, Stream outputStream)
        {
            if (cardData == null)
            {
                throw new ArgumentNullException("cardData");
            }

            if (outputStream == null)
            {
                throw new ArgumentNullException("outputStream");
            }

            var template = new Templates.ContactTemplate();
            template.Session = new Dictionary<string, object>();
            template.Session["Data"] = cardData;
            template.Initialize();

            var foXmlString = template.TransformText();

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

            using (var reader = new StringReader(foXmlString))
            {
                driver.Render(reader, outputStream);
            }
        }
    }

    public interface ICardGenerationEngine
    {
        void CreatePdf(Models.Card cardData, Stream outputStream);
    }
}
