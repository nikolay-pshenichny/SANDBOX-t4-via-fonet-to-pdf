using System;
using System.Collections.Generic;

namespace t4_via_fonet_to_pdf.Models
{
    public class Card
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthdate { get; set; }

        public string Company { get; set; }

        public List<Email> Emails { get; set; }

        public List<Phone> Phones { get; set; }
    }

    public class Phone
    {
        public PhoneType Type { get; set; }

        public string Number { get; set; }
    }

    public class Email
    {
        public EmailType Type { get; set; }

        public string Address { get; set; }
    }

    public enum PhoneType
    {
        Home,
        Work,
        Cell
    }

    public enum EmailType
    {
        Home,
        Work
    }
}